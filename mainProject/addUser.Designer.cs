namespace mainProject
{
    partial class addUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdWorker = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MechanicButton = new System.Windows.Forms.RadioButton();
            this.ReceptionistButton = new System.Windows.Forms.RadioButton();
            this.ManagerButton = new System.Windows.Forms.RadioButton();
            this.addNewUserBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id worker";
            // 
            // txtIdWorker
            // 
            this.txtIdWorker.Location = new System.Drawing.Point(153, 44);
            this.txtIdWorker.Name = "txtIdWorker";
            this.txtIdWorker.Size = new System.Drawing.Size(155, 22);
            this.txtIdWorker.TabIndex = 1;
            this.txtIdWorker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(153, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(155, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "User name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(153, 254);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(155, 22);
            this.txtPhone.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(153, 212);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 22);
            this.txtLastName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(153, 171);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 22);
            this.txtFirstName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // MechanicButton
            // 
            this.MechanicButton.AutoSize = true;
            this.MechanicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.MechanicButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MechanicButton.Location = new System.Drawing.Point(298, 312);
            this.MechanicButton.Name = "MechanicButton";
            this.MechanicButton.Size = new System.Drawing.Size(102, 24);
            this.MechanicButton.TabIndex = 14;
            this.MechanicButton.TabStop = true;
            this.MechanicButton.Text = "Mechanic";
            this.MechanicButton.UseVisualStyleBackColor = true;
            // 
            // ReceptionistButton
            // 
            this.ReceptionistButton.AutoSize = true;
            this.ReceptionistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ReceptionistButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ReceptionistButton.Location = new System.Drawing.Point(153, 312);
            this.ReceptionistButton.Name = "ReceptionistButton";
            this.ReceptionistButton.Size = new System.Drawing.Size(123, 24);
            this.ReceptionistButton.TabIndex = 13;
            this.ReceptionistButton.TabStop = true;
            this.ReceptionistButton.Text = "Receptionist";
            this.ReceptionistButton.UseVisualStyleBackColor = true;
            // 
            // ManagerButton
            // 
            this.ManagerButton.AutoSize = true;
            this.ManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ManagerButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ManagerButton.Location = new System.Drawing.Point(39, 312);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(95, 24);
            this.ManagerButton.TabIndex = 12;
            this.ManagerButton.TabStop = true;
            this.ManagerButton.Text = "Manager";
            this.ManagerButton.UseVisualStyleBackColor = true;
            // 
            // addNewUserBtn
            // 
            this.addNewUserBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserBtn.Location = new System.Drawing.Point(298, 428);
            this.addNewUserBtn.Name = "addNewUserBtn";
            this.addNewUserBtn.Size = new System.Drawing.Size(171, 63);
            this.addNewUserBtn.TabIndex = 15;
            this.addNewUserBtn.Text = "Add new user";
            this.addNewUserBtn.UseVisualStyleBackColor = true;
            this.addNewUserBtn.Click += new System.EventHandler(this.addNewUserBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(50, 428);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(169, 63);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Delete user by id";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 517);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addNewUserBtn);
            this.Controls.Add(this.MechanicButton);
            this.Controls.Add(this.ReceptionistButton);
            this.Controls.Add(this.ManagerButton);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdWorker);
            this.Controls.Add(this.label1);
            this.Name = "addUser";
            this.Text = "addUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdWorker;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton MechanicButton;
        private System.Windows.Forms.RadioButton ReceptionistButton;
        private System.Windows.Forms.RadioButton ManagerButton;
        private System.Windows.Forms.Button addNewUserBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}