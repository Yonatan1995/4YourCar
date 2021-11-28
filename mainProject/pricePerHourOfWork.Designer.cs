namespace mainProject
{
    partial class pricePerHourOfWork
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.updateTheNewPriceBtn = new System.Windows.Forms.Button();
            this.showCurrentPriceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Current price per hour of work :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(296, 65);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 25);
            this.lblPrice.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Enter a new price per hour of work :";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(23, 150);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(308, 22);
            this.txtNewPrice.TabIndex = 59;
            this.txtNewPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // updateTheNewPriceBtn
            // 
            this.updateTheNewPriceBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTheNewPriceBtn.Location = new System.Drawing.Point(39, 231);
            this.updateTheNewPriceBtn.Name = "updateTheNewPriceBtn";
            this.updateTheNewPriceBtn.Size = new System.Drawing.Size(169, 86);
            this.updateTheNewPriceBtn.TabIndex = 63;
            this.updateTheNewPriceBtn.Text = "Update the new price";
            this.updateTheNewPriceBtn.UseVisualStyleBackColor = true;
            this.updateTheNewPriceBtn.Click += new System.EventHandler(this.updateTheNewPriceBtn_Click);
            // 
            // showCurrentPriceBtn
            // 
            this.showCurrentPriceBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCurrentPriceBtn.Location = new System.Drawing.Point(227, 231);
            this.showCurrentPriceBtn.Name = "showCurrentPriceBtn";
            this.showCurrentPriceBtn.Size = new System.Drawing.Size(171, 86);
            this.showCurrentPriceBtn.TabIndex = 62;
            this.showCurrentPriceBtn.Text = "Show current price";
            this.showCurrentPriceBtn.UseVisualStyleBackColor = true;
            this.showCurrentPriceBtn.Click += new System.EventHandler(this.showCurrentPriceBtn_Click);
            // 
            // pricePerHourOfWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.updateTheNewPriceBtn);
            this.Controls.Add(this.showCurrentPriceBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Name = "pricePerHourOfWork";
            this.Text = "pricePerHourOfWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Button updateTheNewPriceBtn;
        private System.Windows.Forms.Button showCurrentPriceBtn;
    }
}