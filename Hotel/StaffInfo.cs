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
    public partial class _ٍStaffInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=USER1;Initial Catalog=Hotel_DB;Integrated Security=True");

        public _ٍStaffInfo()
        {
            InitializeComponent();
            EditBtn.Enabled = false;
            DeleteBtn.Enabled = false;
        }
        public void FillData()
        {
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Staffid,StaffName,Job,StaffPhone,StaffAge,StaffGender from Staff_tbl", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            StaffData.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void ClearText()
        {
            Staffid.Text = "";
            StaffName.Text = "";
            Job.Text = "";
            StaffPhone.Text = "";
            StaffAge.Text = "";
            StaffGender.Text = "";
            StaffPassword.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void _ٍStaffInfo_Load(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            FillData();
            max();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (Staffid.Text == "" || StaffName.Text == "" || Job.Text == "" || StaffPhone.Text == "" || StaffAge.Text == "" || StaffGender.Text == "")
            {
                MessageBox.Show("Please Fill All Fields to ADD !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Staff_tbl values(" + Staffid.Text + ",'" + StaffName.Text + "','" + Job.Text + "','" + StaffPhone.Text + "','" + StaffAge.Text + "','" + StaffGender.SelectedItem.ToString() + "','"+ StaffPassword.Text + "'  )", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Client Added Successfully");
                Con.Close();
                FillData();
            }
            max();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Staff_tbl where StaffName='" + SearchTxt.Text + "'", Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                StaffData.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                MessageBox.Show("Please Write The Staff Name In The Text Field");
                SearchTxt.Focus();
            }
        }

        private void StaffData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Staffid.Text = StaffData.SelectedRows[0].Cells[0].Value.ToString();
            StaffName.Text = StaffData.SelectedRows[0].Cells[1].Value.ToString();
            Job.Text = StaffData.SelectedRows[0].Cells[2].Value.ToString();
            StaffPhone.Text = StaffData.SelectedRows[0].Cells[3].Value.ToString();
            StaffAge.Text = StaffData.SelectedRows[0].Cells[4].Value.ToString();
            StaffGender.Text = StaffData.SelectedRows[0].Cells[5].Value.ToString();
            StaffPassword.Text = StaffData.SelectedRows[0].Cells[6].Value.ToString();
            Staffid.Enabled = false;
            EditBtn.Enabled = true;
            DeleteBtn.Enabled = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Staffid.Text=="")
            {
                MessageBox.Show("Select Staff to Delete !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from Staff_tbl where Staffid = " + Staffid.Text + " ", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Staff Deleted Successfully");
                Staffid.Enabled = true;
                Con.Close();
                FillData();
            }
            max();
        }
        string a = "Staffid";
        public void max()
        {
            string sql = " select  max(" + a + ")+1  from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                Staffid.Text = Convert.ToString(dt.Rows[0][0].ToString());
            }
            catch
            {
                Staffid.Text = "1";
            }
            Staffid.Enabled = false;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Staffid.Text == "" || StaffName.Text == "" || Job.Text == "" || StaffPhone.Text == "" || StaffAge.Text == "" || StaffGender.Text == "")
            {
                MessageBox.Show("You can't Ubdate While They are an Empty Fields ,, Please Refill them  !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Staff_tbl set StaffName='" + StaffName.Text + "',Job='" + Job.Text + "',StaffPhone='" + StaffPhone.Text + "',StaffAge='" + StaffAge.Text + "', StaffGender='" + StaffGender.SelectedItem.ToString() + "',StaffPassword='" + StaffPassword.Text + "' where Staffid = " + Staffid.Text +" ", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Staff Edited Successfully");
                Staffid.Enabled = true;
                Con.Close();
                FillData();
            }
            max();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Reports.Special_Staff myReport = new Reports.Special_Staff();
            myReport.SetParameterValue("@Name", this.StaffData.CurrentRow.Cells[1].Value.ToString());
            Reports.FRM_RPT_SpecialStaff f = new Reports.FRM_RPT_SpecialStaff();
            f.crystalReportViewer1.ReportSource = myReport;
            f.ShowDialog();
        }
    }
}
