namespace mainProject
{
    partial class addWorkCard
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
            this.addNewWorkCardBtn = new System.Windows.Forms.Button();
            this.txtKMcar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCarNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxIdWorker = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addNewWorkCardBtn
            // 
            this.addNewWorkCardBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewWorkCardBtn.Location = new System.Drawing.Point(93, 280);
            this.addNewWorkCardBtn.Name = "addNewWorkCardBtn";
            this.addNewWorkCardBtn.Size = new System.Drawing.Size(258, 86);
            this.addNewWorkCardBtn.TabIndex = 43;
            this.addNewWorkCardBtn.Text = "Add new work card";
            this.addNewWorkCardBtn.UseVisualStyleBackColor = true;
            this.addNewWorkCardBtn.Click += new System.EventHandler(this.addNewWorkCardBtn_Click);
            // 
            // txtKMcar
            // 
            this.txtKMcar.Location = new System.Drawing.Point(147, 159);
            this.txtKMcar.Name = "txtKMcar";
            this.txtKMcar.Size = new System.Drawing.Size(167, 22);
            this.txtKMcar.TabIndex = 42;
            this.txtKMcar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Id worker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "KM car";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(147, 201);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(325, 22);
            this.txtDescription.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Description";
            // 
            // comboBoxCarNumber
            // 
            this.comboBoxCarNumber.FormattingEnabled = true;
            this.comboBoxCarNumber.Location = new System.Drawing.Point(147, 74);
            this.comboBoxCarNumber.Name = "comboBoxCarNumber";
            this.comboBoxCarNumber.Size = new System.Drawing.Size(167, 24);
            this.comboBoxCarNumber.TabIndex = 54;
            this.comboBoxCarNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Car number";
            // 
            // comboBoxIdWorker
            // 
            this.comboBoxIdWorker.FormattingEnabled = true;
            this.comboBoxIdWorker.Location = new System.Drawing.Point(147, 117);
            this.comboBoxIdWorker.Name = "comboBoxIdWorker";
            this.comboBoxIdWorker.Size = new System.Drawing.Size(167, 24);
            this.comboBoxIdWorker.TabIndex = 55;
            this.comboBoxIdWorker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // addWorkCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 409);
            this.Controls.Add(this.comboBoxIdWorker);
            this.Controls.Add(this.comboBoxCarNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addNewWorkCardBtn);
            this.Controls.Add(this.txtKMcar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "addWorkCard";
            this.Text = "addWorkCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewWorkCardBtn;
        private System.Windows.Forms.TextBox txtKMcar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCarNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxIdWorker;
    }
}