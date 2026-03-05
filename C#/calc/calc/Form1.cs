using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_oblicz_Click(object sender, EventArgs e)
        {
            double cena= double.Parse(tb_cena.Text);
            double ilosc = double.Parse(tb_ilosc.Text) ;
            double checkbox5 = 5;
            double checkbox10 = 10;
            double wynik= cena * ilosc + (checkbox5*Convert.ToInt32(cb_5.Checked)+ (checkbox10*Convert.ToInt32(cb_10.Checked)) );
            lb_wynik.Text=wynik.ToString()+" zł";
        }

        private void bt_wyczysc_Click(object sender, EventArgs e)
        {
            lb_wynik.Text = "WYNIK: ";
            tb_cena.Text = "";
            tb_ilosc.Text = "";
            cb_5.Checked = false;
            cb_10.Checked = false;
        }

        private void bt_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki xml|*.xml|Pliki csv|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK) {
                if (sfd.FileName.EndsWith(".xml")) 
                { 
                string plikXML= "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n"+
                        "<Zamowienie>\r\n"+
                        "<cena>"+tb_cena.Text+"</cena>\r\n" +
                        "<ilosc>"+tb_ilosc.Text+"</ilosc>\r\n" +
                        "<dostawa5>"+cb_5.Checked.ToString()+"</dostawa5>\r\n" +
                        "<dostawa10>"+cb_10.Checked.ToString()+"</dostawa10>\r\n" +
                        "<wynik>"+lb_wynik.Text+"</wynik>\r\n" +
                        "</Zamowienie>";
                    File.WriteAllText(sfd.FileName, plikXML);

                }
                if (sfd.FileName.EndsWith(".csv")) 
                {
                    string plikCSV = "cena" + ";" + "ilosc" + ";" + "checkbox5" + ";" + "checkbox10" +";"+"wynik\r\n"+
                        tb_cena.Text+";"+tb_ilosc.Text+";"+cb_5.Checked+";"+cb_10.Checked+";"+lb_wynik.Text;
                    File.WriteAllText(sfd.FileName,plikCSV);
                }
            }
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(".xml"))
                {
                    string daneXML = File.ReadAllText(ofd.FileName);
                    daneXML = daneXML.Remove(0, daneXML.IndexOf("\r\n"));
                    daneXML = daneXML.Remove(0, daneXML.IndexOf("\r\n"));
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">")+3);
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">")+1);
                    tb_cena.Text = daneXML.Substring(0, daneXML.IndexOf("<"));
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">") + 3);
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">") + 1);
                    tb_ilosc.Text = daneXML.Substring(0, daneXML.IndexOf("<"));
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">") + 3);
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">") + 1);
                    cb_5.Checked = bool.Parse(daneXML.Substring(0, daneXML.IndexOf("<")));
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">") + 3);
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">") + 1);
                    cb_10.Checked = bool.Parse(daneXML.Substring(0, daneXML.IndexOf("<")));
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">") + 3);
                    daneXML = daneXML.Remove(0, daneXML.IndexOf(">") + 1);
                    lb_wynik.Text = daneXML.Substring(0, daneXML.IndexOf("<"));
                }
                if (ofd.FileName.EndsWith(".csv")) 
                { 
                    string[] daneCSV = File.ReadAllLines(ofd.FileName);
                    string[] wartosci = daneCSV[1].Split(';');
                    tb_cena.Text = wartosci[0];
                    tb_ilosc.Text = wartosci[1];
                    cb_10.Checked = bool.Parse(wartosci[3]);
                    cb_5.Checked = bool.Parse(wartosci[2]);
                    lb_wynik.Text = wartosci[4];
                }
            }
        }
    }
}
