namespace POS
{
    partial class QuanTypeAdd
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dtpDtAdd = new System.Windows.Forms.DateTimePicker();
            this.btnExt = new System.Windows.Forms.Button();
            this.lblQuanType = new System.Windows.Forms.Label();
            this.txtQtyType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.llblLog = new System.Windows.Forms.LinkLabel();
            this.pQtyTAdd = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pQtyTAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(481, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dtpDtAdd
            // 
            this.dtpDtAdd.Enabled = false;
            this.dtpDtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAdd.Location = new System.Drawing.Point(3, 121);
            this.dtpDtAdd.Name = "dtpDtAdd";
            this.dtpDtAdd.Size = new System.Drawing.Size(231, 22);
            this.dtpDtAdd.TabIndex = 10;
            this.dtpDtAdd.ValueChanged += new System.EventHandler(this.dtpDtAdd_ValueChanged);
            // 
            // btnExt
            // 
            this.btnExt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.Location = new System.Drawing.Point(3, 52);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(175, 63);
            this.btnExt.TabIndex = 2;
            this.btnExt.Text = "Close";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // lblQuanType
            // 
            this.lblQuanType.AutoSize = true;
            this.lblQuanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanType.Location = new System.Drawing.Point(3, 10);
            this.lblQuanType.Name = "lblQuanType";
            this.lblQuanType.Size = new System.Drawing.Size(114, 20);
            this.lblQuanType.TabIndex = 8;
            this.lblQuanType.Text = "Quantity Type :";
            // 
            // txtQtyType
            // 
            this.txtQtyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyType.Location = new System.Drawing.Point(129, 7);
            this.txtQtyType.Name = "txtQtyType";
            this.txtQtyType.Size = new System.Drawing.Size(325, 26);
            this.txtQtyType.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(279, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 63);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // llblLog
            // 
            this.llblLog.AutoSize = true;
            this.llblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLog.Location = new System.Drawing.Point(12, 24);
            this.llblLog.Name = "llblLog";
            this.llblLog.Size = new System.Drawing.Size(51, 16);
            this.llblLog.TabIndex = 0;
            this.llblLog.TabStop = true;
            this.llblLog.Text = "Log In?";
            // 
            // pQtyTAdd
            // 
            this.pQtyTAdd.Controls.Add(this.dtpDtAdd);
            this.pQtyTAdd.Controls.Add(this.lblQuanType);
            this.pQtyTAdd.Controls.Add(this.btnExt);
            this.pQtyTAdd.Controls.Add(this.btnAdd);
            this.pQtyTAdd.Controls.Add(this.txtQtyType);
            this.pQtyTAdd.Location = new System.Drawing.Point(12, 43);
            this.pQtyTAdd.Name = "pQtyTAdd";
            this.pQtyTAdd.Size = new System.Drawing.Size(457, 146);
            this.pQtyTAdd.TabIndex = 13;
            // 
            // QuanTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExt;
            this.ClientSize = new System.Drawing.Size(481, 218);
            this.Controls.Add(this.pQtyTAdd);
            this.Controls.Add(this.llblLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanTypeAdd";
            this.Text = "Quantity Add";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pQtyTAdd.ResumeLayout(false);
            this.pQtyTAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Label lblQuanType;
        private System.Windows.Forms.TextBox txtQtyType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpDtAdd;
        private System.Windows.Forms.LinkLabel llblLog;
        private System.Windows.Forms.Panel pQtyTAdd;
    }
}