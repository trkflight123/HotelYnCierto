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
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);

            btn.BackColor = Color.FromArgb(255,255,255);
            currentBtn = btn;

            pnlNav.Top = btn.Top;
            pnlNav.Height = btn.Height;
            pnlNav.Left = 0;

            pnlNav.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDashboard);

            this.pnlFormLoader.Controls.Clear();
            HYDashboard dashboard = new HYDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCalendar);

            this.pnlFormLoader.Controls.Clear();
            HYCalendar calendar = new HYCalendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            calendar.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(calendar);
            calendar.Show();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReservation);

            this.pnlFormLoader.Controls.Clear();
            Reservation reservation = new Reservation() { Dock = DockStyle.Fill };
            
            this.pnlFormLoader.Controls.Add(reservation);
            reservation.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            ActivateButton(btnPayments);
        }

        private void btnLostnFound_Click(object sender, EventArgs e)
        {
            ActivateButton(btnLostnFound);
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            ActivateButton(btnEvents);
        }
    }
}
