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
    public partial class RoomInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=USER1;Initial Catalog=Hotel_DB;Integrated Security=True");
        public RoomInfo()
        {
            InitializeComponent();
            EditBtn.Enabled = false;
            DeleteBtn.Enabled = false;
        }
        public void FillData()
        {
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Room_tbl", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            RoomData.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void ClearText()
        {
            Roomid.Text = "";
            RoomPhone.Text = "";
            RoomPrice.Text = "";
            BedNum.Text = "";
            RoomFloor.Text = "";
            RoomTybe.Text = "";
            RoomFree.Text = "";
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            FillData();
            max();
        }
        string a = "Roomid";
        public void max()
        {
            string sql = " select  max(" + a + ")+1  from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                Roomid.Text = Convert.ToString(dt.Rows[0][0].ToString());
            }
            catch
            {
                Roomid.Text = "1";
            }
            Roomid.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Roomid.Text == "")
            {
                MessageBox.Show("Select Client to Delete !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from Room_tbl where Roomid = " + Roomid.Text + " ", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Room Deleted Successfully");
                Roomid.Enabled = true;
                Con.Close();
                FillData();
            }
            max();

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Room_tbl where Roomid='" + SearchTxt.Text + "'", Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                RoomData.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                MessageBox.Show("Please Write Room ID In The Text Field");
                SearchTxt.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Roomid.Text == "" || RoomPhone.Text == "" || RoomPrice.Text == "" || BedNum.Text == "" || RoomFloor.Text == "" || RoomTybe.Text == "" || RoomFree.Text == "")
            {
                MessageBox.Show("You can't Ubdate While They are an Empty Fields ,, Please Refill them  !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Room_tbl set RoomPhone='" + RoomPhone.Text + "',RoomPrice='" + RoomPrice.Text + "',BedNum='" + BedNum.SelectedValue.ToString() + "',RoomFloor='" + RoomFloor.SelectedValue.ToString() + "', RoomTybe ='" + RoomTybe.Text + "' , RoomFree='" + RoomFree.SelectedValue.ToString() + "' where Roomid=" + Roomid.Text + " ;", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Room Edited Successfully");
                Roomid.Enabled = true;
                Con.Close();
                FillData();
            }
            max();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Roomid.Text == "" || RoomPhone.Text == "" || RoomPrice.Text == "" || BedNum.Text == "" || RoomFloor.Text == "" || RoomTybe.Text == "" || RoomFree.Text == "")
            {
                MessageBox.Show("Please Fill All Fields to ADD !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Room_tbl values(" + Roomid.Text + ",'" + RoomPhone.Text + "','" + RoomPrice.Text + "','" + BedNum.SelectedItem.ToString() + "','" + RoomFloor.SelectedItem.ToString() + "','" + RoomTybe.SelectedItem.ToString() + "','" + RoomFree.SelectedItem.ToString() + "' )", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Room Added Successfully");
                Con.Close();
                FillData();
            }
            max();
          }

        private void RoomData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Roomid.Text = RoomData.SelectedRows[0].Cells[0].Value.ToString();
            RoomPhone.Text = RoomData.SelectedRows[0].Cells[1].Value.ToString();
            RoomPrice.Text = RoomData.SelectedRows[0].Cells[2].Value.ToString();
            BedNum.Text = RoomData.SelectedRows[0].Cells[3].Value.ToString();
            RoomFloor.Text = RoomData.SelectedRows[0].Cells[4].Value.ToString();
            RoomTybe.Text = RoomData.SelectedRows[0].Cells[5].Value.ToString();
            RoomFree.Text = RoomData.SelectedRows[0].Cells[6].Value.ToString();
            Roomid.Enabled = false;
            EditBtn.Enabled = true;
            DeleteBtn.Enabled = true;
        }
    }
}
