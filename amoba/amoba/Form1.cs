using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace amoba
{
    public partial class Form1 : Form
    {
        static string elsojatekos = "";
        static string masodikjatekos = "";
        static List<Nevek> nev = new List<Nevek>();
        public Form1()
        {
            InitializeComponent();
            jatekosnev1tb.Text = "sadfsad";
            jatekosnev2tb.Text = "asdfasd";
        }        
     
        private void button1_Click(object sender, EventArgs e)
        {
            elsojatekos = jatekosnev1tb.Text;
            masodikjatekos = jatekosnev2tb.Text;

            string segednev = jatekosnev1tb.Text + ";" + jatekosnev2tb.Text;
            

            if (elsojatekos != "" && masodikjatekos != "")
            {
                Nevek uj = new Nevek(segednev);
                nev.Add(uj);
                JatekTer jatekter = new JatekTer();
                this.Hide();
                jatekter.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Kérem adja meg a nevét!", "Hiányzó név", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
