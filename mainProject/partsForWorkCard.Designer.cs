namespace mainProject
{
    partial class partsForWorkCard
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parameterBtn = new System.Windows.Forms.Button();
            this.addPartBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removeBtn = new System.Windows.Forms.Button();
            this.comboBoxIdWorkCard = new System.Windows.Forms.ComboBox();
            this.comboBoxIdWorkCard2 = new System.Windows.Forms.ComboBox();
            this.comboBoxIdPart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(134, 118);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(167, 22);
            this.txtStock.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Id part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Id work card";
            // 
            // parameterBtn
            // 
            this.parameterBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterBtn.Location = new System.Drawing.Point(520, 104);
            this.parameterBtn.Name = "parameterBtn";
            this.parameterBtn.Size = new System.Drawing.Size(268, 37);
            this.parameterBtn.TabIndex = 49;
            this.parameterBtn.Text = "Show parts in work card";
            this.parameterBtn.UseVisualStyleBackColor = true;
            this.parameterBtn.Click += new System.EventHandler(this.parameterBtn_Click);
            // 
            // addPartBtn
            // 
            this.addPartBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartBtn.Location = new System.Drawing.Point(329, 12);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(148, 65);
            this.addPartBtn.TabIndex = 50;
            this.addPartBtn.Text = "Add parts to work card";
            this.addPartBtn.UseVisualStyleBackColor = true;
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 384);
            this.dataGridView1.TabIndex = 51;
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(329, 83);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(148, 65);
            this.removeBtn.TabIndex = 52;
            this.removeBtn.Text = "Remove parts from work card";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // comboBoxIdWorkCard
            // 
            this.comboBoxIdWorkCard.FormattingEnabled = true;
            this.comboBoxIdWorkCard.Location = new System.Drawing.Point(134, 33);
            this.comboBoxIdWorkCard.Name = "comboBoxIdWorkCard";
            this.comboBoxIdWorkCard.Size = new System.Drawing.Size(167, 24);
            this.comboBoxIdWorkCard.TabIndex = 53;
            this.comboBoxIdWorkCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // comboBoxIdWorkCard2
            // 
            this.comboBoxIdWorkCard2.FormattingEnabled = true;
            this.comboBoxIdWorkCard2.Location = new System.Drawing.Point(520, 72);
            this.comboBoxIdWorkCard2.Name = "comboBoxIdWorkCard2";
            this.comboBoxIdWorkCard2.Size = new System.Drawing.Size(268, 24);
            this.comboBoxIdWorkCard2.TabIndex = 54;
            this.comboBoxIdWorkCard2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // comboBoxIdPart
            // 
            this.comboBoxIdPart.FormattingEnabled = true;
            this.comboBoxIdPart.Location = new System.Drawing.Point(134, 73);
            this.comboBoxIdPart.Name = "comboBoxIdPart";
            this.comboBoxIdPart.Size = new System.Drawing.Size(167, 24);
            this.comboBoxIdPart.TabIndex = 55;
            this.comboBoxIdPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // partsForWorkCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.comboBoxIdPart);
            this.Controls.Add(this.comboBoxIdWorkCard2);
            this.Controls.Add(this.comboBoxIdWorkCard);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addPartBtn);
            this.Controls.Add(this.parameterBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "partsForWorkCard";
            this.Text = "partsForWorkCard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button parameterBtn;
        private System.Windows.Forms.Button addPartBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ComboBox comboBoxIdWorkCard;
        private System.Windows.Forms.ComboBox comboBoxIdWorkCard2;
        private System.Windows.Forms.ComboBox comboBoxIdPart;
    }
}