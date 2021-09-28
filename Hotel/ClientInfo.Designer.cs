namespace Hotel
{
    partial class ClientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientGender = new System.Windows.Forms.ComboBox();
            this.ClientCountry = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CardNum = new System.Windows.Forms.TextBox();
            this.ClientAge = new System.Windows.Forms.TextBox();
            this.ClientAddress = new System.Windows.Forms.TextBox();
            this.ClientPhone = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.Clientid = new System.Windows.Forms.TextBox();
            this.SearchTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClientData = new Guna.UI.WinForms.GunaDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.DateLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 81);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Hotel.Properties.Resources.cancel_50px;
            this.pictureBox2.Location = new System.Drawing.Point(1139, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.DateLbl.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.DateLbl.Location = new System.Drawing.Point(979, 54);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(57, 27);
            this.DateLbl.TabIndex = 45;
            this.DateLbl.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(415, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Information";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Client ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(62, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(56, 165);
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
            this.label5.Location = new System.Drawing.Point(36, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(84, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "Age :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(10, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "Num Card :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(44, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "Gender :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FloralWhite;
            this.label9.Location = new System.Drawing.Point(28, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 31);
            this.label9.TabIndex = 42;
            this.label9.Text = "Country  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientGender);
            this.groupBox1.Controls.Add(this.ClientCountry);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CardNum);
            this.groupBox1.Controls.Add(this.ClientAge);
            this.groupBox1.Controls.Add(this.ClientAddress);
            this.groupBox1.Controls.Add(this.ClientPhone);
            this.groupBox1.Controls.Add(this.ClientName);
            this.groupBox1.Controls.Add(this.Clientid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox1.Size = new System.Drawing.Size(383, 604);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // ClientGender
            // 
            this.ClientGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClientGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClientGender.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClientGender.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientGender.ForeColor = System.Drawing.Color.Blue;
            this.ClientGender.FormattingEnabled = true;
            this.ClientGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.ClientGender.Location = new System.Drawing.Point(162, 375);
            this.ClientGender.Name = "ClientGender";
            this.ClientGender.Size = new System.Drawing.Size(207, 31);
            this.ClientGender.Sorted = true;
            this.ClientGender.TabIndex = 7;
            // 
            // ClientCountry
            // 
            this.ClientCountry.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClientCountry.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientCountry.ForeColor = System.Drawing.Color.Blue;
            this.ClientCountry.FormattingEnabled = true;
            this.ClientCountry.Items.AddRange(new object[] {
            "AlBahreen",
            "Egypt",
            "KSA",
            "Lybia",
            "Palstine",
            "Qatar",
            "Syria",
            "Yemen"});
            this.ClientCountry.Location = new System.Drawing.Point(162, 422);
            this.ClientCountry.Name = "ClientCountry";
            this.ClientCountry.Size = new System.Drawing.Size(207, 31);
            this.ClientCountry.Sorted = true;
            this.ClientCountry.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(16, 477);
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
            this.DeleteBtn.TabIndex = 11;
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
            this.EditBtn.TabIndex = 10;
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
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CardNum
            // 
            this.CardNum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CardNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardNum.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNum.ForeColor = System.Drawing.Color.Blue;
            this.CardNum.Location = new System.Drawing.Point(162, 321);
            this.CardNum.Multiline = true;
            this.CardNum.Name = "CardNum";
            this.CardNum.Size = new System.Drawing.Size(207, 33);
            this.CardNum.TabIndex = 6;
            this.CardNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientAge
            // 
            this.ClientAge.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientAge.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientAge.ForeColor = System.Drawing.Color.Blue;
            this.ClientAge.Location = new System.Drawing.Point(162, 269);
            this.ClientAge.Multiline = true;
            this.ClientAge.Name = "ClientAge";
            this.ClientAge.Size = new System.Drawing.Size(207, 33);
            this.ClientAge.TabIndex = 5;
            this.ClientAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientAddress
            // 
            this.ClientAddress.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientAddress.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientAddress.ForeColor = System.Drawing.Color.Blue;
            this.ClientAddress.Location = new System.Drawing.Point(162, 217);
            this.ClientAddress.Multiline = true;
            this.ClientAddress.Name = "ClientAddress";
            this.ClientAddress.Size = new System.Drawing.Size(207, 33);
            this.ClientAddress.TabIndex = 4;
            this.ClientAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientPhone
            // 
            this.ClientPhone.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientPhone.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientPhone.ForeColor = System.Drawing.Color.Blue;
            this.ClientPhone.Location = new System.Drawing.Point(162, 165);
            this.ClientPhone.Multiline = true;
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(207, 33);
            this.ClientPhone.TabIndex = 3;
            this.ClientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClientName
            // 
            this.ClientName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.ForeColor = System.Drawing.Color.Blue;
            this.ClientName.Location = new System.Drawing.Point(162, 113);
            this.ClientName.Multiline = true;
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(207, 33);
            this.ClientName.TabIndex = 2;
            this.ClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Clientid
            // 
            this.Clientid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Clientid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Clientid.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientid.ForeColor = System.Drawing.Color.Blue;
            this.Clientid.Location = new System.Drawing.Point(162, 61);
            this.Clientid.Multiline = true;
            this.Clientid.Name = "Clientid";
            this.Clientid.Size = new System.Drawing.Size(207, 33);
            this.Clientid.TabIndex = 1;
            this.Clientid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchTxt.ForeColor = System.Drawing.Color.Blue;
            this.SearchTxt.HintForeColor = System.Drawing.Color.Empty;
            this.SearchTxt.HintText = "Enter Client Name";
            this.SearchTxt.isPassword = false;
            this.SearchTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchTxt.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.SearchTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchTxt.LineThickness = 3;
            this.SearchTxt.Location = new System.Drawing.Point(606, 117);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(203, 44);
            this.SearchTxt.TabIndex = 12;
            this.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBtn.Location = new System.Drawing.Point(809, 117);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 44);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientData
            // 
            this.ClientData.AllowUserToAddRows = false;
            this.ClientData.AllowUserToDeleteRows = false;
            this.ClientData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.ClientData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientData.BackgroundColor = System.Drawing.Color.White;
            this.ClientData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.ClientData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientData.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientData.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientData.EnableHeadersVisualStyles = false;
            this.ClientData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.ClientData.Location = new System.Drawing.Point(405, 181);
            this.ClientData.Name = "ClientData";
            this.ClientData.ReadOnly = true;
            this.ClientData.RowHeadersWidth = 100;
            this.ClientData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientData.Size = new System.Drawing.Size(766, 477);
            this.ClientData.TabIndex = 49;
            this.ClientData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.ClientData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.ClientData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClientData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClientData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClientData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClientData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClientData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.ClientData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ClientData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ClientData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClientData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClientData.ThemeStyle.HeaderStyle.Height = 35;
            this.ClientData.ThemeStyle.ReadOnly = true;
            this.ClientData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.ClientData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClientData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ClientData.ThemeStyle.RowsStyle.Height = 22;
            this.ClientData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.ClientData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ClientData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientData_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(889, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.MediumPurple;
            this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print.FlatAppearance.BorderSize = 0;
            this.Print.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print.Location = new System.Drawing.Point(1065, 129);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(106, 44);
            this.Print.TabIndex = 50;
            this.Print.Text = "Print Report";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1191, 685);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClientData);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Clientid;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Button SearchBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTxt;
        private System.Windows.Forms.TextBox CardNum;
        private System.Windows.Forms.TextBox ClientAge;
        private System.Windows.Forms.TextBox ClientAddress;
        private System.Windows.Forms.TextBox ClientPhone;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox ClientCountry;
        private System.Windows.Forms.ComboBox ClientGender;
        private Guna.UI.WinForms.GunaDataGridView ClientData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Print;
    }
}