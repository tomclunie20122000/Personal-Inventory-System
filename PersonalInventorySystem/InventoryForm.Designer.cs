namespace PersonalInventorySystem
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.addItm = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new PersonalInventorySystem.HomeInventorySystemDataSetTableAdapters.TableAdapterManager();
            this.itemtblTableAdapter1 = new PersonalInventorySystem.HomeInventorySystemDataSetTableAdapters.itemtblTableAdapter();
            this.usertblTableAdapter1 = new PersonalInventorySystem.HomeInventorySystemDataSetTableAdapters.usertblTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueperitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtblBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.homeInventorySystemDataSet2 = new PersonalInventorySystem.HomeInventorySystemDataSet();
            this.itemtblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.homeInventorySystemDataSet1 = new PersonalInventorySystem.HomeInventorySystemDataSet();
            this.homeInventorySystemDataSet = new PersonalInventorySystem.HomeInventorySystemDataSet();
            this.itemtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemtblTableAdapter = new PersonalInventorySystem.HomeInventorySystemDataSetTableAdapters.itemtblTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.itemtblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemtblTableAdapter2 = new PersonalInventorySystem.HomeInventorySystemDataSetTableAdapters.itemtblTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.homeInventorySystemDataSet21 = new PersonalInventorySystem.HomeInventorySystemDataSet();
            this.itemtblBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.itemtblTableAdapter3 = new PersonalInventorySystem.HomeInventorySystemDataSetTableAdapters.itemtblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // addItm
            // 
            this.addItm.Location = new System.Drawing.Point(342, 338);
            this.addItm.Name = "addItm";
            this.addItm.Size = new System.Drawing.Size(67, 28);
            this.addItm.TabIndex = 1;
            this.addItm.Text = "Add";
            this.addItm.UseVisualStyleBackColor = true;
            this.addItm.Click += new System.EventHandler(this.addItm_Click);
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.SystemColors.Control;
            this.Profile.Location = new System.Drawing.Point(346, 7);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(63, 28);
            this.Profile.TabIndex = 2;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Location = new System.Drawing.Point(9, 328);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(64, 13);
            this.totalValueLabel.TabIndex = 3;
            this.totalValueLabel.Text = "Total Value:";
            // 
            // totaltxt
            // 
            this.totaltxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.totaltxt.Enabled = false;
            this.totaltxt.HideSelection = false;
            this.totaltxt.Location = new System.Drawing.Point(12, 342);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(98, 20);
            this.totaltxt.TabIndex = 4;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.item_infoTableAdapter = null;
            this.tableAdapterManager1.itemtblTableAdapter = this.itemtblTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = PersonalInventorySystem.HomeInventorySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usertblTableAdapter = this.usertblTableAdapter1;
            // 
            // itemtblTableAdapter1
            // 
            this.itemtblTableAdapter1.ClearBeforeFill = true;
            // 
            // usertblTableAdapter1
            // 
            this.usertblTableAdapter1.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Refresh.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Column1,
            this.user_id,
            this.descriptionDataGridViewTextBoxColumn,
            this.valueperitemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemtblBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(8, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(401, 284);
            this.dataGridView1.TabIndex = 6;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueperitemDataGridViewTextBoxColumn
            // 
            this.valueperitemDataGridViewTextBoxColumn.DataPropertyName = "value_per_item";
            this.valueperitemDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueperitemDataGridViewTextBoxColumn.Name = "valueperitemDataGridViewTextBoxColumn";
            this.valueperitemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemtblBindingSource3
            // 
            this.itemtblBindingSource3.DataMember = "itemtbl";
            this.itemtblBindingSource3.DataSource = this.homeInventorySystemDataSet2;
            // 
            // homeInventorySystemDataSet2
            // 
            this.homeInventorySystemDataSet2.DataSetName = "HomeInventorySystemDataSet2";
            this.homeInventorySystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemtblBindingSource1
            // 
            this.itemtblBindingSource1.DataMember = "itemtbl";
            this.itemtblBindingSource1.DataSource = this.homeInventorySystemDataSet1;
            // 
            // homeInventorySystemDataSet1
            // 
            this.homeInventorySystemDataSet1.DataSetName = "HomeInventorySystemDataSet1";
            this.homeInventorySystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homeInventorySystemDataSet
            // 
            this.homeInventorySystemDataSet.DataSetName = "HomeInventorySystemDataSet";
            this.homeInventorySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemtblBindingSource
            // 
            this.itemtblBindingSource.DataMember = "itemtbl";
            this.itemtblBindingSource.DataSource = this.homeInventorySystemDataSet;
            // 
            // itemtblTableAdapter
            // 
            this.itemtblTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemtblBindingSource2
            // 
            this.itemtblBindingSource2.DataMember = "itemtbl";
            this.itemtblBindingSource2.DataSource = this.homeInventorySystemDataSet;
            // 
            // itemtblTableAdapter2
            // 
            this.itemtblTableAdapter2.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // homeInventorySystemDataSet21
            // 
            this.homeInventorySystemDataSet21.DataSetName = "HomeInventorySystemDataSet2";
            this.homeInventorySystemDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemtblBindingSource4
            // 
            this.itemtblBindingSource4.DataMember = "itemtbl";
            this.itemtblBindingSource4.DataSource = this.homeInventorySystemDataSet21;
            // 
            // itemtblTableAdapter3
            // 
            this.itemtblTableAdapter3.ClearBeforeFill = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(418, 386);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.addItm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory List";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeInventorySystemDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtblBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addItm;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.TextBox totaltxt;
        private HomeInventorySystemDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private HomeInventorySystemDataSetTableAdapters.itemtblTableAdapter itemtblTableAdapter1;
        private HomeInventorySystemDataSetTableAdapters.usertblTableAdapter usertblTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemtblBindingSource;
        private HomeInventorySystemDataSet homeInventorySystemDataSet;
        private HomeInventorySystemDataSet homeInventorySystemDataSet1;
        private System.Windows.Forms.BindingSource itemtblBindingSource1;
        private HomeInventorySystemDataSetTableAdapters.itemtblTableAdapter itemtblTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource itemtblBindingSource2;
        private HomeInventorySystemDataSet homeInventorySystemDataSet2;
        private System.Windows.Forms.BindingSource itemtblBindingSource3;
        private HomeInventorySystemDataSetTableAdapters.itemtblTableAdapter itemtblTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueperitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private HomeInventorySystemDataSet homeInventorySystemDataSet21;
        private System.Windows.Forms.BindingSource itemtblBindingSource4;
        private HomeInventorySystemDataSetTableAdapters.itemtblTableAdapter itemtblTableAdapter3;
    }
}