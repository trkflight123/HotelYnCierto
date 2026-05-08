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
            btnEvents = new Button();
            btnLostnFound = new Button();
            btnPayments = new Button();
            pnlNav = new Panel();
            btnReservation = new Button();
            btnCalendar = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnEvents);
            panel1.Controls.Add(btnLostnFound);
            panel1.Controls.Add(btnPayments);
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
            // btnEvents
            // 
            btnEvents.Dock = DockStyle.Top;
            btnEvents.FlatAppearance.BorderSize = 0;
            btnEvents.FlatStyle = FlatStyle.Flat;
            btnEvents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEvents.Image = Properties.Resources.event__1_;
            btnEvents.ImageAlign = ContentAlignment.MiddleLeft;
            btnEvents.Location = new Point(0, 639);
            btnEvents.Name = "btnEvents";
            btnEvents.Padding = new Padding(50, 0, 0, 0);
            btnEvents.Size = new Size(297, 87);
            btnEvents.TabIndex = 14;
            btnEvents.Text = "Events";
            btnEvents.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEvents.UseVisualStyleBackColor = true;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnLostnFound
            // 
            btnLostnFound.Dock = DockStyle.Top;
            btnLostnFound.FlatAppearance.BorderSize = 0;
            btnLostnFound.FlatStyle = FlatStyle.Flat;
            btnLostnFound.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLostnFound.Image = Properties.Resources.lost_and_found__1_;
            btnLostnFound.ImageAlign = ContentAlignment.MiddleLeft;
            btnLostnFound.Location = new Point(0, 552);
            btnLostnFound.Name = "btnLostnFound";
            btnLostnFound.Padding = new Padding(50, 0, 0, 0);
            btnLostnFound.Size = new Size(297, 87);
            btnLostnFound.TabIndex = 13;
            btnLostnFound.Text = "Lost and Found";
            btnLostnFound.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLostnFound.UseVisualStyleBackColor = true;
            btnLostnFound.Click += btnLostnFound_Click;
            // 
            // btnPayments
            // 
            btnPayments.Dock = DockStyle.Top;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPayments.Image = Properties.Resources.secure_payment__1_;
            btnPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayments.Location = new Point(0, 465);
            btnPayments.Name = "btnPayments";
            btnPayments.Padding = new Padding(50, 0, 0, 0);
            btnPayments.Size = new Size(297, 87);
            btnPayments.TabIndex = 12;
            btnPayments.Text = "Payments";
            btnPayments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(183, 219, 175);
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
            // pnlFormLoader
            // 
            pnlFormLoader.BackColor = Color.FromArgb(193, 225, 193);
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(297, 0);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1605, 1033);
            pnlFormLoader.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Yncierto";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnCalendar;
        private Button btnPayments;
        private Panel pnlFormLoader;
        private Button button2;
        private Button btnLostnFound;
        private Button btnEvents;
    }
}
