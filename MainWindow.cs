using CsvHelper;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesolvis_Aufgabe
{
    public partial class MainWindow : Form
    {   
        // Global variable declarations
                
        private static readonly CultureInfo cultureInfo  = CultureInfo.GetCultureInfo("de-DE");
        
        private static char[] headerDelimiter = {'\t'};
        private static string rowDelimiter = "\t\r\n";

        long count;

        // Initialize
        public MainWindow()
        {
            InitializeComponent();
            lbl_betragSoll.Text = "";
            lbl_betraghaben.Text = "";
        }

        //***********************************************************************************************

        // Function to count Line numbers in the excel file
        static long CountLinesInFile(string f)
        {
            long count = 0;
            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }
            }
            return count;
        }



        //***********************************************************************************************


        // Function to load CSV Data
        private void LoadData(string strFilePath)
        {
            DataTable dt = new DataTable();
            try
            {

                // Create stream reader
                StreamReader sr = new StreamReader(strFilePath);

                count = CountLinesInFile(strFilePath);
                

                string line = sr.ReadLine();
                string[] value = line.Split('\t');
                
                DataRow row;
                foreach (string dc in value)
                {
                    dt.Columns.Add(new DataColumn(dc.Trim(headerDelimiter)));
                }

                while (!sr.EndOfStream)
                {
                    value = sr.ReadLine().Split(rowDelimiter.ToCharArray());
                
                    // Add only those rows where column count matches with row count in the csv file
                    if (value.Length == dt.Columns.Count)
                    {
                        row = dt.NewRow();
                        row.ItemArray = value;
                        dt.Rows.Add(row);
                    }
                    else
                    {
                       // Show error that the row count is not matching with column
                       MessageBox.Show("Error in Row " + "\n" + "\n" + sr.ReadLine());
                    }

                }
            }

            catch (System.IndexOutOfRangeException ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
                throw argEx;
            }


            // Set the datagrid source as the data-table dt

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Betrag Soll"].DefaultCellStyle.FormatProvider = cultureInfo;
            dataGridView1.Columns["Betrag Soll"].DefaultCellStyle.Format = String.Format("c");
          
            double resultValueHaben = 0;
            double resultValueSoll = 0;

            // CALCULATION PART FOR BETRAG SOLL AND BETRAG HABEN

            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count- 1; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[15].Value.ToString() != "") 
                
                    {
                        string betragSollData = (string)dataGridView1.Rows[i].Cells[15].FormattedValue.ToString();
                        resultValueSoll += double.Parse(betragSollData, cultureInfo);
                    }

                    if (dataGridView1.Rows[i].Cells[16].Value.ToString() != "")
                
                    {                 
                        string betragHabenData = (string)dataGridView1.Rows[i].Cells[16].FormattedValue.ToString();
                        resultValueHaben += double.Parse(betragHabenData, cultureInfo);
                    }

                }

                // Display the summed results in label.

                lbl_betragSoll.Text = ((char)0x20AC).ToString() + resultValueSoll.ToString(cultureInfo);

                lbl_betraghaben.Text = ((char)0x20AC).ToString() + resultValueHaben.ToString(cultureInfo);

                string message = "Summe der Spalten Betrag Soll: " + lbl_betragSoll.Text + "\n" + "Summe der Spalten Betrag Haben: " + lbl_betraghaben.Text + "\n" + "Anzahl CSV Datei Gesamtzeilen: " + count.ToString();

                MessageBox.Show(message, "Ausgabe");
            }

            catch (Exception ex)
            {
                throw new ApplicationException("An unexpected error occured! "+ ex.Message);
                
            }

        }


        //***********************************************************************************************


        // Function to import csv file on Button click
        private void btn_ImportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialogBox = new OpenFileDialog())
                {
                    dialogBox.Title = "Open CSV File";
                    dialogBox.Filter = "CSV Files (*.csv)|*.csv";
                    if (dialogBox.ShowDialog() == DialogResult.OK)
                    {
                        string strFileName = dialogBox.FileName;
                        if (strFileName != "")
                        {
                            txtFileName.Text = strFileName;
                        }
                        string FileExtension = strFileName.Substring(strFileName.LastIndexOf('.') + 1).ToLower();
                        LoadData(strFileName);
                    }
                    else
                    {
                        MessageBox.Show("No File Chosen!");
                    }
                    
                }

            }
            catch (Exception ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("Not valid CSV file, please re-check!", "index", ex);
                throw argEx;

            }
        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(txtFileName.Text);
                e.Handled = true;
            }
        }


        //***********************************************************************************************

    }
}
