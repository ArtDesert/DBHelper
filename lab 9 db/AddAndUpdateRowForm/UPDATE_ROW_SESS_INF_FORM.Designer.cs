namespace lab_9_db.AddAndUpdateRowForm
{
    partial class UPDATE_ROW_SESS_INF_FORM
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
            this.brnDecline = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblProp = new System.Windows.Forms.Label();
            this.tbProp = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brnDecline
            // 
            this.brnDecline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brnDecline.Location = new System.Drawing.Point(214, 105);
            this.brnDecline.Name = "brnDecline";
            this.brnDecline.Size = new System.Drawing.Size(117, 33);
            this.brnDecline.TabIndex = 77;
            this.brnDecline.Text = "Decline";
            this.brnDecline.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(36, 105);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 33);
            this.btnConfirm.TabIndex = 76;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProp.Location = new System.Drawing.Point(9, 55);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(96, 20);
            this.lblProp.TabIndex = 75;
            this.lblProp.Text = "PROPERTY";
            // 
            // tbProp
            // 
            this.tbProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProp.Location = new System.Drawing.Point(111, 55);
            this.tbProp.Name = "tbProp";
            this.tbProp.Size = new System.Drawing.Size(249, 26);
            this.tbProp.TabIndex = 74;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(17, 23);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(45, 20);
            this.lblNum.TabIndex = 73;
            this.lblNum.Text = "NUM";
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNum.Location = new System.Drawing.Point(111, 23);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(249, 26);
            this.tbNum.TabIndex = 72;
            // 
            // UPDATE_ROW_SESS_INF_FORM
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.CancelButton = this.brnDecline;
            this.ClientSize = new System.Drawing.Size(369, 161);
            this.Controls.Add(this.brnDecline);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.tbProp);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.tbNum);
            this.MaximumSize = new System.Drawing.Size(385, 200);
            this.MinimumSize = new System.Drawing.Size(385, 200);
            this.Name = "UPDATE_ROW_SESS_INF_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updating row in SESS_INF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnDecline;
        public System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.TextBox tbProp;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox tbNum;
    }
}