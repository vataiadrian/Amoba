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
        static string masodikjateko = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            elsojatekos = jatekosnev1tb.Text;
            masodikjateko = jatekosnev2tb.Text;
            
            

            JatekTer jatekter = new JatekTer();
            this.Hide();
            jatekter.ShowDialog(this);
        }
    }
}
