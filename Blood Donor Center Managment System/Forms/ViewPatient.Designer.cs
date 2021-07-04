
namespace Blood_Donor_Center_Managment_System.Forms
{
    partial class ViewPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.PGenderCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PBloodTypeCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PAddressTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PPhoneNumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PAgeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.VPEdit = new Guna.UI2.WinForms.Guna2Button();
            this.VPDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.VPDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VPDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blood Donation Center Managment Center";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(261, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 59);
            this.panel2.TabIndex = 7;
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
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 841);
            this.panel1.TabIndex = 6;
            // 
            // DashMenu
            // 
            this.DashMenu.AutoSize = true;
            this.DashMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DashMenu.ForeColor = System.Drawing.Color.White;
            this.DashMenu.Location = new System.Drawing.Point(28, 599);
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
            this.BTMenu.Location = new System.Drawing.Point(28, 523);
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
            this.BSMenu.Location = new System.Drawing.Point(28, 443);
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
            this.VPMenu.Location = new System.Drawing.Point(28, 368);
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
            this.PMenu.Location = new System.Drawing.Point(28, 294);
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
            this.VDMenu.Location = new System.Drawing.Point(28, 223);
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
            this.DMenu.Location = new System.Drawing.Point(28, 149);
            this.DMenu.Name = "DMenu";
            this.DMenu.Size = new System.Drawing.Size(112, 42);
            this.DMenu.TabIndex = 17;
            this.DMenu.Text = "Donor";
            this.DMenu.Click += new System.EventHandler(this.DMenu_Click);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(12, 359);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 62);
            this.panel6.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(993, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 42);
            this.label16.TabIndex = 41;
            this.label16.Text = "Gender";
            // 
            // PGenderCB
            // 
            this.PGenderCB.BackColor = System.Drawing.Color.Transparent;
            this.PGenderCB.BorderColor = System.Drawing.Color.DarkRed;
            this.PGenderCB.BorderRadius = 10;
            this.PGenderCB.BorderThickness = 3;
            this.PGenderCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PGenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PGenderCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PGenderCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PGenderCB.FocusedState.Parent = this.PGenderCB;
            this.PGenderCB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.PGenderCB.ForeColor = System.Drawing.Color.DarkRed;
            this.PGenderCB.HoverState.Parent = this.PGenderCB;
            this.PGenderCB.ItemHeight = 30;
            this.PGenderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown"});
            this.PGenderCB.ItemsAppearance.Parent = this.PGenderCB;
            this.PGenderCB.Location = new System.Drawing.Point(885, 270);
            this.PGenderCB.Name = "PGenderCB";
            this.PGenderCB.ShadowDecoration.Parent = this.PGenderCB;
            this.PGenderCB.Size = new System.Drawing.Size(306, 36);
            this.PGenderCB.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(1253, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 42);
            this.label15.TabIndex = 39;
            this.label15.Text = "Blood type";
            // 
            // PBloodTypeCB
            // 
            this.PBloodTypeCB.BackColor = System.Drawing.Color.Transparent;
            this.PBloodTypeCB.BorderColor = System.Drawing.Color.DarkRed;
            this.PBloodTypeCB.BorderRadius = 10;
            this.PBloodTypeCB.BorderThickness = 3;
            this.PBloodTypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PBloodTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PBloodTypeCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PBloodTypeCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PBloodTypeCB.FocusedState.Parent = this.PBloodTypeCB;
            this.PBloodTypeCB.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.PBloodTypeCB.ForeColor = System.Drawing.Color.DarkRed;
            this.PBloodTypeCB.HoverState.Parent = this.PBloodTypeCB;
            this.PBloodTypeCB.ItemHeight = 30;
            this.PBloodTypeCB.Items.AddRange(new object[] {
            "A+",
            "B+",
            "0+",
            "AB+",
            "A-",
            "B-",
            "AB-",
            "0-"});
            this.PBloodTypeCB.ItemsAppearance.Parent = this.PBloodTypeCB;
            this.PBloodTypeCB.Location = new System.Drawing.Point(1197, 270);
            this.PBloodTypeCB.Name = "PBloodTypeCB";
            this.PBloodTypeCB.ShadowDecoration.Parent = this.PBloodTypeCB;
            this.PBloodTypeCB.Size = new System.Drawing.Size(282, 36);
            this.PBloodTypeCB.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(1267, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 42);
            this.label14.TabIndex = 38;
            this.label14.Text = "Address";
            // 
            // PAddressTb
            // 
            this.PAddressTb.BorderColor = System.Drawing.Color.DarkRed;
            this.PAddressTb.BorderRadius = 10;
            this.PAddressTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PAddressTb.BorderThickness = 3;
            this.PAddressTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PAddressTb.DefaultText = "";
            this.PAddressTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PAddressTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PAddressTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAddressTb.DisabledState.Parent = this.PAddressTb;
            this.PAddressTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAddressTb.FillColor = System.Drawing.Color.WhiteSmoke;
            this.PAddressTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAddressTb.FocusedState.Parent = this.PAddressTb;
            this.PAddressTb.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.PAddressTb.ForeColor = System.Drawing.Color.DarkRed;
            this.PAddressTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAddressTb.HoverState.Parent = this.PAddressTb;
            this.PAddressTb.Location = new System.Drawing.Point(1200, 359);
            this.PAddressTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PAddressTb.Name = "PAddressTb";
            this.PAddressTb.PasswordChar = '\0';
            this.PAddressTb.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PAddressTb.PlaceholderText = "";
            this.PAddressTb.SelectedText = "";
            this.PAddressTb.ShadowDecoration.Parent = this.PAddressTb;
            this.PAddressTb.Size = new System.Drawing.Size(282, 36);
            this.PAddressTb.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(307, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 42);
            this.label13.TabIndex = 36;
            this.label13.Text = "Phone number";
            // 
            // PPhoneNumberTb
            // 
            this.PPhoneNumberTb.BorderColor = System.Drawing.Color.DarkRed;
            this.PPhoneNumberTb.BorderRadius = 10;
            this.PPhoneNumberTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PPhoneNumberTb.BorderThickness = 3;
            this.PPhoneNumberTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PPhoneNumberTb.DefaultText = "";
            this.PPhoneNumberTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PPhoneNumberTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PPhoneNumberTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPhoneNumberTb.DisabledState.Parent = this.PPhoneNumberTb;
            this.PPhoneNumberTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPhoneNumberTb.FillColor = System.Drawing.Color.WhiteSmoke;
            this.PPhoneNumberTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPhoneNumberTb.FocusedState.Parent = this.PPhoneNumberTb;
            this.PPhoneNumberTb.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.PPhoneNumberTb.ForeColor = System.Drawing.Color.DarkRed;
            this.PPhoneNumberTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPhoneNumberTb.HoverState.Parent = this.PPhoneNumberTb;
            this.PPhoneNumberTb.Location = new System.Drawing.Point(267, 359);
            this.PPhoneNumberTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PPhoneNumberTb.Name = "PPhoneNumberTb";
            this.PPhoneNumberTb.PasswordChar = '\0';
            this.PPhoneNumberTb.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PPhoneNumberTb.PlaceholderText = "";
            this.PPhoneNumberTb.SelectedText = "";
            this.PPhoneNumberTb.ShadowDecoration.Parent = this.PPhoneNumberTb;
            this.PPhoneNumberTb.Size = new System.Drawing.Size(306, 36);
            this.PPhoneNumberTb.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(691, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 42);
            this.label12.TabIndex = 35;
            this.label12.Text = "Age";
            // 
            // PAgeTb
            // 
            this.PAgeTb.BorderColor = System.Drawing.Color.DarkRed;
            this.PAgeTb.BorderRadius = 10;
            this.PAgeTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PAgeTb.BorderThickness = 3;
            this.PAgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PAgeTb.DefaultText = "";
            this.PAgeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PAgeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PAgeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAgeTb.DisabledState.Parent = this.PAgeTb;
            this.PAgeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAgeTb.FillColor = System.Drawing.Color.WhiteSmoke;
            this.PAgeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAgeTb.FocusedState.Parent = this.PAgeTb;
            this.PAgeTb.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.PAgeTb.ForeColor = System.Drawing.Color.DarkRed;
            this.PAgeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAgeTb.HoverState.Parent = this.PAgeTb;
            this.PAgeTb.Location = new System.Drawing.Point(573, 270);
            this.PAgeTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PAgeTb.Name = "PAgeTb";
            this.PAgeTb.PasswordChar = '\0';
            this.PAgeTb.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PAgeTb.PlaceholderText = "";
            this.PAgeTb.SelectedText = "";
            this.PAgeTb.ShadowDecoration.Parent = this.PAgeTb;
            this.PAgeTb.Size = new System.Drawing.Size(306, 36);
            this.PAgeTb.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(363, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 42);
            this.label11.TabIndex = 30;
            this.label11.Text = "Name";
            // 
            // PNameTb
            // 
            this.PNameTb.BorderColor = System.Drawing.Color.DarkRed;
            this.PNameTb.BorderRadius = 10;
            this.PNameTb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PNameTb.BorderThickness = 3;
            this.PNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNameTb.DefaultText = "";
            this.PNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNameTb.DisabledState.Parent = this.PNameTb;
            this.PNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNameTb.FillColor = System.Drawing.Color.WhiteSmoke;
            this.PNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNameTb.FocusedState.Parent = this.PNameTb;
            this.PNameTb.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.PNameTb.ForeColor = System.Drawing.Color.DarkRed;
            this.PNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNameTb.HoverState.Parent = this.PNameTb;
            this.PNameTb.Location = new System.Drawing.Point(261, 270);
            this.PNameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.PasswordChar = '\0';
            this.PNameTb.PlaceholderForeColor = System.Drawing.Color.Red;
            this.PNameTb.PlaceholderText = "";
            this.PNameTb.SelectedText = "";
            this.PNameTb.ShadowDecoration.Parent = this.PNameTb;
            this.PNameTb.Size = new System.Drawing.Size(306, 36);
            this.PNameTb.TabIndex = 34;
            // 
            // VPEdit
            // 
            this.VPEdit.AutoRoundedCorners = true;
            this.VPEdit.BackColor = System.Drawing.Color.Transparent;
            this.VPEdit.BorderColor = System.Drawing.Color.White;
            this.VPEdit.BorderRadius = 17;
            this.VPEdit.CheckedState.Parent = this.VPEdit;
            this.VPEdit.CustomImages.Parent = this.VPEdit;
            this.VPEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VPEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VPEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VPEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VPEdit.DisabledState.Parent = this.VPEdit;
            this.VPEdit.FillColor = System.Drawing.Color.DarkGreen;
            this.VPEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VPEdit.ForeColor = System.Drawing.Color.White;
            this.VPEdit.HoverState.Parent = this.VPEdit;
            this.VPEdit.Location = new System.Drawing.Point(597, 359);
            this.VPEdit.Name = "VPEdit";
            this.VPEdit.ShadowDecoration.Parent = this.VPEdit;
            this.VPEdit.Size = new System.Drawing.Size(254, 36);
            this.VPEdit.TabIndex = 43;
            this.VPEdit.Text = "Edit";
            this.VPEdit.Click += new System.EventHandler(this.VPEdit_Click);
            // 
            // VPDelete
            // 
            this.VPDelete.AutoRoundedCorners = true;
            this.VPDelete.BackColor = System.Drawing.Color.Transparent;
            this.VPDelete.BorderColor = System.Drawing.Color.White;
            this.VPDelete.BorderRadius = 17;
            this.VPDelete.CheckedState.Parent = this.VPDelete;
            this.VPDelete.CustomImages.Parent = this.VPDelete;
            this.VPDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VPDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VPDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VPDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VPDelete.DisabledState.Parent = this.VPDelete;
            this.VPDelete.FillColor = System.Drawing.Color.DarkRed;
            this.VPDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VPDelete.ForeColor = System.Drawing.Color.White;
            this.VPDelete.HoverState.Parent = this.VPDelete;
            this.VPDelete.Location = new System.Drawing.Point(906, 359);
            this.VPDelete.Name = "VPDelete";
            this.VPDelete.ShadowDecoration.Parent = this.VPDelete;
            this.VPDelete.Size = new System.Drawing.Size(254, 36);
            this.VPDelete.TabIndex = 44;
            this.VPDelete.Text = "Delete";
            this.VPDelete.Click += new System.EventHandler(this.VPDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(753, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 55);
            this.label10.TabIndex = 45;
            this.label10.Text = "Patients list";
            // 
            // VPDataGrid
            // 
            this.VPDataGrid.AllowUserToAddRows = false;
            this.VPDataGrid.AllowUserToDeleteRows = false;
            this.VPDataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Pink;
            this.VPDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.VPDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VPDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.VPDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VPDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VPDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VPDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.VPDataGrid.ColumnHeadersHeight = 25;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VPDataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.VPDataGrid.EnableHeadersVisualStyles = false;
            this.VPDataGrid.GridColor = System.Drawing.Color.LavenderBlush;
            this.VPDataGrid.Location = new System.Drawing.Point(401, 418);
            this.VPDataGrid.Name = "VPDataGrid";
            this.VPDataGrid.ReadOnly = true;
            this.VPDataGrid.RowHeadersVisible = false;
            this.VPDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VPDataGrid.Size = new System.Drawing.Size(983, 411);
            this.VPDataGrid.TabIndex = 47;
            this.VPDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.VPDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Pink;
            this.VPDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.VPDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.VPDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.VPDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.VPDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.VPDataGrid.ThemeStyle.GridColor = System.Drawing.Color.LavenderBlush;
            this.VPDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkRed;
            this.VPDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VPDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VPDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.VPDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.VPDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.VPDataGrid.ThemeStyle.ReadOnly = true;
            this.VPDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.VPDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VPDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VPDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.VPDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.VPDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.VPDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.VPDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VPDataGrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 42);
            this.label2.TabIndex = 25;
            this.label2.Text = "Donation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1485, 841);
            this.Controls.Add(this.VPDataGrid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VPDelete);
            this.Controls.Add(this.VPEdit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PGenderCB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PBloodTypeCB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PAddressTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PPhoneNumberTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PAgeTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPatient";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VPDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2ComboBox PGenderCB;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox PBloodTypeCB;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox PAddressTb;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox PPhoneNumberTb;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox PAgeTb;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox PNameTb;
        private Guna.UI2.WinForms.Guna2Button VPEdit;
        private Guna.UI2.WinForms.Guna2Button VPDelete;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView VPDataGrid;
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