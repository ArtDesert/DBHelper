namespace lab_9_db
{
    partial class SessionHistoryForm
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
            this.SessHistDGV = new System.Windows.Forms.DataGridView();
            this.nUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sESSNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUB1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUB2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUB3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sESSIONHISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLab9 = new lab_9_db.DataSetLab9();
            this.sESSION_HISTORYTableAdapter = new lab_9_db.DataSetLab9TableAdapters.SESSION_HISTORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SessHistDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sESSIONHISTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLab9)).BeginInit();
            this.SuspendLayout();
            // 
            // SessHistDGV
            // 
            this.SessHistDGV.AllowUserToAddRows = false;
            this.SessHistDGV.AllowUserToDeleteRows = false;
            this.SessHistDGV.AllowUserToResizeColumns = false;
            this.SessHistDGV.AllowUserToResizeRows = false;
            this.SessHistDGV.AutoGenerateColumns = false;
            this.SessHistDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SessHistDGV.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.SessHistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessHistDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMDataGridViewTextBoxColumn,
            this.sESSNUMDataGridViewTextBoxColumn,
            this.sUB1DataGridViewTextBoxColumn,
            this.sUB2DataGridViewTextBoxColumn,
            this.sUB3DataGridViewTextBoxColumn});
            this.SessHistDGV.DataSource = this.sESSIONHISTORYBindingSource;
            this.SessHistDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SessHistDGV.Location = new System.Drawing.Point(0, 0);
            this.SessHistDGV.Name = "SessHistDGV";
            this.SessHistDGV.ReadOnly = true;
            this.SessHistDGV.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.SessHistDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SessHistDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SessHistDGV.Size = new System.Drawing.Size(800, 450);
            this.SessHistDGV.TabIndex = 1;
            // 
            // nUMDataGridViewTextBoxColumn
            // 
            this.nUMDataGridViewTextBoxColumn.DataPropertyName = "NUM";
            this.nUMDataGridViewTextBoxColumn.HeaderText = "NUM";
            this.nUMDataGridViewTextBoxColumn.Name = "nUMDataGridViewTextBoxColumn";
            this.nUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sESSNUMDataGridViewTextBoxColumn
            // 
            this.sESSNUMDataGridViewTextBoxColumn.DataPropertyName = "SESSNUM";
            this.sESSNUMDataGridViewTextBoxColumn.HeaderText = "SESSNUM";
            this.sESSNUMDataGridViewTextBoxColumn.Name = "sESSNUMDataGridViewTextBoxColumn";
            this.sESSNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUB1DataGridViewTextBoxColumn
            // 
            this.sUB1DataGridViewTextBoxColumn.DataPropertyName = "SUB1";
            this.sUB1DataGridViewTextBoxColumn.HeaderText = "SUB1";
            this.sUB1DataGridViewTextBoxColumn.Name = "sUB1DataGridViewTextBoxColumn";
            this.sUB1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUB2DataGridViewTextBoxColumn
            // 
            this.sUB2DataGridViewTextBoxColumn.DataPropertyName = "SUB2";
            this.sUB2DataGridViewTextBoxColumn.HeaderText = "SUB2";
            this.sUB2DataGridViewTextBoxColumn.Name = "sUB2DataGridViewTextBoxColumn";
            this.sUB2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUB3DataGridViewTextBoxColumn
            // 
            this.sUB3DataGridViewTextBoxColumn.DataPropertyName = "SUB3";
            this.sUB3DataGridViewTextBoxColumn.HeaderText = "SUB3";
            this.sUB3DataGridViewTextBoxColumn.Name = "sUB3DataGridViewTextBoxColumn";
            this.sUB3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sESSIONHISTORYBindingSource
            // 
            this.sESSIONHISTORYBindingSource.DataMember = "SESSION_HISTORY";
            this.sESSIONHISTORYBindingSource.DataSource = this.dataSetLab9;
            // 
            // dataSetLab9
            // 
            this.dataSetLab9.DataSetName = "DataSetLab9";
            this.dataSetLab9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sESSION_HISTORYTableAdapter
            // 
            this.sESSION_HISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // SessionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SessHistDGV);
            this.Name = "SessionHistoryForm";
            this.Text = "SessionHistoryForm";
            this.Load += new System.EventHandler(this.SessionHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessHistDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sESSIONHISTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLab9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView SessHistDGV;
        private DataSetLab9 dataSetLab9;
        private System.Windows.Forms.BindingSource sESSIONHISTORYBindingSource;
        private DataSetLab9TableAdapters.SESSION_HISTORYTableAdapter sESSION_HISTORYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sESSNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUB1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUB2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUB3DataGridViewTextBoxColumn;
    }
}