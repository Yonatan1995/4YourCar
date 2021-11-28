namespace mainProject
{
    partial class addPart
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addNewCarBtn = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinInStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Part name";
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(230, 79);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(155, 22);
            this.txtPartName.TabIndex = 57;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(2, 293);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(169, 86);
            this.deleteBtn.TabIndex = 56;
            this.deleteBtn.Text = "Delete part by id";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addNewCarBtn
            // 
            this.addNewCarBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCarBtn.Location = new System.Drawing.Point(354, 293);
            this.addNewCarBtn.Name = "addNewCarBtn";
            this.addNewCarBtn.Size = new System.Drawing.Size(171, 86);
            this.addNewCarBtn.TabIndex = 55;
            this.addNewCarBtn.Text = "Add new part";
            this.addNewCarBtn.UseVisualStyleBackColor = true;
            this.addNewCarBtn.Click += new System.EventHandler(this.addNewPartBtn_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(230, 199);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(155, 22);
            this.txtStock.TabIndex = 54;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(230, 157);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(155, 22);
            this.txtCost.TabIndex = 52;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(230, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 22);
            this.txtPrice.TabIndex = 50;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Stock";
            // 
            // txtIdPart
            // 
            this.txtIdPart.Location = new System.Drawing.Point(230, 42);
            this.txtIdPart.Name = "txtIdPart";
            this.txtIdPart.Size = new System.Drawing.Size(155, 22);
            this.txtIdPart.TabIndex = 48;
            this.txtIdPart.Text = "only for edit\\delete part";
            this.txtIdPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Id part";
            // 
            // txtMinInStock
            // 
            this.txtMinInStock.Location = new System.Drawing.Point(230, 238);
            this.txtMinInStock.Name = "txtMinInStock";
            this.txtMinInStock.Size = new System.Drawing.Size(155, 22);
            this.txtMinInStock.TabIndex = 60;
            this.txtMinInStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Minimum in stock";
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(177, 293);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(169, 86);
            this.editBtn.TabIndex = 61;
            this.editBtn.Text = "Edit stock by id";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 411);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.txtMinInStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addNewCarBtn);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPart);
            this.Controls.Add(this.label1);
            this.Name = "addPart";
            this.Text = "addPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addNewCarBtn;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinInStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editBtn;
    }
}