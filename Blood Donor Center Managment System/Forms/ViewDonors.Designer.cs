
namespace Blood_Donor_Center_Managment_System.Forms
{
    partial class ViewDonors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.VDDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VDDataGrid)).BeginInit();
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
            this.panel1.Controls.Add(this.panel4);
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
            this.DashMenu.Location = new System.Drawing.Point(24, 598);
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
            this.BTMenu.Location = new System.Drawing.Point(24, 522);
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
            this.BSMenu.Location = new System.Drawing.Point(24, 442);
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
            this.VPMenu.Location = new System.Drawing.Point(24, 367);
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
            this.PMenu.Location = new System.Drawing.Point(24, 293);
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
            this.VDMenu.Location = new System.Drawing.Point(24, 222);
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
            this.DMenu.Location = new System.Drawing.Point(24, 148);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(12, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 62);
            this.panel4.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(289, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 42);
            this.label11.TabIndex = 21;
            this.label11.Text = "Name";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.DarkRed;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2TextBox1.BorderThickness = 3;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(403, 155);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Red;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(306, 36);
            this.guna2TextBox1.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.Crimson;
            this.label17.Location = new System.Drawing.Point(734, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(246, 55);
            this.label17.TabIndex = 45;
            this.label17.Text = "Donors list";
            // 
            // VDDataGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Pink;
            this.VDDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.VDDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VDDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.VDDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VDDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VDDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VDDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.VDDataGrid.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VDDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.VDDataGrid.EnableHeadersVisualStyles = false;
            this.VDDataGrid.GridColor = System.Drawing.Color.LavenderBlush;
            this.VDDataGrid.Location = new System.Drawing.Point(296, 223);
            this.VDDataGrid.Name = "VDDataGrid";
            this.VDDataGrid.RowHeadersVisible = false;
            this.VDDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VDDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VDDataGrid.Size = new System.Drawing.Size(1157, 618);
            this.VDDataGrid.TabIndex = 46;
            this.VDDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.VDDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Pink;
            this.VDDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.VDDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.VDDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.VDDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.VDDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.VDDataGrid.ThemeStyle.GridColor = System.Drawing.Color.LavenderBlush;
            this.VDDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkRed;
            this.VDDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VDDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VDDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.VDDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.VDDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.VDDataGrid.ThemeStyle.ReadOnly = false;
            this.VDDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.VDDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VDDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VDDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.VDDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.VDDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.VDDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.VDDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VDDataGrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 42);
            this.label2.TabIndex = 25;
            this.label2.Text = "Donation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ViewDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1485, 841);
            this.Controls.Add(this.VDDataGrid);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDonors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDonors";
            this.Load += new System.EventHandler(this.ViewDonors_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VDDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2DataGridView VDDataGrid;
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