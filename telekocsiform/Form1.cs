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

namespace telekocsiform
{
    public partial class FrmFo : Form
    {
        private List<auto> autok = new List<auto>();
        private List<igeny> igenyek = new List<igeny>();
        public FrmFo()
        {
            InitializeComponent();
            lbKimenet.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBeolvasas_Click(object sender, EventArgs e)
        {
            try
            {
                
                    StreamReader sr = new StreamReader("autok.csv");
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        autok.Add(new auto(sr.ReadLine()));
                    }
                    sr.Close();
                


                
                    //StreamReader s = new StreamReader("igenyek.csv");
                    //s.ReadLine();
                    //while (!s.EndOfStream)
                    //{
                    //    igenyek.Add(new igeny(sr.ReadLine()));
                    //}
                    //s.Close();


                btnSecond.Enabled = true;
                BtnBeolvasas.Enabled = false;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            
            lbKimenet.Items.Add("2. feladat");
            lbKimenet.Items.Add(autok.Count() + " Autós hirdet fuvart");
            btnSecond.Enabled = false;
            btnThird.Enabled = true;
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            
            lbKimenet.Items.Add("3. feladat");
            int ferohely = 0;
            foreach (var t in autok)
            {
                if (t.Indulas == "Budapest" && t.Cel == "Miskolc")
                {
                    ferohely += t.Ferohely;
                }
            }

            lbKimenet.Items.Add($"Összesen {ferohely} férőhelyet hirdettek meg");
            btnThird.Enabled = false;
            btnFourth.Enabled = true;
        }

        private void btnFourth_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> utvonal = new Dictionary<string, int>();

            foreach (var t in autok)
            {
                if (!utvonal.ContainsKey(t.utvonalak))
                {
                    utvonal.Add(t.utvonalak, t.Ferohely);
                }
                else
                {
                    utvonal[t.utvonalak] = utvonal[t.utvonalak] + t.Ferohely;
                }
            }


            int max = 0;
            string utv = "";
            foreach (var u in utvonal)
            {
                if (u.Value > max)
                {
                    max = u.Value;
                    utv = u.Key;
                }
            }
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("4.feladat");
            lbKimenet.Items.Add("A legtöbb férőhely: ");
            lbKimenet.Items.Add($"{max} ");
            lbKimenet.Items.Add("a");
            lbKimenet.Items.Add($"{utv} útvonalon");
            lbKimenet.Items.Add("Ajánlották fel a hirdetők");
            btnFourth.Enabled = false;
            btnFith.Enabled = true;
        }

        private void btnFith_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("5. feladat");
            foreach (var igeny in igenyek)
            {
                int i = igeny.VanAuto(autok);

                if (i > -1)
                {
                    lbKimenet.Items.Add($"{igeny.Azonosito} => {autok[i].Rendszam}");
                }
            }
            btnFith.Enabled = false;
            btnSixth.Enabled = true;

        }

        private void btnSixth_Click(object sender, EventArgs e)
        {
            try
            {
                lbKimenet.Items.Clear();
                lbKimenet.Items.Add("6.feladat");
                StreamWriter sw = new StreamWriter("utasvalami.txt");
                foreach (var igeny in igenyek)
                {
                    int i = igeny.VanAuto(autok);
                    if (i < -1)
                    {
                        sw.WriteLine($"{igeny.Azonosito} => {autok[i].Rendszam}");
                    }
                    else
                    {
                        sw.WriteLine($"{igeny.Azonosito}: Sajnos nem sikerült autók találni");
                    }
                    sw.Close();
                    lbKimenet.Items.Add("Az adatok fájlba írása megtörtént");
                    btnSixth.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
