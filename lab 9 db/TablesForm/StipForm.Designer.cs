namespace lab_9_db
{
    partial class StipForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StipDGV = new System.Windows.Forms.DataGridView();
            this.nUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLab9 = new lab_9_db.DataSetLab9();
            this.sTIPTableAdapter = new lab_9_db.DataSetLab9TableAdapters.STIPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StipDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTIPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLab9)).BeginInit();
            this.SuspendLayout();
            // 
            // StipDGV
            // 
            this.StipDGV.AllowUserToAddRows = false;
            this.StipDGV.AllowUserToDeleteRows = false;
            this.StipDGV.AllowUserToResizeColumns = false;
            this.StipDGV.AllowUserToResizeRows = false;
            this.StipDGV.AutoGenerateColumns = false;
            this.StipDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StipDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.StipDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StipDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMDataGridViewTextBoxColumn,
            this.sALARYDataGridViewTextBoxColumn});
            this.StipDGV.DataSource = this.sTIPBindingSource;
            this.StipDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StipDGV.Location = new System.Drawing.Point(0, 0);
            this.StipDGV.Name = "StipDGV";
            this.StipDGV.ReadOnly = true;
            this.StipDGV.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.StipDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StipDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StipDGV.Size = new System.Drawing.Size(800, 450);
            this.StipDGV.TabIndex = 1;
            // 
            // nUMDataGridViewTextBoxColumn
            // 
            this.nUMDataGridViewTextBoxColumn.DataPropertyName = "NUM";
            this.nUMDataGridViewTextBoxColumn.HeaderText = "NUM";
            this.nUMDataGridViewTextBoxColumn.Name = "nUMDataGridViewTextBoxColumn";
            this.nUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALARYDataGridViewTextBoxColumn
            // 
            this.sALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.HeaderText = "SALARY";
            this.sALARYDataGridViewTextBoxColumn.Name = "sALARYDataGridViewTextBoxColumn";
            this.sALARYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTIPBindingSource
            // 
            this.sTIPBindingSource.DataMember = "STIP";
            this.sTIPBindingSource.DataSource = this.dataSetLab9;
            // 
            // dataSetLab9
            // 
            this.dataSetLab9.DataSetName = "DataSetLab9";
            this.dataSetLab9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTIPTableAdapter
            // 
            this.sTIPTableAdapter.ClearBeforeFill = true;
            // 
            // StipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StipDGV);
            this.Name = "StipForm";
            this.Text = "StipForm";
            this.Load += new System.EventHandler(this.StipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StipDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTIPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLab9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView StipDGV;
        private DataSetLab9 dataSetLab9;
        private System.Windows.Forms.BindingSource sTIPBindingSource;
        private DataSetLab9TableAdapters.STIPTableAdapter sTIPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARYDataGridViewTextBoxColumn;
    }
}