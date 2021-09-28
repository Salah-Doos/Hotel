namespace Hotel
{
    partial class _ٍStaffInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ٍStaffInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StaffPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffGender = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.StaffAge = new System.Windows.Forms.TextBox();
            this.StaffPhone = new System.Windows.Forms.TextBox();
            this.Job = new System.Windows.Forms.TextBox();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.Staffid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StaffData = new Guna.UI.WinForms.GunaDataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 26;
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
            this.label7.Size = new System.Drawing.Size(378, 55);
            this.label7.TabIndex = 3;
            this.label7.Text = "Staff Information";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StaffPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StaffGender);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.StaffAge);
            this.groupBox1.Controls.Add(this.StaffPhone);
            this.groupBox1.Controls.Add(this.Job);
            this.groupBox1.Controls.Add(this.StaffName);
            this.groupBox1.Controls.Add(this.Staffid);
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
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // StaffPassword
            // 
            this.StaffPassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StaffPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffPassword.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPassword.ForeColor = System.Drawing.Color.Blue;
            this.StaffPassword.Location = new System.Drawing.Point(162, 338);
            this.StaffPassword.Multiline = true;
            this.StaffPassword.Name = "StaffPassword";
            this.StaffPassword.PasswordChar = '*';
            this.StaffPassword.Size = new System.Drawing.Size(207, 33);
            this.StaffPassword.TabIndex = 6;
            this.StaffPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(10, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "Password :";
            // 
            // StaffGender
            // 
            this.StaffGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StaffGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StaffGender.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StaffGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StaffGender.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffGender.ForeColor = System.Drawing.Color.Blue;
            this.StaffGender.FormattingEnabled = true;
            this.StaffGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.StaffGender.Location = new System.Drawing.Point(162, 395);
            this.StaffGender.Name = "StaffGender";
            this.StaffGender.Size = new System.Drawing.Size(207, 31);
            this.StaffGender.Sorted = true;
            this.StaffGender.TabIndex = 7;
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
            // StaffAge
            // 
            this.StaffAge.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StaffAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffAge.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffAge.ForeColor = System.Drawing.Color.Blue;
            this.StaffAge.Location = new System.Drawing.Point(162, 280);
            this.StaffAge.Multiline = true;
            this.StaffAge.Name = "StaffAge";
            this.StaffAge.Size = new System.Drawing.Size(207, 33);
            this.StaffAge.TabIndex = 5;
            this.StaffAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StaffPhone
            // 
            this.StaffPhone.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StaffPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffPhone.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPhone.ForeColor = System.Drawing.Color.Blue;
            this.StaffPhone.Location = new System.Drawing.Point(162, 221);
            this.StaffPhone.Multiline = true;
            this.StaffPhone.Name = "StaffPhone";
            this.StaffPhone.Size = new System.Drawing.Size(207, 33);
            this.StaffPhone.TabIndex = 4;
            this.StaffPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Job
            // 
            this.Job.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Job.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Job.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Job.ForeColor = System.Drawing.Color.Blue;
            this.Job.Location = new System.Drawing.Point(162, 163);
            this.Job.Multiline = true;
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(207, 33);
            this.Job.TabIndex = 3;
            this.Job.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StaffName
            // 
            this.StaffName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StaffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffName.ForeColor = System.Drawing.Color.Blue;
            this.StaffName.Location = new System.Drawing.Point(162, 104);
            this.StaffName.Multiline = true;
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(207, 33);
            this.StaffName.TabIndex = 2;
            this.StaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Staffid
            // 
            this.Staffid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Staffid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Staffid.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staffid.ForeColor = System.Drawing.Color.Blue;
            this.Staffid.Location = new System.Drawing.Point(162, 48);
            this.Staffid.Multiline = true;
            this.Staffid.Name = "Staffid";
            this.Staffid.Size = new System.Drawing.Size(207, 33);
            this.Staffid.TabIndex = 1;
            this.Staffid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Staff ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(48, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name :";
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
            this.label8.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(42, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(76, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Job :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(70, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "Age :";
            // 
            // StaffData
            // 
            this.StaffData.AllowUserToAddRows = false;
            this.StaffData.AllowUserToDeleteRows = false;
            this.StaffData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.StaffData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffData.BackgroundColor = System.Drawing.Color.White;
            this.StaffData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffData.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffData.DefaultCellStyle = dataGridViewCellStyle3;
            this.StaffData.EnableHeadersVisualStyles = false;
            this.StaffData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.StaffData.Location = new System.Drawing.Point(407, 172);
            this.StaffData.Name = "StaffData";
            this.StaffData.ReadOnly = true;
            this.StaffData.RowHeadersVisible = false;
            this.StaffData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffData.Size = new System.Drawing.Size(772, 461);
            this.StaffData.TabIndex = 53;
            this.StaffData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.StaffData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.StaffData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StaffData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StaffData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StaffData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StaffData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StaffData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.StaffData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.StaffData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.StaffData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffData.ThemeStyle.HeaderStyle.Height = 35;
            this.StaffData.ThemeStyle.ReadOnly = true;
            this.StaffData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.StaffData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.StaffData.ThemeStyle.RowsStyle.Height = 22;
            this.StaffData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.StaffData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StaffData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffData_CellDoubleClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBtn.Location = new System.Drawing.Point(798, 114);
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
            this.SearchTxt.HintText = "Enter Staff Name";
            this.SearchTxt.isPassword = false;
            this.SearchTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchTxt.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.SearchTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchTxt.LineThickness = 3;
            this.SearchTxt.Location = new System.Drawing.Point(595, 114);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(203, 44);
            this.SearchTxt.TabIndex = 11;
            this.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(878, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.MediumPurple;
            this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print.FlatAppearance.BorderSize = 0;
            this.Print.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print.Location = new System.Drawing.Point(1073, 122);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(106, 44);
            this.Print.TabIndex = 56;
            this.Print.Text = "Print Report";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // _ٍStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1191, 685);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StaffData);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_ٍStaffInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffInfo";
            this.Load += new System.EventHandler(this._ٍStaffInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox StaffGender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox StaffAge;
        private System.Windows.Forms.TextBox StaffPhone;
        private System.Windows.Forms.TextBox Job;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.TextBox Staffid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView StaffData;
        private System.Windows.Forms.Button SearchBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox StaffPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Print;
    }
}