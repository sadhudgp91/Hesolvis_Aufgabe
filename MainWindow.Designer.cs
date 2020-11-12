
namespace Hesolvis_Aufgabe
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ImportCSV = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_betrag_soll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_betragSoll = new System.Windows.Forms.Label();
            this.lbl_betraghaben = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ImportCSV
            // 
            this.btn_ImportCSV.Location = new System.Drawing.Point(23, 47);
            this.btn_ImportCSV.Name = "btn_ImportCSV";
            this.btn_ImportCSV.Size = new System.Drawing.Size(138, 41);
            this.btn_ImportCSV.TabIndex = 0;
            this.btn_ImportCSV.Text = "CSV datei importieren";
            this.btn_ImportCSV.UseVisualStyleBackColor = true;
            this.btn_ImportCSV.Click += new System.EventHandler(this.btn_ImportCSV_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(215, 58);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(510, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1304, 378);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Read CSV File ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Summe der Betrag Soll:";
            // 
            // lbl_betrag_soll
            // 
            this.lbl_betrag_soll.AutoSize = true;
            this.lbl_betrag_soll.Location = new System.Drawing.Point(166, 502);
            this.lbl_betrag_soll.Name = "lbl_betrag_soll";
            this.lbl_betrag_soll.Size = new System.Drawing.Size(0, 13);
            this.lbl_betrag_soll.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Summe der Betrag Haben:";
            // 
            // lbl_betragSoll
            // 
            this.lbl_betragSoll.AutoSize = true;
            this.lbl_betragSoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_betragSoll.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_betragSoll.Location = new System.Drawing.Point(231, 502);
            this.lbl_betragSoll.Name = "lbl_betragSoll";
            this.lbl_betragSoll.Size = new System.Drawing.Size(103, 20);
            this.lbl_betragSoll.TabIndex = 7;
            this.lbl_betragSoll.Text = "Betrag Soll:";
            // 
            // lbl_betraghaben
            // 
            this.lbl_betraghaben.AutoSize = true;
            this.lbl_betraghaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_betraghaben.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_betraghaben.Location = new System.Drawing.Point(231, 538);
            this.lbl_betraghaben.Name = "lbl_betraghaben";
            this.lbl_betraghaben.Size = new System.Drawing.Size(121, 20);
            this.lbl_betraghaben.TabIndex = 8;
            this.lbl_betraghaben.Text = "Betrag Haben";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(750, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sie können auch den Dateinamen auswählen und die Eingabetaste drücken, um die Dat" +
    "en neu zu laden";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_betraghaben);
            this.Controls.Add(this.lbl_betragSoll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_betrag_soll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btn_ImportCSV);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Text = "MainWindow Hesolvis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ImportCSV;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_betrag_soll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_betragSoll;
        private System.Windows.Forms.Label lbl_betraghaben;
        private System.Windows.Forms.Label label4;
    }
}

