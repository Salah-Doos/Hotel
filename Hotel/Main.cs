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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void gunaAdvenceTileButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            ClientInfo f = new ClientInfo();
            f.Show();
            this.Hide();
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            _ٍStaffInfo f = new _ٍStaffInfo();
            f.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();

        }

        private void gunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            RoomInfo f = new RoomInfo();
            f.Show();
            this.Hide();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            ReservationInfo f = new ReservationInfo();
            f.Show();
            this.Hide();
        }

        private void gunaAdvenceTileButton6_Click(object sender, EventArgs e)
        {
            Main_Reports f = new Main_Reports();
            f.Show();
            this.Hide();
        }
    }
}
