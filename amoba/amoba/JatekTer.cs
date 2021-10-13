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
        static bool elso = true;
        
        public JatekTer()
        {
            InitializeComponent();
            generalas();
            MenuBehozas();
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

        private void MenuBehozas()
        {
            this.KeyPreview = true;
            this.KeyPress += (ss, ee) =>
            {
                if (ee.KeyChar == 27)
                {
                    if (!esc)
                    {
                        guna2Panel1.Visible = true;
                        panelO.Visible = false;
                        panelX.Visible = false;
                        label100.Visible = false;
                        label101.Visible = false;
                        kezdonevlbl.Visible = false;
                        kezdojatekostbx.Visible = false;
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                labelok[i, j].Visible = false;
                            }

                        }
                        esc = true;
                    }
                    else
                    {
                        guna2Panel1.Visible = false;
                        panelO.Visible = true;
                        panelX.Visible = true;
                        label100.Visible = true;
                        label101.Visible = true;
                        kezdonevlbl.Visible = true;
                        kezdojatekostbx.Visible = true;
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                labelok[i, j].Visible = true;
                            }

                        }
                        esc = false;
                    }
                }
            };
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
            guna2Panel1.Visible = false;
            panelO.Visible = true;
            panelX.Visible = true;
            label100.Visible = true;
            label101.Visible = true;
            kezdonevlbl.Visible = true;
            kezdojatekostbx.Visible = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labelok[i, j].Visible = true;
                }

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (labelok[i, j].Text != "")
                    {
                        labelok[i, j].Text = "";
                    }
                }
            }

            NevekRandom();
        }

        private void jatekfolytbtn_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            panelO.Visible = true;
            panelX.Visible = true;
            label100.Visible = true;
            label101.Visible = true;
            kezdonevlbl.Visible = true;
            kezdojatekostbx.Visible = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labelok[i, j].Visible = true;
                }

            }
        }


        //Játék
        private void JatekTer_Load(object sender, EventArgs e)
        {
            NevekRandom();
        }

        private void NevekRandom()
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
            if (r.Next(0, 6) > 3)
            {
                elso = false;
                kezdojatekostbx.Font = new Font("Arial", 24);
                kezdojatekostbx.Text = labelX.Text;
            }
            else
            {
                elso = true;
                kezdojatekostbx.Font = new Font("Arial", 24);
                kezdojatekostbx.Text = labelO.Text;
                
            }
            kezdonevlbl.Text = "";
        }

        private void generalas()
        {
            
            int yrajz = 0;
            int xrajz = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labelok[i, j] = new Label();
                    labelok[i, j].Size = new Size(60, 60);
                    labelok[i, j].BackColor = Color.FromArgb(127, 127, 127);
                    labelok[i, j].Name = i+";"+j;

                    
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
                    labelok[i, j].Anchor = AnchorStyles.None;
                    labelok[i, j].Location = new System.Drawing.Point(yrajz, xrajz);
                    labelok[i, j].Click += new System.EventHandler(this.katt);
                    labelok[i, j].Font = new Font("Arial", 32);
                    labelok[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    Controls.Add(labelok[i, j]);
                    labelok[i, j].BringToFront();
                }
            }
        }

        private void katt(object sender, EventArgs e)
        {
            Label kattintott = sender as Label;
            int y = Convert.ToInt32(kattintott.Name.Split(';')[0]);
            int x = Convert.ToInt32(kattintott.Name.Split(';')[1]);
            if (labelok[y, x].Text == "")
            {
                if (elso)
                {

                    labelok[y, x].Text = "O";
                    labelok[y, x].ForeColor = System.Drawing.Color.Red;
                    kezdojatekostbx.Font = new Font("Arial", 24);
                    kezdojatekostbx.Text = labelX.Text;
                    xjelenes();
                    elso = false;
                }
                else
                {
                    labelok[y, x].Text = "X";
                    labelok[y, x].ForeColor = System.Drawing.Color.Blue;
                    kezdojatekostbx.Font = new Font("Arial", 24);
                    kezdojatekostbx.Text = labelO.Text;
                    korjelenes();
                    elso = true;
                }
                ellenorzes();
            }
            else
            {
                kezdonevlbl.Text = "Ne csaljál kis k*cs*g!";

            }    
        }

        private void ellenorzes()
        {
            throw new NotImplementedException();
        }

        //Timer
        private void xjelenes()
        {
            timer2.Start();
        }

        private void korjelenes()
        {
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        labelok[i, j].Visible = true;
                    }
                }
                nagyXlbl.Visible = false;
                nagyOlbl.Visible = false;
                timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labelok[i, j].Visible = false;
                }
            }
            timer2.Stop();
            nagyXlbl.Visible = true;
            timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labelok[i, j].Visible = false;
                }
            }
            timer3.Stop();
            nagyOlbl.Visible = true;
            timer1.Start();
        }
    }
}
