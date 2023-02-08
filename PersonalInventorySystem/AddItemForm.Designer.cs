namespace PersonalInventorySystem
{
    partial class AddItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.descriptionTXT = new System.Windows.Forms.TextBox();
            this.priceTXT = new System.Windows.Forms.TextBox();
            this.quantityTXT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.purchaseDateTxt = new System.Windows.Forms.Label();
            this.retailerlbl = new System.Windows.Forms.Label();
            this.imglbl = new System.Windows.Forms.Label();
            this.retailerTxt = new System.Windows.Forms.TextBox();
            this.imageUrlTxt = new System.Windows.Forms.TextBox();
            this.dobtxt = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(12, 26);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(182, 20);
            this.nameTXT.TabIndex = 1;
            // 
            // descriptionTXT
            // 
            this.descriptionTXT.Location = new System.Drawing.Point(12, 66);
            this.descriptionTXT.Name = "descriptionTXT";
            this.descriptionTXT.Size = new System.Drawing.Size(182, 20);
            this.descriptionTXT.TabIndex = 2;
            // 
            // priceTXT
            // 
            this.priceTXT.Location = new System.Drawing.Point(12, 103);
            this.priceTXT.Name = "priceTXT";
            this.priceTXT.Size = new System.Drawing.Size(182, 20);
            this.priceTXT.TabIndex = 3;
            // 
            // quantityTXT
            // 
            this.quantityTXT.Location = new System.Drawing.Point(12, 140);
            this.quantityTXT.Name = "quantityTXT";
            this.quantityTXT.Size = new System.Drawing.Size(182, 20);
            this.quantityTXT.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchaseDateTxt
            // 
            this.purchaseDateTxt.AutoSize = true;
            this.purchaseDateTxt.Location = new System.Drawing.Point(10, 165);
            this.purchaseDateTxt.Name = "purchaseDateTxt";
            this.purchaseDateTxt.Size = new System.Drawing.Size(78, 13);
            this.purchaseDateTxt.TabIndex = 9;
            this.purchaseDateTxt.Text = "Purchase Date";
            // 
            // retailerlbl
            // 
            this.retailerlbl.AutoSize = true;
            this.retailerlbl.Location = new System.Drawing.Point(10, 203);
            this.retailerlbl.Name = "retailerlbl";
            this.retailerlbl.Size = new System.Drawing.Size(43, 13);
            this.retailerlbl.TabIndex = 10;
            this.retailerlbl.Text = "Retailer";
            // 
            // imglbl
            // 
            this.imglbl.AutoSize = true;
            this.imglbl.Location = new System.Drawing.Point(11, 243);
            this.imglbl.Name = "imglbl";
            this.imglbl.Size = new System.Drawing.Size(61, 13);
            this.imglbl.TabIndex = 11;
            this.imglbl.Text = "Image URL";
            // 
            // retailerTxt
            // 
            this.retailerTxt.Location = new System.Drawing.Point(12, 218);
            this.retailerTxt.Name = "retailerTxt";
            this.retailerTxt.Size = new System.Drawing.Size(182, 20);
            this.retailerTxt.TabIndex = 6;
            // 
            // imageUrlTxt
            // 
            this.imageUrlTxt.Location = new System.Drawing.Point(12, 258);
            this.imageUrlTxt.Name = "imageUrlTxt";
            this.imageUrlTxt.Size = new System.Drawing.Size(182, 20);
            this.imageUrlTxt.TabIndex = 7;
            // 
            // dobtxt
            // 
            this.dobtxt.Location = new System.Drawing.Point(12, 179);
            this.dobtxt.Name = "dobtxt";
            this.dobtxt.Size = new System.Drawing.Size(182, 20);
            this.dobtxt.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dobtxt);
            this.Controls.Add(this.imageUrlTxt);
            this.Controls.Add(this.retailerTxt);
            this.Controls.Add(this.imglbl);
            this.Controls.Add(this.retailerlbl);
            this.Controls.Add(this.purchaseDateTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantityTXT);
            this.Controls.Add(this.priceTXT);
            this.Controls.Add(this.descriptionTXT);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(222, 288);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.TextBox descriptionTXT;
        private System.Windows.Forms.TextBox priceTXT;
        private System.Windows.Forms.TextBox quantityTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label purchaseDateTxt;
        private System.Windows.Forms.Label retailerlbl;
        private System.Windows.Forms.Label imglbl;
        private System.Windows.Forms.TextBox retailerTxt;
        private System.Windows.Forms.TextBox imageUrlTxt;
        private System.Windows.Forms.DateTimePicker dobtxt;
        private System.Windows.Forms.Button button2;
    }
}