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

        

        public MainWindow()
        {
            InitializeComponent();
            lbl_betragSoll.Text = "";
            lbl_betraghaben.Text = "";
        }

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


        private void LoadData(string strFilePath)
        {

            StreamReader sr = new StreamReader(strFilePath);

            long count = CountLinesInFile(strFilePath);
            MessageBox.Show("Anzahl CSV Datei Gesamtzeilen: " + count.ToString());

            string line = sr.ReadLine();
            string[] value = line.Split('\t');
            DataTable dt = new DataTable();
            DataRow row;
            foreach (string dc in value)
            {
                dt.Columns.Add(new DataColumn(dc.Trim('\t')));

            }

            while (!sr.EndOfStream)
            {
                value = sr.ReadLine().Split("\t\r\n".ToCharArray());
                if (value.Length == dt.Columns.Count)
                {
                    row = dt.NewRow();
                    row.ItemArray = value;
                    dt.Rows.Add(row);

                }
                else
                {
                    MessageBox.Show("Error in Row " + "\n" + "\n" + sr.ReadLine());
                }

                

            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Betrag Soll"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("de-DE");
            dataGridView1.Columns["Betrag Soll"].DefaultCellStyle.Format = String.Format("c");
          
            double resultValueHaben = 0;
            double resultValueSoll = 0;

            CultureInfo culture = new CultureInfo("de-DE");


            for (int i = 0; i < dataGridView1.Rows.Count- 1; ++i)
            {
                if (dataGridView1.Rows[i].Cells[15].Value.ToString() != "") 
                
                {
                    string betragSollData = (string)dataGridView1.Rows[i].Cells[15].FormattedValue.ToString();
                    resultValueSoll += double.Parse(betragSollData, CultureInfo.GetCultureInfo("de"));

                }

                if (dataGridView1.Rows[i].Cells[16].Value.ToString() != "")
                
                {
                 
                    string betragHabenData = (string)dataGridView1.Rows[i].Cells[16].FormattedValue.ToString();
                    resultValueHaben += double.Parse(betragHabenData, CultureInfo.GetCultureInfo("de"));

                }

            }

            lbl_betragSoll.Text = resultValueSoll.ToString(culture);

            lbl_betraghaben.Text = resultValueHaben.ToString(culture);


        }

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
            catch (Exception)
            {
                throw;
                
            }
        }
    }
}
