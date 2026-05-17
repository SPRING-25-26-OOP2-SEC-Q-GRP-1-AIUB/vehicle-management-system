using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Service_Panel
{
    public partial class ServicePanel : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        // Track current user control loaded in the panel
        private UserControl currentControl = null;

        public ServicePanel()
        {
            InitializeComponent();
        }

        private void ServicePanel_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                // Apply rounded corners
                this.Region = Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

                pnlN.Height = btmbookservice.Height;
                pnlN.Top = btmbookservice.Top;
                pnlN.Left = btmbookservice.Left;
                btmbookservice.BackColor = Color.FromArgb(46, 51, 73);

                lblTitel.Text = "Book Service";

                // Make sure content panel exists and is visible
                if (pnlContentContainer != null)
                {
                    pnlContentContainer.Visible = true;
                    pnlContentContainer.BringToFront();
                }

                // Show booking controls
                ShowBookingControls();
            }
        }

        private void ShowBookingControls()
        {
            // Clear any loaded user control first
            ClearContentPanel();

            bookservice1.Visible = true;
            bookservice2.Visible = true;
            bookservice3.Visible = true;
            flowLayoutPanel1.Visible = true;
            Grettings.Visible = true;
            submitbutton.Visible = true;

            // Hide content container when showing booking controls
            if (pnlContentContainer != null)
            {
                pnlContentContainer.Visible = false;
            }
        }

        private void HideBookingControls()
        {
            bookservice1.Visible = false;
            bookservice2.Visible = false;
            bookservice3.Visible = false;
            flowLayoutPanel1.Visible = false;
            Grettings.Visible = false;
            submitbutton.Visible = false;

            // Show content container for other features
            if (pnlContentContainer != null)
            {
                pnlContentContainer.Visible = true;
                pnlContentContainer.BringToFront();
            }
        }

        private void ClearContentPanel()
        {
            // Remove current user control if exists
            if (currentControl != null)
            {
                if (pnlContentContainer != null && pnlContentContainer.Controls.Contains(currentControl))
                {
                    pnlContentContainer.Controls.Remove(currentControl);
                }
                currentControl.Dispose();
                currentControl = null;
            }

            // Clear all controls from content panel
            if (pnlContentContainer != null)
            {
                pnlContentContainer.Controls.Clear();
            }
        }

        private void LoadUserControl(UserControl uc)
        {
            // Clear existing controls
            ClearContentPanel();

            // Hide booking controls first
            HideBookingControls();

            // Set up the user control
            uc.Dock = DockStyle.Fill;
            uc.BackColor = Color.FromArgb(46, 51, 73);

            // Add to content panel
            if (pnlContentContainer != null)
            {
                pnlContentContainer.Controls.Add(uc);
                currentControl = uc;
                pnlContentContainer.Visible = true;
                pnlContentContainer.BringToFront();
            }
        }

        private void ResetButtonsColor()
        {
            btmbookservice.BackColor = Color.Transparent;
            btmAppointment.BackColor = Color.Transparent;
            btmService.BackColor = Color.Transparent;
            btmTracking.BackColor = Color.Transparent;
            btmServiceTracking.BackColor = Color.Transparent;
            btmmanagement.BackColor = Color.Transparent;
            btmParts.BackColor = Color.Transparent;
            btmbill.BackColor = Color.Transparent;
            btmFeedback.BackColor = Color.Transparent;
        }

        private void btmbookservice_Click(object sender, EventArgs e)
        {
            pnlN.Height = btmbookservice.Height;
            pnlN.Top = btmbookservice.Top;
            pnlN.Left = btmbookservice.Left;
            ResetButtonsColor();
            btmbookservice.BackColor = Color.FromArgb(46, 51, 73);

            lblTitel.Text = "Book Service";
            ShowBookingControls();
            this.Refresh();
        }

        private void btmAppointment_Click(object sender, EventArgs e)
        {
            pnlN.Height = btmAppointment.Height;
            pnlN.Top = btmAppointment.Top;
            pnlN.Left = btmAppointment.Left;
            ResetButtonsColor();
            btmAppointment.BackColor = Color.FromArgb(46, 51, 73);

            lblTitel.Text = "Appointment Scheduling";

            // Load the appointment user control
            ucAppointment appointmentControl = new ucAppointment();
            LoadUserControl(appointmentControl);
        }

        private void btmService_Click(object sender, EventArgs e)
        {
            pnlN.Height = btmService.Height;
            pnlN.Top = btmService.Top;
            pnlN.Left = btmService.Left;
            ResetButtonsColor();
            btmService.BackColor = Color.FromArgb(46, 51, 73);

            lblTitel.Text = "Service Type";

            // Load the service type user control
            ucServiceType serviceTypeControl = new ucServiceType();
            LoadUserControl(serviceTypeControl);
        }

        private void btmTracking_Click(object sender, EventArgs e)
        {
            pnlN.Height = btmTracking.Height;
            pnlN.Top = btmTracking.Top;
            pnlN.Left = btmTracking.Left;
            ResetButtonsColor();
            btmTracking.BackColor = Color.FromArgb(46, 51, 73);

            lblTitel.Text = "Vehicle History Tracking";

            // Load the vehicle history user control
            ucVehicleHistory vehicleHistoryControl = new ucVehicleHistory();
            LoadUserControl(vehicleHistoryControl);
        }

        private void btmServiceTracking_Click(object sender, EventArgs e)
        {
            pnlN.Height = btmServiceTracking.Height;
            pnlN.Top = btmServiceTracking.Top;
            pnlN.Left = btmServiceTracking.Left;
            ResetButtonsColor();
            btmServiceTracking.BackColor = Color.FromArgb(46, 51, 73);

            lblTitel.Text = "Service Tracking";

            // Load the service tracking user control
            ucServiceTracking serviceTrackingControl = new ucServiceTracking();
            LoadUserControl(serviceTrackingControl);
        }

        private void btmmanagement_Click(object sender, EventArgs e)
        {
            pnlN.Height = btmmanagement.Height;
            pnlN.Top = btmmanagement.Top;
            pnlN.Left = btmmanagement.Left;
            ResetButtonsColor();
            btmmanagement.BackColor = Color.FromArgb(46, 51, 73);

            lblTitel.Text = "Appointment Management";

            // Load the appointment management user control
            ucAppointmentManagement appointmentManagementControl = new ucAppointmentManagement();
            LoadUserControl(appointmentManagementControl);
        }

        private void btmParts_Click(object sender, EventArgs e)
        {
            pnlN.Height = btmParts.Height;
            pnlN.Top = btmParts.Top;
            pnlN.Left = btmParts.Left;
            ResetButtonsColor();
            btmParts.BackColor = Color.FromArgb(46, 51, 73);

            lblTitel.Text = "Spare Parts";

            // Load the spare parts user control
            ucSpareParts sparePartsControl = new ucSpareParts();
            LoadUserControl(sparePartsControl);
        }

        private void btmbill_Click(object sender, EventArgs e)
        {
            pnlN.Height = btmbill.Height;
            pnlN.Top = btmbill.Top;
            pnlN.Left = btmbill.Left;
            ResetButtonsColor();
            btmbill.BackColor = Color.FromArgb(46, 51, 73);

            lblTitel.Text = "Billings";

            // Load the billings user control
            ucBillings billingsControl = new ucBillings();
            LoadUserControl(billingsControl);
        }

        private void btmFeedback_Click(object sender, EventArgs e)
        {
            pnlN.Height = btmFeedback.Height;
            pnlN.Top = btmFeedback.Top;
            pnlN.Left = btmFeedback.Left;
            ResetButtonsColor();
            btmFeedback.BackColor = Color.FromArgb(46, 51, 73);

            lblTitel.Text = "Service Feedback";

            // Load the service feedback user control
            ucServiceFeedback feedbackControl = new ucServiceFeedback();
            LoadUserControl(feedbackControl);
        }

        private void btmback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            // Validate booking form
            if (string.IsNullOrWhiteSpace(bookservicetextBox1.Text) || bookservicetextBox1.Text == "Enter vehicle model...")
            {
                MessageBox.Show("Please enter your vehicle model.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bookservicetextBox1.Focus();
                return;
            }

            if (bookservicetextBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bookservicetextBox2.Focus();
                return;
            }

            // Handle book service submit
            MessageBox.Show($"✓ SERVICE BOOKING CONFIRMED!\n\n" +
                          $"Vehicle Model: {bookservicetextBox1.Text}\n" +
                          $"Service Type: {bookservicetextBox2.SelectedItem}\n" +
                          $"Service Date: {dateTimePicker1.Value:dddd, MMMM dd, yyyy}\n" +
                          $"Additional Notes: {(string.IsNullOrWhiteSpace(textBox1.Text) ? "None" : textBox1.Text)}\n\n" +
                          $"Thank you for choosing our service! We will contact you shortly.",
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form after submission
            bookservicetextBox1.Text = "Enter vehicle model...";
            bookservicetextBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            textBox1.Text = "Enter additional notes...";
        }
    }
}