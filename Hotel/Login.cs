using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=USER1;Initial Catalog=Hotel_DB;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (StaffName.Text != "" && StaffPassword.Text !="")
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select COUNT(*) from Staff_tbl where StaffName = '" + StaffName.Text + "' and StaffPassword ='" + StaffPassword.Text + "' and Job='Reception' ", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows[0][0].ToString() == "1")
                {
                    Main f = new Main();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName Or Password !!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields !!");
            }
            Con.Close();
        }

        private void StaffPassword_Enter(object sender, EventArgs e)
        {
            this.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

    }
}
