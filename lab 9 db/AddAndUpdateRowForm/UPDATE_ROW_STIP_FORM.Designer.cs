namespace lab_9_db.AddRowForm
{
    partial class UPDATE_ROW_STIP_FORM
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
            this.lblSal = new System.Windows.Forms.Label();
            this.tbSal = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brnDecline
            // 
            this.brnDecline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brnDecline.Location = new System.Drawing.Point(210, 105);
            this.brnDecline.Name = "brnDecline";
            this.brnDecline.Size = new System.Drawing.Size(117, 33);
            this.brnDecline.TabIndex = 71;
            this.brnDecline.Text = "Decline";
            this.brnDecline.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(32, 105);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 33);
            this.btnConfirm.TabIndex = 70;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSal.Location = new System.Drawing.Point(12, 55);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(74, 20);
            this.lblSal.TabIndex = 69;
            this.lblSal.Text = "SALARY";
            // 
            // tbSal
            // 
            this.tbSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSal.Location = new System.Drawing.Point(107, 55);
            this.tbSal.Name = "tbSal";
            this.tbSal.Size = new System.Drawing.Size(249, 26);
            this.tbSal.TabIndex = 68;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(13, 23);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(45, 20);
            this.lblNum.TabIndex = 67;
            this.lblNum.Text = "NUM";
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNum.Location = new System.Drawing.Point(107, 23);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(249, 26);
            this.tbNum.TabIndex = 66;
            // 
            // UPDATE_ROW_STIP_FORM
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.CancelButton = this.brnDecline;
            this.ClientSize = new System.Drawing.Size(369, 161);
            this.Controls.Add(this.brnDecline);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.tbSal);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.tbNum);
            this.MaximumSize = new System.Drawing.Size(385, 200);
            this.MinimumSize = new System.Drawing.Size(385, 200);
            this.Name = "UPDATE_ROW_STIP_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updating row in STIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnDecline;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox tbSal;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox tbNum;
    }
}