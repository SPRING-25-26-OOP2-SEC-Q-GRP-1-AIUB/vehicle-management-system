namespace Service_Panel
{
    partial class ucServiceTracking
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
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.groupBoxJobs = new System.Windows.Forms.GroupBox();
            this.lblTotalJobs = new System.Windows.Forms.Label();
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDurationTitle = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.lblCompletedCountValue = new System.Windows.Forms.Label();
            this.lblInProgressCount = new System.Windows.Forms.Label();
            this.lblInProgressCountValue = new System.Windows.Forms.Label();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.lblPendingCountValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxJobs.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
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
            this.splitContainer.Size = new System.Drawing.Size(560, 500);
            this.splitContainer.SplitterDistance = 220;
            this.splitContainer.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxFilters);
            this.panelLeft.Controls.Add(this.groupBoxJobs);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(220, 500);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxFilters.Controls.Add(this.cmbStatusFilter);
            this.groupBoxFilters.Controls.Add(this.lblFilter);
            this.groupBoxFilters.Controls.Add(this.btnRefresh);
            this.groupBoxFilters.Controls.Add(this.btnAddService);
            this.groupBoxFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilters.ForeColor = System.Drawing.Color.White;
            this.groupBoxFilters.Location = new System.Drawing.Point(6, 6);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(208, 100);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Controls";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.ForeColor = System.Drawing.Color.White;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(50, 22);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(150, 23);
            this.cmbStatusFilter.TabIndex = 3;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.ForeColor = System.Drawing.Color.LightGray;
            this.lblFilter.Location = new System.Drawing.Point(6, 25);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(44, 15);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(110, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(8, 55);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(90, 30);
            this.btnAddService.TabIndex = 0;
            this.btnAddService.Text = "+ Add Service";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // groupBoxJobs
            // 
            this.groupBoxJobs.Controls.Add(this.lblTotalJobs);
            this.groupBoxJobs.Controls.Add(this.listBoxServices);
            this.groupBoxJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxJobs.ForeColor = System.Drawing.Color.White;
            this.groupBoxJobs.Location = new System.Drawing.Point(6, 112);
            this.groupBoxJobs.Name = "groupBoxJobs";
            this.groupBoxJobs.Size = new System.Drawing.Size(208, 380);
            this.groupBoxJobs.TabIndex = 1;
            this.groupBoxJobs.TabStop = false;
            this.groupBoxJobs.Text = "Service Jobs";
            // 
            // lblTotalJobs
            // 
            this.lblTotalJobs.AutoSize = true;
            this.lblTotalJobs.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalJobs.Location = new System.Drawing.Point(6, 360);
            this.lblTotalJobs.Name = "lblTotalJobs";
            this.lblTotalJobs.Size = new System.Drawing.Size(77, 15);
            this.lblTotalJobs.TabIndex = 1;
            this.lblTotalJobs.Text = "Total Jobs:";
            // 
            // listBoxServices
            // 
            this.listBoxServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.listBoxServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxServices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBoxServices.ForeColor = System.Drawing.Color.White;
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.ItemHeight = 15;
            this.listBoxServices.Location = new System.Drawing.Point(6, 19);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(196, 332);
            this.listBoxServices.TabIndex = 0;
            this.listBoxServices.SelectedIndexChanged += new System.EventHandler(this.listBoxServices_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxDetails);
            this.panelRight.Controls.Add(this.groupBoxStatistics);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(336, 500);
            this.panelRight.TabIndex = 0;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxDetails.Controls.Add(this.lblTimer);
            this.groupBoxDetails.Controls.Add(this.lblDuration);
            this.groupBoxDetails.Controls.Add(this.lblDurationTitle);
            this.groupBoxDetails.Controls.Add(this.txtEndTime);
            this.groupBoxDetails.Controls.Add(this.label7);
            this.groupBoxDetails.Controls.Add(this.txtStartTime);
            this.groupBoxDetails.Controls.Add(this.label5);
            this.groupBoxDetails.Controls.Add(this.cmbStatus);
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.Controls.Add(this.txtVehicleModel);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetails.ForeColor = System.Drawing.Color.White;
            this.groupBoxDetails.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(324, 257);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Job Details";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTimer.Location = new System.Drawing.Point(111, 161);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(61, 25);
            this.lblTimer.TabIndex = 24;
            this.lblTimer.Text = "00:00";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblDuration.Location = new System.Drawing.Point(111, 136);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(25, 19);
            this.lblDuration.TabIndex = 22;
            this.lblDuration.Text = "0h";
            // 
            // lblDurationTitle
            // 
            this.lblDurationTitle.AutoSize = true;
            this.lblDurationTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblDurationTitle.Location = new System.Drawing.Point(39, 136);
            this.lblDurationTitle.Name = "lblDurationTitle";
            this.lblDurationTitle.Size = new System.Drawing.Size(66, 15);
            this.lblDurationTitle.TabIndex = 23;
            this.lblDurationTitle.Text = "Duration:";
            // 
            // txtEndTime
            // 
            this.txtEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtEndTime.ForeColor = System.Drawing.Color.White;
            this.txtEndTime.Location = new System.Drawing.Point(109, 103);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.ReadOnly = true;
            this.txtEndTime.Size = new System.Drawing.Size(209, 21);
            this.txtEndTime.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(33, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "End Time:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtStartTime.ForeColor = System.Drawing.Color.White;
            this.txtStartTime.Location = new System.Drawing.Point(109, 72);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            this.txtStartTime.Size = new System.Drawing.Size(209, 21);
            this.txtStartTime.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(33, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Start Time:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(109, 42);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(209, 23);
            this.cmbStatus.TabIndex = 13;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(59, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status:";
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtVehicleModel.ForeColor = System.Drawing.Color.White;
            this.txtVehicleModel.Location = new System.Drawing.Point(109, 15);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.ReadOnly = true;
            this.txtVehicleModel.Size = new System.Drawing.Size(209, 21);
            this.txtVehicleModel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vehicle Model:";
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxStatistics.Controls.Add(this.lblCompletedCount);
            this.groupBoxStatistics.Controls.Add(this.lblCompletedCountValue);
            this.groupBoxStatistics.Controls.Add(this.lblInProgressCount);
            this.groupBoxStatistics.Controls.Add(this.lblInProgressCountValue);
            this.groupBoxStatistics.Controls.Add(this.lblPendingCount);
            this.groupBoxStatistics.Controls.Add(this.lblPendingCountValue);
            this.groupBoxStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatistics.ForeColor = System.Drawing.Color.White;
            this.groupBoxStatistics.Location = new System.Drawing.Point(6, 269);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(324, 223);
            this.groupBoxStatistics.TabIndex = 1;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            // 
            // lblCompletedCount
            // 
            this.lblCompletedCount.AutoSize = true;
            this.lblCompletedCount.ForeColor = System.Drawing.Color.LightGray;
            this.lblCompletedCount.Location = new System.Drawing.Point(170, 55);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Size = new System.Drawing.Size(70, 13);
            this.lblCompletedCount.TabIndex = 4;
            this.lblCompletedCount.Text = "Completed:";
            // 
            // lblCompletedCountValue
            // 
            this.lblCompletedCountValue.AutoSize = true;
            this.lblCompletedCountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompletedCountValue.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCompletedCountValue.Location = new System.Drawing.Point(240, 50);
            this.lblCompletedCountValue.Name = "lblCompletedCountValue";
            this.lblCompletedCountValue.Size = new System.Drawing.Size(19, 21);
            this.lblCompletedCountValue.TabIndex = 5;
            this.lblCompletedCountValue.Text = "0";
            // 
            // lblInProgressCount
            // 
            this.lblInProgressCount.AutoSize = true;
            this.lblInProgressCount.ForeColor = System.Drawing.Color.LightGray;
            this.lblInProgressCount.Location = new System.Drawing.Point(10, 55);
            this.lblInProgressCount.Name = "lblInProgressCount";
            this.lblInProgressCount.Size = new System.Drawing.Size(75, 13);
            this.lblInProgressCount.TabIndex = 2;
            this.lblInProgressCount.Text = "In Progress:";
            // 
            // lblInProgressCountValue
            // 
            this.lblInProgressCountValue.AutoSize = true;
            this.lblInProgressCountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInProgressCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblInProgressCountValue.Location = new System.Drawing.Point(100, 50);
            this.lblInProgressCountValue.Name = "lblInProgressCountValue";
            this.lblInProgressCountValue.Size = new System.Drawing.Size(19, 21);
            this.lblInProgressCountValue.TabIndex = 3;
            this.lblInProgressCountValue.Text = "0";
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.ForeColor = System.Drawing.Color.LightGray;
            this.lblPendingCount.Location = new System.Drawing.Point(10, 25);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(57, 13);
            this.lblPendingCount.TabIndex = 0;
            this.lblPendingCount.Text = "Pending:";
            // 
            // lblPendingCountValue
            // 
            this.lblPendingCountValue.AutoSize = true;
            this.lblPendingCountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPendingCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblPendingCountValue.Location = new System.Drawing.Point(100, 20);
            this.lblPendingCountValue.Name = "lblPendingCountValue";
            this.lblPendingCountValue.Size = new System.Drawing.Size(19, 21);
            this.lblPendingCountValue.TabIndex = 1;
            this.lblPendingCountValue.Text = "0";
            // 
            // ucServiceTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.splitContainer);
            this.Name = "ucServiceTracking";
            this.Size = new System.Drawing.Size(560, 500);
            this.Load += new System.EventHandler(this.ucServiceTracking_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBoxJobs.ResumeLayout(false);
            this.groupBoxJobs.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.GroupBox groupBoxJobs;
        private System.Windows.Forms.Label lblTotalJobs;
        private System.Windows.Forms.ListBox listBoxServices;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDurationTitle;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Label lblCompletedCount;
        private System.Windows.Forms.Label lblCompletedCountValue;
        private System.Windows.Forms.Label lblInProgressCount;
        private System.Windows.Forms.Label lblInProgressCountValue;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblPendingCountValue;
    }
}