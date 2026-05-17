using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Service_Panel
{
    public partial class ucServiceFeedback : UserControl
    {
        private List<Feedback> feedbacks;
        private Feedback selected;

        public ucServiceFeedback()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(46, 51, 73);
            this.Dock = DockStyle.Fill;
        }

        private void ucServiceFeedback_Load(object sender, EventArgs e)
        {
            LoadSampleData();
            SetupComboBoxes();
            UpdateStatistics();
        }

        private void SetupComboBoxes()
        {
            cmbRatingFilter.Items.Clear();
            cmbRatingFilter.Items.AddRange(new[] { "All Ratings", "5 Stars ★★★★★", "4 Stars ★★★★☆", "3 Stars ★★★☆☆", "2 Stars ★★☆☆☆", "1 Star ★☆☆☆☆" });
            cmbRatingFilter.SelectedIndex = 0;

            cmbAppointmentType.Items.Clear();
            cmbAppointmentType.Items.AddRange(new[] { "Oil Change", "Full Service", "Brake Repair", "Engine Diagnosis", "Tire Rotation", "AC Service", "Battery Replacement", "Transmission Service", "Other" });
            cmbAppointmentType.SelectedIndex = -1;
        }

        private void LoadSampleData()
        {
            feedbacks = new List<Feedback>
            {
                new Feedback("FB001", "John Smith", "Oil Change", 5, "Excellent service! Very professional and timely.", DateTime.Now.AddDays(-2), "Mike Johnson"),
                new Feedback("FB002", "Emma Davis", "Full Service", 4, "Good service, but took a bit longer than expected.", DateTime.Now.AddDays(-5), "Sarah Wilson"),
                new Feedback("FB003", "Robert Wilson", "Brake Repair", 5, "Brakes working perfectly now. Highly recommend!", DateTime.Now.AddDays(-1), "David Brown"),
                new Feedback("FB004", "Lisa Anderson", "Engine Diagnosis", 3, "Diagnosis was accurate but price was high.", DateTime.Now.AddDays(-7), "Mike Johnson"),
                new Feedback("FB005", "Michael Lee", "Tire Rotation", 5, "Quick and efficient service. Great job!", DateTime.Now.AddDays(-3), "Sarah Wilson"),
                new Feedback("FB006", "Sarah Brown", "AC Service", 4, "AC is working great now. Satisfied with the service.", DateTime.Now.AddDays(-4), "David Brown"),
                new Feedback("FB007", "David Miller", "Battery Replacement", 5, "Quick battery replacement. Very helpful staff.", DateTime.Now.AddDays(-6), "Mike Johnson")
            };
            UpdateFeedbackList();
        }

        private void UpdateFeedbackList()
        {
            listBoxFeedbacks.Items.Clear();
            string filter = cmbRatingFilter.SelectedItem?.ToString() ?? "All Ratings";
            int? rating = filter.Contains("5") ? 5 : filter.Contains("4") ? 4 : filter.Contains("3") ? 3 : filter.Contains("2") ? 2 : filter.Contains("1") ? 1 : (int?)null;
            var filtered = rating.HasValue ? feedbacks.Where(f => f.Rating == rating.Value).ToList() : feedbacks;

            foreach (var fb in filtered)
                listBoxFeedbacks.Items.Add($"{GetStars(fb.Rating)} {fb.Customer} - {fb.AppointmentType} ({fb.Date:MMM dd})");

            lblTotalFeedbacks.Text = $"Total: {filtered.Count} feedbacks";
        }

        private string GetStars(int rating) => rating == 5 ? "★★★★★" : rating == 4 ? "★★★★☆" : rating == 3 ? "★★★☆☆" : rating == 2 ? "★★☆☆☆" : "★☆☆☆☆";

        private void listBoxFeedbacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFeedbacks.SelectedIndex >= 0)
            {
                string selectedText = listBoxFeedbacks.SelectedItem.ToString();
                string customer = selectedText.Substring(selectedText.IndexOf(' ') + 1).Split('-')[0].Trim();
                selected = feedbacks.First(f => f.Customer == customer);

                txtCustomerName.Text = selected.Customer;
                txtAppointmentType.Text = selected.AppointmentType;
                txtRating.Text = GetStars(selected.Rating);
                txtRating.ForeColor = selected.Rating >= 4 ? Color.LightGreen : (selected.Rating == 3 ? Color.FromArgb(255, 193, 7) : Color.FromArgb(220, 53, 69));
                txtComment.Text = selected.Comment;
                txtDate.Text = selected.Date.ToString("dddd, MMMM dd, yyyy");
                txtTechnician.Text = selected.Technician;
            }
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtNewCustomer.Text))
            {
                MessageBox.Show("Please enter customer name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewCustomer.Focus();
                return;
            }

            if (cmbAppointmentType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select appointment type!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAppointmentType.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewComment.Text))
            {
                MessageBox.Show("Please enter your feedback comment!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewComment.Focus();
                return;
            }

            // Create new feedback
            var newFb = new Feedback(
                $"FB{new Random().Next(100, 999)}",
                txtNewCustomer.Text,
                cmbAppointmentType.SelectedItem.ToString(),
                (int)ratingControl.Value,
                txtNewComment.Text,
                DateTime.Now,
                GetRandomTech()
            );

            feedbacks.Add(newFb);
            UpdateFeedbackList();
            UpdateStatistics();
            ClearForm();

            MessageBox.Show($"✓ Thank you for your feedback!\n\nCustomer: {newFb.Customer}\nRating: {GetStars(newFb.Rating)}\n\nYour feedback has been recorded successfully.",
                "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetRandomTech() => new[] { "Mike Johnson", "Sarah Wilson", "David Brown" }[new Random().Next(3)];

        private void btnDeleteFeedback_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("Please select a feedback to delete!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete feedback from {selected.Customer}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                feedbacks.Remove(selected);
                selected = null;
                UpdateFeedbackList();
                UpdateStatistics();
                ClearDisplay();
                MessageBox.Show("Feedback deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearForm()
        {
            txtNewCustomer.Clear();
            cmbAppointmentType.SelectedIndex = -1;
            ratingControl.Value = 3;
            txtNewComment.Clear();
            txtNewCustomer.Focus();
        }

        private void ClearDisplay()
        {
            txtCustomerName.Clear();
            txtAppointmentType.Clear();
            txtRating.Clear();
            txtComment.Clear();
            txtDate.Clear();
            txtTechnician.Clear();
        }

        private void UpdateStatistics()
        {
            int total = feedbacks.Count;
            double avg = total > 0 ? feedbacks.Average(f => f.Rating) : 0;

            lblTotalFeedbacksCount.Text = total.ToString();
            lblAverageRating.Text = avg.ToString("F1");
            lblAverageRating.ForeColor = avg >= 4 ? Color.LightGreen : (avg >= 3 ? Color.FromArgb(255, 193, 7) : Color.FromArgb(220, 53, 69));
            lblAverageStars.Text = GetStars((int)Math.Round(avg));
            lblFiveStarCount.Text = feedbacks.Count(f => f.Rating == 5).ToString();
            lblFourStarCount.Text = feedbacks.Count(f => f.Rating == 4).ToString();
            lblThreeStarCount.Text = feedbacks.Count(f => f.Rating == 3).ToString();
        }

        private void cmbRatingFilter_SelectedIndexChanged(object sender, EventArgs e) => UpdateFeedbackList();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateFeedbackList();
            if (selected != null)
            {
                var refreshed = feedbacks.FirstOrDefault(f => f.ID == selected.ID);
                if (refreshed != null)
                {
                    selected = refreshed;
                    txtCustomerName.Text = selected.Customer;
                    txtAppointmentType.Text = selected.AppointmentType;
                    txtRating.Text = GetStars(selected.Rating);
                    txtRating.ForeColor = selected.Rating >= 4 ? Color.LightGreen : (selected.Rating == 3 ? Color.FromArgb(255, 193, 7) : Color.FromArgb(220, 53, 69));
                    txtComment.Text = selected.Comment;
                    txtDate.Text = selected.Date.ToString("dddd, MMMM dd, yyyy");
                    txtTechnician.Text = selected.Technician;
                }
            }
        }

        private class Feedback
        {
            public string ID { get; set; }
            public string Customer { get; set; }
            public string AppointmentType { get; set; }
            public int Rating { get; set; }
            public string Comment { get; set; }
            public DateTime Date { get; set; }
            public string Technician { get; set; }

            public Feedback(string id, string customer, string apt, int rating, string comment, DateTime date, string tech)
            {
                ID = id;
                Customer = customer;
                AppointmentType = apt;
                Rating = rating;
                Comment = comment;
                Date = date;
                Technician = tech;
            }
        }
    }
}