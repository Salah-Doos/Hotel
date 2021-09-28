using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Main_Reports : Form
    {
        public Main_Reports()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void gunaAdvenceTileButton5_Click(object sender, EventArgs e)
        {
            Clients_Report f = new Clients_Report();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            Rooms_Report f = new Rooms_Report();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            Staff_Report f = new Staff_Report();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            Reservation_Report f = new Reservation_Report();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Main_Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
