namespace mainProject
{
    partial class allParts
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
            this.showPartsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parameterBtn = new System.Windows.Forms.Button();
            this.parameterBox = new System.Windows.Forms.ComboBox();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(656, 400);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 38);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // showPartsBtn
            // 
            this.showPartsBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPartsBtn.Location = new System.Drawing.Point(465, 400);
            this.showPartsBtn.Name = "showPartsBtn";
            this.showPartsBtn.Size = new System.Drawing.Size(159, 38);
            this.showPartsBtn.TabIndex = 8;
            this.showPartsBtn.Text = "Show all parts";
            this.showPartsBtn.UseVisualStyleBackColor = true;
            this.showPartsBtn.Click += new System.EventHandler(this.showPartsBtn_Click);
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
            this.dataGridView1.TabIndex = 7;
            // 
            // parameterBtn
            // 
            this.parameterBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterBtn.Location = new System.Drawing.Point(12, 409);
            this.parameterBtn.Name = "parameterBtn";
            this.parameterBtn.Size = new System.Drawing.Size(249, 30);
            this.parameterBtn.TabIndex = 12;
            this.parameterBtn.Text = "Show parts by parameter";
            this.parameterBtn.UseVisualStyleBackColor = true;
            this.parameterBtn.Click += new System.EventHandler(this.parameterBtn_Click);
            // 
            // parameterBox
            // 
            this.parameterBox.FormattingEnabled = true;
            this.parameterBox.Items.AddRange(new object[] {
            "idPart",
            "partName",
            "price",
            "cost",
            "stock"});
            this.parameterBox.Location = new System.Drawing.Point(140, 381);
            this.parameterBox.Name = "parameterBox";
            this.parameterBox.Size = new System.Drawing.Size(121, 24);
            this.parameterBox.TabIndex = 11;
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(12, 381);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(107, 22);
            this.txtParameter.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(288, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Parts to order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parameterBtn);
            this.Controls.Add(this.parameterBox);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showPartsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "allParts";
            this.Text = "allParts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button showPartsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button parameterBtn;
        private System.Windows.Forms.ComboBox parameterBox;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Button button1;
    }
}