namespace Service_Panel
{
    partial class ucAppointmentManagement
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
            this.groupBoxAppointments = new System.Windows.Forms.GroupBox();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBoxReschedule = new System.Windows.Forms.GroupBox();
            this.txtRescheduleTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRescheduleDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCancellation = new System.Windows.Forms.GroupBox();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCancellationReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReschedule = new System.Windows.Forms.Button();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.lblCompletedCount = new System.Windows.Forms.Label();
            this.lblCompletedCountValue = new System.Windows.Forms.Label();
            this.lblCancelledCount = new System.Windows.Forms.Label();
            this.lblCancelledCountValue = new System.Windows.Forms.Label();
            this.lblScheduledCount = new System.Windows.Forms.Label();
            this.lblScheduledCountValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxAppointments.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxReschedule.SuspendLayout();
            this.groupBoxCancellation.SuspendLayout();
            this.panelButtons.SuspendLayout();
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
            this.splitContainer.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxFilters);
            this.panelLeft.Controls.Add(this.groupBoxAppointments);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(220, 500);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxFilters.Controls.Add(this.cmbStatusFilter);
            this.groupBoxFilters.Controls.Add(this.lblFilter);
            this.groupBoxFilters.Controls.Add(this.btnRefresh);
            this.groupBoxFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilters.ForeColor = System.Drawing.Color.White;
            this.groupBoxFilters.Location = new System.Drawing.Point(6, 6);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(208, 80);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
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
            this.btnRefresh.Location = new System.Drawing.Point(130, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 25);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBoxAppointments
            // 
            this.groupBoxAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxAppointments.Controls.Add(this.lblTotalCount);
            this.groupBoxAppointments.Controls.Add(this.listBoxAppointments);
            this.groupBoxAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAppointments.ForeColor = System.Drawing.Color.White;
            this.groupBoxAppointments.Location = new System.Drawing.Point(6, 92);
            this.groupBoxAppointments.Name = "groupBoxAppointments";
            this.groupBoxAppointments.Size = new System.Drawing.Size(208, 400);
            this.groupBoxAppointments.TabIndex = 1;
            this.groupBoxAppointments.TabStop = false;
            this.groupBoxAppointments.Text = "Appointments";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalCount.Location = new System.Drawing.Point(6, 380);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(77, 15);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "Total Jobs:";
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.listBoxAppointments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAppointments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBoxAppointments.ForeColor = System.Drawing.Color.White;
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.ItemHeight = 15;
            this.listBoxAppointments.Location = new System.Drawing.Point(6, 19);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(196, 347);
            this.listBoxAppointments.TabIndex = 0;
            this.listBoxAppointments.SelectedIndexChanged += new System.EventHandler(this.listBoxAppointments_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxDetails);
            this.panelRight.Controls.Add(this.groupBoxReschedule);
            this.panelRight.Controls.Add(this.groupBoxCancellation);
            this.panelRight.Controls.Add(this.panelButtons);
            this.panelRight.Controls.Add(this.groupBoxStatistics);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(336, 500);
            this.panelRight.TabIndex = 0;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxDetails.Controls.Add(this.txtStatus);
            this.groupBoxDetails.Controls.Add(this.lblStatus);
            this.groupBoxDetails.Controls.Add(this.txtServiceType);
            this.groupBoxDetails.Controls.Add(this.lblServiceType);
            this.groupBoxDetails.Controls.Add(this.txtPhone);
            this.groupBoxDetails.Controls.Add(this.lblPhone);
            this.groupBoxDetails.Controls.Add(this.txtCustomerName);
            this.groupBoxDetails.Controls.Add(this.lblCustomerName);
            this.groupBoxDetails.Controls.Add(this.dtpDate);
            this.groupBoxDetails.Controls.Add(this.lblDate);
            this.groupBoxDetails.Controls.Add(this.txtTime);
            this.groupBoxDetails.Controls.Add(this.lblTime);
            this.groupBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetails.ForeColor = System.Drawing.Color.White;
            this.groupBoxDetails.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(324, 220);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Appointment Details";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtStatus.ForeColor = System.Drawing.Color.White;
            this.txtStatus.Location = new System.Drawing.Point(120, 185);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(190, 21);
            this.txtStatus.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblStatus.Location = new System.Drawing.Point(10, 188);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // txtServiceType
            // 
            this.txtServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtServiceType.ForeColor = System.Drawing.Color.White;
            this.txtServiceType.Location = new System.Drawing.Point(120, 100);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.ReadOnly = true;
            this.txtServiceType.Size = new System.Drawing.Size(190, 21);
            this.txtServiceType.TabIndex = 13;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.ForeColor = System.Drawing.Color.LightGray;
            this.lblServiceType.Location = new System.Drawing.Point(10, 103);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(92, 15);
            this.lblServiceType.TabIndex = 12;
            this.lblServiceType.Text = "Service Type:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(120, 55);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(190, 21);
            this.txtPhone.TabIndex = 11;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.LightGray;
            this.lblPhone.Location = new System.Drawing.Point(10, 58);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 15);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtCustomerName.ForeColor = System.Drawing.Color.White;
            this.txtCustomerName.Location = new System.Drawing.Point(120, 25);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(190, 21);
            this.txtCustomerName.TabIndex = 9;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.ForeColor = System.Drawing.Color.LightGray;
            this.lblCustomerName.Location = new System.Drawing.Point(10, 28);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(114, 15);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(120, 130);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(190, 21);
            this.dtpDate.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.LightGray;
            this.lblDate.Location = new System.Drawing.Point(10, 133);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(120, 157);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(190, 21);
            this.txtTime.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblTime.Location = new System.Drawing.Point(10, 160);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 15);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // groupBoxReschedule
            // 
            this.groupBoxReschedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxReschedule.Controls.Add(this.txtRescheduleTime);
            this.groupBoxReschedule.Controls.Add(this.label3);
            this.groupBoxReschedule.Controls.Add(this.txtRescheduleDate);
            this.groupBoxReschedule.Controls.Add(this.label2);
            this.groupBoxReschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReschedule.ForeColor = System.Drawing.Color.White;
            this.groupBoxReschedule.Location = new System.Drawing.Point(6, 232);
            this.groupBoxReschedule.Name = "groupBoxReschedule";
            this.groupBoxReschedule.Size = new System.Drawing.Size(324, 70);
            this.groupBoxReschedule.TabIndex = 1;
            this.groupBoxReschedule.TabStop = false;
            this.groupBoxReschedule.Text = "Reschedule Information";
            // 
            // txtRescheduleTime
            // 
            this.txtRescheduleTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtRescheduleTime.ForeColor = System.Drawing.Color.White;
            this.txtRescheduleTime.Location = new System.Drawing.Point(120, 40);
            this.txtRescheduleTime.Name = "txtRescheduleTime";
            this.txtRescheduleTime.ReadOnly = true;
            this.txtRescheduleTime.Size = new System.Drawing.Size(190, 21);
            this.txtRescheduleTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(10, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            // 
            // txtRescheduleDate
            // 
            this.txtRescheduleDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtRescheduleDate.ForeColor = System.Drawing.Color.White;
            this.txtRescheduleDate.Location = new System.Drawing.Point(120, 15);
            this.txtRescheduleDate.Name = "txtRescheduleDate";
            this.txtRescheduleDate.ReadOnly = true;
            this.txtRescheduleDate.Size = new System.Drawing.Size(190, 21);
            this.txtRescheduleDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date:";
            // 
            // groupBoxCancellation
            // 
            this.groupBoxCancellation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxCancellation.Controls.Add(this.txtUpdatedBy);
            this.groupBoxCancellation.Controls.Add(this.label5);
            this.groupBoxCancellation.Controls.Add(this.txtCancellationReason);
            this.groupBoxCancellation.Controls.Add(this.label4);
            this.groupBoxCancellation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCancellation.ForeColor = System.Drawing.Color.White;
            this.groupBoxCancellation.Location = new System.Drawing.Point(6, 308);
            this.groupBoxCancellation.Name = "groupBoxCancellation";
            this.groupBoxCancellation.Size = new System.Drawing.Size(324, 70);
            this.groupBoxCancellation.TabIndex = 2;
            this.groupBoxCancellation.TabStop = false;
            this.groupBoxCancellation.Text = "Cancellation Information";
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtUpdatedBy.ForeColor = System.Drawing.Color.White;
            this.txtUpdatedBy.Location = new System.Drawing.Point(120, 40);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.ReadOnly = true;
            this.txtUpdatedBy.Size = new System.Drawing.Size(190, 21);
            this.txtUpdatedBy.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(10, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Updated By:";
            // 
            // txtCancellationReason
            // 
            this.txtCancellationReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtCancellationReason.ForeColor = System.Drawing.Color.White;
            this.txtCancellationReason.Location = new System.Drawing.Point(120, 15);
            this.txtCancellationReason.Name = "txtCancellationReason";
            this.txtCancellationReason.ReadOnly = true;
            this.txtCancellationReason.Size = new System.Drawing.Size(190, 21);
            this.txtCancellationReason.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cancellation Reason:";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Controls.Add(this.btnReschedule);
            this.panelButtons.Location = new System.Drawing.Point(6, 384);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(324, 40);
            this.panelButtons.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(170, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel Appointment";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReschedule
            // 
            this.btnReschedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReschedule.Enabled = false;
            this.btnReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReschedule.ForeColor = System.Drawing.Color.White;
            this.btnReschedule.Location = new System.Drawing.Point(15, 5);
            this.btnReschedule.Name = "btnReschedule";
            this.btnReschedule.Size = new System.Drawing.Size(140, 30);
            this.btnReschedule.TabIndex = 0;
            this.btnReschedule.Text = "Reschedule";
            this.btnReschedule.UseVisualStyleBackColor = false;
            this.btnReschedule.Click += new System.EventHandler(this.btnReschedule_Click);
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxStatistics.Controls.Add(this.lblCompletedCount);
            this.groupBoxStatistics.Controls.Add(this.lblCompletedCountValue);
            this.groupBoxStatistics.Controls.Add(this.lblCancelledCount);
            this.groupBoxStatistics.Controls.Add(this.lblCancelledCountValue);
            this.groupBoxStatistics.Controls.Add(this.lblScheduledCount);
            this.groupBoxStatistics.Controls.Add(this.lblScheduledCountValue);
            this.groupBoxStatistics.ForeColor = System.Drawing.Color.White;
            this.groupBoxStatistics.Location = new System.Drawing.Point(6, 430);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(324, 62);
            this.groupBoxStatistics.TabIndex = 4;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            // 
            // lblCompletedCount
            // 
            this.lblCompletedCount.AutoSize = true;
            this.lblCompletedCount.ForeColor = System.Drawing.Color.LightGray;
            this.lblCompletedCount.Location = new System.Drawing.Point(230, 40);
            this.lblCompletedCount.Name = "lblCompletedCount";
            this.lblCompletedCount.Size = new System.Drawing.Size(60, 13);
            this.lblCompletedCount.TabIndex = 5;
            this.lblCompletedCount.Text = "Completed:";
            // 
            // lblCompletedCountValue
            // 
            this.lblCompletedCountValue.AutoSize = true;
            this.lblCompletedCountValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompletedCountValue.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCompletedCountValue.Location = new System.Drawing.Point(290, 38);
            this.lblCompletedCountValue.Name = "lblCompletedCountValue";
            this.lblCompletedCountValue.Size = new System.Drawing.Size(17, 19);
            this.lblCompletedCountValue.TabIndex = 4;
            this.lblCompletedCountValue.Text = "0";
            // 
            // lblCancelledCount
            // 
            this.lblCancelledCount.AutoSize = true;
            this.lblCancelledCount.ForeColor = System.Drawing.Color.LightGray;
            this.lblCancelledCount.Location = new System.Drawing.Point(120, 40);
            this.lblCancelledCount.Name = "lblCancelledCount";
            this.lblCancelledCount.Size = new System.Drawing.Size(57, 13);
            this.lblCancelledCount.TabIndex = 3;
            this.lblCancelledCount.Text = "Cancelled:";
            // 
            // lblCancelledCountValue
            // 
            this.lblCancelledCountValue.AutoSize = true;
            this.lblCancelledCountValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCancelledCountValue.ForeColor = System.Drawing.Color.Red;
            this.lblCancelledCountValue.Location = new System.Drawing.Point(185, 38);
            this.lblCancelledCountValue.Name = "lblCancelledCountValue";
            this.lblCancelledCountValue.Size = new System.Drawing.Size(17, 19);
            this.lblCancelledCountValue.TabIndex = 2;
            this.lblCancelledCountValue.Text = "0";
            // 
            // lblScheduledCount
            // 
            this.lblScheduledCount.AutoSize = true;
            this.lblScheduledCount.ForeColor = System.Drawing.Color.LightGray;
            this.lblScheduledCount.Location = new System.Drawing.Point(10, 40);
            this.lblScheduledCount.Name = "lblScheduledCount";
            this.lblScheduledCount.Size = new System.Drawing.Size(61, 13);
            this.lblScheduledCount.TabIndex = 1;
            this.lblScheduledCount.Text = "Scheduled:";
            // 
            // lblScheduledCountValue
            // 
            this.lblScheduledCountValue.AutoSize = true;
            this.lblScheduledCountValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblScheduledCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblScheduledCountValue.Location = new System.Drawing.Point(75, 38);
            this.lblScheduledCountValue.Name = "lblScheduledCountValue";
            this.lblScheduledCountValue.Size = new System.Drawing.Size(17, 19);
            this.lblScheduledCountValue.TabIndex = 0;
            this.lblScheduledCountValue.Text = "0";
            // 
            // ucAppointmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.splitContainer);
            this.Name = "ucAppointmentManagement";
            this.Size = new System.Drawing.Size(560, 500);
            this.Load += new System.EventHandler(this.ucAppointmentManagement_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBoxAppointments.ResumeLayout(false);
            this.groupBoxAppointments.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxReschedule.ResumeLayout(false);
            this.groupBoxReschedule.PerformLayout();
            this.groupBoxCancellation.ResumeLayout(false);
            this.groupBoxCancellation.PerformLayout();
            this.panelButtons.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBoxAppointments;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBoxReschedule;
        private System.Windows.Forms.TextBox txtRescheduleTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRescheduleDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCancellation;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCancellationReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReschedule;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Label lblCompletedCount;
        private System.Windows.Forms.Label lblCompletedCountValue;
        private System.Windows.Forms.Label lblCancelledCount;
        private System.Windows.Forms.Label lblCancelledCountValue;
        private System.Windows.Forms.Label lblScheduledCount;
        private System.Windows.Forms.Label lblScheduledCountValue;
    }
}