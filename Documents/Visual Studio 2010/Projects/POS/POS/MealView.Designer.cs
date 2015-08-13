namespace POS
{
    partial class MealView
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMealEdit = new System.Windows.Forms.Panel();
            this.pEdt = new System.Windows.Forms.Panel();
            this.rdbHaveStock = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCtgy = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCtgy = new System.Windows.Forms.ComboBox();
            this.cmbQtyType = new System.Windows.Forms.ComboBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.dtpDtAdd = new System.Windows.Forms.DateTimePicker();
            this.llblLog = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.pMealEdit.SuspendLayout();
            this.pEdt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 1;
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
            // pMealEdit
            // 
            this.pMealEdit.Controls.Add(this.pEdt);
            this.pMealEdit.Controls.Add(this.btnAdd);
            this.pMealEdit.Controls.Add(this.btnEdit);
            this.pMealEdit.Controls.Add(this.btnSave);
            this.pMealEdit.Controls.Add(this.btnDel);
            this.pMealEdit.Controls.Add(this.btnClose);
            this.pMealEdit.Controls.Add(this.dgvCat);
            this.pMealEdit.Controls.Add(this.dtpDtAdd);
            this.pMealEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMealEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMealEdit.Location = new System.Drawing.Point(0, 24);
            this.pMealEdit.Name = "pMealEdit";
            this.pMealEdit.Size = new System.Drawing.Size(975, 582);
            this.pMealEdit.TabIndex = 20;
            this.pMealEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.pMealEdit_Paint);
            // 
            // pEdt
            // 
            this.pEdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pEdt.Controls.Add(this.rdbHaveStock);
            this.pEdt.Controls.Add(this.lblName);
            this.pEdt.Controls.Add(this.txtName);
            this.pEdt.Controls.Add(this.lblCtgy);
            this.pEdt.Controls.Add(this.lblPrice);
            this.pEdt.Controls.Add(this.label3);
            this.pEdt.Controls.Add(this.cmbCtgy);
            this.pEdt.Controls.Add(this.cmbQtyType);
            this.pEdt.Controls.Add(this.numPrice);
            this.pEdt.Location = new System.Drawing.Point(3, 377);
            this.pEdt.Name = "pEdt";
            this.pEdt.Size = new System.Drawing.Size(494, 165);
            this.pEdt.TabIndex = 27;
            // 
            // rdbHaveStock
            // 
            this.rdbHaveStock.AutoSize = true;
            this.rdbHaveStock.Location = new System.Drawing.Point(388, 9);
            this.rdbHaveStock.Name = "rdbHaveStock";
            this.rdbHaveStock.Size = new System.Drawing.Size(98, 20);
            this.rdbHaveStock.TabIndex = 21;
            this.rdbHaveStock.TabStop = true;
            this.rdbHaveStock.Text = "Track Stock";
            this.rdbHaveStock.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Meal Name :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(107, 4);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 26);
            this.txtName.TabIndex = 0;
            // 
            // lblCtgy
            // 
            this.lblCtgy.AutoSize = true;
            this.lblCtgy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtgy.Location = new System.Drawing.Point(3, 89);
            this.lblCtgy.Name = "lblCtgy";
            this.lblCtgy.Size = new System.Drawing.Size(81, 20);
            this.lblCtgy.TabIndex = 14;
            this.lblCtgy.Text = "Category :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(3, 49);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Qty Type :";
            // 
            // cmbCtgy
            // 
            this.cmbCtgy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCtgy.Location = new System.Drawing.Point(107, 84);
            this.cmbCtgy.Name = "cmbCtgy";
            this.cmbCtgy.Size = new System.Drawing.Size(238, 28);
            this.cmbCtgy.TabIndex = 2;
            // 
            // cmbQtyType
            // 
            this.cmbQtyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQtyType.Location = new System.Drawing.Point(107, 126);
            this.cmbQtyType.Name = "cmbQtyType";
            this.cmbQtyType.Size = new System.Drawing.Size(238, 28);
            this.cmbQtyType.TabIndex = 3;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPrice.Location = new System.Drawing.Point(107, 44);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(238, 26);
            this.numPrice.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(0, 548);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Tag = "4";
            this.btnAdd.Text = "Quick &Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(766, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(206, 85);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Tag = "4";
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(766, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 85);
            this.btnSave.TabIndex = 1;
            this.btnSave.Tag = "4";
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(766, 147);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(206, 85);
            this.btnDel.TabIndex = 2;
            this.btnDel.Tag = "3";
            this.btnDel.Text = "&Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(766, 494);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(206, 85);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvCat
            // 
            this.dgvCat.AllowUserToAddRows = false;
            this.dgvCat.AllowUserToDeleteRows = false;
            this.dgvCat.AllowUserToOrderColumns = true;
            this.dgvCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.Location = new System.Drawing.Point(3, 19);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.Size = new System.Drawing.Size(740, 341);
            this.dgvCat.TabIndex = 22;
            this.dgvCat.Click += new System.EventHandler(this.dgvCat_Click);
            // 
            // dtpDtAdd
            // 
            this.dtpDtAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDtAdd.Enabled = false;
            this.dtpDtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAdd.Location = new System.Drawing.Point(512, 557);
            this.dtpDtAdd.Name = "dtpDtAdd";
            this.dtpDtAdd.Size = new System.Drawing.Size(231, 22);
            this.dtpDtAdd.TabIndex = 13;
            // 
            // llblLog
            // 
            this.llblLog.AutoSize = true;
            this.llblLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.llblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLog.Location = new System.Drawing.Point(0, 24);
            this.llblLog.Name = "llblLog";
            this.llblLog.Size = new System.Drawing.Size(51, 16);
            this.llblLog.TabIndex = 0;
            this.llblLog.TabStop = true;
            this.llblLog.Text = "Log In?";
            // 
            // MealView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(975, 628);
            this.Controls.Add(this.llblLog);
            this.Controls.Add(this.pMealEdit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(744, 551);
            this.Name = "MealView";
            this.Text = "Dish View / Edit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pMealEdit.ResumeLayout(false);
            this.pEdt.ResumeLayout(false);
            this.pEdt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pMealEdit;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.ComboBox cmbQtyType;
        private System.Windows.Forms.ComboBox cmbCtgy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCtgy;
        private System.Windows.Forms.DateTimePicker dtpDtAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.LinkLabel llblLog;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvCat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pEdt;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbHaveStock;
    }
}