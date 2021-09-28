namespace Hotel
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.gunaAdvenceTileButton6 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton5 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton3 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton4 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton2 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.DateLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 81);
            this.panel1.TabIndex = 25;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.DateLbl.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.DateLbl.Location = new System.Drawing.Point(993, 54);
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
            this.label2.Location = new System.Drawing.Point(476, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main Form";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(133, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 55);
            this.label1.TabIndex = 31;
            this.label1.Text = "Clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(964, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 55);
            this.label3.TabIndex = 32;
            this.label3.Text = "Exit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(509, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 55);
            this.label4.TabIndex = 33;
            this.label4.Text = "Reservation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(133, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 55);
            this.label5.TabIndex = 34;
            this.label5.Text = "Rooms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(558, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 55);
            this.label6.TabIndex = 35;
            this.label6.Text = "Staff";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(921, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 55);
            this.label7.TabIndex = 37;
            this.label7.Text = "Reports";
            // 
            // gunaAdvenceTileButton6
            // 
            this.gunaAdvenceTileButton6.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton6.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton6.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton6.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton6.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton6.CheckedImage")));
            this.gunaAdvenceTileButton6.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton6.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceTileButton6.Image = global::Hotel.Properties.Resources.Dossier_34px;
            this.gunaAdvenceTileButton6.ImageSize = new System.Drawing.Size(100, 100);
            this.gunaAdvenceTileButton6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton6.Location = new System.Drawing.Point(922, 186);
            this.gunaAdvenceTileButton6.Name = "gunaAdvenceTileButton6";
            this.gunaAdvenceTileButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton6.OnHoverImage = null;
            this.gunaAdvenceTileButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton6.Radius = 100;
            this.gunaAdvenceTileButton6.Size = new System.Drawing.Size(170, 160);
            this.gunaAdvenceTileButton6.TabIndex = 36;
            this.gunaAdvenceTileButton6.Click += new System.EventHandler(this.gunaAdvenceTileButton6_Click);
            // 
            // gunaAdvenceTileButton5
            // 
            this.gunaAdvenceTileButton5.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton5.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton5.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton5.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton5.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton5.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton5.CheckedImage")));
            this.gunaAdvenceTileButton5.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton5.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceTileButton5.Image = global::Hotel.Properties.Resources.cancel_50px;
            this.gunaAdvenceTileButton5.ImageSize = new System.Drawing.Size(80, 80);
            this.gunaAdvenceTileButton5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton5.Location = new System.Drawing.Point(948, 454);
            this.gunaAdvenceTileButton5.Name = "gunaAdvenceTileButton5";
            this.gunaAdvenceTileButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton5.OnHoverImage = null;
            this.gunaAdvenceTileButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton5.Radius = 100;
            this.gunaAdvenceTileButton5.Size = new System.Drawing.Size(130, 121);
            this.gunaAdvenceTileButton5.TabIndex = 30;
            this.gunaAdvenceTileButton5.Click += new System.EventHandler(this.gunaAdvenceTileButton5_Click);
            // 
            // gunaAdvenceTileButton3
            // 
            this.gunaAdvenceTileButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton3.CheckedImage")));
            this.gunaAdvenceTileButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceTileButton3.Image = global::Hotel.Properties.Resources.employee_50px;
            this.gunaAdvenceTileButton3.ImageSize = new System.Drawing.Size(100, 100);
            this.gunaAdvenceTileButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton3.Location = new System.Drawing.Point(538, 431);
            this.gunaAdvenceTileButton3.Name = "gunaAdvenceTileButton3";
            this.gunaAdvenceTileButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton3.OnHoverImage = null;
            this.gunaAdvenceTileButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton3.Radius = 100;
            this.gunaAdvenceTileButton3.Size = new System.Drawing.Size(170, 160);
            this.gunaAdvenceTileButton3.TabIndex = 29;
            this.gunaAdvenceTileButton3.Click += new System.EventHandler(this.gunaAdvenceTileButton3_Click);
            // 
            // gunaAdvenceTileButton4
            // 
            this.gunaAdvenceTileButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton4.CheckedImage")));
            this.gunaAdvenceTileButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton4.Image")));
            this.gunaAdvenceTileButton4.ImageSize = new System.Drawing.Size(100, 100);
            this.gunaAdvenceTileButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton4.Location = new System.Drawing.Point(113, 431);
            this.gunaAdvenceTileButton4.Name = "gunaAdvenceTileButton4";
            this.gunaAdvenceTileButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton4.OnHoverImage = null;
            this.gunaAdvenceTileButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton4.Radius = 100;
            this.gunaAdvenceTileButton4.Size = new System.Drawing.Size(170, 160);
            this.gunaAdvenceTileButton4.TabIndex = 28;
            this.gunaAdvenceTileButton4.Click += new System.EventHandler(this.gunaAdvenceTileButton4_Click);
            // 
            // gunaAdvenceTileButton2
            // 
            this.gunaAdvenceTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton2.CheckedImage")));
            this.gunaAdvenceTileButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceTileButton2.Image = global::Hotel.Properties.Resources.amount_;
            this.gunaAdvenceTileButton2.ImageSize = new System.Drawing.Size(100, 100);
            this.gunaAdvenceTileButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton2.Location = new System.Drawing.Point(538, 186);
            this.gunaAdvenceTileButton2.Name = "gunaAdvenceTileButton2";
            this.gunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.OnHoverImage = null;
            this.gunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.Radius = 100;
            this.gunaAdvenceTileButton2.Size = new System.Drawing.Size(170, 160);
            this.gunaAdvenceTileButton2.TabIndex = 27;
            this.gunaAdvenceTileButton2.Click += new System.EventHandler(this.gunaAdvenceTileButton2_Click);
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.CheckedImage")));
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.Image")));
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(100, 100);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(116, 186);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Radius = 100;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(170, 160);
            this.gunaAdvenceTileButton1.TabIndex = 26;
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1200, 685);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gunaAdvenceTileButton6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaAdvenceTileButton5);
            this.Controls.Add(this.gunaAdvenceTileButton3);
            this.Controls.Add(this.gunaAdvenceTileButton4);
            this.Controls.Add(this.gunaAdvenceTileButton2);
            this.Controls.Add(this.gunaAdvenceTileButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton5;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton3;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton4;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton2;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton6;
    }
}