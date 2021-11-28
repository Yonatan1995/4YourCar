namespace mainProject
{
    partial class userStatistics
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
            this.comboBoxIdWorker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewWorkerStatisticsBtn = new System.Windows.Forms.Button();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblWorkCards = new System.Windows.Forms.Label();
            this.lblLine3 = new System.Windows.Forms.Label();
            this.lblOpenWorkCards = new System.Windows.Forms.Label();
            this.lblCloseWorkCards = new System.Windows.Forms.Label();
            this.lblLine4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.workerWithTheMostWorkCardsBtn = new System.Windows.Forms.Button();
            this.lblMaxWorkerName = new System.Windows.Forms.Label();
            this.lblMaxWorkCards = new System.Windows.Forms.Label();
            this.lblMaxCloseWorkCards = new System.Windows.Forms.Label();
            this.lblMaxOpenWorkCards = new System.Windows.Forms.Label();
            this.lblMaxWorkerId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxIdWorker
            // 
            this.comboBoxIdWorker.FormattingEnabled = true;
            this.comboBoxIdWorker.Location = new System.Drawing.Point(166, 267);
            this.comboBoxIdWorker.Name = "comboBoxIdWorker";
            this.comboBoxIdWorker.Size = new System.Drawing.Size(155, 24);
            this.comboBoxIdWorker.TabIndex = 54;
            this.comboBoxIdWorker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "worker ID :";
            // 
            // viewWorkerStatisticsBtn
            // 
            this.viewWorkerStatisticsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewWorkerStatisticsBtn.Location = new System.Drawing.Point(113, 318);
            this.viewWorkerStatisticsBtn.Name = "viewWorkerStatisticsBtn";
            this.viewWorkerStatisticsBtn.Size = new System.Drawing.Size(169, 86);
            this.viewWorkerStatisticsBtn.TabIndex = 55;
            this.viewWorkerStatisticsBtn.Text = "View worker statistics";
            this.viewWorkerStatisticsBtn.UseVisualStyleBackColor = true;
            this.viewWorkerStatisticsBtn.Click += new System.EventHandler(this.viewWorkerStatisticsBtn_Click);
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine1.Location = new System.Drawing.Point(43, 53);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(134, 25);
            this.lblLine1.TabIndex = 56;
            this.lblLine1.Text = "Worker name :";
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.Location = new System.Drawing.Point(183, 53);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(0, 25);
            this.lblWorkerName.TabIndex = 57;
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine2.Location = new System.Drawing.Point(43, 94);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(208, 25);
            this.lblLine2.TabIndex = 58;
            this.lblLine2.Text = "Number of work cards :";
            // 
            // lblWorkCards
            // 
            this.lblWorkCards.AutoSize = true;
            this.lblWorkCards.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkCards.Location = new System.Drawing.Point(257, 94);
            this.lblWorkCards.Name = "lblWorkCards";
            this.lblWorkCards.Size = new System.Drawing.Size(0, 25);
            this.lblWorkCards.TabIndex = 59;
            // 
            // lblLine3
            // 
            this.lblLine3.AutoSize = true;
            this.lblLine3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine3.Location = new System.Drawing.Point(43, 175);
            this.lblLine3.Name = "lblLine3";
            this.lblLine3.Size = new System.Drawing.Size(256, 25);
            this.lblLine3.TabIndex = 60;
            this.lblLine3.Text = "Number of open work cards :";
            // 
            // lblOpenWorkCards
            // 
            this.lblOpenWorkCards.AutoSize = true;
            this.lblOpenWorkCards.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenWorkCards.Location = new System.Drawing.Point(305, 175);
            this.lblOpenWorkCards.Name = "lblOpenWorkCards";
            this.lblOpenWorkCards.Size = new System.Drawing.Size(0, 25);
            this.lblOpenWorkCards.TabIndex = 61;
            // 
            // lblCloseWorkCards
            // 
            this.lblCloseWorkCards.AutoSize = true;
            this.lblCloseWorkCards.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseWorkCards.Location = new System.Drawing.Point(305, 135);
            this.lblCloseWorkCards.Name = "lblCloseWorkCards";
            this.lblCloseWorkCards.Size = new System.Drawing.Size(0, 25);
            this.lblCloseWorkCards.TabIndex = 63;
            // 
            // lblLine4
            // 
            this.lblLine4.AutoSize = true;
            this.lblLine4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine4.Location = new System.Drawing.Point(43, 135);
            this.lblLine4.Name = "lblLine4";
            this.lblLine4.Size = new System.Drawing.Size(256, 25);
            this.lblLine4.TabIndex = 62;
            this.lblLine4.Text = "Number of close work cards :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(409, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 468);
            this.panel1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Number of close work cards :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Number of open work cards :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 66;
            this.label4.Text = "Number of work cards :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Worker name :";
            // 
            // workerWithTheMostWorkCardsBtn
            // 
            this.workerWithTheMostWorkCardsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerWithTheMostWorkCardsBtn.Location = new System.Drawing.Point(513, 318);
            this.workerWithTheMostWorkCardsBtn.Name = "workerWithTheMostWorkCardsBtn";
            this.workerWithTheMostWorkCardsBtn.Size = new System.Drawing.Size(192, 86);
            this.workerWithTheMostWorkCardsBtn.TabIndex = 69;
            this.workerWithTheMostWorkCardsBtn.Text = "Worker with the most work cards";
            this.workerWithTheMostWorkCardsBtn.UseVisualStyleBackColor = true;
            this.workerWithTheMostWorkCardsBtn.Click += new System.EventHandler(this.workerWithTheMostWorkCardsBtn_Click);
            // 
            // lblMaxWorkerName
            // 
            this.lblMaxWorkerName.AutoSize = true;
            this.lblMaxWorkerName.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxWorkerName.Location = new System.Drawing.Point(583, 53);
            this.lblMaxWorkerName.Name = "lblMaxWorkerName";
            this.lblMaxWorkerName.Size = new System.Drawing.Size(0, 25);
            this.lblMaxWorkerName.TabIndex = 70;
            // 
            // lblMaxWorkCards
            // 
            this.lblMaxWorkCards.AutoSize = true;
            this.lblMaxWorkCards.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxWorkCards.Location = new System.Drawing.Point(657, 127);
            this.lblMaxWorkCards.Name = "lblMaxWorkCards";
            this.lblMaxWorkCards.Size = new System.Drawing.Size(0, 25);
            this.lblMaxWorkCards.TabIndex = 71;
            // 
            // lblMaxCloseWorkCards
            // 
            this.lblMaxCloseWorkCards.AutoSize = true;
            this.lblMaxCloseWorkCards.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCloseWorkCards.Location = new System.Drawing.Point(705, 168);
            this.lblMaxCloseWorkCards.Name = "lblMaxCloseWorkCards";
            this.lblMaxCloseWorkCards.Size = new System.Drawing.Size(0, 25);
            this.lblMaxCloseWorkCards.TabIndex = 72;
            // 
            // lblMaxOpenWorkCards
            // 
            this.lblMaxOpenWorkCards.AutoSize = true;
            this.lblMaxOpenWorkCards.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxOpenWorkCards.Location = new System.Drawing.Point(705, 208);
            this.lblMaxOpenWorkCards.Name = "lblMaxOpenWorkCards";
            this.lblMaxOpenWorkCards.Size = new System.Drawing.Size(0, 25);
            this.lblMaxOpenWorkCards.TabIndex = 73;
            // 
            // lblMaxWorkerId
            // 
            this.lblMaxWorkerId.AutoSize = true;
            this.lblMaxWorkerId.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxWorkerId.Location = new System.Drawing.Point(554, 89);
            this.lblMaxWorkerId.Name = "lblMaxWorkerId";
            this.lblMaxWorkerId.Size = new System.Drawing.Size(0, 25);
            this.lblMaxWorkerId.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(443, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 74;
            this.label10.Text = "Worker ID :";
            // 
            // userStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.lblMaxWorkerId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMaxOpenWorkCards);
            this.Controls.Add(this.lblMaxCloseWorkCards);
            this.Controls.Add(this.lblMaxWorkCards);
            this.Controls.Add(this.lblMaxWorkerName);
            this.Controls.Add(this.workerWithTheMostWorkCardsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCloseWorkCards);
            this.Controls.Add(this.lblLine4);
            this.Controls.Add(this.lblOpenWorkCards);
            this.Controls.Add(this.lblLine3);
            this.Controls.Add(this.lblWorkCards);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.viewWorkerStatisticsBtn);
            this.Controls.Add(this.comboBoxIdWorker);
            this.Controls.Add(this.label1);
            this.Name = "userStatistics";
            this.Text = "userStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewWorkerStatisticsBtn;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblWorkCards;
        private System.Windows.Forms.Label lblLine3;
        private System.Windows.Forms.Label lblOpenWorkCards;
        private System.Windows.Forms.Label lblCloseWorkCards;
        private System.Windows.Forms.Label lblLine4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button workerWithTheMostWorkCardsBtn;
        private System.Windows.Forms.Label lblMaxWorkerName;
        private System.Windows.Forms.Label lblMaxWorkCards;
        private System.Windows.Forms.Label lblMaxCloseWorkCards;
        private System.Windows.Forms.Label lblMaxOpenWorkCards;
        private System.Windows.Forms.Label lblMaxWorkerId;
        private System.Windows.Forms.Label label10;
    }
}