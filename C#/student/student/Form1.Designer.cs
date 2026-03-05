namespace student
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_imie = new System.Windows.Forms.TextBox();
            this.tb_nazwisko = new System.Windows.Forms.TextBox();
            this.tb_kierunek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.cb_xml = new System.Windows.Forms.CheckBox();
            this.cb_csv = new System.Windows.Forms.CheckBox();
            this.cb_json = new System.Windows.Forms.CheckBox();
            this.bt_utworz = new System.Windows.Forms.Button();
            this.bt_import = new System.Windows.Forms.Button();
            this.bt_export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_imie
            // 
            this.tb_imie.Location = new System.Drawing.Point(33, 62);
            this.tb_imie.Name = "tb_imie";
            this.tb_imie.Size = new System.Drawing.Size(227, 22);
            this.tb_imie.TabIndex = 0;
            this.tb_imie.Text = "Maksymilian";
            // 
            // tb_nazwisko
            // 
            this.tb_nazwisko.Location = new System.Drawing.Point(33, 105);
            this.tb_nazwisko.Name = "tb_nazwisko";
            this.tb_nazwisko.Size = new System.Drawing.Size(227, 22);
            this.tb_nazwisko.TabIndex = 1;
            this.tb_nazwisko.Text = "Beta";
            // 
            // tb_kierunek
            // 
            this.tb_kierunek.Location = new System.Drawing.Point(33, 150);
            this.tb_kierunek.Name = "tb_kierunek";
            this.tb_kierunek.Size = new System.Drawing.Size(227, 22);
            this.tb_kierunek.TabIndex = 2;
            this.tb_kierunek.Text = "Informatyka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "kierunek";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(305, 38);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(452, 355);
            this.rtb.TabIndex = 6;
            this.rtb.Text = "";
            // 
            // cb_xml
            // 
            this.cb_xml.AutoSize = true;
            this.cb_xml.Location = new System.Drawing.Point(33, 178);
            this.cb_xml.Name = "cb_xml";
            this.cb_xml.Size = new System.Drawing.Size(89, 20);
            this.cb_xml.TabIndex = 7;
            this.cb_xml.Text = "utworz xml";
            this.cb_xml.UseVisualStyleBackColor = true;
            // 
            // cb_csv
            // 
            this.cb_csv.AutoSize = true;
            this.cb_csv.Location = new System.Drawing.Point(32, 204);
            this.cb_csv.Name = "cb_csv";
            this.cb_csv.Size = new System.Drawing.Size(90, 20);
            this.cb_csv.TabIndex = 8;
            this.cb_csv.Text = "utworz csv";
            this.cb_csv.UseVisualStyleBackColor = true;
            // 
            // cb_json
            // 
            this.cb_json.AutoSize = true;
            this.cb_json.Location = new System.Drawing.Point(33, 230);
            this.cb_json.Name = "cb_json";
            this.cb_json.Size = new System.Drawing.Size(94, 20);
            this.cb_json.TabIndex = 9;
            this.cb_json.Text = "utworz json";
            this.cb_json.UseVisualStyleBackColor = true;
            // 
            // bt_utworz
            // 
            this.bt_utworz.Location = new System.Drawing.Point(33, 256);
            this.bt_utworz.Name = "bt_utworz";
            this.bt_utworz.Size = new System.Drawing.Size(227, 46);
            this.bt_utworz.TabIndex = 10;
            this.bt_utworz.Text = "Utworz format";
            this.bt_utworz.UseVisualStyleBackColor = true;
            this.bt_utworz.Click += new System.EventHandler(this.bt_utworz_Click);
            // 
            // bt_import
            // 
            this.bt_import.Location = new System.Drawing.Point(25, 319);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(97, 74);
            this.bt_import.TabIndex = 11;
            this.bt_import.Text = "Importuj";
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click);
            // 
            // bt_export
            // 
            this.bt_export.Location = new System.Drawing.Point(155, 318);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(105, 75);
            this.bt_export.TabIndex = 12;
            this.bt_export.Text = "Exportuj";
            this.bt_export.UseVisualStyleBackColor = true;
            this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_import);
            this.Controls.Add(this.bt_utworz);
            this.Controls.Add(this.cb_json);
            this.Controls.Add(this.cb_csv);
            this.Controls.Add(this.cb_xml);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_kierunek);
            this.Controls.Add(this.tb_nazwisko);
            this.Controls.Add(this.tb_imie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_imie;
        private System.Windows.Forms.TextBox tb_nazwisko;
        private System.Windows.Forms.TextBox tb_kierunek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.CheckBox cb_xml;
        private System.Windows.Forms.CheckBox cb_csv;
        private System.Windows.Forms.CheckBox cb_json;
        private System.Windows.Forms.Button bt_utworz;
        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.Button bt_export;
    }
}

