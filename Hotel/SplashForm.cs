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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int StartPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 2;
            SplashProgress.Value = StartPoint;
            if (SplashProgress.Value==100)
            {
                SplashProgress.Value = 0;
                timer1.Stop();
                Login f = new Login();
                f.Show();
                this.Hide();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
