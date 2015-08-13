namespace POS
{
    partial class UserView
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.llblLog = new System.Windows.Forms.LinkLabel();
            this.dgvUsr = new System.Windows.Forms.DataGridView();
            this.dtpDtAdd = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.pCatV = new System.Windows.Forms.Panel();
            this.pCatAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tBxFirstName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsr)).BeginInit();
            this.pCatV.SuspendLayout();
            this.pCatAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(954, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 21;
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
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 493);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Quick Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // llblLog
            // 
            this.llblLog.AutoSize = true;
            this.llblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLog.Location = new System.Drawing.Point(12, 24);
            this.llblLog.Name = "llblLog";
            this.llblLog.Size = new System.Drawing.Size(51, 16);
            this.llblLog.TabIndex = 19;
            this.llblLog.TabStop = true;
            this.llblLog.Text = "Log In?";
            // 
            // dgvUsr
            // 
            this.dgvUsr.AllowUserToAddRows = false;
            this.dgvUsr.AllowUserToDeleteRows = false;
            this.dgvUsr.AllowUserToOrderColumns = true;
            this.dgvUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsr.Location = new System.Drawing.Point(3, 3);
            this.dgvUsr.Name = "dgvUsr";
            this.dgvUsr.Size = new System.Drawing.Size(760, 343);
            this.dgvUsr.TabIndex = 5;
            this.dgvUsr.TabStop = false;
            this.dgvUsr.Click += new System.EventHandler(this.dgvUsr_Click);
            // 
            // dtpDtAdd
            // 
            this.dtpDtAdd.Enabled = false;
            this.dtpDtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAdd.Location = new System.Drawing.Point(275, 502);
            this.dtpDtAdd.Name = "dtpDtAdd";
            this.dtpDtAdd.Size = new System.Drawing.Size(231, 22);
            this.dtpDtAdd.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(769, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 69);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pCatV
            // 
            this.pCatV.Controls.Add(this.pCatAdd);
            this.pCatV.Controls.Add(this.btnAdd);
            this.pCatV.Controls.Add(this.dgvUsr);
            this.pCatV.Controls.Add(this.dtpDtAdd);
            this.pCatV.Controls.Add(this.btnClose);
            this.pCatV.Controls.Add(this.btnDel);
            this.pCatV.Controls.Add(this.btnSave);
            this.pCatV.Controls.Add(this.btnEdit);
            this.pCatV.Location = new System.Drawing.Point(12, 43);
            this.pCatV.Name = "pCatV";
            this.pCatV.Size = new System.Drawing.Size(930, 527);
            this.pCatV.TabIndex = 22;
            // 
            // pCatAdd
            // 
            this.pCatAdd.Controls.Add(this.label1);
            this.pCatAdd.Controls.Add(this.txtBxPassword);
            this.pCatAdd.Controls.Add(this.cmbType);
            this.pCatAdd.Controls.Add(this.tBxFirstName);
            this.pCatAdd.Controls.Add(this.lblName);
            this.pCatAdd.Controls.Add(this.lblType);
            this.pCatAdd.Location = new System.Drawing.Point(3, 352);
            this.pCatAdd.Name = "pCatAdd";
            this.pCatAdd.Size = new System.Drawing.Size(547, 135);
            this.pCatAdd.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Password:";
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBxPassword.Location = new System.Drawing.Point(272, 105);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '●';
            this.txtBxPassword.Size = new System.Drawing.Size(272, 26);
            this.txtBxPassword.TabIndex = 18;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(272, 55);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(272, 28);
            this.cmbType.TabIndex = 15;
            // 
            // tBxFirstName
            // 
            this.tBxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxFirstName.Location = new System.Drawing.Point(272, 5);
            this.tBxFirstName.Name = "tBxFirstName";
            this.tBxFirstName.Size = new System.Drawing.Size(272, 26);
            this.tBxFirstName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(3, 58);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(85, 20);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "User Type:";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(769, 144);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(158, 69);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(769, 277);
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
            this.btnEdit.Location = new System.Drawing.Point(769, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 69);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 595);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.llblLog);
            this.Controls.Add(this.pCatV);
            this.Name = "UserView";
            this.Text = "Users View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsr)).EndInit();
            this.pCatV.ResumeLayout(false);
            this.pCatAdd.ResumeLayout(false);
            this.pCatAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel llblLog;
        private System.Windows.Forms.DataGridView dgvUsr;
        private System.Windows.Forms.DateTimePicker dtpDtAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pCatV;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pCatAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox tBxFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;

    }
}