namespace Hotel
{
    partial class ReservationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReservationData = new Guna.UI.WinForms.GunaDataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Client = new System.Windows.Forms.ComboBox();
            this.Room = new System.Windows.Forms.ComboBox();
            this.DateOut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DateIn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ResId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.TabIndex = 25;
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.label2.Location = new System.Drawing.Point(373, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reservation Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(899, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReservationData
            // 
            this.ReservationData.AllowUserToAddRows = false;
            this.ReservationData.AllowUserToDeleteRows = false;
            this.ReservationData.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.ReservationData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ReservationData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReservationData.BackgroundColor = System.Drawing.Color.White;
            this.ReservationData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservationData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 13F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ReservationData.ColumnHeadersHeight = 35;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationData.DefaultCellStyle = dataGridViewCellStyle9;
            this.ReservationData.EnableHeadersVisualStyles = false;
            this.ReservationData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.ReservationData.Location = new System.Drawing.Point(404, 181);
            this.ReservationData.Name = "ReservationData";
            this.ReservationData.ReadOnly = true;
            this.ReservationData.RowHeadersVisible = false;
            this.ReservationData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservationData.Size = new System.Drawing.Size(766, 477);
            this.ReservationData.TabIndex = 54;
            this.ReservationData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.ReservationData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.ReservationData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReservationData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReservationData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReservationData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReservationData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReservationData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.ReservationData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ReservationData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ReservationData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ReservationData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReservationData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReservationData.ThemeStyle.HeaderStyle.Height = 35;
            this.ReservationData.ThemeStyle.ReadOnly = true;
            this.ReservationData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.ReservationData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReservationData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ReservationData.ThemeStyle.RowsStyle.Height = 22;
            this.ReservationData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.ReservationData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ReservationData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationData_CellDoubleClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBtn.Location = new System.Drawing.Point(819, 117);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 44);
            this.SearchBtn.TabIndex = 51;
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
            this.SearchTxt.HintText = "Enter Reservation ID";
            this.SearchTxt.isPassword = false;
            this.SearchTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.SearchTxt.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.SearchTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SearchTxt.LineThickness = 3;
            this.SearchTxt.Location = new System.Drawing.Point(616, 117);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(203, 44);
            this.SearchTxt.TabIndex = 50;
            this.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Client);
            this.groupBox1.Controls.Add(this.Room);
            this.groupBox1.Controls.Add(this.DateOut);
            this.groupBox1.Controls.Add(this.DateIn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ResId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox1.Size = new System.Drawing.Size(383, 604);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // Client
            // 
            this.Client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Client.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.ForeColor = System.Drawing.Color.Blue;
            this.Client.FormattingEnabled = true;
            this.Client.ItemHeight = 23;
            this.Client.Location = new System.Drawing.Point(150, 125);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(207, 31);
            this.Client.Sorted = true;
            this.Client.TabIndex = 2;
            // 
            // Room
            // 
            this.Room.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Room.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Room.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room.ForeColor = System.Drawing.Color.Blue;
            this.Room.FormattingEnabled = true;
            this.Room.ItemHeight = 23;
            this.Room.Location = new System.Drawing.Point(150, 191);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(207, 31);
            this.Room.Sorted = true;
            this.Room.TabIndex = 3;
            // 
            // DateOut
            // 
            this.DateOut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DateOut.BorderRadius = 0;
            this.DateOut.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.DateOut.ForeColor = System.Drawing.Color.Blue;
            this.DateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOut.FormatCustom = null;
            this.DateOut.Location = new System.Drawing.Point(150, 317);
            this.DateOut.Margin = new System.Windows.Forms.Padding(4);
            this.DateOut.Name = "DateOut";
            this.DateOut.Size = new System.Drawing.Size(207, 36);
            this.DateOut.TabIndex = 5;
            this.DateOut.Value = new System.DateTime(2020, 10, 25, 21, 1, 35, 963);
            this.DateOut.onValueChanged += new System.EventHandler(this.DateOut_onValueChanged);
            // 
            // DateIn
            // 
            this.DateIn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DateIn.BorderRadius = 0;
            this.DateIn.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.DateIn.ForeColor = System.Drawing.Color.Blue;
            this.DateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateIn.FormatCustom = null;
            this.DateIn.Location = new System.Drawing.Point(150, 257);
            this.DateIn.Margin = new System.Windows.Forms.Padding(4);
            this.DateIn.Name = "DateIn";
            this.DateIn.Size = new System.Drawing.Size(207, 36);
            this.DateIn.TabIndex = 4;
            this.DateIn.Value = new System.DateTime(2020, 10, 25, 20, 55, 24, 987);
            this.DateIn.onValueChanged += new System.EventHandler(this.DateIn_onValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(16, 441);
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
            // ResId
            // 
            this.ResId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ResId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResId.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResId.ForeColor = System.Drawing.Color.Blue;
            this.ResId.Location = new System.Drawing.Point(150, 65);
            this.ResId.Multiline = true;
            this.ResId.Name = "ResId";
            this.ResId.Size = new System.Drawing.Size(207, 33);
            this.ResId.TabIndex = 1;
            this.ResId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Res_ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(43, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Client :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(41, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Room :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(2, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "Date Out :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(25, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Date In :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.MediumPurple;
            this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print.FlatAppearance.BorderSize = 0;
            this.Print.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print.Location = new System.Drawing.Point(1064, 131);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(106, 44);
            this.Print.TabIndex = 55;
            this.Print.Text = "Print Report";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // ReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1191, 685);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReservationData);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationInfo";
            this.Load += new System.EventHandler(this.ReservationInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView ReservationData;
        private System.Windows.Forms.Button SearchBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox ResId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker DateOut;
        private Bunifu.Framework.UI.BunifuDatepicker DateIn;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox Client;
        private System.Windows.Forms.ComboBox Room;
        private System.Windows.Forms.Button Print;
    }
}