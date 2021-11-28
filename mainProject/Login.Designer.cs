namespace mainProject
{
    partial class Login
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ManagerButton = new System.Windows.Forms.RadioButton();
            this.ReceptionistButton = new System.Windows.Forms.RadioButton();
            this.MechanicButton = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginBtn.Location = new System.Drawing.Point(100, 285);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(91, 37);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExitBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitBtn.Location = new System.Drawing.Point(539, 338);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(96, 39);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(95, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "userName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(95, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(209, 56);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(196, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(209, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(196, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // ManagerButton
            // 
            this.ManagerButton.AutoSize = true;
            this.ManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ManagerButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ManagerButton.Location = new System.Drawing.Point(44, 229);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(95, 24);
            this.ManagerButton.TabIndex = 7;
            this.ManagerButton.TabStop = true;
            this.ManagerButton.Text = "Manager";
            this.ManagerButton.UseVisualStyleBackColor = true;
            // 
            // ReceptionistButton
            // 
            this.ReceptionistButton.AutoSize = true;
            this.ReceptionistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ReceptionistButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ReceptionistButton.Location = new System.Drawing.Point(158, 229);
            this.ReceptionistButton.Name = "ReceptionistButton";
            this.ReceptionistButton.Size = new System.Drawing.Size(123, 24);
            this.ReceptionistButton.TabIndex = 8;
            this.ReceptionistButton.TabStop = true;
            this.ReceptionistButton.Text = "Receptionist";
            this.ReceptionistButton.UseVisualStyleBackColor = true;
            // 
            // MechanicButton
            // 
            this.MechanicButton.AutoSize = true;
            this.MechanicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.MechanicButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MechanicButton.Location = new System.Drawing.Point(303, 229);
            this.MechanicButton.Name = "MechanicButton";
            this.MechanicButton.Size = new System.Drawing.Size(102, 24);
            this.MechanicButton.TabIndex = 9;
            this.MechanicButton.TabStop = true;
            this.MechanicButton.Text = "Mechanic";
            this.MechanicButton.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(487, 56);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 40);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "22:22";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(489, 96);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(40, 30);
            this.lblDay.TabIndex = 11;
            this.lblDay.Text = "יום";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(584, 73);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(28, 21);
            this.lblSec.TabIndex = 12;
            this.lblSec.Text = "10";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(647, 398);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.MechanicButton);
            this.Controls.Add(this.ReceptionistButton);
            this.Controls.Add(this.ManagerButton);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.MaximumSize = new System.Drawing.Size(665, 445);
            this.MinimumSize = new System.Drawing.Size(665, 445);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton ManagerButton;
        private System.Windows.Forms.RadioButton ReceptionistButton;
        private System.Windows.Forms.RadioButton MechanicButton;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Button LoginBtn;
    }
}

