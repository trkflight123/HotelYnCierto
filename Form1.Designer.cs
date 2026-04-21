namespace HotelYnCierto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnCheckout = new Button();
            pnlNav = new Panel();
            btnReservation = new Button();
            btnCalendar = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblTitle = new Label();
            txtBoxSearch = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnCalendar);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 1033);
            panel1.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.Dock = DockStyle.Top;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCheckout.Image = Properties.Resources.check_in__1_;
            btnCheckout.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckout.Location = new Point(0, 465);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Padding = new Padding(50, 0, 0, 0);
            btnCheckout.Size = new Size(297, 87);
            btnCheckout.TabIndex = 12;
            btnCheckout.Text = "Checkout";
            btnCheckout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.PaleTurquoise;
            pnlNav.Location = new Point(0, 288);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(10, 125);
            pnlNav.TabIndex = 8;
            // 
            // btnReservation
            // 
            btnReservation.Dock = DockStyle.Top;
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReservation.Image = (Image)resources.GetObject("btnReservation.Image");
            btnReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservation.Location = new Point(0, 378);
            btnReservation.Name = "btnReservation";
            btnReservation.Padding = new Padding(50, 0, 0, 0);
            btnReservation.Size = new Size(297, 87);
            btnReservation.TabIndex = 11;
            btnReservation.Text = "Reservation";
            btnReservation.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalendar.Image = (Image)resources.GetObject("btnCalendar.Image");
            btnCalendar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendar.Location = new Point(0, 291);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Padding = new Padding(50, 0, 0, 0);
            btnCalendar.Size = new Size(297, 87);
            btnCalendar.TabIndex = 9;
            btnCalendar.Text = "Calendar";
            btnCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 204);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(50, 0, 0, 0);
            btnDashboard.Size = new Size(297, 87);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(150, 78);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 2;
            label2.Text = "Front Desk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 50);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 1;
            label1.Text = "Hotel Yncierto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-23, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 160);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 204);
            panel2.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.AppWorkspace;
            lblTitle.Location = new Point(87, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(229, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Dashboard";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BorderStyle = BorderStyle.None;
            txtBoxSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSearch.Location = new Point(1088, 38);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(431, 36);
            txtBoxSearch.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LemonChiffon;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblTitle);
            panel3.Controls.Add(txtBoxSearch);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(297, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1605, 116);
            panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_removebg_preview__32___1_;
            pictureBox2.Location = new Point(1525, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 36);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(297, 116);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1605, 917);
            pnlFormLoader.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Yncierto";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button btnDashboard;
        private Panel pnlNav;
        private Button btnReservation;
        private Button button2;
        private Button btnCalendar;
        private Button btnCheckout;
        private Label lblTitle;
        private TextBox txtBoxSearch;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel pnlFormLoader;
    }
}
