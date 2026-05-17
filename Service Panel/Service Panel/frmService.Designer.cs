namespace Service_Panel
{
    partial class ucServiceType
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
            this.btnBackToCategories = new System.Windows.Forms.Button();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelServices = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnBackToCategories
            // 
            this.btnBackToCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.btnBackToCategories.FlatAppearance.BorderSize = 0;
            this.btnBackToCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToCategories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBackToCategories.Location = new System.Drawing.Point(10, 90);
            this.btnBackToCategories.Name = "btnBackToCategories";
            this.btnBackToCategories.Size = new System.Drawing.Size(120, 30);
            this.btnBackToCategories.TabIndex = 3;
            this.btnBackToCategories.Text = "← Back to Categories";
            this.btnBackToCategories.UseVisualStyleBackColor = false;
            this.btnBackToCategories.Visible = false;
            this.btnBackToCategories.Click += new System.EventHandler(this.btnBackToCategories_Click);
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.AutoSize = true;
            this.lblSelectedCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedCategory.ForeColor = System.Drawing.Color.White;
            this.lblSelectedCategory.Location = new System.Drawing.Point(140, 92);
            this.lblSelectedCategory.Name = "lblSelectedCategory";
            this.lblSelectedCategory.Size = new System.Drawing.Size(0, 21);
            this.lblSelectedCategory.TabIndex = 4;
            this.lblSelectedCategory.Visible = false;
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.AutoScroll = true;
            this.flowLayoutPanelCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(10, 90);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(540, 400);
            this.flowLayoutPanelCategories.TabIndex = 1;
            // 
            // flowLayoutPanelServices
            // 
            this.flowLayoutPanelServices.AutoScroll = true;
            this.flowLayoutPanelServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.flowLayoutPanelServices.Location = new System.Drawing.Point(10, 90);
            this.flowLayoutPanelServices.Name = "flowLayoutPanelServices";
            this.flowLayoutPanelServices.Size = new System.Drawing.Size(540, 370);
            this.flowLayoutPanelServices.TabIndex = 2;
            this.flowLayoutPanelServices.Visible = false;
            // 
            // ucServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.lblSelectedCategory);
            this.Controls.Add(this.btnBackToCategories);
            this.Controls.Add(this.flowLayoutPanelServices);
            this.Controls.Add(this.flowLayoutPanelCategories);
            this.Name = "ucServiceType";
            this.Size = new System.Drawing.Size(560, 500);
            this.Load += new System.EventHandler(this.ucServiceType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnBackToCategories;
        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelServices;
    }
}