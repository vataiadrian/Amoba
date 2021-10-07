using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amoba
{
    public partial class JatekTer : Form
    {
        public JatekTer()
        {
            InitializeComponent();

            GoFullscreen(true);
        }

        //Design
        static bool esc = false;
        private void GoFullscreen(bool fullscreen)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void JatekTer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (!esc)
                {
                    guna2Panel1.Visible = true;
                    esc = true;
                }
                else
                {
                    guna2Panel1.Visible = false;
                    esc = false;
                }
            }
        }

        private void kilepesbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog(this);
        }

        private void restertbtn_Click(object sender, EventArgs e)
        {

        }

        private void JatekTer_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            if (r.Next(0, 100) >= 50)
            {

            }
            else
            {

            }
        }
    }
}
