namespace mainProject
{
    partial class addCar
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addNewCarBtn = new System.Windows.Forms.Button();
            this.txtManufactureYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.changeOwnerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(12, 290);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(169, 86);
            this.deleteBtn.TabIndex = 44;
            this.deleteBtn.Text = "Delete car by id";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addNewCarBtn
            // 
            this.addNewCarBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCarBtn.Location = new System.Drawing.Point(364, 290);
            this.addNewCarBtn.Name = "addNewCarBtn";
            this.addNewCarBtn.Size = new System.Drawing.Size(171, 86);
            this.addNewCarBtn.TabIndex = 43;
            this.addNewCarBtn.Text = "Add new car";
            this.addNewCarBtn.UseVisualStyleBackColor = true;
            this.addNewCarBtn.Click += new System.EventHandler(this.addNewCarBtn_Click);
            // 
            // txtManufactureYear
            // 
            this.txtManufactureYear.Location = new System.Drawing.Point(228, 223);
            this.txtManufactureYear.Name = "txtManufactureYear";
            this.txtManufactureYear.Size = new System.Drawing.Size(155, 22);
            this.txtManufactureYear.TabIndex = 42;
            this.txtManufactureYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(228, 181);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(155, 22);
            this.txtModel.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "make";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(228, 140);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(155, 22);
            this.txtMake.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Manufacture year";
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Location = new System.Drawing.Point(228, 66);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(155, 22);
            this.txtCarNumber.TabIndex = 36;
            this.txtCarNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Car number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Id customer";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(228, 103);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(155, 22);
            this.txtIdCustomer.TabIndex = 45;
            this.txtIdCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // changeOwnerBtn
            // 
            this.changeOwnerBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOwnerBtn.Location = new System.Drawing.Point(187, 290);
            this.changeOwnerBtn.Name = "changeOwnerBtn";
            this.changeOwnerBtn.Size = new System.Drawing.Size(171, 86);
            this.changeOwnerBtn.TabIndex = 47;
            this.changeOwnerBtn.Text = "Car ownership change";
            this.changeOwnerBtn.UseVisualStyleBackColor = true;
            this.changeOwnerBtn.Click += new System.EventHandler(this.changeOwnerBtn_Click);
            // 
            // addCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 425);
            this.Controls.Add(this.changeOwnerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addNewCarBtn);
            this.Controls.Add(this.txtManufactureYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarNumber);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(565, 472);
            this.MinimumSize = new System.Drawing.Size(565, 472);
            this.Name = "addCar";
            this.Text = "addCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addNewCarBtn;
        private System.Windows.Forms.TextBox txtManufactureYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Button changeOwnerBtn;
    }
}