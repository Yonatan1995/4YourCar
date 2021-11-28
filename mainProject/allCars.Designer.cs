namespace mainProject
{
    partial class allCars
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showCarsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.parameterBox = new System.Windows.Forms.ComboBox();
            this.parameterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.TabIndex = 4;
            // 
            // showCarsBtn
            // 
            this.showCarsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCarsBtn.Location = new System.Drawing.Point(464, 400);
            this.showCarsBtn.Name = "showCarsBtn";
            this.showCarsBtn.Size = new System.Drawing.Size(159, 38);
            this.showCarsBtn.TabIndex = 5;
            this.showCarsBtn.Text = "Show all cars";
            this.showCarsBtn.UseVisualStyleBackColor = true;
            this.showCarsBtn.Click += new System.EventHandler(this.showCarsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(656, 400);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 38);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(12, 389);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(107, 22);
            this.txtParameter.TabIndex = 7;
            // 
            // parameterBox
            // 
            this.parameterBox.FormattingEnabled = true;
            this.parameterBox.Items.AddRange(new object[] {
            "carNumber",
            "IdCustomer",
            "make",
            "model",
            "manufactureYear"});
            this.parameterBox.Location = new System.Drawing.Point(140, 389);
            this.parameterBox.Name = "parameterBox";
            this.parameterBox.Size = new System.Drawing.Size(121, 24);
            this.parameterBox.TabIndex = 8;
            // 
            // parameterBtn
            // 
            this.parameterBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterBtn.Location = new System.Drawing.Point(12, 417);
            this.parameterBtn.Name = "parameterBtn";
            this.parameterBtn.Size = new System.Drawing.Size(249, 30);
            this.parameterBtn.TabIndex = 9;
            this.parameterBtn.Text = "Show cars by parameter";
            this.parameterBtn.UseVisualStyleBackColor = true;
            this.parameterBtn.Click += new System.EventHandler(this.parameterBtn_Click);
            // 
            // allCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parameterBtn);
            this.Controls.Add(this.parameterBox);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showCarsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "allCars";
            this.Text = "allCars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showCarsBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.ComboBox parameterBox;
        private System.Windows.Forms.Button parameterBtn;
    }
}