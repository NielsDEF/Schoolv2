using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace AlgoritmeCircus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> dieren = new List<string>();

        Trein t = new Trein();
        string invoer = "";
        string verwijder = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string Input()
        {
            invoer = Convert.ToString(cbInput.Text);
            return invoer;
        }
        private string Verwijderen()
        {
            verwijder = Convert.ToString(cbInput.Text);
            return verwijder;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbWagons.DataSource = null;
            lbWagons.Items.Clear();
            lbWagons.Refresh();
            labIngevoerd.Visible = true;
            labIngevoerd.Text = lbIngevoerd.Items.Count.ToString();
            foreach (string veld in lbIngevoerd.Items)
            {
                Dier d;
                if (veld == "KV")
                {
                    d = new Dier(DierSoorten.KleineCarnivoor);
                    t.VerdeelDier(d);
                }
                else if (veld == "MV")
                {
                    d = new Dier(DierSoorten.MiddelCarnivoor);
                    t.VerdeelDier(d);
                }
                else if (veld == "GV")
                {
                    d = new Dier(DierSoorten.GroteCarnivoor);
                    t.VerdeelDier(d);
                }
                else if (veld == "KP")
                {
                    d = new Dier(DierSoorten.KleineHerbivoor);
                    t.VerdeelDier(d);
                }
                else if (veld == "MP")
                {
                    d = new Dier(DierSoorten.MiddelHerbivoor);
                    t.VerdeelDier(d);
                }
                else
                {
                    d = new Dier(DierSoorten.GroteHerbivoor);
                    t.VerdeelDier(d);
                }
            }

            foreach (Wagon w in t.Wagons)
            {
                lbWagons.Items.Add(w);
                // check voor punten aantallen
                Console.WriteLine($"{w.Punten} ");
                foreach (Dier d in w.Dieren)
                {
                    Console.WriteLine($"{d.Punten} - {d.Soort} - {d.AlgemeneSoort}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input();
            dieren.Add(invoer);
            lbIngevoerd.Items.Clear();
            for (int i = 0; i < dieren.Count; i++)
            {
                lbIngevoerd.Items.Add(dieren.ElementAt(i));
            }
        }

        private void btVerwijderen_Click(object sender, EventArgs e)
        {
            Verwijderen();
            dieren.Remove(verwijder);
            lbIngevoerd.Items.Clear();
            for (int i = 0; i < dieren.Count; i++)
            {
                lbIngevoerd.Items.Add(dieren.ElementAt(i));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (string item in lbIngevoerd.Items)
            {
                if (item == "KP")
                {
                    dieren.Remove("KP");
                }
                else if (item == "KV")
                {
                    dieren.Remove("KV");
                }
                else if (item == "MV")
                {
                    dieren.Remove("MV");
                }
                else if (item == "MP")
                {
                    dieren.Remove("MP");
                }
                else if (item == "GP")
                {
                    dieren.Remove("GP");
                }
                else if (item == "GV")
                {
                    dieren.Remove("GV");
                }
            }
                lbIngevoerd.Items.Clear();
                for (int i = 0; i < dieren.Count; i++)
                {
                    lbIngevoerd.Items.Add(dieren.ElementAt(i));
                }
        }
    }
}
