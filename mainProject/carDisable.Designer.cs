namespace mainProject
{
    partial class carDisable
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DisableCarBtn = new System.Windows.Forms.Button();
            this.comboBoxCarNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxIdCustomer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Id customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Car number";
            // 
            // DisableCarBtn
            // 
            this.DisableCarBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableCarBtn.Location = new System.Drawing.Point(119, 237);
            this.DisableCarBtn.Name = "DisableCarBtn";
            this.DisableCarBtn.Size = new System.Drawing.Size(169, 86);
            this.DisableCarBtn.TabIndex = 51;
            this.DisableCarBtn.Text = "Disable this car";
            this.DisableCarBtn.UseVisualStyleBackColor = true;
            this.DisableCarBtn.Click += new System.EventHandler(this.DisableCarBtn_Click);
            // 
            // comboBoxCarNumber
            // 
            this.comboBoxCarNumber.FormattingEnabled = true;
            this.comboBoxCarNumber.Location = new System.Drawing.Point(161, 83);
            this.comboBoxCarNumber.Name = "comboBoxCarNumber";
            this.comboBoxCarNumber.Size = new System.Drawing.Size(155, 24);
            this.comboBoxCarNumber.TabIndex = 52;
            this.comboBoxCarNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // comboBoxIdCustomer
            // 
            this.comboBoxIdCustomer.FormattingEnabled = true;
            this.comboBoxIdCustomer.Location = new System.Drawing.Point(160, 119);
            this.comboBoxIdCustomer.Name = "comboBoxIdCustomer";
            this.comboBoxIdCustomer.Size = new System.Drawing.Size(155, 24);
            this.comboBoxIdCustomer.TabIndex = 53;
            this.comboBoxIdCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // carDisable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 378);
            this.Controls.Add(this.comboBoxIdCustomer);
            this.Controls.Add(this.comboBoxCarNumber);
            this.Controls.Add(this.DisableCarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(441, 425);
            this.MinimumSize = new System.Drawing.Size(441, 425);
            this.Name = "carDisable";
            this.Text = "carDisable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisableCarBtn;
        private System.Windows.Forms.ComboBox comboBoxCarNumber;
        private System.Windows.Forms.ComboBox comboBoxIdCustomer;
    }
}