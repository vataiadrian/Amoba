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

        private void kilepbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            kilepbtn.Visible = false;
            visszabtn.Visible = true;
            jatekosnev1tb.Visible = true;
            jatekosnev2tb.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void visszabtn_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            kilepbtn.Visible = true;
            visszabtn.Visible = false;
            panel1.Visible = false;
            jatekosnev1tb.Visible = false;
            jatekosnev2tb.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            kilepbtn.Visible = false;
            panel1.Visible = true;
            visszabtn.Visible = true;
        }
    }
}
