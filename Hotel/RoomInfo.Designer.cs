namespace Hotel
{
    partial class RoomInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RoomTybe = new System.Windows.Forms.ComboBox();
            this.RoomFloor = new System.Windows.Forms.ComboBox();
            this.BedNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomFree = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RoomPrice = new System.Windows.Forms.TextBox();
            this.RoomPhone = new System.Windows.Forms.TextBox();
            this.Roomid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoomData = new Guna.UI.WinForms.GunaDataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomData)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.DateLbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 81);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Hotel.Properties.Resources.cancel_50px;
            this.pictureBox2.Location = new System.Drawing.Point(1139, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.DateLbl.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.DateLbl.Location = new System.Drawing.Point(963, 49);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(57, 27);
            this.DateLbl.TabIndex = 54;
            this.DateLbl.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label7.Location = new System.Drawing.Point(416, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 55);
            this.label7.TabIndex = 3;
            this.label7.Text = "Room Information";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RoomTybe);
            this.groupBox1.Controls.Add(this.RoomFloor);
            this.groupBox1.Controls.Add(this.BedNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RoomFree);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.RoomPrice);
            this.groupBox1.Controls.Add(this.RoomPhone);
            this.groupBox1.Controls.Add(this.Roomid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox1.Size = new System.Drawing.Size(383, 604);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // RoomTybe
            // 
            this.RoomTybe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RoomTybe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RoomTybe.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RoomTybe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoomTybe.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTybe.ForeColor = System.Drawing.Color.Blue;
            this.RoomTybe.FormattingEnabled = true;
            this.RoomTybe.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big",
            "VIP"});
            this.RoomTybe.Location = new System.Drawing.Point(162, 342);
            this.RoomTybe.Name = "RoomTybe";
            this.RoomTybe.Size = new System.Drawing.Size(207, 31);
            this.RoomTybe.TabIndex = 6;
            // 
            // RoomFloor
            // 
            this.RoomFloor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RoomFloor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RoomFloor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RoomFloor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoomFloor.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomFloor.ForeColor = System.Drawing.Color.Blue;
            this.RoomFloor.FormattingEnabled = true;
            this.RoomFloor.Items.AddRange(new object[] {
            "First Floor",
            "Second Floor",
            "Third Floor",
            "Fourth Floor",
            "Fifth Floor"});
            this.RoomFloor.Location = new System.Drawing.Point(162, 286);
            this.RoomFloor.Name = "RoomFloor";
            this.RoomFloor.Size = new System.Drawing.Size(207, 31);
            this.RoomFloor.TabIndex = 5;
            // 
            // BedNum
            // 
            this.BedNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BedNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BedNum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BedNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BedNum.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedNum.ForeColor = System.Drawing.Color.Blue;
            this.BedNum.FormattingEnabled = true;
            this.BedNum.Items.AddRange(new object[] {
            "One Bed",
            "Tow Bed",
            "Three Beds"});
            this.BedNum.Location = new System.Drawing.Point(162, 227);
            this.BedNum.Name = "BedNum";
            this.BedNum.Size = new System.Drawing.Size(207, 31);
            this.BedNum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(31, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "R_Type :";
            // 
            // RoomFree
            // 
            this.RoomFree.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RoomFree.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RoomFree.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RoomFree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoomFree.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomFree.ForeColor = System.Drawing.Color.Blue;
            this.RoomFree.FormattingEnabled = true;
            this.RoomFree.Items.AddRange(new object[] {
            "Busy",
            "Free"});
            this.RoomFree.Location = new System.Drawing.Point(162, 395);
            this.RoomFree.Name = "RoomFree";
            this.RoomFree.Size = new System.Drawing.Size(207, 31);
            this.RoomFree.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(23, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 100);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Purple;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(233, 36);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(99, 44);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Purple;
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.EditBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditBtn.Location = new System.Drawing.Point(127, 36);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(90, 44);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Purple;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.AddBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(18, 36);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(89, 44);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RoomPrice
            // 
            this.RoomPrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RoomPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomPrice.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomPrice.ForeColor = System.Drawing.Color.Blue;
            this.RoomPrice.Location = new System.Drawing.Point(162, 163);
            this.RoomPrice.Multiline = true;
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.Size = new System.Drawing.Size(207, 33);
            this.RoomPrice.TabIndex = 3;
            this.RoomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomPhone
            // 
            this.RoomPhone.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RoomPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomPhone.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomPhone.ForeColor = System.Drawing.Color.Blue;
            this.RoomPhone.Location = new System.Drawing.Point(162, 104);
            this.RoomPhone.Multiline = true;
            this.RoomPhone.Name = "RoomPhone";
            this.RoomPhone.Size = new System.Drawing.Size(207, 33);
            this.RoomPhone.TabIndex = 2;
            this.RoomPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Roomid
            // 
            this.Roomid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Roomid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Roomid.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomid.ForeColor = System.Drawing.Color.Blue;
            this.Roomid.Location = new System.Drawing.Point(164, 50);
            this.Roomid.Multiline = true;
            this.Roomid.Name = "Roomid";
            this.Roomid.Size = new System.Drawing.Size(207, 33);
            this.Roomid.TabIndex = 1;
            this.Roomid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Room ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "R_Phone :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(31, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "R_State :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(35, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "R_Beds :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(31, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "R_Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(30, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "R_Floor :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(889, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RoomData
            // 
            this.RoomData.AllowUserToAddRows = false;
            this.RoomData.AllowUserToDeleteRows = false;
            this.RoomData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.RoomData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RoomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomData.BackgroundColor = System.Drawing.Color.White;
            this.RoomData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.RoomData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RoomData.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomData.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoomData.EnableHeadersVisualStyles = false;
            this.RoomData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.RoomData.Location = new System.Drawing.Point(405, 178);
            this.RoomData.Name = "RoomData";
            this.RoomData.ReadOnly = true;
            this.RoomData.RowHeadersVisible = false;
            this.RoomData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomData.Size = new System.Drawing.Size(766, 477);
            this.RoomData.TabIndex = 53;
            this.RoomData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.RoomData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.RoomData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.RoomData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.RoomData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.RoomData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.RoomData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomData.ThemeStyle.HeaderStyle.Height = 35;
            this.RoomData.ThemeStyle.ReadOnly = true;
            this.RoomData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.RoomData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoomData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.RoomData.ThemeStyle.RowsStyle.Height = 22;
            this.RoomData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.RoomData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.RoomData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomData_CellDoubleClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBtn.Location = new System.Drawing.Point(809, 114);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 44);
            this.SearchBtn.TabIndex = 12;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchTxt.ForeColor = System.Drawing.Color.Blue;
            this.SearchTxt.HintForeColor = System.Drawing.Color.Empty;
            this.SearchTxt.HintText = "Enter Room ID";
            this.SearchTxt.isPassword = false;
            this.SearchTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchTxt.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.SearchTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchTxt.LineThickness = 3;
            this.SearchTxt.Location = new System.Drawing.Point(606, 114);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(203, 44);
            this.SearchTxt.TabIndex = 11;
            this.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1191, 685);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RoomData);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInfo";
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RoomFree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox RoomPrice;
        private System.Windows.Forms.TextBox RoomPhone;
        private System.Windows.Forms.TextBox Roomid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView RoomData;
        private System.Windows.Forms.Button SearchBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTxt;
        private System.Windows.Forms.ComboBox RoomTybe;
        private System.Windows.Forms.ComboBox RoomFloor;
        private System.Windows.Forms.ComboBox BedNum;
    }
}