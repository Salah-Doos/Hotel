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
    public partial class ClientInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=USER1;Initial Catalog=Hotel_DB;Integrated Security=True");
        public ClientInfo()
        {
            InitializeComponent();
            EditBtn.Enabled = false;
            DeleteBtn.Enabled = false;
        }
        public void FillData()
        {
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Client_tbl", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            ClientData.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void ClearText()
        {
            Clientid.Text = "";
            ClientName.Text = "";
            ClientPhone.Text = "";
            ClientAddress.Text = "";
            ClientAge.Text = "";
            CardNum.Text = "";
            ClientGender.Text = "";
            ClientCountry.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            FillData();
            max();
        }
        string a = "Clientid";
        public void max()
        {
            string sql = " select  max(" + a + ")+1  from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(sql,Con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                Clientid.Text = Convert.ToString(dt.Rows[0][0].ToString());
            }
            catch
            {
                Clientid.Text = "1";
            }
            Clientid.Enabled = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Clientid.Text == "" || ClientName.Text == "" || ClientPhone.Text == "" || ClientAddress.Text == "" || ClientAge.Text == "" || ClientGender.Text == "" || ClientCountry.Text == "")
            {
                MessageBox.Show("Please Fill All Fields to ADD !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Client_tbl values(" + Clientid.Text + ",'" + ClientName.Text + "','" + ClientPhone.Text + "','" + ClientAddress.Text + "','" + ClientAge.Text + "','" + CardNum.Text + "','" + ClientGender.SelectedItem.ToString() + "','" + ClientCountry.SelectedItem.ToString() + "' )", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Client Added Successfully");
                Con.Close();
                FillData();
            }
            max();

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Clientid.Text == "" || ClientName.Text == "" || ClientPhone.Text == "" || ClientAddress.Text == "" || ClientAge.Text == "" || ClientGender.Text == "" || ClientCountry.Text == "")
            {
                MessageBox.Show("You can't Ubdate While They are an Empty Fields ,, Please Refill them  !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Client_tbl set ClientName='" + ClientName.Text + "',ClientPhone='" + ClientPhone.Text + "',ClientAddress='" + ClientAddress.Text + "',ClientAge='" + ClientAge.Text + "',CardNum='" + CardNum.Text + "',ClientGender='" + ClientGender.SelectedItem.ToString() + "',ClientCountry='" + ClientCountry.Text + "' where Clientid=" + Clientid.Text + " ", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Client Edited Successfully");
                Clientid.Enabled = true;
                Con.Close();
                FillData();
            }
            max();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Clientid.Text=="")
            {
                MessageBox.Show("Select Client to Delete !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from Client_tbl where Clientid = " + Clientid.Text + " ", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Client Deleted Successfully");
                Clientid.Enabled = true;
                Con.Close();
                FillData();
            }
            max();

        }

        private void ClientData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clientid.Text = ClientData.SelectedRows[0].Cells[0].Value.ToString();
            ClientName.Text = ClientData.SelectedRows[0].Cells[1].Value.ToString();
            ClientPhone.Text = ClientData.SelectedRows[0].Cells[2].Value.ToString();
            ClientAddress.Text = ClientData.SelectedRows[0].Cells[3].Value.ToString();
            ClientAge.Text = ClientData.SelectedRows[0].Cells[4].Value.ToString();
            CardNum.Text = ClientData.SelectedRows[0].Cells[5].Value.ToString();
            ClientGender.Text = ClientData.SelectedRows[0].Cells[6].Value.ToString();
            ClientCountry.Text = ClientData.SelectedRows[0].Cells[7].Value.ToString();
            Clientid.Enabled = false;
            EditBtn.Enabled = true;
            DeleteBtn.Enabled = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Client_tbl where ClientName Like '%" + SearchTxt.Text + "%'", Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                ClientData.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                MessageBox.Show("Please Write The Client Name In The Text Field");
                SearchTxt.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void Print_Click(object sender, EventArgs e)
        {
                Reports.Special_Client myReport = new Reports.Special_Client();
                myReport.SetParameterValue("@Name", this.ClientData.CurrentRow.Cells[1].Value.ToString());
                Reports.FRM_RPT_SpecialClient f = new Reports.FRM_RPT_SpecialClient();
                f.crystalReportViewer1.ReportSource = myReport;
                f.ShowDialog();
        }
    }
}
