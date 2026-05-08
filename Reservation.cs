using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace HotelYnCierto
{
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();
            SetRoundedRegion(btnBook, 5);
            SetRoundedRegion(btnClear, 5);
        }

        private void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(0, 0, diameter, diameter, 180, 90);
            path.AddArc(control.Width - diameter, 0, diameter, diameter, 270, 90);
            path.AddArc(control.Width - diameter, control.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(0, control.Height - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        
            // Clear all TextBox and ComboBox controls within this UserControl
            ClearAllInputs(this);
        }

        private void ClearAllInputs(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.Clear();
                }
                else if (ctrl is ComboBox cb)
                {
                    // Clear text and selection
                    cb.SelectedIndex = -1;
                    cb.Text = string.Empty;
                }
                else
                {
                    // Recurse into child controls (panels, groupboxes, etc.)
                    if (ctrl.HasChildren)
                        ClearAllInputs(ctrl);
                }
            }
        }
    }
}
