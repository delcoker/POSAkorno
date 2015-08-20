namespace POS
{
    partial class NumPortions
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
            this.numPrtns = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCncl = new System.Windows.Forms.Button();
            this.llblLog = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numPrtns)).BeginInit();
            this.SuspendLayout();
            // 
            // numPrtns
            // 
            this.numPrtns.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrtns.Location = new System.Drawing.Point(12, 12);
            this.numPrtns.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numPrtns.Name = "numPrtns";
            this.numPrtns.Size = new System.Drawing.Size(157, 86);
            this.numPrtns.TabIndex = 0;
            this.numPrtns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPrtns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(12, 140);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(157, 86);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCncl
            // 
            this.btnCncl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCncl.Location = new System.Drawing.Point(12, 232);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(157, 86);
            this.btnCncl.TabIndex = 2;
            this.btnCncl.Text = "Cancel";
            this.btnCncl.UseVisualStyleBackColor = true;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // llblLog
            // 
            this.llblLog.AutoSize = true;
            this.llblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLog.Location = new System.Drawing.Point(12, 111);
            this.llblLog.Name = "llblLog";
            this.llblLog.Size = new System.Drawing.Size(51, 16);
            this.llblLog.TabIndex = 4;
            this.llblLog.TabStop = true;
            this.llblLog.Text = "Log In?";
            // 
            // NumPortions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCncl;
            this.ClientSize = new System.Drawing.Size(181, 330);
            this.Controls.Add(this.llblLog);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numPrtns);
            this.Name = "NumPortions";
            this.Text = "Portions";
            ((System.ComponentModel.ISupportInitialize)(this.numPrtns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPrtns;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.LinkLabel llblLog;
    }
}