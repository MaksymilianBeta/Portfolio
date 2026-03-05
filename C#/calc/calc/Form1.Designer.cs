namespace calc
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
            this.tb_cena = new System.Windows.Forms.TextBox();
            this.tb_ilosc = new System.Windows.Forms.TextBox();
            this.lb_wynik = new System.Windows.Forms.Label();
            this.bt_oblicz = new System.Windows.Forms.Button();
            this.bt_export = new System.Windows.Forms.Button();
            this.bt_import = new System.Windows.Forms.Button();
            this.cb_5 = new System.Windows.Forms.CheckBox();
            this.cb_10 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_wyczysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_cena
            // 
            this.tb_cena.Location = new System.Drawing.Point(24, 60);
            this.tb_cena.Name = "tb_cena";
            this.tb_cena.Size = new System.Drawing.Size(171, 22);
            this.tb_cena.TabIndex = 0;
            // 
            // tb_ilosc
            // 
            this.tb_ilosc.Location = new System.Drawing.Point(24, 115);
            this.tb_ilosc.Name = "tb_ilosc";
            this.tb_ilosc.Size = new System.Drawing.Size(171, 22);
            this.tb_ilosc.TabIndex = 1;
            // 
            // lb_wynik
            // 
            this.lb_wynik.AutoSize = true;
            this.lb_wynik.Location = new System.Drawing.Point(271, 51);
            this.lb_wynik.Name = "lb_wynik";
            this.lb_wynik.Size = new System.Drawing.Size(56, 16);
            this.lb_wynik.TabIndex = 2;
            this.lb_wynik.Text = "WYNIK: ";
            // 
            // bt_oblicz
            // 
            this.bt_oblicz.Location = new System.Drawing.Point(24, 154);
            this.bt_oblicz.Name = "bt_oblicz";
            this.bt_oblicz.Size = new System.Drawing.Size(171, 48);
            this.bt_oblicz.TabIndex = 3;
            this.bt_oblicz.Text = "oblicz";
            this.bt_oblicz.UseVisualStyleBackColor = true;
            this.bt_oblicz.Click += new System.EventHandler(this.bt_oblicz_Click);
            // 
            // bt_export
            // 
            this.bt_export.Location = new System.Drawing.Point(24, 283);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(75, 102);
            this.bt_export.TabIndex = 4;
            this.bt_export.Text = "exportuj";
            this.bt_export.UseVisualStyleBackColor = true;
            this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
            // 
            // bt_import
            // 
            this.bt_import.Location = new System.Drawing.Point(120, 283);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(75, 102);
            this.bt_import.TabIndex = 5;
            this.bt_import.Text = "importuj";
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click);
            // 
            // cb_5
            // 
            this.cb_5.AutoSize = true;
            this.cb_5.Location = new System.Drawing.Point(24, 208);
            this.cb_5.Name = "cb_5";
            this.cb_5.Size = new System.Drawing.Size(43, 20);
            this.cb_5.TabIndex = 6;
            this.cb_5.Text = "+5";
            this.cb_5.UseVisualStyleBackColor = true;
            // 
            // cb_10
            // 
            this.cb_10.AutoSize = true;
            this.cb_10.Location = new System.Drawing.Point(145, 208);
            this.cb_10.Name = "cb_10";
            this.cb_10.Size = new System.Drawing.Size(50, 20);
            this.cb_10.TabIndex = 7;
            this.cb_10.Text = "+10";
            this.cb_10.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ilosc";
            // 
            // bt_wyczysc
            // 
            this.bt_wyczysc.Location = new System.Drawing.Point(24, 242);
            this.bt_wyczysc.Name = "bt_wyczysc";
            this.bt_wyczysc.Size = new System.Drawing.Size(171, 35);
            this.bt_wyczysc.TabIndex = 10;
            this.bt_wyczysc.Text = "wyczyść";
            this.bt_wyczysc.UseVisualStyleBackColor = true;
            this.bt_wyczysc.Click += new System.EventHandler(this.bt_wyczysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_wyczysc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_10);
            this.Controls.Add(this.cb_5);
            this.Controls.Add(this.bt_import);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_oblicz);
            this.Controls.Add(this.lb_wynik);
            this.Controls.Add(this.tb_ilosc);
            this.Controls.Add(this.tb_cena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cena;
        private System.Windows.Forms.TextBox tb_ilosc;
        private System.Windows.Forms.Label lb_wynik;
        private System.Windows.Forms.Button bt_oblicz;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.CheckBox cb_5;
        private System.Windows.Forms.CheckBox cb_10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_wyczysc;
    }
}

