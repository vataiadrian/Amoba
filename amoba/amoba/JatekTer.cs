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
        static Label[,] labelok = new Label[10, 10];
        public JatekTer()
        {
            InitializeComponent();
            generalas();

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
                    panelO.Visible = false; panelX.Visible = false; label100.Visible = false; label101.Visible = false;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            labelok[i,j].Visible = false;

                        }

                    }
                }
                else
                {
                    guna2Panel1.Visible = false;
                    esc = false;
                    panelO.Visible = true; panelX.Visible = true; label100.Visible = true; label101.Visible = true;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            labelok[i, j].Visible = true;

                        }

                    }

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
            if (r.Next(0, 6) > 3)
            {
                labelO.Text = global.jatekosnev1;
                labelX.Text = global.jatekosnev2;
                
            }
            else
            {
                labelO.Text = global.jatekosnev2;
                labelX.Text = global.jatekosnev1;

            }
        }

        private void generalas()
        {
            int labelindexelo = 0;
            int yrajz = 0;
            int xrajz = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labelok[i, j] = new Label();
                    labelok[i, j].Size = new Size(60, 60);
                    labelok[i, j].BackColor = Color.FromArgb(127, 127, 127);
                    labelok[i, j].Name = "label" + labelindexelo;

                    labelindexelo++;
                    switch (i)
                    {
                        case 0:
                            xrajz = 33;
                            break;
                        case 1:
                            xrajz = 100;
                            break;
                        case 2:
                            xrajz = 167;
                            break;
                        case 3:
                            xrajz = 234;
                            break;
                        case 4:
                            xrajz = 301;
                            break;
                        case 5:
                            xrajz = 368;
                            break;
                        case 6:
                            xrajz = 435;
                            break;
                        case 7:
                            xrajz = 502;
                            break;
                        case 8:
                            xrajz = 569;
                            break;
                        case 9:
                            xrajz = 636;
                            break;
                    }
                    switch (j)
                    {
                        case 0:
                            yrajz = 367;
                            break;
                        case 1:
                            yrajz = 434;
                            break;
                        case 2:
                            yrajz = 501;
                            break;
                        case 3:
                            yrajz = 568;
                            break;
                        case 4:
                            yrajz = 635;
                            break;
                        case 5:
                            yrajz = 702;
                            break;
                        case 6:
                            yrajz = 769;
                            break;
                        case 7:
                            yrajz = 836;
                            break;
                        case 8:
                            yrajz = 903;
                            break;
                        case 9:
                            yrajz = 970;
                            break;
                    }
                   // MessageBox.Show("" + i + " " + j, "asd", MessageBoxButtons.OK);
                    labelok[i, j].Anchor = AnchorStyles.None;
                    labelok[i, j].Location = new System.Drawing.Point(yrajz, xrajz);
                    Controls.Add(labelok[i, j]);
                    labelok[i, j].BringToFront();
                }

            }
        }
    }
}
