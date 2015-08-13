namespace POS
{
    partial class PermissionView
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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvPrmssnT = new System.Windows.Forms.DataGridView();
            this.dtpDtAdd = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblQuanType = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtQtyType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pView = new System.Windows.Forms.Panel();
            this.pPerEdit = new System.Windows.Forms.Panel();
            this.numP = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrmssnT)).BeginInit();
            this.pView.SuspendLayout();
            this.pPerEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).BeginInit();
            this.SuspendLayout();
            // 
            // llblLog
            // 
            this.llblLog.AutoSize = true;
            this.llblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLog.Location = new System.Drawing.Point(12, 24);
            this.llblLog.Name = "llblLog";
            this.llblLog.Size = new System.Drawing.Size(51, 16);
            this.llblLog.TabIndex = 17;
            this.llblLog.TabStop = true;
            this.llblLog.Text = "Log In?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(5, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Quick Add";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(681, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvPrmssnT
            // 
            this.dgvPrmssnT.AllowUserToAddRows = false;
            this.dgvPrmssnT.AllowUserToDeleteRows = false;
            this.dgvPrmssnT.AllowUserToOrderColumns = true;
            this.dgvPrmssnT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrmssnT.Location = new System.Drawing.Point(5, 3);
            this.dgvPrmssnT.Name = "dgvPrmssnT";
            this.dgvPrmssnT.Size = new System.Drawing.Size(450, 238);
            this.dgvPrmssnT.TabIndex = 0;
            this.dgvPrmssnT.Click += new System.EventHandler(this.dgvPrmssnT_Click);
            // 
            // dtpDtAdd
            // 
            this.dtpDtAdd.Enabled = false;
            this.dtpDtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAdd.Location = new System.Drawing.Point(224, 350);
            this.dtpDtAdd.Name = "dtpDtAdd";
            this.dtpDtAdd.Size = new System.Drawing.Size(231, 22);
            this.dtpDtAdd.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(494, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 69);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblQuanType
            // 
            this.lblQuanType.AutoSize = true;
            this.lblQuanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanType.Location = new System.Drawing.Point(3, 252);
            this.lblQuanType.Name = "lblQuanType";
            this.lblQuanType.Size = new System.Drawing.Size(143, 20);
            this.lblQuanType.TabIndex = 13;
            this.lblQuanType.Text = "Persmission Level :";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(494, 103);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(158, 69);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtQtyType
            // 
            this.txtQtyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyType.Location = new System.Drawing.Point(75, 5);
            this.txtQtyType.Multiline = true;
            this.txtQtyType.Name = "txtQtyType";
            this.txtQtyType.Size = new System.Drawing.Size(231, 78);
            this.txtQtyType.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(494, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 69);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(494, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 69);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pView
            // 
            this.pView.Controls.Add(this.pPerEdit);
            this.pView.Controls.Add(this.btnAdd);
            this.pView.Controls.Add(this.dgvPrmssnT);
            this.pView.Controls.Add(this.dtpDtAdd);
            this.pView.Controls.Add(this.btnClose);
            this.pView.Controls.Add(this.lblQuanType);
            this.pView.Controls.Add(this.btnDel);
            this.pView.Controls.Add(this.btnSave);
            this.pView.Controls.Add(this.btnEdit);
            this.pView.Location = new System.Drawing.Point(12, 43);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(657, 375);
            this.pView.TabIndex = 18;
            // 
            // pPerEdit
            // 
            this.pPerEdit.Controls.Add(this.numP);
            this.pPerEdit.Controls.Add(this.txtQtyType);
            this.pPerEdit.Location = new System.Drawing.Point(143, 247);
            this.pPerEdit.Name = "pPerEdit";
            this.pPerEdit.Size = new System.Drawing.Size(312, 97);
            this.pPerEdit.TabIndex = 17;
            // 
            // numP
            // 
            this.numP.Location = new System.Drawing.Point(3, 5);
            this.numP.Maximum = new decimal(new int[] {
            98,
            0,
            0,
            0});
            this.numP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numP.Name = "numP";
            this.numP.Size = new System.Drawing.Size(66, 20);
            this.numP.TabIndex = 16;
            this.numP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PermissionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 463);
            this.Controls.Add(this.llblLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pView);
            this.Name = "PermissionView";
            this.Text = "Permission View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrmssnT)).EndInit();
            this.pView.ResumeLayout(false);
            this.pView.PerformLayout();
            this.pPerEdit.ResumeLayout(false);
            this.pPerEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblLog;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvPrmssnT;
        private System.Windows.Forms.DateTimePicker dtpDtAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblQuanType;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtQtyType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pView;
        private System.Windows.Forms.NumericUpDown numP;
        private System.Windows.Forms.Panel pPerEdit;
    }
}