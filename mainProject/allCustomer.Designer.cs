namespace mainProject
{
    partial class allCustomer
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
            this.showCustomersBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parameterBtn = new System.Windows.Forms.Button();
            this.parameterBox = new System.Windows.Forms.ComboBox();
            this.txtParameter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(656, 387);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 51);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // showCustomersBtn
            // 
            this.showCustomersBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCustomersBtn.Location = new System.Drawing.Point(465, 387);
            this.showCustomersBtn.Name = "showCustomersBtn";
            this.showCustomersBtn.Size = new System.Drawing.Size(169, 51);
            this.showCustomersBtn.TabIndex = 11;
            this.showCustomersBtn.Text = "Show all customer";
            this.showCustomersBtn.UseVisualStyleBackColor = true;
            this.showCustomersBtn.Click += new System.EventHandler(this.showCustomersBtn_Click);
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
            // parameterBtn
            // 
            this.parameterBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterBtn.Location = new System.Drawing.Point(12, 408);
            this.parameterBtn.Name = "parameterBtn";
            this.parameterBtn.Size = new System.Drawing.Size(293, 30);
            this.parameterBtn.TabIndex = 15;
            this.parameterBtn.Text = "Show customer by parameter";
            this.parameterBtn.UseVisualStyleBackColor = true;
            this.parameterBtn.Click += new System.EventHandler(this.parameterBtn_Click);
            // 
            // parameterBox
            // 
            this.parameterBox.FormattingEnabled = true;
            this.parameterBox.Items.AddRange(new object[] {
            "IdCustomer",
            "firstName",
            "lastName",
            "phone"});
            this.parameterBox.Location = new System.Drawing.Point(140, 380);
            this.parameterBox.Name = "parameterBox";
            this.parameterBox.Size = new System.Drawing.Size(121, 24);
            this.parameterBox.TabIndex = 14;
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(12, 380);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(107, 22);
            this.txtParameter.TabIndex = 13;
            // 
            // allCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parameterBtn);
            this.Controls.Add(this.parameterBox);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showCustomersBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "allCustomer";
            this.Text = "allCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button showCustomersBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button parameterBtn;
        private System.Windows.Forms.ComboBox parameterBox;
        private System.Windows.Forms.TextBox txtParameter;
    }
}