using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Service_Panel
{
    public partial class ucServiceTracking : UserControl
    {
        private List<ServiceJob> jobs;
        private Timer refreshTimer;

        public ucServiceTracking()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(46, 51, 73);
            this.Dock = DockStyle.Fill;
            refreshTimer = new Timer { Interval = 1000 };
            refreshTimer.Tick += (s, e) => UpdateTimers();
            refreshTimer.Start();
        }

        private void ucServiceTracking_Load(object sender, EventArgs e)
        {
            LoadSampleData();
            cmbStatusFilter.Items.AddRange(new[] { "All", "Pending", "In Progress", "Completed" });
            cmbStatusFilter.SelectedIndex = 0;
        }

        private void LoadSampleData()
        {
            jobs = new List<ServiceJob>
            {
                new ServiceJob("SRV001", "Toyota Camry", DateTime.Now.AddHours(-2), null, "In Progress"),
                new ServiceJob("SRV002", "Honda Civic", DateTime.Now.AddHours(-1.5), null, "In Progress"),
                new ServiceJob("SRV003", "Ford Mustang", DateTime.Now.AddHours(-3), DateTime.Now.AddHours(-1), "Completed"),
                new ServiceJob("SRV004", "BMW X5", DateTime.Now.AddMinutes(-30), null, "Pending"),
                new ServiceJob("SRV005", "Tesla Model 3", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-1.5), "Completed"),
                new ServiceJob("SRV006", "Toyota Corolla", DateTime.Now.AddHours(-5), DateTime.Now.AddHours(-2), "Completed"),
                new ServiceJob("SRV007", "Honda Accord", DateTime.Now.AddMinutes(-45), null, "In Progress"),
                new ServiceJob("SRV008", "Nissan Altima", DateTime.Now.AddHours(-1), null, "Pending")
            };
            UpdateServiceList();
            UpdateStatistics();
        }

        private void UpdateServiceList()
        {
            listBoxServices.Items.Clear();
            string filter = cmbStatusFilter.SelectedItem?.ToString() ?? "All";
            var filtered = filter == "All" ? jobs : jobs.Where(j => j.Status == filter).ToList();
            foreach (var job in filtered)
            {
                string icon = job.Status == "Completed" ? "✓" : (job.Status == "In Progress" ? "🔄" : "⏳");
                listBoxServices.Items.Add($"{icon} {job.ID} - {job.Vehicle} ({job.Status})");
            }
            lblTotalJobs.Text = $"Total: {filtered.Count}";
        }

        private void listBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxServices.SelectedIndex >= 0)
            {
                string id = listBoxServices.SelectedItem.ToString().Split('-')[0].Trim().Substring(1);
                var job = jobs.First(j => j.ID == id);
                DisplayJobDetails(job);
            }
        }

        private void DisplayJobDetails(ServiceJob job)
        {
            txtVehicleModel.Text = job.Vehicle;
            cmbStatus.SelectedItem = job.Status;
            txtStartTime.Text = job.StartTime.ToString("hh:mm tt");
            lblStartDate.Text = job.StartTime.ToString("MMM dd, yyyy");

            if (job.Status == "Completed" && job.EndTime.HasValue)
            {
                txtEndTime.Text = job.EndTime.Value.ToString("hh:mm tt");
                lblEndDate.Text = job.EndTime.Value.ToString("MMM dd, yyyy");
                var duration = job.EndTime.Value - job.StartTime;
                lblDuration.Text = $"{duration.Hours}h {duration.Minutes}m";
            }
            else if (job.Status == "In Progress")
            {
                txtEndTime.Text = "In Progress";
                lblEndDate.Text = "-";
                var elapsed = DateTime.Now - job.StartTime;
                lblDuration.Text = $"{elapsed.Hours}h {elapsed.Minutes}m";
            }
            else
            {
                txtEndTime.Text = "Not Started";
                lblEndDate.Text = "-";
                lblDuration.Text = "0h 0m";
            }
            UpdateTimerDisplay(job);
        }

        private void UpdateTimerDisplay(ServiceJob job)
        {
            if (job.Status == "In Progress")
            {
                var elapsed = DateTime.Now - job.StartTime;
                lblTimer.Text = $"{elapsed.Hours:D2}:{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
                lblTimer.ForeColor = Color.FromArgb(0, 126, 249);
            }
            else if (job.Status == "Completed" && job.EndTime.HasValue)
            {
                var total = job.EndTime.Value - job.StartTime;
                lblTimer.Text = $"{total.Hours:D2}:{total.Minutes:D2}:{total.Seconds:D2}";
                lblTimer.ForeColor = Color.LightGreen;
            }
            else
            {
                lblTimer.Text = "00:00:00";
                lblTimer.ForeColor = Color.Gray;
            }
        }

        private void UpdateTimers()
        {
            if (listBoxServices.SelectedIndex >= 0)
            {
                string id = listBoxServices.SelectedItem.ToString().Split('-')[0].Trim().Substring(1);
                var job = jobs.FirstOrDefault(j => j.ID == id);
                if (job != null && job.Status == "In Progress")
                {
                    UpdateTimerDisplay(job);
                    var elapsed = DateTime.Now - job.StartTime;
                    lblDuration.Text = $"{elapsed.Hours}h {elapsed.Minutes}m";
                }
            }
            UpdateServiceList();
        }

        private void UpdateStatistics()
        {
            lblPendingCount.Text = jobs.Count(j => j.Status == "Pending").ToString();
            lblInProgressCount.Text = jobs.Count(j => j.Status == "In Progress").ToString();
            lblCompletedCount.Text = jobs.Count(j => j.Status == "Completed").ToString();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxServices.SelectedIndex >= 0)
            {
                string id = listBoxServices.SelectedItem.ToString().Split('-')[0].Trim().Substring(1);
                var job = jobs.First(j => j.ID == id);
                string newStatus = cmbStatus.SelectedItem.ToString();

                if (newStatus == "Completed" && job.Status != "Completed")
                {
                    job.EndTime = DateTime.Now;
                    MessageBox.Show($"Service {job.ID} completed!\nDuration: {(job.EndTime.Value - job.StartTime).Hours}h {(job.EndTime.Value - job.StartTime).Minutes}m", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (newStatus == "In Progress" && job.Status == "Pending")
                {
                    job.StartTime = DateTime.Now;
                    MessageBox.Show($"Service {job.ID} started!", "Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                job.Status = newStatus;
                UpdateServiceList();
                UpdateStatistics();
                DisplayJobDetails(job);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            var addForm = new frmAddService();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var newJob = addForm.GetServiceJob();
                jobs.Add(newJob);
                UpdateServiceList();
                UpdateStatistics();
                MessageBox.Show($"Service added: {newJob.ID} - {newJob.Vehicle}", "Service Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e) => UpdateServiceList();
        private void btnRefresh_Click(object sender, EventArgs e) => UpdateServiceList();

        private class ServiceJob
        {
            public string ID { get; set; }
            public string Vehicle { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime? EndTime { get; set; }
            public string Status { get; set; }
            public ServiceJob(string id, string vehicle, DateTime start, DateTime? end, string status) { ID = id; Vehicle = vehicle; StartTime = start; EndTime = end; Status = status; }
        }

        private class frmAddService : Form
        {
            private TextBox txtVehicle;
            public frmAddService()
            {
                this.Text = "Add New Service";
                this.Size = new Size(350, 150);
                this.StartPosition = FormStartPosition.CenterParent;
                this.BackColor = Color.FromArgb(46, 51, 73);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;

                var lblVehicle = new Label { Text = "Vehicle Model:", Location = new Point(20, 30), Size = new Size(100, 25), ForeColor = Color.White };
                txtVehicle = new TextBox { Location = new Point(130, 30), Size = new Size(180, 25), BackColor = Color.FromArgb(55, 61, 83), ForeColor = Color.White };

                var btnAdd = new Button { Text = "Add", Location = new Point(130, 80), Size = new Size(80, 35), BackColor = Color.FromArgb(0, 126, 249), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnAdd.Click += (s, e) => { if (!string.IsNullOrWhiteSpace(txtVehicle.Text)) this.DialogResult = DialogResult.OK; else MessageBox.Show("Enter vehicle model!"); this.Close(); };

                var btnCancel = new Button { Text = "Cancel", Location = new Point(220, 80), Size = new Size(80, 35), BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

                this.Controls.AddRange(new Control[] { lblVehicle, txtVehicle, btnAdd, btnCancel });
            }
            public ServiceJob GetServiceJob() => new ServiceJob($"SRV{new Random().Next(100, 999)}", txtVehicle.Text, DateTime.Now, null, "Pending");
        }
    }
}