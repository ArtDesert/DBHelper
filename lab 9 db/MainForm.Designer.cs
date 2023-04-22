namespace lab_9_db
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnStip = new System.Windows.Forms.Button();
            this.btnSessInf = new System.Windows.Forms.Button();
            this.btnSessHist = new System.Windows.Forms.Button();
            this.btnStud = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.logDGV = new System.Windows.Forms.DataGridView();
            this.DMLPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDMLQuery = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.btnUpdateRow = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDGV)).BeginInit();
            this.DMLPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnStip);
            this.panelMenu.Controls.Add(this.btnSessInf);
            this.panelMenu.Controls.Add(this.btnSessHist);
            this.panelMenu.Controls.Add(this.btnStud);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 513);
            this.panelMenu.TabIndex = 10;
            // 
            // btnStip
            // 
            this.btnStip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStip.FlatAppearance.BorderSize = 0;
            this.btnStip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStip.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStip.Location = new System.Drawing.Point(0, 191);
            this.btnStip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStip.Name = "btnStip";
            this.btnStip.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStip.Size = new System.Drawing.Size(188, 48);
            this.btnStip.TabIndex = 3;
            this.btnStip.Text = "STIP";
            this.btnStip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStip.UseVisualStyleBackColor = true;
            this.btnStip.Click += new System.EventHandler(this.btnStip_Click);
            // 
            // btnSessInf
            // 
            this.btnSessInf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSessInf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSessInf.FlatAppearance.BorderSize = 0;
            this.btnSessInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSessInf.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSessInf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessInf.Location = new System.Drawing.Point(0, 143);
            this.btnSessInf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSessInf.Name = "btnSessInf";
            this.btnSessInf.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSessInf.Size = new System.Drawing.Size(188, 48);
            this.btnSessInf.TabIndex = 2;
            this.btnSessInf.Text = "SESS_INF";
            this.btnSessInf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessInf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSessInf.UseVisualStyleBackColor = true;
            this.btnSessInf.Click += new System.EventHandler(this.btnSessInf_Click);
            // 
            // btnSessHist
            // 
            this.btnSessHist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSessHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSessHist.FlatAppearance.BorderSize = 0;
            this.btnSessHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSessHist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSessHist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessHist.Location = new System.Drawing.Point(0, 95);
            this.btnSessHist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSessHist.Name = "btnSessHist";
            this.btnSessHist.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSessHist.Size = new System.Drawing.Size(188, 48);
            this.btnSessHist.TabIndex = 1;
            this.btnSessHist.Text = "SESSION_HISTORY";
            this.btnSessHist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSessHist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSessHist.UseVisualStyleBackColor = true;
            this.btnSessHist.Click += new System.EventHandler(this.btnSessHist_Click);
            // 
            // btnStud
            // 
            this.btnStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStud.FlatAppearance.BorderSize = 0;
            this.btnStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStud.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStud.Location = new System.Drawing.Point(0, 47);
            this.btnStud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStud.Name = "btnStud";
            this.btnStud.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStud.Size = new System.Drawing.Size(188, 48);
            this.btnStud.TabIndex = 0;
            this.btnStud.Text = "STUDENTS";
            this.btnStud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStud.UseVisualStyleBackColor = true;
            this.btnStud.Click += new System.EventHandler(this.btnStud_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 47);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Teal;
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimaze);
            this.panelTitleBar.Controls.Add(this.btnCLose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(967, 47);
            this.panelTitleBar.TabIndex = 13;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(893, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(32, 32);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click_1);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimaze.ForeColor = System.Drawing.Color.White;
            this.btnMinimaze.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimaze.Image")));
            this.btnMinimaze.Location = new System.Drawing.Point(857, 3);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(32, 32);
            this.btnMinimaze.TabIndex = 3;
            this.btnMinimaze.UseVisualStyleBackColor = true;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click_1);
            // 
            // btnCLose
            // 
            this.btnCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLose.FlatAppearance.BorderSize = 0;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCLose.ForeColor = System.Drawing.Color.White;
            this.btnCLose.Image = ((System.Drawing.Image)(resources.GetObject("btnCLose.Image")));
            this.btnCLose.Location = new System.Drawing.Point(929, 3);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(32, 32);
            this.btnCLose.TabIndex = 2;
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(359, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DATABASE EDITOR";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.AutoScroll = true;
            this.panelDesktopPane.Controls.Add(this.logDGV);
            this.panelDesktopPane.Controls.Add(this.DMLPanel);
            this.panelDesktopPane.Controls.Add(this.panelTitleBar);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(188, 0);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(967, 513);
            this.panelDesktopPane.TabIndex = 13;
            // 
            // logDGV
            // 
            this.logDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logDGV.Location = new System.Drawing.Point(957, 47);
            this.logDGV.Name = "logDGV";
            this.logDGV.Size = new System.Drawing.Size(10, 10);
            this.logDGV.TabIndex = 15;
            this.logDGV.Visible = false;
            // 
            // DMLPanel
            // 
            this.DMLPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DMLPanel.Controls.Add(this.button1);
            this.DMLPanel.Controls.Add(this.btnDMLQuery);
            this.DMLPanel.Controls.Add(this.btnRemoveRow);
            this.DMLPanel.Controls.Add(this.btnUpdateRow);
            this.DMLPanel.Controls.Add(this.btnAddRow);
            this.DMLPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DMLPanel.Location = new System.Drawing.Point(0, 457);
            this.DMLPanel.Name = "DMLPanel";
            this.DMLPanel.Size = new System.Drawing.Size(967, 56);
            this.DMLPanel.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(627, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(170, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create general report";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDMLQuery
            // 
            this.btnDMLQuery.BackColor = System.Drawing.Color.Teal;
            this.btnDMLQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDMLQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDMLQuery.FlatAppearance.BorderSize = 0;
            this.btnDMLQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMLQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDMLQuery.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDMLQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMLQuery.Location = new System.Drawing.Point(797, 0);
            this.btnDMLQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDMLQuery.Name = "btnDMLQuery";
            this.btnDMLQuery.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDMLQuery.Size = new System.Drawing.Size(170, 56);
            this.btnDMLQuery.TabIndex = 6;
            this.btnDMLQuery.Text = "Create report";
            this.btnDMLQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDMLQuery.UseVisualStyleBackColor = false;
            this.btnDMLQuery.Click += new System.EventHandler(this.btnDMLQuery_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRemoveRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveRow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemoveRow.FlatAppearance.BorderSize = 0;
            this.btnRemoveRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveRow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveRow.Location = new System.Drawing.Point(407, 0);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRemoveRow.Size = new System.Drawing.Size(221, 56);
            this.btnRemoveRow.TabIndex = 3;
            this.btnRemoveRow.Text = "Remove row";
            this.btnRemoveRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveRow.UseVisualStyleBackColor = false;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // btnUpdateRow
            // 
            this.btnUpdateRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUpdateRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdateRow.FlatAppearance.BorderSize = 0;
            this.btnUpdateRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateRow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRow.Location = new System.Drawing.Point(199, 0);
            this.btnUpdateRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateRow.Name = "btnUpdateRow";
            this.btnUpdateRow.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUpdateRow.Size = new System.Drawing.Size(208, 56);
            this.btnUpdateRow.TabIndex = 2;
            this.btnUpdateRow.Text = "Update row";
            this.btnUpdateRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateRow.UseVisualStyleBackColor = false;
            this.btnUpdateRow.Click += new System.EventHandler(this.btnUpdateRow_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddRow.FlatAppearance.BorderSize = 0;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRow.Location = new System.Drawing.Point(0, 0);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddRow.Size = new System.Drawing.Size(199, 56);
            this.btnAddRow.TabIndex = 1;
            this.btnAddRow.Text = "Add row";
            this.btnAddRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRow.UseVisualStyleBackColor = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 513);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1171, 552);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logDGV)).EndInit();
            this.DMLPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnStip;
        private System.Windows.Forms.Button btnSessInf;
        private System.Windows.Forms.Button btnSessHist;
        private System.Windows.Forms.Button btnStud;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel DMLPanel;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnUpdateRow;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDMLQuery;
        private System.Windows.Forms.DataGridView logDGV;
    }
}

