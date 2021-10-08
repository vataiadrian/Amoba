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
        
        public Form1()
        {
            InitializeComponent();
            jatekosnev1tb.Text = "sadfsad";
            jatekosnev2tb.Text = "asdfasd";
        }        
     
        public void button1_Click(object sender, EventArgs e)
        {
            elsojatekos = jatekosnev1tb.Text;
            masodikjatekos = jatekosnev2tb.Text;

            
            

            if (elsojatekos != "" && masodikjatekos != "")
            {
                global.jatekosnev1 = elsojatekos;
                global.jatekosnev2 = masodikjatekos;
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
