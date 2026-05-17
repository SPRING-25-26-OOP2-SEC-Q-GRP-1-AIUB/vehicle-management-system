using System;
using System.Drawing;
using System.Windows.Forms;

namespace Service_Panel
{
    public partial class ucAppointment : UserControl
    {
        public ucAppointment()
        {
            InitializeComponent();
        }

        private void ucAppointment_Load(object sender, EventArgs e)
        {
            dtpDate.MinDate = DateTime.Now.AddDays(1);
            dtpTime.Value = DateTime.Now.Date.AddHours(9);
            dtpTime.MinDate = DateTime.Now.Date.AddHours(8);
            dtpTime.MaxDate = DateTime.Now.Date.AddHours(18);
        }

        private void txtNotes_Enter(object sender, EventArgs e)
        {
            if (txtNotes.Text == "Enter additional notes...")
            {
                txtNotes.Text = "";
                txtNotes.ForeColor = Color.White;
            }
        }

        private void txtNotes_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                txtNotes.Text = "Enter additional notes...";
                txtNotes.ForeColor = Color.Gray;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter customer name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid phone number (minimum 10 digits).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVehicleModel.Text))
            {
                MessageBox.Show("Please enter vehicle model.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVehicleModel.Focus();
                return;
            }

            if (cmbServiceType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbServiceType.Focus();
                return;
            }

            // Show confirmation
            MessageBox.Show($"✓ APPOINTMENT CONFIRMED!\n\n" +
                          $"Customer: {txtCustomerName.Text}\n" +
                          $"Phone: {txtPhone.Text}\n" +
                          $"Email: {(string.IsNullOrWhiteSpace(txtEmail.Text) ? "Not provided" : txtEmail.Text)}\n" +
                          $"Vehicle: {txtVehicleModel.Text}\n" +
                          $"Service: {cmbServiceType.SelectedItem}\n" +
                          $"Date: {dtpDate.Value:dddd, MMMM dd, yyyy}\n" +
                          $"Time: {dtpTime.Value:hh:mm tt}\n" +
                          $"Notes: {(string.IsNullOrWhiteSpace(txtNotes.Text) || txtNotes.Text == "Enter additional notes..." ? "None" : txtNotes.Text)}\n\n" +
                          $"We will send confirmation to {txtPhone.Text}.",
                          "Appointment Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form after successful booking
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtVehicleModel.Clear();
            cmbServiceType.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now.AddDays(1);
            dtpTime.Value = DateTime.Now.Date.AddHours(9);
            txtNotes.Text = "Enter additional notes...";
            txtNotes.ForeColor = Color.Gray;
        }
    }
}