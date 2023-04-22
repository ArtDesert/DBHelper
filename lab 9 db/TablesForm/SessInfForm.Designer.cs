namespace lab_9_db
{
    partial class SessInfForm
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
            this.SessInfDGV = new System.Windows.Forms.DataGridView();
            this.nUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPERTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sESSINFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLab9 = new lab_9_db.DataSetLab9();
            this.sESS_INFTableAdapter = new lab_9_db.DataSetLab9TableAdapters.SESS_INFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SessInfDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sESSINFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLab9)).BeginInit();
            this.SuspendLayout();
            // 
            // SessInfDGV
            // 
            this.SessInfDGV.AllowUserToAddRows = false;
            this.SessInfDGV.AllowUserToDeleteRows = false;
            this.SessInfDGV.AllowUserToResizeColumns = false;
            this.SessInfDGV.AllowUserToResizeRows = false;
            this.SessInfDGV.AutoGenerateColumns = false;
            this.SessInfDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SessInfDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.SessInfDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessInfDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMDataGridViewTextBoxColumn,
            this.pROPERTYDataGridViewTextBoxColumn});
            this.SessInfDGV.DataSource = this.sESSINFBindingSource;
            this.SessInfDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SessInfDGV.Location = new System.Drawing.Point(0, 0);
            this.SessInfDGV.Name = "SessInfDGV";
            this.SessInfDGV.ReadOnly = true;
            this.SessInfDGV.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.SessInfDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SessInfDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SessInfDGV.Size = new System.Drawing.Size(800, 450);
            this.SessInfDGV.TabIndex = 1;
            // 
            // nUMDataGridViewTextBoxColumn
            // 
            this.nUMDataGridViewTextBoxColumn.DataPropertyName = "NUM";
            this.nUMDataGridViewTextBoxColumn.HeaderText = "NUM";
            this.nUMDataGridViewTextBoxColumn.Name = "nUMDataGridViewTextBoxColumn";
            this.nUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROPERTYDataGridViewTextBoxColumn
            // 
            this.pROPERTYDataGridViewTextBoxColumn.DataPropertyName = "PROPERTY";
            this.pROPERTYDataGridViewTextBoxColumn.HeaderText = "PROPERTY";
            this.pROPERTYDataGridViewTextBoxColumn.Name = "pROPERTYDataGridViewTextBoxColumn";
            this.pROPERTYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sESSINFBindingSource
            // 
            this.sESSINFBindingSource.DataMember = "SESS_INF";
            this.sESSINFBindingSource.DataSource = this.dataSetLab9;
            // 
            // dataSetLab9
            // 
            this.dataSetLab9.DataSetName = "DataSetLab9";
            this.dataSetLab9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sESS_INFTableAdapter
            // 
            this.sESS_INFTableAdapter.ClearBeforeFill = true;
            // 
            // SessInfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SessInfDGV);
            this.Name = "SessInfForm";
            this.Text = "SessInfForm";
            this.Load += new System.EventHandler(this.SessInfForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessInfDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sESSINFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLab9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView SessInfDGV;
        private DataSetLab9 dataSetLab9;
        private System.Windows.Forms.BindingSource sESSINFBindingSource;
        private DataSetLab9TableAdapters.SESS_INFTableAdapter sESS_INFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPERTYDataGridViewTextBoxColumn;
    }
}