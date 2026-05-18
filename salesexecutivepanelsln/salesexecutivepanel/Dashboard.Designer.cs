namespace salesexecutivepanel
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalcustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotalcars = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcarsordered = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmostavailablebrand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmostorderedbrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtexpensivemodelavailable = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcheapestmodelavailable = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtaverageprice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Red;
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(570, 1);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(30, 23);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(226, 495);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 31);
            this.btnshow.TabIndex = 2;
            this.btnshow.Text = "Fetch";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. of customers:";
            // 
            // txttotalcustomer
            // 
            this.txttotalcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcustomer.Location = new System.Drawing.Point(288, 120);
            this.txttotalcustomer.Name = "txttotalcustomer";
            this.txttotalcustomer.Size = new System.Drawing.Size(109, 24);
            this.txttotalcustomer.TabIndex = 4;
            this.txttotalcustomer.TextChanged += new System.EventHandler(this.txttotalcustomer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cars available:";
            // 
            // txttotalcars
            // 
            this.txttotalcars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcars.Location = new System.Drawing.Point(288, 165);
            this.txttotalcars.Name = "txttotalcars";
            this.txttotalcars.Size = new System.Drawing.Size(109, 24);
            this.txttotalcars.TabIndex = 6;
            this.txttotalcars.TextChanged += new System.EventHandler(this.txttotalcars_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. of cars ordered:";
            // 
            // txtcarsordered
            // 
            this.txtcarsordered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarsordered.Location = new System.Drawing.Point(288, 210);
            this.txtcarsordered.Name = "txtcarsordered";
            this.txtcarsordered.Size = new System.Drawing.Size(108, 24);
            this.txtcarsordered.TabIndex = 8;
            this.txtcarsordered.TextChanged += new System.EventHandler(this.txtcarsordered_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Most available brand:";
            // 
            // txtmostavailablebrand
            // 
            this.txtmostavailablebrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmostavailablebrand.Location = new System.Drawing.Point(288, 257);
            this.txtmostavailablebrand.Name = "txtmostavailablebrand";
            this.txtmostavailablebrand.Size = new System.Drawing.Size(108, 24);
            this.txtmostavailablebrand.TabIndex = 10;
            this.txtmostavailablebrand.TextChanged += new System.EventHandler(this.txtmostavailablebrand_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Most ordered brand:";
            // 
            // txtmostorderedbrand
            // 
            this.txtmostorderedbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmostorderedbrand.Location = new System.Drawing.Point(288, 299);
            this.txtmostorderedbrand.Name = "txtmostorderedbrand";
            this.txtmostorderedbrand.Size = new System.Drawing.Size(109, 24);
            this.txtmostorderedbrand.TabIndex = 12;
            this.txtmostorderedbrand.TextChanged += new System.EventHandler(this.txtmostorderedbrand_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(85, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Expensive model available:";
            // 
            // txtexpensivemodelavailable
            // 
            this.txtexpensivemodelavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexpensivemodelavailable.Location = new System.Drawing.Point(288, 345);
            this.txtexpensivemodelavailable.Name = "txtexpensivemodelavailable";
            this.txtexpensivemodelavailable.Size = new System.Drawing.Size(109, 24);
            this.txtexpensivemodelavailable.TabIndex = 14;
            this.txtexpensivemodelavailable.TextChanged += new System.EventHandler(this.txtexpensivemodelavailable_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(85, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cheapest model available:";
            // 
            // txtcheapestmodelavailable
            // 
            this.txtcheapestmodelavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcheapestmodelavailable.Location = new System.Drawing.Point(288, 389);
            this.txtcheapestmodelavailable.Name = "txtcheapestmodelavailable";
            this.txtcheapestmodelavailable.Size = new System.Drawing.Size(109, 24);
            this.txtcheapestmodelavailable.TabIndex = 16;
            this.txtcheapestmodelavailable.TextChanged += new System.EventHandler(this.txtcheapestmodelavailable_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(85, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Average price of cars:";
            // 
            // txtaverageprice
            // 
            this.txtaverageprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaverageprice.Location = new System.Drawing.Point(288, 434);
            this.txtaverageprice.Name = "txtaverageprice";
            this.txtaverageprice.Size = new System.Drawing.Size(109, 24);
            this.txtaverageprice.TabIndex = 18;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(599, 564);
            this.Controls.Add(this.txtaverageprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcheapestmodelavailable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtexpensivemodelavailable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmostorderedbrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmostavailablebrand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcarsordered);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotalcars);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotalcustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(218, 0);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotalcustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotalcars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcarsordered;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmostavailablebrand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmostorderedbrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtexpensivemodelavailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcheapestmodelavailable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtaverageprice;
    }
}