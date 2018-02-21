namespace SalaryCalculator
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtResultYearlySalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserHourlyRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.txtUserHoursPerWeekInput = new System.Windows.Forms.TextBox();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.lblAfterTaxes = new System.Windows.Forms.Label();
            this.txtResultTax = new System.Windows.Forms.TextBox();
            this.txtResultAfterTaxes = new System.Windows.Forms.TextBox();
            this.lblBeforeTaxes = new System.Windows.Forms.Label();
            this.txtResultTaxRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultYearlySalary
            // 
            this.txtResultYearlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultYearlySalary.Location = new System.Drawing.Point(471, 132);
            this.txtResultYearlySalary.Name = "txtResultYearlySalary";
            this.txtResultYearlySalary.ReadOnly = true;
            this.txtResultYearlySalary.Size = new System.Drawing.Size(133, 29);
            this.txtResultYearlySalary.TabIndex = 0;
            this.txtResultYearlySalary.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "This app calculates salaries!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yearly";
            // 
            // txtUserHourlyRate
            // 
            this.txtUserHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserHourlyRate.Location = new System.Drawing.Point(162, 132);
            this.txtUserHourlyRate.Name = "txtUserHourlyRate";
            this.txtUserHourlyRate.Size = new System.Drawing.Size(100, 29);
            this.txtUserHourlyRate.TabIndex = 1;
            this.txtUserHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHourlyRate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hourly Rate";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(162, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 34);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursPerWeek.Location = new System.Drawing.Point(7, 173);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(149, 24);
            this.lblHoursPerWeek.TabIndex = 7;
            this.lblHoursPerWeek.Text = "Hours Per Week";
            // 
            // txtUserHoursPerWeekInput
            // 
            this.txtUserHoursPerWeekInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserHoursPerWeekInput.Location = new System.Drawing.Point(162, 167);
            this.txtUserHoursPerWeekInput.Name = "txtUserHoursPerWeekInput";
            this.txtUserHoursPerWeekInput.Size = new System.Drawing.Size(100, 29);
            this.txtUserHoursPerWeekInput.TabIndex = 2;
            this.txtUserHoursPerWeekInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserHoursPerWeekInput_KeyPress);
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxes.Location = new System.Drawing.Point(403, 205);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(62, 24);
            this.lblTaxes.TabIndex = 3;
            this.lblTaxes.Text = "Taxes";
            // 
            // lblAfterTaxes
            // 
            this.lblAfterTaxes.AutoSize = true;
            this.lblAfterTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfterTaxes.Location = new System.Drawing.Point(360, 240);
            this.lblAfterTaxes.Name = "lblAfterTaxes";
            this.lblAfterTaxes.Size = new System.Drawing.Size(105, 24);
            this.lblAfterTaxes.TabIndex = 3;
            this.lblAfterTaxes.Text = "After Taxes";
            // 
            // txtResultTax
            // 
            this.txtResultTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultTax.Location = new System.Drawing.Point(471, 202);
            this.txtResultTax.Name = "txtResultTax";
            this.txtResultTax.ReadOnly = true;
            this.txtResultTax.Size = new System.Drawing.Size(133, 29);
            this.txtResultTax.TabIndex = 0;
            this.txtResultTax.TabStop = false;
            // 
            // txtResultAfterTaxes
            // 
            this.txtResultAfterTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultAfterTaxes.Location = new System.Drawing.Point(471, 237);
            this.txtResultAfterTaxes.Name = "txtResultAfterTaxes";
            this.txtResultAfterTaxes.ReadOnly = true;
            this.txtResultAfterTaxes.Size = new System.Drawing.Size(133, 29);
            this.txtResultAfterTaxes.TabIndex = 0;
            this.txtResultAfterTaxes.TabStop = false;
            // 
            // lblBeforeTaxes
            // 
            this.lblBeforeTaxes.AutoSize = true;
            this.lblBeforeTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeforeTaxes.Location = new System.Drawing.Point(343, 135);
            this.lblBeforeTaxes.Name = "lblBeforeTaxes";
            this.lblBeforeTaxes.Size = new System.Drawing.Size(122, 24);
            this.lblBeforeTaxes.TabIndex = 3;
            this.lblBeforeTaxes.Text = "Before Taxes";
            // 
            // txtResultTaxRate
            // 
            this.txtResultTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultTaxRate.Location = new System.Drawing.Point(471, 167);
            this.txtResultTaxRate.Name = "txtResultTaxRate";
            this.txtResultTaxRate.ReadOnly = true;
            this.txtResultTaxRate.Size = new System.Drawing.Size(133, 29);
            this.txtResultTaxRate.TabIndex = 0;
            this.txtResultTaxRate.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tax Rate";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 459);
            this.Controls.Add(this.lblHoursPerWeek);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserHoursPerWeekInput);
            this.Controls.Add(this.txtUserHourlyRate);
            this.Controls.Add(this.lblBeforeTaxes);
            this.Controls.Add(this.lblAfterTaxes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultAfterTaxes);
            this.Controls.Add(this.txtResultTaxRate);
            this.Controls.Add(this.txtResultTax);
            this.Controls.Add(this.txtResultYearlySalary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultYearlySalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserHourlyRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.TextBox txtUserHoursPerWeekInput;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblAfterTaxes;
        private System.Windows.Forms.TextBox txtResultTax;
        private System.Windows.Forms.TextBox txtResultAfterTaxes;
        private System.Windows.Forms.Label lblBeforeTaxes;
        private System.Windows.Forms.TextBox txtResultTaxRate;
        private System.Windows.Forms.Label label4;
    }
}

