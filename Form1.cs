using System.Drawing;
using System.Drawing.Drawing2D;

namespace HotelYnCierto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActivateButton(btnDashboard);

            //dashboard

            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            HYDashboard dashboard = new HYDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard);
            dashboard.Show();

 
        }
        Button currentBtn;

        

        private void ActivateButton(Button btn)
        {
            if (currentBtn != null)
                currentBtn.BackColor = Color.FromArgb(255, 255, 255, 255);

            btn.BackColor = Color.FromArgb(255, 255, 255, 255);
            currentBtn = btn;

            pnlNav.Top = btn.Top;
            pnlNav.Height = btn.Height;
            pnlNav.Left = 0;

            pnlNav.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDashboard);
            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            HYDashboard dashboard = new HYDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCalendar);
            lblTitle.Text = "Calendar";
            this.pnlFormLoader.Controls.Clear();
            HYCalendar calendar= new HYCalendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            calendar.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(calendar);
            calendar.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReservation);
            lblTitle.Text = "Reservation";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCheckout);
            lblTitle.Text = "Checkout";
        }

    }
}
