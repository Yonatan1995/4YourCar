namespace mainProject
{
    partial class allGarageWorkCard
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.showAlWorkCardBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openWorkCardsBtn = new System.Windows.Forms.Button();
            this.endWorkCardsBtn = new System.Windows.Forms.Button();
            this.parameterBtn = new System.Windows.Forms.Button();
            this.parameterBox = new System.Windows.Forms.ComboBox();
            this.txtParameter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(656, 391);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 54);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // showAlWorkCardBtn
            // 
            this.showAlWorkCardBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAlWorkCardBtn.Location = new System.Drawing.Point(464, 385);
            this.showAlWorkCardBtn.Name = "showAlWorkCardBtn";
            this.showAlWorkCardBtn.Size = new System.Drawing.Size(172, 60);
            this.showAlWorkCardBtn.TabIndex = 11;
            this.showAlWorkCardBtn.Text = "Show all work cards";
            this.showAlWorkCardBtn.UseVisualStyleBackColor = true;
            this.showAlWorkCardBtn.Click += new System.EventHandler(this.showAllWorkCardBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 319);
            this.dataGridView1.TabIndex = 10;
            // 
            // openWorkCardsBtn
            // 
            this.openWorkCardsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openWorkCardsBtn.Location = new System.Drawing.Point(286, 384);
            this.openWorkCardsBtn.Name = "openWorkCardsBtn";
            this.openWorkCardsBtn.Size = new System.Drawing.Size(172, 63);
            this.openWorkCardsBtn.TabIndex = 13;
            this.openWorkCardsBtn.Text = "Show opens work cards";
            this.openWorkCardsBtn.UseVisualStyleBackColor = true;
            this.openWorkCardsBtn.Click += new System.EventHandler(this.openWorkCardsBtn_Click);
            // 
            // endWorkCardsBtn
            // 
            this.endWorkCardsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endWorkCardsBtn.Location = new System.Drawing.Point(286, 325);
            this.endWorkCardsBtn.Name = "endWorkCardsBtn";
            this.endWorkCardsBtn.Size = new System.Drawing.Size(172, 63);
            this.endWorkCardsBtn.TabIndex = 14;
            this.endWorkCardsBtn.Text = "Show closes work cards";
            this.endWorkCardsBtn.UseVisualStyleBackColor = true;
            this.endWorkCardsBtn.Click += new System.EventHandler(this.endWorkCardsBtn_Click);
            // 
            // parameterBtn
            // 
            this.parameterBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterBtn.Location = new System.Drawing.Point(0, 408);
            this.parameterBtn.Name = "parameterBtn";
            this.parameterBtn.Size = new System.Drawing.Size(280, 37);
            this.parameterBtn.TabIndex = 18;
            this.parameterBtn.Text = "Show work card by parameter";
            this.parameterBtn.UseVisualStyleBackColor = true;
            this.parameterBtn.Click += new System.EventHandler(this.parameterBtn_Click);
            // 
            // parameterBox
            // 
            this.parameterBox.FormattingEnabled = true;
            this.parameterBox.Items.AddRange(new object[] {
            "idGarageWorkCard",
            "carNumber",
            "IdCustomer",
            "idWorker"});
            this.parameterBox.Location = new System.Drawing.Point(125, 380);
            this.parameterBox.Name = "parameterBox";
            this.parameterBox.Size = new System.Drawing.Size(155, 24);
            this.parameterBox.TabIndex = 17;
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(12, 380);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(107, 22);
            this.txtParameter.TabIndex = 16;
            // 
            // allGarageWorkCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parameterBtn);
            this.Controls.Add(this.parameterBox);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.endWorkCardsBtn);
            this.Controls.Add(this.openWorkCardsBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showAlWorkCardBtn);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "allGarageWorkCard";
            this.Text = "allGarageWorkCard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button showAlWorkCardBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button openWorkCardsBtn;
        private System.Windows.Forms.Button endWorkCardsBtn;
        private System.Windows.Forms.Button parameterBtn;
        private System.Windows.Forms.ComboBox parameterBox;
        private System.Windows.Forms.TextBox txtParameter;
    }
}