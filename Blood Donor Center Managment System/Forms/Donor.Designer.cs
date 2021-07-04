
namespace Blood_Donor_Center_Managment_System.Forms
{
    partial class Donor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donor));
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DashMenu = new System.Windows.Forms.Label();
            this.BTMenu = new System.Windows.Forms.Label();
            this.BSMenu = new System.Windows.Forms.Label();
            this.VPMenu = new System.Windows.Forms.Label();
            this.PMenu = new System.Windows.Forms.Label();
            this.VDMenu = new System.Windows.Forms.Label();
            this.DMenu = new System.Windows.Forms.Label();
            this.DNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DAgeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DPhoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DAddressTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.DBloodTypeCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DGenderCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Blood_drop = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DSave = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Blood_drop)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(52, 799);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 33);
            this.label9.TabIndex = 16;
            this.label9.Text = "Logout";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(12, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 62);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blood Donation Center Managment System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(261, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 59);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DashMenu);
            this.panel1.Controls.Add(this.BTMenu);
            this.panel1.Controls.Add(this.BSMenu);
            this.panel1.Controls.Add(this.VPMenu);
            this.panel1.Controls.Add(this.PMenu);
            this.panel1.Controls.Add(this.VDMenu);
            this.panel1.Controls.Add(this.DMenu);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 841);
            this.panel1.TabIndex = 4;
            // 
            // DashMenu
            // 
            this.DashMenu.AutoSize = true;
            this.DashMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DashMenu.ForeColor = System.Drawing.Color.White;
            this.DashMenu.Location = new System.Drawing.Point(30, 599);
            this.DashMenu.Name = "DashMenu";
            this.DashMenu.Size = new System.Drawing.Size(176, 42);
            this.DashMenu.TabIndex = 23;
            this.DashMenu.Text = "Dashboard";
            this.DashMenu.Click += new System.EventHandler(this.DashMenu_Click);
            // 
            // BTMenu
            // 
            this.BTMenu.AutoSize = true;
            this.BTMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTMenu.ForeColor = System.Drawing.Color.White;
            this.BTMenu.Location = new System.Drawing.Point(30, 523);
            this.BTMenu.Name = "BTMenu";
            this.BTMenu.Size = new System.Drawing.Size(237, 42);
            this.BTMenu.TabIndex = 22;
            this.BTMenu.Text = "Blood Transfer";
            this.BTMenu.Click += new System.EventHandler(this.BTMenu_Click);
            // 
            // BSMenu
            // 
            this.BSMenu.AutoSize = true;
            this.BSMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BSMenu.ForeColor = System.Drawing.Color.White;
            this.BSMenu.Location = new System.Drawing.Point(30, 443);
            this.BSMenu.Name = "BSMenu";
            this.BSMenu.Size = new System.Drawing.Size(197, 42);
            this.BSMenu.TabIndex = 21;
            this.BSMenu.Text = "Blood Stock";
            this.BSMenu.Click += new System.EventHandler(this.BSMenu_Click);
            // 
            // VPMenu
            // 
            this.VPMenu.AutoSize = true;
            this.VPMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VPMenu.ForeColor = System.Drawing.Color.White;
            this.VPMenu.Location = new System.Drawing.Point(30, 368);
            this.VPMenu.Name = "VPMenu";
            this.VPMenu.Size = new System.Drawing.Size(219, 42);
            this.VPMenu.TabIndex = 20;
            this.VPMenu.Text = "View Patients";
            this.VPMenu.Click += new System.EventHandler(this.VPMenu_Click);
            // 
            // PMenu
            // 
            this.PMenu.AutoSize = true;
            this.PMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PMenu.ForeColor = System.Drawing.Color.White;
            this.PMenu.Location = new System.Drawing.Point(30, 294);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(119, 42);
            this.PMenu.TabIndex = 19;
            this.PMenu.Text = "Patient";
            this.PMenu.Click += new System.EventHandler(this.PMenu_Click);
            // 
            // VDMenu
            // 
            this.VDMenu.AutoSize = true;
            this.VDMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VDMenu.ForeColor = System.Drawing.Color.White;
            this.VDMenu.Location = new System.Drawing.Point(30, 223);
            this.VDMenu.Name = "VDMenu";
            this.VDMenu.Size = new System.Drawing.Size(212, 42);
            this.VDMenu.TabIndex = 18;
            this.VDMenu.Text = "View Donors";
            this.VDMenu.Click += new System.EventHandler(this.VDMenu_Click);
            // 
            // DMenu
            // 
            this.DMenu.AutoSize = true;
            this.DMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DMenu.ForeColor = System.Drawing.Color.White;
            this.DMenu.Location = new System.Drawing.Point(30, 149);
            this.DMenu.Name = "DMenu";
            this.DMenu.Size = new System.Drawing.Size(112, 42);
            this.DMenu.TabIndex = 17;
            this.DMenu.Text = "Donor";
            this.DMenu.Click += new System.EventHandler(this.DMenu_Click);
            // 
            // DNameTb
            // 
            this.DNameTb.BorderColor = System.Drawing.Color.DarkRed;
            this.DNameTb.BorderRadius = 10;
            this.DNameTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DNameTb.BorderThickness = 3;
            this.DNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DNameTb.DefaultText = "";
            this.DNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DNameTb.DisabledState.Parent = this.DNameTb;
            this.DNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DNameTb.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DNameTb.FocusedState.Parent = this.DNameTb;
            this.DNameTb.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.DNameTb.ForeColor = System.Drawing.Color.DarkRed;
            this.DNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DNameTb.HoverState.Parent = this.DNameTb;
            this.DNameTb.Location = new System.Drawing.Point(398, 372);
            this.DNameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DNameTb.Name = "DNameTb";
            this.DNameTb.PasswordChar = '\0';
            this.DNameTb.PlaceholderForeColor = System.Drawing.Color.Red;
            this.DNameTb.PlaceholderText = "";
            this.DNameTb.SelectedText = "";
            this.DNameTb.ShadowDecoration.Parent = this.DNameTb;
            this.DNameTb.Size = new System.Drawing.Size(306, 36);
            this.DNameTb.TabIndex = 20;
            this.DNameTb.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(488, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 42);
            this.label11.TabIndex = 19;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(862, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 42);
            this.label12.TabIndex = 21;
            this.label12.Text = "Age";
            // 
            // DAgeTb
            // 
            this.DAgeTb.BorderColor = System.Drawing.Color.DarkRed;
            this.DAgeTb.BorderRadius = 10;
            this.DAgeTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DAgeTb.BorderThickness = 3;
            this.DAgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DAgeTb.DefaultText = "";
            this.DAgeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DAgeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DAgeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DAgeTb.DisabledState.Parent = this.DAgeTb;
            this.DAgeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DAgeTb.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DAgeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DAgeTb.FocusedState.Parent = this.DAgeTb;
            this.DAgeTb.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.DAgeTb.ForeColor = System.Drawing.Color.DarkRed;
            this.DAgeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DAgeTb.HoverState.Parent = this.DAgeTb;
            this.DAgeTb.Location = new System.Drawing.Point(763, 372);
            this.DAgeTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DAgeTb.Name = "DAgeTb";
            this.DAgeTb.PasswordChar = '\0';
            this.DAgeTb.PlaceholderForeColor = System.Drawing.Color.Red;
            this.DAgeTb.PlaceholderText = "";
            this.DAgeTb.SelectedText = "";
            this.DAgeTb.ShadowDecoration.Parent = this.DAgeTb;
            this.DAgeTb.Size = new System.Drawing.Size(306, 36);
            this.DAgeTb.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(434, 478);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 42);
            this.label13.TabIndex = 23;
            this.label13.Text = "Phone number";
            // 
            // DPhoneTb
            // 
            this.DPhoneTb.BorderColor = System.Drawing.Color.DarkRed;
            this.DPhoneTb.BorderRadius = 10;
            this.DPhoneTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DPhoneTb.BorderThickness = 3;
            this.DPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DPhoneTb.DefaultText = "";
            this.DPhoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DPhoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DPhoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DPhoneTb.DisabledState.Parent = this.DPhoneTb;
            this.DPhoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DPhoneTb.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DPhoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DPhoneTb.FocusedState.Parent = this.DPhoneTb;
            this.DPhoneTb.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.DPhoneTb.ForeColor = System.Drawing.Color.DarkRed;
            this.DPhoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DPhoneTb.HoverState.Parent = this.DPhoneTb;
            this.DPhoneTb.Location = new System.Drawing.Point(398, 523);
            this.DPhoneTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DPhoneTb.Name = "DPhoneTb";
            this.DPhoneTb.PasswordChar = '\0';
            this.DPhoneTb.PlaceholderForeColor = System.Drawing.Color.Red;
            this.DPhoneTb.PlaceholderText = "";
            this.DPhoneTb.SelectedText = "";
            this.DPhoneTb.ShadowDecoration.Parent = this.DPhoneTb;
            this.DPhoneTb.Size = new System.Drawing.Size(306, 36);
            this.DPhoneTb.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(862, 478);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 42);
            this.label14.TabIndex = 25;
            this.label14.Text = "Address";
            // 
            // DAddressTB
            // 
            this.DAddressTB.BorderColor = System.Drawing.Color.DarkRed;
            this.DAddressTB.BorderRadius = 10;
            this.DAddressTB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DAddressTB.BorderThickness = 3;
            this.DAddressTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DAddressTB.DefaultText = "";
            this.DAddressTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DAddressTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DAddressTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DAddressTB.DisabledState.Parent = this.DAddressTB;
            this.DAddressTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DAddressTB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DAddressTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DAddressTB.FocusedState.Parent = this.DAddressTB;
            this.DAddressTB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.DAddressTB.ForeColor = System.Drawing.Color.DarkRed;
            this.DAddressTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DAddressTB.HoverState.Parent = this.DAddressTB;
            this.DAddressTB.Location = new System.Drawing.Point(763, 523);
            this.DAddressTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DAddressTB.Name = "DAddressTB";
            this.DAddressTB.PasswordChar = '\0';
            this.DAddressTB.PlaceholderForeColor = System.Drawing.Color.Red;
            this.DAddressTB.PlaceholderText = "";
            this.DAddressTB.SelectedText = "";
            this.DAddressTB.ShadowDecoration.Parent = this.DAddressTB;
            this.DAddressTB.Size = new System.Drawing.Size(306, 151);
            this.DAddressTB.TabIndex = 24;
            // 
            // DBloodTypeCB
            // 
            this.DBloodTypeCB.BackColor = System.Drawing.Color.Transparent;
            this.DBloodTypeCB.BorderColor = System.Drawing.Color.DarkRed;
            this.DBloodTypeCB.BorderRadius = 10;
            this.DBloodTypeCB.BorderThickness = 3;
            this.DBloodTypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DBloodTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DBloodTypeCB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DBloodTypeCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DBloodTypeCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DBloodTypeCB.FocusedState.Parent = this.DBloodTypeCB;
            this.DBloodTypeCB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.DBloodTypeCB.ForeColor = System.Drawing.Color.DarkRed;
            this.DBloodTypeCB.HoverState.Parent = this.DBloodTypeCB;
            this.DBloodTypeCB.ItemHeight = 30;
            this.DBloodTypeCB.Items.AddRange(new object[] {
            "A+",
            "B+",
            "0+",
            "AB+",
            "A-",
            "B-",
            "AB-",
            "0-"});
            this.DBloodTypeCB.ItemsAppearance.Parent = this.DBloodTypeCB;
            this.DBloodTypeCB.Location = new System.Drawing.Point(1131, 529);
            this.DBloodTypeCB.Name = "DBloodTypeCB";
            this.DBloodTypeCB.ShadowDecoration.Parent = this.DBloodTypeCB;
            this.DBloodTypeCB.Size = new System.Drawing.Size(306, 36);
            this.DBloodTypeCB.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(1211, 478);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 42);
            this.label15.TabIndex = 26;
            this.label15.Text = "Blood type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(1211, 327);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 42);
            this.label16.TabIndex = 28;
            this.label16.Text = "Gender";
            // 
            // DGenderCB
            // 
            this.DGenderCB.BackColor = System.Drawing.Color.Transparent;
            this.DGenderCB.BorderColor = System.Drawing.Color.DarkRed;
            this.DGenderCB.BorderRadius = 10;
            this.DGenderCB.BorderThickness = 3;
            this.DGenderCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DGenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DGenderCB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DGenderCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DGenderCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DGenderCB.FocusedState.Parent = this.DGenderCB;
            this.DGenderCB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.DGenderCB.ForeColor = System.Drawing.Color.DarkRed;
            this.DGenderCB.HoverState.Parent = this.DGenderCB;
            this.DGenderCB.ItemHeight = 30;
            this.DGenderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown"});
            this.DGenderCB.ItemsAppearance.Parent = this.DGenderCB;
            this.DGenderCB.Location = new System.Drawing.Point(1131, 372);
            this.DGenderCB.Name = "DGenderCB";
            this.DGenderCB.ShadowDecoration.Parent = this.DGenderCB;
            this.DGenderCB.Size = new System.Drawing.Size(306, 36);
            this.DGenderCB.TabIndex = 27;
            // 
            // Blood_drop
            // 
            this.Blood_drop.Image = ((System.Drawing.Image)(resources.GetObject("Blood_drop.Image")));
            this.Blood_drop.InitialImage = ((System.Drawing.Image)(resources.GetObject("Blood_drop.InitialImage")));
            this.Blood_drop.Location = new System.Drawing.Point(821, 140);
            this.Blood_drop.Name = "Blood_drop";
            this.Blood_drop.Size = new System.Drawing.Size(176, 158);
            this.Blood_drop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Blood_drop.TabIndex = 30;
            this.Blood_drop.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.Crimson;
            this.label17.Location = new System.Drawing.Point(843, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 55);
            this.label17.TabIndex = 44;
            this.label17.Text = "Donor";
            // 
            // DSave
            // 
            this.DSave.AutoRoundedCorners = true;
            this.DSave.BackColor = System.Drawing.Color.Transparent;
            this.DSave.BorderColor = System.Drawing.Color.White;
            this.DSave.BorderRadius = 17;
            this.DSave.CheckedState.Parent = this.DSave;
            this.DSave.CustomImages.Parent = this.DSave;
            this.DSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DSave.DisabledState.Parent = this.DSave;
            this.DSave.FillColor = System.Drawing.Color.DarkRed;
            this.DSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DSave.ForeColor = System.Drawing.Color.White;
            this.DSave.HoverState.Parent = this.DSave;
            this.DSave.Location = new System.Drawing.Point(763, 731);
            this.DSave.Name = "DSave";
            this.DSave.ShadowDecoration.Parent = this.DSave;
            this.DSave.Size = new System.Drawing.Size(306, 36);
            this.DSave.TabIndex = 58;
            this.DSave.Text = "Save";
            this.DSave.Click += new System.EventHandler(this.DSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 42);
            this.label2.TabIndex = 25;
            this.label2.Text = "Donation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Donor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1485, 841);
            this.Controls.Add(this.DSave);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Blood_drop);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DGenderCB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DBloodTypeCB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DAddressTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DPhoneTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DAgeTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DNameTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Donor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Blood_drop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox DNameTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox DAgeTb;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox DPhoneTb;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox DAddressTB;
        private Guna.UI2.WinForms.Guna2ComboBox DBloodTypeCB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2ComboBox DGenderCB;
        private System.Windows.Forms.PictureBox Blood_drop;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2Button DSave;
        private System.Windows.Forms.Label DashMenu;
        private System.Windows.Forms.Label BTMenu;
        private System.Windows.Forms.Label BSMenu;
        private System.Windows.Forms.Label VPMenu;
        private System.Windows.Forms.Label PMenu;
        private System.Windows.Forms.Label VDMenu;
        private System.Windows.Forms.Label DMenu;
        private System.Windows.Forms.Label label2;
    }
}