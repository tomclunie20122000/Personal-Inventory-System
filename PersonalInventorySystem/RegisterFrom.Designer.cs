namespace PersonalInventorySystem
{
    partial class RegisterFrom
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.mobiletxt = new System.Windows.Forms.TextBox();
            this.dobtxt = new System.Windows.Forms.DateTimePicker();
            this.usertblTableAdapter1 = new PersonalInventorySystem.HomeInventorySystemDataSetTableAdapters.usertblTableAdapter();
            this.homeInventorySystemDataSet1 = new PersonalInventorySystem.HomeInventorySystemDataSet();
            this.Cancel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(15, 68);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(100, 20);
            this.passtxt.TabIndex = 2;
            this.passtxt.UseSystemPasswordChar = true;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(15, 25);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(100, 20);
            this.usertxt.TabIndex = 1;
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(88, 147);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(75, 23);
            this.registerbtn.TabIndex = 6;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "D.O.B";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(15, 112);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(100, 20);
            this.emailtxt.TabIndex = 3;
            // 
            // mobiletxt
            // 
            this.mobiletxt.Location = new System.Drawing.Point(130, 25);
            this.mobiletxt.Name = "mobiletxt";
            this.mobiletxt.Size = new System.Drawing.Size(117, 20);
            this.mobiletxt.TabIndex = 4;
            // 
            // dobtxt
            // 
            this.dobtxt.Location = new System.Drawing.Point(130, 68);
            this.dobtxt.Name = "dobtxt";
            this.dobtxt.Size = new System.Drawing.Size(117, 20);
            this.dobtxt.TabIndex = 5;
            // 
            // usertblTableAdapter1
            // 
            this.usertblTableAdapter1.ClearBeforeFill = true;
            // 
            // homeInventorySystemDataSet1
            // 
            this.homeInventorySystemDataSet1.DataSetName = "HomeInventorySystemDataSet";
            this.homeInventorySystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(88, 176);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 13;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // RegisterFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 209);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.dobtxt);
            this.Controls.Add(this.mobiletxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 221);
            this.Name = "RegisterFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox mobiletxt;
        private System.Windows.Forms.DateTimePicker dobtxt;
        private HomeInventorySystemDataSetTableAdapters.usertblTableAdapter usertblTableAdapter1;
        private HomeInventorySystemDataSet homeInventorySystemDataSet1;
        private System.Windows.Forms.Button Cancel_btn;
    }
}