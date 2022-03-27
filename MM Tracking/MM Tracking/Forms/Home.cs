using MM_Tracking.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_Tracking
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {

                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            CustomizedErrorMessage.Show("Voulez vous vraiment quitter L'application?", "alerte", "Oui", "Non");
            if (CustomizedErrorMessage.closeProgram)
            {
                Application.Exit();
            }
        }

        private void TrackBtn_Click(object sender, EventArgs e)
        {
            MoneyTrack money = new MoneyTrack();
            money.WindowState = this.WindowState;
            money.Show();
            Home home = (Home)Application.OpenForms["Home"];
            home.Hide();
        }


    }
}
