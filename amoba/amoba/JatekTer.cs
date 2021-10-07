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
                    lbl1.Visible = false; label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false; label9.Visible = false;
                    label10.Visible = false; label11.Visible = false; label12.Visible = false; label13.Visible = false; label14.Visible = false; label15.Visible = false; label16.Visible = false; label17.Visible = false; label18.Visible = false; label19.Visible = false;
                    label20.Visible = false; label21.Visible = false; label22.Visible = false; label23.Visible = false; label24.Visible = false; label25.Visible = false; label26.Visible = false; label27.Visible = false; label28.Visible = false; label29.Visible = false;
                    label30.Visible = false; label31.Visible = false; label32.Visible = false; label33.Visible = false; label34.Visible = false; label35.Visible = false; label36.Visible = false; label37.Visible = false; label38.Visible = false; label39.Visible = false;
                    label40.Visible = false; label41.Visible = false; label42.Visible = false; label43.Visible = false; label44.Visible = false; label45.Visible = false; label46.Visible = false; label47.Visible = false; label48.Visible = false; label49.Visible = false;
                    label50.Visible = false; label51.Visible = false; label52.Visible = false; label53.Visible = false; label54.Visible = false; label55.Visible = false; label56.Visible = false; label57.Visible = false; label58.Visible = false; label59.Visible = false;
                    label60.Visible = false; label61.Visible = false; label62.Visible = false; label63.Visible = false; label64.Visible = false; label65.Visible = false; label66.Visible = false; label67.Visible = false; label68.Visible = false; label69.Visible = false;
                    label70.Visible = false; label71.Visible = false; label72.Visible = false; label73.Visible = false; label74.Visible = false; label75.Visible = false; label76.Visible = false; label77.Visible = false; label78.Visible = false; label79.Visible = false;
                    label80.Visible = false; label81.Visible = false; label82.Visible = false; label83.Visible = false; label84.Visible = false; label85.Visible = false; label86.Visible = false; label87.Visible = false; label88.Visible = false; label89.Visible = false;
                    label90.Visible = false; label91.Visible = false; label92.Visible = false; label93.Visible = false; label94.Visible = false; label95.Visible = false; label96.Visible = false; label97.Visible = false; label98.Visible = false; label99.Visible = false;
                    panelO.Visible = false; panelX.Visible = false; label100.Visible = false; label101.Visible = false;
                }
                else
                {
                    guna2Panel1.Visible = false;
                    esc = false;
                    lbl1.Visible = true; label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true; label9.Visible = true;
                    label10.Visible = true; label11.Visible = true; label12.Visible = true; label13.Visible = true; label14.Visible = true; label15.Visible = true; label16.Visible = true; label17.Visible = true; label18.Visible = true; label19.Visible = true;
                    label20.Visible = true; label21.Visible = true; label22.Visible = true; label23.Visible = true; label24.Visible = true; label25.Visible = true; label26.Visible = true; label27.Visible = true; label28.Visible = true; label29.Visible = true;
                    label30.Visible = true; label31.Visible = true; label32.Visible = true; label33.Visible = true; label34.Visible = true; label35.Visible = true; label36.Visible = true; label37.Visible = true; label38.Visible = true; label39.Visible = true;
                    label40.Visible = true; label41.Visible = true; label42.Visible = true; label43.Visible = true; label44.Visible = true; label45.Visible = true; label46.Visible = true; label47.Visible = true; label48.Visible = true; label49.Visible = true;
                    label50.Visible = true; label51.Visible = true; label52.Visible = true; label53.Visible = true; label54.Visible = true; label55.Visible = true; label56.Visible = true; label57.Visible = true; label58.Visible = true; label59.Visible = true;
                    label60.Visible = true; label61.Visible = true; label62.Visible = true; label63.Visible = true; label64.Visible = true; label65.Visible = true; label66.Visible = true; label67.Visible = true; label68.Visible = true; label69.Visible = true;
                    label70.Visible = true; label71.Visible = true; label72.Visible = true; label73.Visible = true; label74.Visible = true; label75.Visible = true; label76.Visible = true; label77.Visible = true; label78.Visible = true; label79.Visible = true;
                    label80.Visible = true; label81.Visible = true; label82.Visible = true; label83.Visible = true; label84.Visible = true; label85.Visible = true; label86.Visible = true; label87.Visible = true; label88.Visible = true; label89.Visible = true;
                    label90.Visible = true; label91.Visible = true; label92.Visible = true; label93.Visible = true; label94.Visible = true; label95.Visible = true; label96.Visible = true; label97.Visible = true; label98.Visible = true; label99.Visible = true;
                    panelO.Visible = true; panelX.Visible = true; label100.Visible = true; label101.Visible = true;
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
    }
}
