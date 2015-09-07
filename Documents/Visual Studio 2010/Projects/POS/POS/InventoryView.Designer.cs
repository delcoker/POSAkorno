namespace POS
{
    partial class InventoryView
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.dtpDtAdd = new System.Windows.Forms.DateTimePicker();
            this.lblQty = new System.Windows.Forms.Label();
            this.pEdt = new System.Windows.Forms.Panel();
            this.gpbx = new System.Windows.Forms.GroupBox();
            this.rdbDeduct = new System.Windows.Forms.RadioButton();
            this.rdbAddition = new System.Windows.Forms.RadioButton();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pMealEdit = new System.Windows.Forms.Panel();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.llblLog = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.pEdt.SuspendLayout();
            this.gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pMealEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 631);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Tag = "3";
            this.btnAdd.Text = "&Add Stock";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(3, 89);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(110, 20);
            this.lblUpdate.TabIndex = 14;
            this.lblUpdate.Text = "Addition Date:";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(604, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(255, 94);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Tag = "3";
            this.btnEdit.Text = "Edit Stock";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(604, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(255, 94);
            this.btnSave.TabIndex = 1;
            this.btnSave.Tag = "3";
            this.btnSave.Text = "Add / Deduct";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(604, 157);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(255, 94);
            this.btnDel.TabIndex = 2;
            this.btnDel.Tag = "3";
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(604, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(255, 94);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Item Name :";
            // 
            // dgvInv
            // 
            this.dgvInv.AllowUserToAddRows = false;
            this.dgvInv.AllowUserToDeleteRows = false;
            this.dgvInv.AllowUserToOrderColumns = true;
            this.dgvInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Location = new System.Drawing.Point(6, 43);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.ReadOnly = true;
            this.dgvInv.Size = new System.Drawing.Size(583, 439);
            this.dgvInv.TabIndex = 22;
            this.dgvInv.Click += new System.EventHandler(this.dgvInv_Click);
            // 
            // dtpDtAdd
            // 
            this.dtpDtAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDtAdd.Enabled = false;
            this.dtpDtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAdd.Location = new System.Drawing.Point(358, 640);
            this.dtpDtAdd.Name = "dtpDtAdd";
            this.dtpDtAdd.Size = new System.Drawing.Size(231, 22);
            this.dtpDtAdd.TabIndex = 13;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(3, 49);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(76, 20);
            this.lblQty.TabIndex = 16;
            this.lblQty.Text = "Quantity :";
            // 
            // pEdt
            // 
            this.pEdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pEdt.Controls.Add(this.gpbx);
            this.pEdt.Controls.Add(this.dtpDateAdded);
            this.pEdt.Controls.Add(this.lblName);
            this.pEdt.Controls.Add(this.lblUpdate);
            this.pEdt.Controls.Add(this.lblQty);
            this.pEdt.Controls.Add(this.cmbItems);
            this.pEdt.Controls.Add(this.numQty);
            this.pEdt.Location = new System.Drawing.Point(6, 488);
            this.pEdt.Name = "pEdt";
            this.pEdt.Size = new System.Drawing.Size(583, 135);
            this.pEdt.TabIndex = 27;
            // 
            // gpbx
            // 
            this.gpbx.Controls.Add(this.rdbDeduct);
            this.gpbx.Controls.Add(this.rdbAddition);
            this.gpbx.Location = new System.Drawing.Point(410, 9);
            this.gpbx.Name = "gpbx";
            this.gpbx.Size = new System.Drawing.Size(162, 106);
            this.gpbx.TabIndex = 29;
            this.gpbx.TabStop = false;
            this.gpbx.Text = "Addiion / Deduction";
            // 
            // rdbDeduct
            // 
            this.rdbDeduct.AutoSize = true;
            this.rdbDeduct.Location = new System.Drawing.Point(7, 75);
            this.rdbDeduct.Name = "rdbDeduct";
            this.rdbDeduct.Size = new System.Drawing.Size(60, 17);
            this.rdbDeduct.TabIndex = 1;
            this.rdbDeduct.TabStop = true;
            this.rdbDeduct.Text = "Deduct";
            this.rdbDeduct.UseVisualStyleBackColor = true;
            // 
            // rdbAddition
            // 
            this.rdbAddition.AutoSize = true;
            this.rdbAddition.Location = new System.Drawing.Point(7, 31);
            this.rdbAddition.Name = "rdbAddition";
            this.rdbAddition.Size = new System.Drawing.Size(44, 17);
            this.rdbAddition.TabIndex = 0;
            this.rdbAddition.TabStop = true;
            this.rdbAddition.Text = "Add";
            this.rdbAddition.UseVisualStyleBackColor = true;
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.Enabled = false;
            this.dtpDateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAdded.Location = new System.Drawing.Point(152, 89);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(238, 22);
            this.dtpDateAdded.TabIndex = 28;
            // 
            // cmbItems
            // 
            this.cmbItems.Enabled = false;
            this.cmbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItems.Location = new System.Drawing.Point(152, 6);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(238, 28);
            this.cmbItems.TabIndex = 2;
            // 
            // numQty
            // 
            this.numQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQty.Location = new System.Drawing.Point(152, 47);
            this.numQty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(238, 26);
            this.numQty.TabIndex = 1;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(862, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pMealEdit
            // 
            this.pMealEdit.Controls.Add(this.btnTrack);
            this.pMealEdit.Controls.Add(this.btnAddItem);
            this.pMealEdit.Controls.Add(this.pEdt);
            this.pMealEdit.Controls.Add(this.btnAdd);
            this.pMealEdit.Controls.Add(this.llblLog);
            this.pMealEdit.Controls.Add(this.btnEdit);
            this.pMealEdit.Controls.Add(this.btnSave);
            this.pMealEdit.Controls.Add(this.btnDel);
            this.pMealEdit.Controls.Add(this.btnClose);
            this.pMealEdit.Controls.Add(this.dgvInv);
            this.pMealEdit.Controls.Add(this.dtpDtAdd);
            this.pMealEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMealEdit.Location = new System.Drawing.Point(0, 0);
            this.pMealEdit.Name = "pMealEdit";
            this.pMealEdit.Size = new System.Drawing.Size(862, 687);
            this.pMealEdit.TabIndex = 24;
            // 
            // btnTrack
            // 
            this.btnTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrack.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrack.Location = new System.Drawing.Point(604, 387);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(255, 94);
            this.btnTrack.TabIndex = 29;
            this.btnTrack.Tag = "3";
            this.btnTrack.Text = "Track New Item";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(145, 631);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(133, 31);
            this.btnAddItem.TabIndex = 28;
            this.btnAddItem.Tag = "3";
            this.btnAddItem.Text = "View All &Items";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // llblLog
            // 
            this.llblLog.AutoSize = true;
            this.llblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLog.Location = new System.Drawing.Point(3, 24);
            this.llblLog.Name = "llblLog";
            this.llblLog.Size = new System.Drawing.Size(51, 16);
            this.llblLog.TabIndex = 21;
            this.llblLog.TabStop = true;
            this.llblLog.Text = "Log In?";
            // 
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(862, 687);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pMealEdit);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(629, 563);
            this.Name = "InventoryView";
            this.Text = "Inventory View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.pEdt.ResumeLayout(false);
            this.pEdt.PerformLayout();
            this.gpbx.ResumeLayout(false);
            this.gpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pMealEdit.ResumeLayout(false);
            this.pMealEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.DateTimePicker dtpDtAdd;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Panel pEdt;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pMealEdit;
        private System.Windows.Forms.LinkLabel llblLog;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.GroupBox gpbx;
        private System.Windows.Forms.RadioButton rdbDeduct;
        private System.Windows.Forms.RadioButton rdbAddition;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnTrack;
    }
}