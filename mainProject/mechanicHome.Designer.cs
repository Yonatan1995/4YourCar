namespace mainProject
{
    partial class mechanicHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mechanicHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.EXIT = new System.Windows.Forms.Button();
            this.allWorkCardBtn = new System.Windows.Forms.Button();
            this.allPartsBtn = new System.Windows.Forms.Button();
            this.carDisableBtn = new System.Windows.Forms.Button();
            this.partsForWorkCardBtn = new System.Windows.Forms.Button();
            this.closingWorkCardBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(944, 100);
            this.panel1.TabIndex = 17;
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
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(800, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 40);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "22:22";
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(802, 58);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(40, 30);
            this.lblDay.TabIndex = 14;
            this.lblDay.Text = "יום";
            // 
            // lblSec
            // 
            this.lblSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(904, 37);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(28, 21);
            this.lblSec.TabIndex = 13;
            this.lblSec.Text = "10";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EXIT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 100);
            this.panel2.TabIndex = 19;
            // 
            // EXIT
            // 
            this.EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EXIT.AutoSize = true;
            this.EXIT.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(842, 46);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(90, 36);
            this.EXIT.TabIndex = 0;
            this.EXIT.Text = "Exit";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // allWorkCardBtn
            // 
            this.allWorkCardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allWorkCardBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allWorkCardBtn.Image = ((System.Drawing.Image)(resources.GetObject("allWorkCardBtn.Image")));
            this.allWorkCardBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allWorkCardBtn.Location = new System.Drawing.Point(197, 121);
            this.allWorkCardBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.allWorkCardBtn.Name = "allWorkCardBtn";
            this.allWorkCardBtn.Size = new System.Drawing.Size(167, 179);
            this.allWorkCardBtn.TabIndex = 31;
            this.allWorkCardBtn.Text = "My work cards";
            this.allWorkCardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allWorkCardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allWorkCardBtn.UseVisualStyleBackColor = true;
            this.allWorkCardBtn.Click += new System.EventHandler(this.allWorkCardBtn_Click);
            // 
            // allPartsBtn
            // 
            this.allPartsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allPartsBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPartsBtn.Image = ((System.Drawing.Image)(resources.GetObject("allPartsBtn.Image")));
            this.allPartsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allPartsBtn.Location = new System.Drawing.Point(400, 317);
            this.allPartsBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.allPartsBtn.Name = "allPartsBtn";
            this.allPartsBtn.Size = new System.Drawing.Size(167, 179);
            this.allPartsBtn.TabIndex = 32;
            this.allPartsBtn.Text = "All parts";
            this.allPartsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allPartsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allPartsBtn.UseVisualStyleBackColor = true;
            this.allPartsBtn.Click += new System.EventHandler(this.allPartsBtn_Click);
            // 
            // carDisableBtn
            // 
            this.carDisableBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carDisableBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carDisableBtn.Image = ((System.Drawing.Image)(resources.GetObject("carDisableBtn.Image")));
            this.carDisableBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.carDisableBtn.Location = new System.Drawing.Point(197, 317);
            this.carDisableBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.carDisableBtn.Name = "carDisableBtn";
            this.carDisableBtn.Size = new System.Drawing.Size(167, 179);
            this.carDisableBtn.TabIndex = 33;
            this.carDisableBtn.Text = "Car disable";
            this.carDisableBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.carDisableBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.carDisableBtn.UseVisualStyleBackColor = true;
            this.carDisableBtn.Click += new System.EventHandler(this.carDisableBtn_Click);
            // 
            // partsForWorkCardBtn
            // 
            this.partsForWorkCardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partsForWorkCardBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsForWorkCardBtn.Image = ((System.Drawing.Image)(resources.GetObject("partsForWorkCardBtn.Image")));
            this.partsForWorkCardBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.partsForWorkCardBtn.Location = new System.Drawing.Point(400, 121);
            this.partsForWorkCardBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.partsForWorkCardBtn.Name = "partsForWorkCardBtn";
            this.partsForWorkCardBtn.Size = new System.Drawing.Size(167, 179);
            this.partsForWorkCardBtn.TabIndex = 34;
            this.partsForWorkCardBtn.Text = "Parts for work card";
            this.partsForWorkCardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.partsForWorkCardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.partsForWorkCardBtn.UseVisualStyleBackColor = true;
            this.partsForWorkCardBtn.Click += new System.EventHandler(this.partsForWorkCardBtn_Click);
            // 
            // closingWorkCardBtn
            // 
            this.closingWorkCardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closingWorkCardBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closingWorkCardBtn.Image = ((System.Drawing.Image)(resources.GetObject("closingWorkCardBtn.Image")));
            this.closingWorkCardBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closingWorkCardBtn.Location = new System.Drawing.Point(599, 121);
            this.closingWorkCardBtn.MinimumSize = new System.Drawing.Size(167, 163);
            this.closingWorkCardBtn.Name = "closingWorkCardBtn";
            this.closingWorkCardBtn.Size = new System.Drawing.Size(167, 179);
            this.closingWorkCardBtn.TabIndex = 35;
            this.closingWorkCardBtn.Text = "Closing a work card";
            this.closingWorkCardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closingWorkCardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closingWorkCardBtn.UseVisualStyleBackColor = true;
            this.closingWorkCardBtn.Click += new System.EventHandler(this.closingWorkCardBtn_Click);
            // 
            // mechanicHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.closingWorkCardBtn);
            this.Controls.Add(this.partsForWorkCardBtn);
            this.Controls.Add(this.carDisableBtn);
            this.Controls.Add(this.allPartsBtn);
            this.Controls.Add(this.allWorkCardBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "mechanicHome";
            this.Text = "mechanicHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button allWorkCardBtn;
        private System.Windows.Forms.Button allPartsBtn;
        private System.Windows.Forms.Button carDisableBtn;
        private System.Windows.Forms.Button partsForWorkCardBtn;
        private System.Windows.Forms.Button closingWorkCardBtn;
    }
}