namespace Service_Panel
{
    partial class ucServiceFeedback
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.cmbRatingFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBoxFeedbackList = new System.Windows.Forms.GroupBox();
            this.lblTotalFeedbacks = new System.Windows.Forms.Label();
            this.listBoxFeedbacks = new System.Windows.Forms.ListBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxAddFeedback = new System.Windows.Forms.GroupBox();
            this.ratingControl = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.txtNewComment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAppointmentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxFeedbackDetails = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.txtTechnician = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAppointmentType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteFeedback = new System.Windows.Forms.Button();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.lblAverageStars = new System.Windows.Forms.Label();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblThreeStarCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFourStarCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFiveStarCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalFeedbacksCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxFeedbackList.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxAddFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl)).BeginInit();
            this.groupBoxFeedbackDetails.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelRight);
            this.splitContainer.Size = new System.Drawing.Size(534, 490);
            this.splitContainer.SplitterDistance = 220;
            this.splitContainer.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxFilters);
            this.panelLeft.Controls.Add(this.groupBoxFeedbackList);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(3);
            this.panelLeft.Size = new System.Drawing.Size(220, 490);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxFilters.Controls.Add(this.cmbRatingFilter);
            this.groupBoxFilters.Controls.Add(this.lblFilter);
            this.groupBoxFilters.Controls.Add(this.btnRefresh);
            this.groupBoxFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxFilters.ForeColor = System.Drawing.Color.White;
            this.groupBoxFilters.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(214, 90);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // cmbRatingFilter
            // 
            this.cmbRatingFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.cmbRatingFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRatingFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRatingFilter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbRatingFilter.ForeColor = System.Drawing.Color.White;
            this.cmbRatingFilter.FormattingEnabled = true;
            this.cmbRatingFilter.Location = new System.Drawing.Point(70, 25);
            this.cmbRatingFilter.Name = "cmbRatingFilter";
            this.cmbRatingFilter.Size = new System.Drawing.Size(135, 21);
            this.cmbRatingFilter.TabIndex = 2;
            this.cmbRatingFilter.SelectedIndexChanged += new System.EventHandler(this.cmbRatingFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFilter.ForeColor = System.Drawing.Color.LightGray;
            this.lblFilter.Location = new System.Drawing.Point(10, 28);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(59, 13);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Rating by:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(70, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 25);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBoxFeedbackList
            // 
            this.groupBoxFeedbackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxFeedbackList.Controls.Add(this.lblTotalFeedbacks);
            this.groupBoxFeedbackList.Controls.Add(this.listBoxFeedbacks);
            this.groupBoxFeedbackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFeedbackList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxFeedbackList.ForeColor = System.Drawing.Color.White;
            this.groupBoxFeedbackList.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFeedbackList.Name = "groupBoxFeedbackList";
            this.groupBoxFeedbackList.Size = new System.Drawing.Size(214, 484);
            this.groupBoxFeedbackList.TabIndex = 1;
            this.groupBoxFeedbackList.TabStop = false;
            this.groupBoxFeedbackList.Text = "Customer Feedback";
            // 
            // lblTotalFeedbacks
            // 
            this.lblTotalFeedbacks.AutoSize = true;
            this.lblTotalFeedbacks.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalFeedbacks.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalFeedbacks.Location = new System.Drawing.Point(10, 365);
            this.lblTotalFeedbacks.Name = "lblTotalFeedbacks";
            this.lblTotalFeedbacks.Size = new System.Drawing.Size(74, 13);
            this.lblTotalFeedbacks.TabIndex = 1;
            this.lblTotalFeedbacks.Text = "Total: 0 items";
            // 
            // listBoxFeedbacks
            // 
            this.listBoxFeedbacks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.listBoxFeedbacks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFeedbacks.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listBoxFeedbacks.ForeColor = System.Drawing.Color.White;
            this.listBoxFeedbacks.FormattingEnabled = true;
            this.listBoxFeedbacks.Location = new System.Drawing.Point(10, 22);
            this.listBoxFeedbacks.Name = "listBoxFeedbacks";
            this.listBoxFeedbacks.Size = new System.Drawing.Size(194, 340);
            this.listBoxFeedbacks.TabIndex = 0;
            this.listBoxFeedbacks.SelectedIndexChanged += new System.EventHandler(this.listBoxFeedbacks_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxAddFeedback);
            this.panelRight.Controls.Add(this.groupBoxFeedbackDetails);
            this.panelRight.Controls.Add(this.btnDeleteFeedback);
            this.panelRight.Controls.Add(this.groupBoxStatistics);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(3);
            this.panelRight.Size = new System.Drawing.Size(310, 490);
            this.panelRight.TabIndex = 0;
            // 
            // groupBoxAddFeedback
            // 
            this.groupBoxAddFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxAddFeedback.Controls.Add(this.ratingControl);
            this.groupBoxAddFeedback.Controls.Add(this.label9);
            this.groupBoxAddFeedback.Controls.Add(this.btnSubmitFeedback);
            this.groupBoxAddFeedback.Controls.Add(this.txtNewComment);
            this.groupBoxAddFeedback.Controls.Add(this.label7);
            this.groupBoxAddFeedback.Controls.Add(this.cmbAppointmentType);
            this.groupBoxAddFeedback.Controls.Add(this.label6);
            this.groupBoxAddFeedback.Controls.Add(this.txtNewCustomer);
            this.groupBoxAddFeedback.Controls.Add(this.label5);
            this.groupBoxAddFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAddFeedback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxAddFeedback.ForeColor = System.Drawing.Color.White;
            this.groupBoxAddFeedback.Location = new System.Drawing.Point(3, 201);
            this.groupBoxAddFeedback.Name = "groupBoxAddFeedback";
            this.groupBoxAddFeedback.Size = new System.Drawing.Size(304, 171);
            this.groupBoxAddFeedback.TabIndex = 0;
            this.groupBoxAddFeedback.TabStop = false;
            this.groupBoxAddFeedback.Text = "Submit New Feedback";
            // 
            // ratingControl
            // 
            this.ratingControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.ratingControl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ratingControl.ForeColor = System.Drawing.Color.White;
            this.ratingControl.Location = new System.Drawing.Point(130, 74);
            this.ratingControl.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratingControl.Name = "ratingControl";
            this.ratingControl.Size = new System.Drawing.Size(162, 22);
            this.ratingControl.TabIndex = 3;
            this.ratingControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(28, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Rating (1-5 stars):";
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSubmitFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitFeedback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmitFeedback.ForeColor = System.Drawing.Color.White;
            this.btnSubmitFeedback.Location = new System.Drawing.Point(145, 138);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(82, 26);
            this.btnSubmitFeedback.TabIndex = 5;
            this.btnSubmitFeedback.Text = "Submit →";
            this.btnSubmitFeedback.UseVisualStyleBackColor = false;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // txtNewComment
            // 
            this.txtNewComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtNewComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewComment.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtNewComment.ForeColor = System.Drawing.Color.White;
            this.txtNewComment.Location = new System.Drawing.Point(129, 105);
            this.txtNewComment.Multiline = true;
            this.txtNewComment.Name = "txtNewComment";
            this.txtNewComment.Size = new System.Drawing.Size(160, 31);
            this.txtNewComment.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(60, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Comment:";
            // 
            // cmbAppointmentType
            // 
            this.cmbAppointmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.cmbAppointmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAppointmentType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbAppointmentType.ForeColor = System.Drawing.Color.White;
            this.cmbAppointmentType.FormattingEnabled = true;
            this.cmbAppointmentType.Location = new System.Drawing.Point(130, 47);
            this.cmbAppointmentType.Name = "cmbAppointmentType";
            this.cmbAppointmentType.Size = new System.Drawing.Size(160, 21);
            this.cmbAppointmentType.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(23, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Appointment Type:";
            // 
            // txtNewCustomer
            // 
            this.txtNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtNewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewCustomer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtNewCustomer.ForeColor = System.Drawing.Color.White;
            this.txtNewCustomer.Location = new System.Drawing.Point(130, 19);
            this.txtNewCustomer.Name = "txtNewCustomer";
            this.txtNewCustomer.Size = new System.Drawing.Size(160, 22);
            this.txtNewCustomer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(36, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Name:";
            // 
            // groupBoxFeedbackDetails
            // 
            this.groupBoxFeedbackDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxFeedbackDetails.Controls.Add(this.txtCustomerName);
            this.groupBoxFeedbackDetails.Controls.Add(this.lblCustomerNameLabel);
            this.groupBoxFeedbackDetails.Controls.Add(this.txtTechnician);
            this.groupBoxFeedbackDetails.Controls.Add(this.label8);
            this.groupBoxFeedbackDetails.Controls.Add(this.txtDate);
            this.groupBoxFeedbackDetails.Controls.Add(this.label4);
            this.groupBoxFeedbackDetails.Controls.Add(this.txtComment);
            this.groupBoxFeedbackDetails.Controls.Add(this.label3);
            this.groupBoxFeedbackDetails.Controls.Add(this.txtRating);
            this.groupBoxFeedbackDetails.Controls.Add(this.label2);
            this.groupBoxFeedbackDetails.Controls.Add(this.txtAppointmentType);
            this.groupBoxFeedbackDetails.Controls.Add(this.label1);
            this.groupBoxFeedbackDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFeedbackDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxFeedbackDetails.ForeColor = System.Drawing.Color.White;
            this.groupBoxFeedbackDetails.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFeedbackDetails.Name = "groupBoxFeedbackDetails";
            this.groupBoxFeedbackDetails.Size = new System.Drawing.Size(304, 198);
            this.groupBoxFeedbackDetails.TabIndex = 1;
            this.groupBoxFeedbackDetails.TabStop = false;
            this.groupBoxFeedbackDetails.Text = "Selected Feedback Details";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.White;
            this.txtCustomerName.Location = new System.Drawing.Point(130, 22);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(160, 22);
            this.txtCustomerName.TabIndex = 13;
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCustomerNameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(20, 25);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(91, 13);
            this.lblCustomerNameLabel.TabIndex = 12;
            this.lblCustomerNameLabel.Text = "Customer Name:";
            // 
            // txtTechnician
            // 
            this.txtTechnician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtTechnician.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTechnician.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtTechnician.ForeColor = System.Drawing.Color.White;
            this.txtTechnician.Location = new System.Drawing.Point(129, 164);
            this.txtTechnician.Name = "txtTechnician";
            this.txtTechnician.ReadOnly = true;
            this.txtTechnician.Size = new System.Drawing.Size(160, 22);
            this.txtTechnician.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(19, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Technician:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(129, 139);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(160, 22);
            this.txtDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(19, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date:";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtComment.ForeColor = System.Drawing.Color.White;
            this.txtComment.Location = new System.Drawing.Point(130, 95);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.Size = new System.Drawing.Size(160, 39);
            this.txtComment.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comment:";
            // 
            // txtRating
            // 
            this.txtRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRating.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.txtRating.ForeColor = System.Drawing.Color.Gold;
            this.txtRating.Location = new System.Drawing.Point(130, 70);
            this.txtRating.Name = "txtRating";
            this.txtRating.ReadOnly = true;
            this.txtRating.Size = new System.Drawing.Size(160, 22);
            this.txtRating.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rating:";
            // 
            // txtAppointmentType
            // 
            this.txtAppointmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtAppointmentType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppointmentType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtAppointmentType.ForeColor = System.Drawing.Color.White;
            this.txtAppointmentType.Location = new System.Drawing.Point(130, 46);
            this.txtAppointmentType.Name = "txtAppointmentType";
            this.txtAppointmentType.ReadOnly = true;
            this.txtAppointmentType.Size = new System.Drawing.Size(160, 22);
            this.txtAppointmentType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Type:";
            // 
            // btnDeleteFeedback
            // 
            this.btnDeleteFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFeedback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteFeedback.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFeedback.Location = new System.Drawing.Point(90, 378);
            this.btnDeleteFeedback.Name = "btnDeleteFeedback";
            this.btnDeleteFeedback.Size = new System.Drawing.Size(164, 31);
            this.btnDeleteFeedback.TabIndex = 2;
            this.btnDeleteFeedback.Text = "Delete Selected Feedback";
            this.btnDeleteFeedback.UseVisualStyleBackColor = false;
            this.btnDeleteFeedback.Click += new System.EventHandler(this.btnDeleteFeedback_Click);
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxStatistics.Controls.Add(this.lblAverageStars);
            this.groupBoxStatistics.Controls.Add(this.lblAverageRating);
            this.groupBoxStatistics.Controls.Add(this.label14);
            this.groupBoxStatistics.Controls.Add(this.lblThreeStarCount);
            this.groupBoxStatistics.Controls.Add(this.label12);
            this.groupBoxStatistics.Controls.Add(this.lblFourStarCount);
            this.groupBoxStatistics.Controls.Add(this.label10);
            this.groupBoxStatistics.Controls.Add(this.lblFiveStarCount);
            this.groupBoxStatistics.Controls.Add(this.label11);
            this.groupBoxStatistics.Controls.Add(this.lblTotalFeedbacksCount);
            this.groupBoxStatistics.Controls.Add(this.label13);
            this.groupBoxStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxStatistics.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.groupBoxStatistics.ForeColor = System.Drawing.Color.White;
            this.groupBoxStatistics.Location = new System.Drawing.Point(3, 415);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(304, 72);
            this.groupBoxStatistics.TabIndex = 3;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            // 
            // lblAverageStars
            // 
            this.lblAverageStars.AutoSize = true;
            this.lblAverageStars.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAverageStars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblAverageStars.Location = new System.Drawing.Point(230, 42);
            this.lblAverageStars.Name = "lblAverageStars";
            this.lblAverageStars.Size = new System.Drawing.Size(62, 15);
            this.lblAverageStars.TabIndex = 10;
            this.lblAverageStars.Text = "★★★★★";
            // 
            // lblAverageRating
            // 
            this.lblAverageRating.AutoSize = true;
            this.lblAverageRating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAverageRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblAverageRating.Location = new System.Drawing.Point(180, 40);
            this.lblAverageRating.Name = "lblAverageRating";
            this.lblAverageRating.Size = new System.Drawing.Size(29, 19);
            this.lblAverageRating.TabIndex = 9;
            this.lblAverageRating.Text = "0.0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(100, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "Average Rating:";
            // 
            // lblThreeStarCount
            // 
            this.lblThreeStarCount.AutoSize = true;
            this.lblThreeStarCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThreeStarCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblThreeStarCount.Location = new System.Drawing.Point(275, 20);
            this.lblThreeStarCount.Name = "lblThreeStarCount";
            this.lblThreeStarCount.Size = new System.Drawing.Size(14, 15);
            this.lblThreeStarCount.TabIndex = 7;
            this.lblThreeStarCount.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(190, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "3 Stars (★★★☆☆):";
            // 
            // lblFourStarCount
            // 
            this.lblFourStarCount.AutoSize = true;
            this.lblFourStarCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFourStarCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblFourStarCount.Location = new System.Drawing.Point(165, 20);
            this.lblFourStarCount.Name = "lblFourStarCount";
            this.lblFourStarCount.Size = new System.Drawing.Size(14, 15);
            this.lblFourStarCount.TabIndex = 5;
            this.lblFourStarCount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(85, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "4 Stars (★★★★☆):";
            // 
            // lblFiveStarCount
            // 
            this.lblFiveStarCount.AutoSize = true;
            this.lblFiveStarCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiveStarCount.ForeColor = System.Drawing.Color.LightGreen;
            this.lblFiveStarCount.Location = new System.Drawing.Point(60, 20);
            this.lblFiveStarCount.Name = "lblFiveStarCount";
            this.lblFiveStarCount.Size = new System.Drawing.Size(14, 15);
            this.lblFiveStarCount.TabIndex = 3;
            this.lblFiveStarCount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "★★★★★:";
            // 
            // lblTotalFeedbacksCount
            // 
            this.lblTotalFeedbacksCount.AutoSize = true;
            this.lblTotalFeedbacksCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFeedbacksCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTotalFeedbacksCount.Location = new System.Drawing.Point(110, 40);
            this.lblTotalFeedbacksCount.Name = "lblTotalFeedbacksCount";
            this.lblTotalFeedbacksCount.Size = new System.Drawing.Size(17, 19);
            this.lblTotalFeedbacksCount.TabIndex = 1;
            this.lblTotalFeedbacksCount.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label13.ForeColor = System.Drawing.Color.LightGray;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total Feedbacks:";
            // 
            // ucServiceFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.splitContainer);
            this.Name = "ucServiceFeedback";
            this.Size = new System.Drawing.Size(534, 490);
            this.Load += new System.EventHandler(this.ucServiceFeedback_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBoxFeedbackList.ResumeLayout(false);
            this.groupBoxFeedbackList.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.groupBoxAddFeedback.ResumeLayout(false);
            this.groupBoxAddFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl)).EndInit();
            this.groupBoxFeedbackDetails.ResumeLayout(false);
            this.groupBoxFeedbackDetails.PerformLayout();
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        // Control declarations
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.ComboBox cmbRatingFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBoxFeedbackList;
        private System.Windows.Forms.Label lblTotalFeedbacks;
        private System.Windows.Forms.ListBox listBoxFeedbacks;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxAddFeedback;
        private System.Windows.Forms.NumericUpDown ratingControl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubmitFeedback;
        private System.Windows.Forms.TextBox txtNewComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAppointmentType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxFeedbackDetails;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.TextBox txtTechnician;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAppointmentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteFeedback;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Label lblAverageStars;
        private System.Windows.Forms.Label lblAverageRating;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblThreeStarCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFourStarCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFiveStarCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalFeedbacksCount;
        private System.Windows.Forms.Label label13;
    }
}