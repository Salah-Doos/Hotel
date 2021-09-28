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
    public partial class ReservationInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=USER1;Initial Catalog=Hotel_DB;Integrated Security=True");
        DateTime today;
        public ReservationInfo()
        {
            InitializeComponent();
        }
        public void FillData()
        {
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Reservation_tbl", Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            ReservationData.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void ClearText()
        {
            ResId.Text = "";
            Client.Text = "";
            Room.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }
        public void fillClientCombo()
        {
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Client_tbl", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Client.DataSource = dt;
            Client.DisplayMember = "ClientName";
            Client.ValueMember = "ClientName";
            Con.Close();
        }
        public void fillRoomCombo()
        {
            Con.Open();
            string R_State = "Free";
            SqlDataAdapter da = new SqlDataAdapter("select * from Room_tbl where RoomFree ='"+R_State+"'", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Room.DataSource = dt;
            Room.DisplayMember = "Roomid";
            Room.ValueMember = "Roomid";
            Con.Close();
        }
        private void ReservationInfo_Load(object sender, EventArgs e)
        {
            today = DateIn.Value;
            DateLbl.Text = DateTime.Today.Day.ToString()+"-"+ DateTime.Today.Month.ToString()+ "-" + DateTime.Today.Year.ToString();
            fillClientCombo();
            fillRoomCombo();
            FillData();
            max();
        }
        string a = "ResId";
        public void max()
        {
            string sql = " select  max(" + a + ")+1  from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                ResId.Text = Convert.ToString(dt.Rows[0][0].ToString());
            }
            catch
            {
                ResId.Text = "1";
            }
            ResId.Enabled = false;
        }
        private void DateIn_onValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(DateIn.Value, today);
            if (res < 0)
            {
                MessageBox.Show("Wrong Date For Reservation");
            }
        }

        private void DateOut_onValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(DateOut.Value , DateIn.Value);
            if (res < 0)
            {
                MessageBox.Show("Wrong DateOut !! Check Again");
            }
        }
        public void UpdateRoomState()
        {
            Con.Open();
            string newState = "Busy";
            SqlCommand cmd = new SqlCommand("UPDATE Room_tbl set RoomFree='" + newState + "' where Roomid=" +Convert.ToInt32(Room.SelectedValue.ToString())+ ";", Con);
            cmd.ExecuteNonQuery();
            ClearText();
            ResId.Enabled = true;
            Con.Close();
            fillRoomCombo();
        }
        public void UpdateRoomStateOnDeleteAndUpdate()
        {
            Con.Open();
            string newState = "Free";
            int RomId = Convert.ToInt32(Room.Text = ReservationData.SelectedRows[0].Cells[2].Value.ToString());
            SqlCommand cmd = new SqlCommand("UPDATE Room_tbl set RoomFree='" + newState + "' where Roomid=" + RomId + ";", Con);
            cmd.ExecuteNonQuery();
            ClearText();
            ResId.Enabled = true;
            Con.Close();
            fillRoomCombo();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            if (ResId.Text == "" || Client.Text == "" || Room.Text == "")
            {
                MessageBox.Show("Please Fill All Fields to ADD !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values(" + ResId.Text + ",'" + Client.SelectedValue.ToString() + "','" + Room.SelectedValue.ToString() + "','" + DateIn.Value.ToString() + "','" + DateOut.Value.ToString() + "' )", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Reservation Added Successfully");
                Con.Close();
                UpdateRoomState();
                FillData();
            }
            max();
        }

        private void ReservationData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            ResId.Text = ReservationData.SelectedRows[0].Cells[0].Value.ToString();
            Client.Text = ReservationData.SelectedRows[0].Cells[1].Value.ToString();
            Room.Text = ReservationData.SelectedRows[0].Cells[2].Value.ToString();
            DateIn.Text = ReservationData.SelectedRows[0].Cells[3].Value.ToString();
            DateOut.Text = ReservationData.SelectedRows[0].Cells[4].Value.ToString();
            ResId.Enabled = false;
            EditBtn.Enabled = true;
            DeleteBtn.Enabled = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            if (ResId.Text == "")
            {
                MessageBox.Show("Select Reservation to Delete !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from Reservation_tbl where ResId = " + ResId.Text + " ", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Reservation Deleted Successfully");
                ResId.Enabled = true;
                Con.Close();
                UpdateRoomStateOnDeleteAndUpdate();
                FillData();
            }
            max();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
           
            if (ResId.Text == "" || Client.Text == "" || Room.Text == "")
            {
                MessageBox.Show("You can't Ubdate While They are an Empty Fields ,, Please Refill them  !!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Reservation_tbl set Client='" + Client.SelectedValue.ToString() + "',Room='" + Room.SelectedValue.ToString() + "',DateIn='" + DateIn.Value.ToString() + "',DateOut='" + DateOut.Value.ToString() + "' where ResId=" + ResId.Text + " ;", Con);
                cmd.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Reservation Edited Successfully");
                ResId.Enabled = true;
                Con.Close();
                UpdateRoomStateOnDeleteAndUpdate();
                FillData();
            }
            max();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Reservation_tbl where ResId='" + SearchTxt.Text + "'", Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                da.Fill(ds);
                ReservationData.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                MessageBox.Show("Please Write Reservation ID In The Text Field");
                SearchTxt.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Reports.Special_Reservation myReport = new Reports.Special_Reservation();
            myReport.SetParameterValue("@Name", this.ReservationData.CurrentRow.Cells[1].Value.ToString());
            Reports.FRM_RPT_SpecialReservation f = new Reports.FRM_RPT_SpecialReservation();
            f.crystalReportViewer1.ReportSource = myReport;
            f.ShowDialog();
        }
    }

}
