namespace POS
{
    partial class UserAdd
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
            this.lblType = new System.Windows.Forms.Label();
            this.dtpDtAdd = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.pCatAdd = new System.Windows.Forms.Panel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tBxFirstName = new System.Windows.Forms.TextBox();
            this.tBxLastName = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtBxCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.pCatAdd.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblLog
            // 
            this.llblLog.AutoSize = true;
            this.llblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLog.Location = new System.Drawing.Point(12, 24);
            this.llblLog.Name = "llblLog";
            this.llblLog.Size = new System.Drawing.Size(51, 16);
            this.llblLog.TabIndex = 20;
            this.llblLog.TabStop = true;
            this.llblLog.Text = "Log In?";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(3, 110);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(85, 20);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "User Type:";
            // 
            // dtpDtAdd
            // 
            this.dtpDtAdd.Enabled = false;
            this.dtpDtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAdd.Location = new System.Drawing.Point(3, 252);
            this.dtpDtAdd.Name = "dtpDtAdd";
            this.dtpDtAdd.Size = new System.Drawing.Size(231, 22);
            this.dtpDtAdd.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(275, 183);
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
            this.btnCls.Location = new System.Drawing.Point(3, 183);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(175, 63);
            this.btnCls.TabIndex = 2;
            this.btnCls.Text = "Close";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // pCatAdd
            // 
            this.pCatAdd.Controls.Add(this.label1);
            this.pCatAdd.Controls.Add(this.txtBxPassword);
            this.pCatAdd.Controls.Add(this.lblCompany);
            this.pCatAdd.Controls.Add(this.txtBxCompany);
            this.pCatAdd.Controls.Add(this.cmbType);
            this.pCatAdd.Controls.Add(this.tBxLastName);
            this.pCatAdd.Controls.Add(this.tBxFirstName);
            this.pCatAdd.Controls.Add(this.lblLastName);
            this.pCatAdd.Controls.Add(this.lblFirstName);
            this.pCatAdd.Controls.Add(this.lblType);
            this.pCatAdd.Controls.Add(this.dtpDtAdd);
            this.pCatAdd.Controls.Add(this.btnAdd);
            this.pCatAdd.Controls.Add(this.btnCls);
            this.pCatAdd.Location = new System.Drawing.Point(12, 43);
            this.pCatAdd.Name = "pCatAdd";
            this.pCatAdd.Size = new System.Drawing.Size(453, 277);
            this.pCatAdd.TabIndex = 21;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(490, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(3, 5);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 40);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            // 
            // tBxFirstName
            // 
            this.tBxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxFirstName.Location = new System.Drawing.Point(178, 2);
            this.tBxFirstName.Name = "tBxFirstName";
            this.tBxFirstName.Size = new System.Drawing.Size(272, 26);
            this.tBxFirstName.TabIndex = 13;
            // 
            // tBxLastName
            // 
            this.tBxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxLastName.Location = new System.Drawing.Point(178, 37);
            this.tBxLastName.Name = "tBxLastName";
            this.tBxLastName.Size = new System.Drawing.Size(272, 26);
            this.tBxLastName.TabIndex = 14;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(178, 107);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(272, 28);
            this.cmbType.TabIndex = 15;
            // 
            // txtBxCompany
            // 
            this.txtBxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCompany.Location = new System.Drawing.Point(178, 72);
            this.txtBxCompany.Name = "txtBxCompany";
            this.txtBxCompany.ReadOnly = true;
            this.txtBxCompany.Size = new System.Drawing.Size(272, 26);
            this.txtBxCompany.TabIndex = 16;
            this.txtBxCompany.Text = "Akorno";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(3, 75);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(80, 20);
            this.lblCompany.TabIndex = 17;
            this.lblCompany.Text = "Company:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Password:";
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBxPassword.Location = new System.Drawing.Point(178, 144);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(272, 26);
            this.txtBxPassword.TabIndex = 18;
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 345);
            this.Controls.Add(this.llblLog);
            this.Controls.Add(this.pCatAdd);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserAdd";
            this.Text = "User Add";
            this.pCatAdd.ResumeLayout(false);
            this.pCatAdd.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblLog;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DateTimePicker dtpDtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Panel pCatAdd;
        private System.Windows.Forms.TextBox tBxLastName;
        private System.Windows.Forms.TextBox tBxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtBxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPassword;
    }
}