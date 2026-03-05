using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
namespace student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_utworz_Click(object sender, EventArgs e)
        {
            if (cb_csv.Checked)
            {
                string plikCSV = "imie" + ";" + "nazwisko" + ";" + "kierunek" + "\r\n" +
                    tb_imie.Text + ";" + tb_nazwisko.Text + ";" + tb_kierunek.Text;
                rtb.Text = plikCSV;
            }
            if (cb_xml.Checked)
            {
                string plikXML = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n" +
                        "<student>\r\n" +
                    "<imie>" + tb_imie.Text + "</imie>\r\n" +
                    "<nazwisko>" + tb_nazwisko.Text + "</nazwisko>\r\n" +
                    "<kierunek>" + tb_kierunek.Text + "</kierunek>\r\n" +
                    "</student>";
                rtb.Text = plikXML;
            }
            if (cb_json.Checked)
            {
                string plikJSON = $@"{{
  ""imie"": ""{tb_imie.Text}"",
    ""nazwisko"": ""{tb_nazwisko.Text}"",
    ""kierunek"": ""{tb_kierunek.Text}""
}}";
                rtb.Text = plikJSON;
            }
        }

        private void bt_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki XML|*.xml|Pliki CSV|*.csv|Pliki JSON|*.json";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                if (sfd.FileName.EndsWith(".xml"))
                {
                    string plikXML = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n" +
                        "<student>\r\n" +
                    "<imie>" + tb_imie.Text + "</imie>\r\n" +
                    "<nazwisko>" + tb_nazwisko.Text + "</nazwisko>\r\n" +
                    "<kierunek>" + tb_kierunek.Text + "</kierunek>\r\n" +
                    "</student>";
                    File.WriteAllText(sfd.FileName, plikXML);
                }
                if (sfd.FileName.EndsWith(".csv"))
                {
                    string plikCSV = "imie" + ";" + "nazwisko" + ";" + "kierunek" + "\r\n" +
                        tb_imie.Text + ";" + tb_nazwisko.Text + ";" + tb_kierunek.Text;
                    File.WriteAllText(sfd.FileName, plikCSV);
                }
                if (sfd.FileName.EndsWith(".json"))
                {

                    string plikJSON = $@"{{
  ""imie"": ""{tb_imie.Text}"",
    ""nazwisko"": ""{tb_nazwisko.Text}"",
    ""kierunek"": ""{tb_kierunek.Text}""
}}";
                    File.WriteAllText(sfd.FileName, plikJSON);
                }
            }
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki XML|*.xml|Pliki CSV|*.csv|Pliki JSON|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(".csv")) {
                    string[] dane = File.ReadAllLines(ofd.FileName);
                    string[] wartosci = dane[1].Split(';');
                    tb_imie.Text=wartosci[0];
                    tb_nazwisko.Text=wartosci[1];
                    tb_kierunek.Text=wartosci[2];    
                }
                if (ofd.FileName.EndsWith(".xml")) {
                    string[] dane = File.ReadAllLines(ofd.FileName);
                    tb_imie.Text = dane[2].Replace("<imie>", "").Replace("</imie>", "").Trim();
                    tb_nazwisko.Text = dane[3].Replace("<nazwisko>", "").Replace("</nazwisko>", "").Trim();
                    tb_kierunek.Text = dane[4].Replace("<kierunek>", "").Replace("</kierunek>", "").Trim();
                }
                if (ofd.FileName.EndsWith(".json")) {
                string dane= File.ReadAllText(ofd.FileName);
                    dane=dane.Remove(0, dane.IndexOf(":")+3);
                    tb_imie.Text=dane.Substring(0,dane.IndexOf(",")-1);
                    dane=dane.Remove(0, dane.IndexOf(":")+3);
                    tb_nazwisko.Text=dane.Substring(0,dane.IndexOf(",")-1);
                    dane=dane.Remove(0, dane.IndexOf(":")+3);
                    tb_kierunek.Text = dane.Substring(0, dane.IndexOf("}")-3);

                }
            }
        }
    }
}
