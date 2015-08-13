namespace POS
{
    partial class CategoryAdd
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
            this.llblLog = new System.Windows.Forms.LinkLabel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCatAdd = new System.Windows.Forms.Panel();
            this.lblCat = new System.Windows.Forms.Label();
            this.dtpDtAdd = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.pCatAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblLog
            // 
            this.llblLog.AutoSize = true;
            this.llblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLog.Location = new System.Drawing.Point(12, 24);
            this.llblLog.Name = "llblLog";
            this.llblLog.Size = new System.Drawing.Size(51, 16);
            this.llblLog.TabIndex = 16;
            this.llblLog.TabStop = true;
            this.llblLog.Text = "Log In?";
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 195);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // pCatAdd
            // 
            this.pCatAdd.Controls.Add(this.lblCat);
            this.pCatAdd.Controls.Add(this.dtpDtAdd);
            this.pCatAdd.Controls.Add(this.btnAdd);
            this.pCatAdd.Controls.Add(this.btnCls);
            this.pCatAdd.Controls.Add(this.txtCat);
            this.pCatAdd.Location = new System.Drawing.Point(12, 43);
            this.pCatAdd.Name = "pCatAdd";
            this.pCatAdd.Size = new System.Drawing.Size(453, 149);
            this.pCatAdd.TabIndex = 17;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(3, 11);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(81, 20);
            this.lblCat.TabIndex = 8;
            this.lblCat.Text = "Category :";
            // 
            // dtpDtAdd
            // 
            this.dtpDtAdd.Enabled = false;
            this.dtpDtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAdd.Location = new System.Drawing.Point(3, 124);
            this.dtpDtAdd.Name = "dtpDtAdd";
            this.dtpDtAdd.Size = new System.Drawing.Size(231, 22);
            this.dtpDtAdd.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(275, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 63);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCls
            // 
            this.btnCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCls.Location = new System.Drawing.Point(3, 48);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(175, 63);
            this.btnCls.TabIndex = 2;
            this.btnCls.Text = "Close";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // txtCat
            // 
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.Location = new System.Drawing.Point(125, 8);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(325, 26);
            this.txtCat.TabIndex = 0;
            // 
            // CategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 217);
            this.Controls.Add(this.pCatAdd);
            this.Controls.Add(this.llblLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CategoryAdd";
            this.Text = "Category Add";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pCatAdd.ResumeLayout(false);
            this.pCatAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblLog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pCatAdd;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.DateTimePicker dtpDtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.TextBox txtCat;
    }
}