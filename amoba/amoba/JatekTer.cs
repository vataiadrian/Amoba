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
        private void GoFullscreen(bool fullscreen)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
