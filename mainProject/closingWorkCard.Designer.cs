namespace mainProject
{
    partial class closingWorkCard
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
            this.comboBoxIdWorkCard = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoursWork = new System.Windows.Forms.TextBox();
            this.closeWorkCardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxIdWorkCard
            // 
            this.comboBoxIdWorkCard.FormattingEnabled = true;
            this.comboBoxIdWorkCard.Location = new System.Drawing.Point(287, 57);
            this.comboBoxIdWorkCard.Name = "comboBoxIdWorkCard";
            this.comboBoxIdWorkCard.Size = new System.Drawing.Size(167, 24);
            this.comboBoxIdWorkCard.TabIndex = 58;
            this.comboBoxIdWorkCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Hours of work in the garage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Id work card";
            // 
            // txtHoursWork
            // 
            this.txtHoursWork.Location = new System.Drawing.Point(287, 100);
            this.txtHoursWork.Name = "txtHoursWork";
            this.txtHoursWork.Size = new System.Drawing.Size(167, 22);
            this.txtHoursWork.TabIndex = 59;
            this.txtHoursWork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // closeWorkCardBtn
            // 
            this.closeWorkCardBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWorkCardBtn.Location = new System.Drawing.Point(131, 208);
            this.closeWorkCardBtn.Name = "closeWorkCardBtn";
            this.closeWorkCardBtn.Size = new System.Drawing.Size(218, 73);
            this.closeWorkCardBtn.TabIndex = 60;
            this.closeWorkCardBtn.Text = "Close work card";
            this.closeWorkCardBtn.UseVisualStyleBackColor = true;
            this.closeWorkCardBtn.Click += new System.EventHandler(this.closeWorkCardBtn_Click);
            // 
            // closingWorkCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 412);
            this.Controls.Add(this.closeWorkCardBtn);
            this.Controls.Add(this.txtHoursWork);
            this.Controls.Add(this.comboBoxIdWorkCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "closingWorkCard";
            this.Text = "closingWorkCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdWorkCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoursWork;
        private System.Windows.Forms.Button closeWorkCardBtn;
    }
}