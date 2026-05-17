using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Service_Panel
{
    public partial class ucAppointmentManagement : UserControl
    {
        private List<Appointment> appointments;
        private Appointment selected;

        public ucAppointmentManagement()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(46, 51, 73);
            this.Dock = DockStyle.Fill;
        }

        private void ucAppointmentManagement_Load(object sender, EventArgs e)
        {
            LoadSampleData();
            cmbStatusFilter.Items.AddRange(new[] { "All", "Scheduled", "Completed", "Cancelled" });
            cmbStatusFilter.SelectedIndex = 0;
            UpdateStatistics();
        }

        private void LoadSampleData()
        {
            appointments = new List<Appointment>
            {
                new Appointment("APT001", "John Smith", "555-0101", "Oil Change", DateTime.Now.AddDays(2), "10:00 AM", "Scheduled"),
                new Appointment("APT002", "Emma Davis", "555-0102", "Full Service", DateTime.Now.AddDays(3), "2:00 PM", "Scheduled"),
                new Appointment("APT003", "Robert Wilson", "555-0103", "Brake Repair", DateTime.Now.AddDays(-1), "11:00 AM", "Completed"),
                new Appointment("APT004", "Lisa Anderson", "555-0104", "Engine Diagnosis", DateTime.Now.AddDays(1), "3:00 PM", "Scheduled"),
                new Appointment("APT005", "Michael Lee", "555-0105", "Tire Rotation", DateTime.Now.AddDays(-2), "9:00 AM", "Cancelled", "Customer request", "Admin")
            };
            UpdateAppointmentList();
            UpdateStatistics();
        }

        private void UpdateAppointmentList()
        {
            listBoxAppointments.Items.Clear();
            string filter = cmbStatusFilter.SelectedItem?.ToString() ?? "All";
            var filtered = filter == "All" ? appointments : appointments.Where(a => a.Status == filter).ToList();
            foreach (var apt in filtered)
            {
                string icon = apt.Status == "Completed" ? "✓" : (apt.Status == "Cancelled" ? "✗" : "●");
                listBoxAppointments.Items.Add($"{icon} {apt.ID} - {apt.Customer} - {apt.ServiceType} ({apt.Status})");
            }
            lblTotalCount.Text = $"Total: {filtered.Count}";
        }

        private void listBoxAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAppointments.SelectedIndex >= 0)
            {
                string id = listBoxAppointments.SelectedItem.ToString().Split('-')[0].Trim().Substring(1);
                selected = appointments.First(a => a.ID == id);
                DisplayDetails(selected);
                EnableControls(selected.Status != "Completed" && selected.Status != "Cancelled");
            }
        }

        private void DisplayDetails(Appointment apt)
        {
            txtCustomerName.Text = apt.Customer;
            txtPhone.Text = apt.Phone;
            txtServiceType.Text = apt.ServiceType;
            txtStatus.Text = apt.Status;
            dtpDate.Value = apt.Date;
            txtTime.Text = apt.Time;
            txtStatus.ForeColor = apt.Status == "Completed" ? Color.LightGreen : (apt.Status == "Cancelled" ? Color.Red : Color.FromArgb(0, 126, 249));
            txtRescheduleDate.Text = apt.RescheduledDate?.ToString("MMM dd, yyyy") ?? "";
            txtRescheduleTime.Text = apt.RescheduleTime ?? "";
            txtCancellationReason.Text = apt.CancellationReason ?? "N/A";
            txtUpdatedBy.Text = apt.UpdatedBy ?? "N/A";
        }

        private void EnableControls(bool enable)
        {
            btnReschedule.Enabled = enable;
            btnCancel.Enabled = enable;
            btnReschedule.BackColor = enable ? Color.FromArgb(0, 126, 249) : Color.FromArgb(64, 64, 64);
            btnCancel.BackColor = enable ? Color.FromArgb(220, 53, 69) : Color.FromArgb(64, 64, 64);
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            if (selected == null) { MessageBox.Show("Select an appointment first."); return; }
            var rescheduleForm = new frmReschedule(selected);
            if (rescheduleForm.ShowDialog() == DialogResult.OK)
            {
                selected.RescheduledDate = rescheduleForm.NewDate;
                selected.RescheduleTime = rescheduleForm.NewTime;
                selected.UpdatedBy = rescheduleForm.UpdatedBy;
                selected.Date = rescheduleForm.NewDate;
                selected.Time = rescheduleForm.NewTime;
                MessageBox.Show($"Appointment {selected.ID} rescheduled to {rescheduleForm.NewDate:MMM dd, yyyy} at {rescheduleForm.NewTime}", "Rescheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateAppointmentList();
                DisplayDetails(selected);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selected == null) { MessageBox.Show("Select an appointment first."); return; }
            var cancelForm = new frmCancellation();
            if (cancelForm.ShowDialog() == DialogResult.OK)
            {
                selected.Status = "Cancelled";
                selected.CancellationReason = cancelForm.Reason;
                selected.UpdatedBy = cancelForm.UpdatedBy;
                MessageBox.Show($"Appointment {selected.ID} cancelled!\nReason: {cancelForm.Reason}", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateAppointmentList();
                UpdateStatistics();
                DisplayDetails(selected);
                EnableControls(false);
            }
        }

        private void UpdateStatistics()
        {
            lblScheduledCount.Text = appointments.Count(a => a.Status == "Scheduled").ToString();
            lblCompletedCount.Text = appointments.Count(a => a.Status == "Completed").ToString();
            lblCancelledCount.Text = appointments.Count(a => a.Status == "Cancelled").ToString();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e) => UpdateAppointmentList();
        private void btnRefresh_Click(object sender, EventArgs e) => UpdateAppointmentList();

        private class Appointment
        {
            public string ID { get; set; }
            public string Customer { get; set; }
            public string Phone { get; set; }
            public string ServiceType { get; set; }
            public DateTime Date { get; set; }
            public string Time { get; set; }
            public string Status { get; set; }
            public DateTime? RescheduledDate { get; set; }
            public string RescheduleTime { get; set; }
            public string CancellationReason { get; set; }
            public string UpdatedBy { get; set; }
            public Appointment(string id, string customer, string phone, string service, DateTime date, string time, string status, string cancelReason = null, string updatedBy = null) { ID = id; Customer = customer; Phone = phone; ServiceType = service; Date = date; Time = time; Status = status; CancellationReason = cancelReason; UpdatedBy = updatedBy; }
        }

        private class frmReschedule : Form
        {
            public DateTime NewDate { get; private set; }
            public string NewTime { get; private set; }
            public string UpdatedBy { get; private set; }
            public frmReschedule(Appointment apt)
            {
                this.Text = "Reschedule Appointment";
                this.Size = new Size(350, 220);
                this.StartPosition = FormStartPosition.CenterParent;
                this.BackColor = Color.FromArgb(46, 51, 73);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;

                var dtpDate = new DateTimePicker { Location = new Point(120, 30), Size = new Size(180, 25), Value = apt.Date.AddDays(1), MinDate = DateTime.Now.AddDays(1) };
                var dtpTime = new DateTimePicker { Location = new Point(120, 70), Size = new Size(100, 25), Format = DateTimePickerFormat.Time, ShowUpDown = true, Value = DateTime.Parse(apt.Time) };
                var txtBy = new TextBox { Location = new Point(120, 110), Size = new Size(180, 25), BackColor = Color.FromArgb(55, 61, 83), ForeColor = Color.White, Text = "Admin" };

                var btnConfirm = new Button { Text = "Confirm", Location = new Point(120, 150), Size = new Size(80, 35), BackColor = Color.FromArgb(0, 126, 249), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnConfirm.Click += (s, e) => { NewDate = dtpDate.Value; NewTime = dtpTime.Value.ToString("hh:mm tt"); UpdatedBy = txtBy.Text; this.DialogResult = DialogResult.OK; this.Close(); };

                var btnCancel = new Button { Text = "Cancel", Location = new Point(220, 150), Size = new Size(80, 35), BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

                this.Controls.AddRange(new Control[] { new Label { Text = "New Date:", Location = new Point(20, 30), ForeColor = Color.White }, dtpDate,
                    new Label { Text = "New Time:", Location = new Point(20, 70), ForeColor = Color.White }, dtpTime,
                    new Label { Text = "Updated By:", Location = new Point(20, 110), ForeColor = Color.White }, txtBy, btnConfirm, btnCancel });
            }
        }

        private class frmCancellation : Form
        {
            public string Reason { get; private set; }
            public string UpdatedBy { get; private set; }
            public frmCancellation()
            {
                this.Text = "Cancel Appointment";
                this.Size = new Size(400, 250);
                this.StartPosition = FormStartPosition.CenterParent;
                this.BackColor = Color.FromArgb(46, 51, 73);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;

                var txtReason = new TextBox { Location = new Point(150, 30), Size = new Size(210, 25), BackColor = Color.FromArgb(55, 61, 83), ForeColor = Color.White };
                var txtBy = new TextBox { Location = new Point(150, 80), Size = new Size(210, 25), BackColor = Color.FromArgb(55, 61, 83), ForeColor = Color.White, Text = "Admin" };

                var btnConfirm = new Button { Text = "Confirm Cancellation", Location = new Point(150, 130), Size = new Size(150, 35), BackColor = Color.FromArgb(220, 53, 69), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnConfirm.Click += (s, e) => { if (!string.IsNullOrWhiteSpace(txtReason.Text) && !string.IsNullOrWhiteSpace(txtBy.Text)) { Reason = txtReason.Text; UpdatedBy = txtBy.Text; this.DialogResult = DialogResult.OK; this.Close(); } else MessageBox.Show("Enter reason and updater name!"); };

                var btnCancel = new Button { Text = "Cancel", Location = new Point(150, 180), Size = new Size(150, 35), BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

                this.Controls.AddRange(new Control[] { new Label { Text = "Cancellation Reason:", Location = new Point(20, 30), ForeColor = Color.White }, txtReason,
                    new Label { Text = "Cancelled By:", Location = new Point(20, 80), ForeColor = Color.White }, txtBy, btnConfirm, btnCancel });
            }
        }
    }
}