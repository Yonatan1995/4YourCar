namespace mainProject
{
    partial class managerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerHome));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EXIT = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.addPartBtn = new System.Windows.Forms.Button();
            this.addWorkCardBtn = new System.Windows.Forms.Button();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.allCarsBtn = new System.Windows.Forms.Button();
            this.allPartsBtn = new System.Windows.Forms.Button();
            this.allWorkCardBtn = new System.Windows.Forms.Button();
            this.allCustomersBtn = new System.Windows.Forms.Button();
            this.pricePerHourOfWorkBtn = new System.Windows.Forms.Button();
            this.userStatisticsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1020, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 40);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "22:22";
            // 
            // lblSec
            // 
            this.lblSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(1124, 37);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(28, 21);
            this.lblSec.TabIndex = 13;
            this.lblSec.Text = "10";
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(1022, 58);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(40, 30);
            this.lblDay.TabIndex = 14;
            this.lblDay.Text = "יום";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblSec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 100);
            this.panel1.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(169, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 34);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "welcome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EXIT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 100);
            this.panel2.TabIndex = 17;
            // 
            // EXIT
            // 
            this.EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EXIT.AutoSize = true;
            this.EXIT.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(1062, 46);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(90, 36);
            this.EXIT.TabIndex = 0;
            this.EXIT.Text = "Exit";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.Image = ((System.Drawing.Image)(resources.GetObject("addUserBtn.Image")));
            this.addUserBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addUserBtn.Location = new System.Drawing.Point(35, 121);
            this.addUserBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(167, 178);
            this.addUserBtn.TabIndex = 22;
            this.addUserBtn.Text = "User actions";
            this.addUserBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // addCarBtn
            // 
            this.addCarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCarBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarBtn.Image = ((System.Drawing.Image)(resources.GetObject("addCarBtn.Image")));
            this.addCarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addCarBtn.Location = new System.Drawing.Point(219, 121);
            this.addCarBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(167, 178);
            this.addCarBtn.TabIndex = 23;
            this.addCarBtn.Text = "Car actions";
            this.addCarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addCarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // addPartBtn
            // 
            this.addPartBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPartBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartBtn.Image = ((System.Drawing.Image)(resources.GetObject("addPartBtn.Image")));
            this.addPartBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addPartBtn.Location = new System.Drawing.Point(401, 121);
            this.addPartBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(167, 178);
            this.addPartBtn.TabIndex = 24;
            this.addPartBtn.Text = "Parts actions";
            this.addPartBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addPartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addPartBtn.UseVisualStyleBackColor = true;
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            // 
            // addWorkCardBtn
            // 
            this.addWorkCardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addWorkCardBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkCardBtn.Image = ((System.Drawing.Image)(resources.GetObject("addWorkCardBtn.Image")));
            this.addWorkCardBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addWorkCardBtn.Location = new System.Drawing.Point(587, 121);
            this.addWorkCardBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.addWorkCardBtn.Name = "addWorkCardBtn";
            this.addWorkCardBtn.Size = new System.Drawing.Size(167, 178);
            this.addWorkCardBtn.TabIndex = 25;
            this.addWorkCardBtn.Text = "Add work card";
            this.addWorkCardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addWorkCardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addWorkCardBtn.UseVisualStyleBackColor = true;
            this.addWorkCardBtn.Click += new System.EventHandler(this.addWorkCardBtn_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCustomerBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("addCustomerBtn.Image")));
            this.addCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addCustomerBtn.Location = new System.Drawing.Point(777, 121);
            this.addCustomerBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(167, 178);
            this.addCustomerBtn.TabIndex = 26;
            this.addCustomerBtn.Text = "Customer actions";
            this.addCustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // editUserBtn
            // 
            this.editUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editUserBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserBtn.Image = ((System.Drawing.Image)(resources.GetObject("editUserBtn.Image")));
            this.editUserBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editUserBtn.Location = new System.Drawing.Point(35, 322);
            this.editUserBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(167, 179);
            this.editUserBtn.TabIndex = 27;
            this.editUserBtn.Text = "All users";
            this.editUserBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editUserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editUserBtn.UseVisualStyleBackColor = true;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // allCarsBtn
            // 
            this.allCarsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allCarsBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCarsBtn.Image = ((System.Drawing.Image)(resources.GetObject("allCarsBtn.Image")));
            this.allCarsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allCarsBtn.Location = new System.Drawing.Point(219, 322);
            this.allCarsBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.allCarsBtn.Name = "allCarsBtn";
            this.allCarsBtn.Size = new System.Drawing.Size(167, 179);
            this.allCarsBtn.TabIndex = 28;
            this.allCarsBtn.Text = "All cars";
            this.allCarsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allCarsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allCarsBtn.UseVisualStyleBackColor = true;
            this.allCarsBtn.Click += new System.EventHandler(this.allCarsBtn_Click);
            // 
            // allPartsBtn
            // 
            this.allPartsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allPartsBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPartsBtn.Image = ((System.Drawing.Image)(resources.GetObject("allPartsBtn.Image")));
            this.allPartsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allPartsBtn.Location = new System.Drawing.Point(401, 322);
            this.allPartsBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.allPartsBtn.Name = "allPartsBtn";
            this.allPartsBtn.Size = new System.Drawing.Size(167, 179);
            this.allPartsBtn.TabIndex = 29;
            this.allPartsBtn.Text = "All parts";
            this.allPartsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allPartsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allPartsBtn.UseVisualStyleBackColor = true;
            this.allPartsBtn.Click += new System.EventHandler(this.allPartsBtn_Click);
            // 
            // allWorkCardBtn
            // 
            this.allWorkCardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allWorkCardBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allWorkCardBtn.Image = ((System.Drawing.Image)(resources.GetObject("allWorkCardBtn.Image")));
            this.allWorkCardBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allWorkCardBtn.Location = new System.Drawing.Point(587, 322);
            this.allWorkCardBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.allWorkCardBtn.Name = "allWorkCardBtn";
            this.allWorkCardBtn.Size = new System.Drawing.Size(167, 179);
            this.allWorkCardBtn.TabIndex = 30;
            this.allWorkCardBtn.Text = "All work card";
            this.allWorkCardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allWorkCardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allWorkCardBtn.UseVisualStyleBackColor = true;
            this.allWorkCardBtn.Click += new System.EventHandler(this.allWorkCardBtn_Click);
            // 
            // allCustomersBtn
            // 
            this.allCustomersBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allCustomersBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCustomersBtn.Image = ((System.Drawing.Image)(resources.GetObject("allCustomersBtn.Image")));
            this.allCustomersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allCustomersBtn.Location = new System.Drawing.Point(777, 323);
            this.allCustomersBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.allCustomersBtn.Name = "allCustomersBtn";
            this.allCustomersBtn.Size = new System.Drawing.Size(167, 178);
            this.allCustomersBtn.TabIndex = 31;
            this.allCustomersBtn.Text = "All customer";
            this.allCustomersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allCustomersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allCustomersBtn.UseVisualStyleBackColor = true;
            this.allCustomersBtn.Click += new System.EventHandler(this.allCustomersBtn_Click);
            // 
            // pricePerHourOfWorkBtn
            // 
            this.pricePerHourOfWorkBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pricePerHourOfWorkBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerHourOfWorkBtn.Image = ((System.Drawing.Image)(resources.GetObject("pricePerHourOfWorkBtn.Image")));
            this.pricePerHourOfWorkBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pricePerHourOfWorkBtn.Location = new System.Drawing.Point(965, 121);
            this.pricePerHourOfWorkBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.pricePerHourOfWorkBtn.Name = "pricePerHourOfWorkBtn";
            this.pricePerHourOfWorkBtn.Size = new System.Drawing.Size(167, 178);
            this.pricePerHourOfWorkBtn.TabIndex = 32;
            this.pricePerHourOfWorkBtn.Text = "Price per hour of work";
            this.pricePerHourOfWorkBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pricePerHourOfWorkBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pricePerHourOfWorkBtn.UseVisualStyleBackColor = true;
            this.pricePerHourOfWorkBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // userStatisticsBtn
            // 
            this.userStatisticsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userStatisticsBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userStatisticsBtn.Image = ((System.Drawing.Image)(resources.GetObject("userStatisticsBtn.Image")));
            this.userStatisticsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userStatisticsBtn.Location = new System.Drawing.Point(965, 322);
            this.userStatisticsBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.userStatisticsBtn.Name = "userStatisticsBtn";
            this.userStatisticsBtn.Size = new System.Drawing.Size(167, 178);
            this.userStatisticsBtn.TabIndex = 33;
            this.userStatisticsBtn.Text = "User statistics";
            this.userStatisticsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userStatisticsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.userStatisticsBtn.UseVisualStyleBackColor = true;
            this.userStatisticsBtn.Click += new System.EventHandler(this.userStatisticsBtn_Click);
            // 
            // managerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 617);
            this.Controls.Add(this.userStatisticsBtn);
            this.Controls.Add(this.pricePerHourOfWorkBtn);
            this.Controls.Add(this.allCustomersBtn);
            this.Controls.Add(this.allWorkCardBtn);
            this.Controls.Add(this.allPartsBtn);
            this.Controls.Add(this.allCarsBtn);
            this.Controls.Add(this.editUserBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.addWorkCardBtn);
            this.Controls.Add(this.addPartBtn);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(990, 626);
            this.Name = "managerHome";
            this.Text = "managerHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.Button addPartBtn;
        private System.Windows.Forms.Button addWorkCardBtn;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button allCarsBtn;
        private System.Windows.Forms.Button allPartsBtn;
        private System.Windows.Forms.Button allWorkCardBtn;
        private System.Windows.Forms.Button allCustomersBtn;
        private System.Windows.Forms.Button pricePerHourOfWorkBtn;
        private System.Windows.Forms.Button userStatisticsBtn;
    }
}