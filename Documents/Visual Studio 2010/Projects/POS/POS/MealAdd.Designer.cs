namespace POS
{
    partial class MealAdd
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
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbQtyType = new System.Windows.Forms.ComboBox();
            this.cmbCtgy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCtgy = new System.Windows.Forms.Label();
            this.dtpDtAdd = new System.Windows.Forms.DateTimePicker();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMealA = new System.Windows.Forms.Panel();
            this.rdbHaveStock = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pMealA.SuspendLayout();
            this.SuspendLayout();
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
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPrice.Location = new System.Drawing.Point(225, 47);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(238, 26);
            this.numPrice.TabIndex = 1;
            // 
            // cmbQtyType
            // 
            this.cmbQtyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQtyType.Location = new System.Drawing.Point(225, 141);
            this.cmbQtyType.Name = "cmbQtyType";
            this.cmbQtyType.Size = new System.Drawing.Size(238, 28);
            this.cmbQtyType.TabIndex = 3;
            // 
            // cmbCtgy
            // 
            this.cmbCtgy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCtgy.Location = new System.Drawing.Point(225, 97);
            this.cmbCtgy.Name = "cmbCtgy";
            this.cmbCtgy.Size = new System.Drawing.Size(238, 28);
            this.cmbCtgy.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Qty Type :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(3, 53);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price :";
            // 
            // lblCtgy
            // 
            this.lblCtgy.AutoSize = true;
            this.lblCtgy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtgy.Location = new System.Drawing.Point(3, 97);
            this.lblCtgy.Name = "lblCtgy";
            this.lblCtgy.Size = new System.Drawing.Size(81, 20);
            this.lblCtgy.TabIndex = 14;
            this.lblCtgy.Text = "Category :";
            // 
            // dtpDtAdd
            // 
            this.dtpDtAdd.Enabled = false;
            this.dtpDtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAdd.Location = new System.Drawing.Point(3, 310);
            this.dtpDtAdd.Name = "dtpDtAdd";
            this.dtpDtAdd.Size = new System.Drawing.Size(231, 22);
            this.dtpDtAdd.TabIndex = 13;
            // 
            // btnExt
            // 
            this.btnExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.Location = new System.Drawing.Point(3, 241);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(175, 63);
            this.btnExt.TabIndex = 5;
            this.btnExt.Text = "Close";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(288, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 63);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtName.Location = new System.Drawing.Point(225, 9);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 26);
            this.txtName.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
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
            // pMealA
            // 
            this.pMealA.Controls.Add(this.rdbHaveStock);
            this.pMealA.Controls.Add(this.numPrice);
            this.pMealA.Controls.Add(this.lblName);
            this.pMealA.Controls.Add(this.cmbQtyType);
            this.pMealA.Controls.Add(this.txtName);
            this.pMealA.Controls.Add(this.cmbCtgy);
            this.pMealA.Controls.Add(this.btnAdd);
            this.pMealA.Controls.Add(this.label3);
            this.pMealA.Controls.Add(this.btnExt);
            this.pMealA.Controls.Add(this.lblPrice);
            this.pMealA.Controls.Add(this.dtpDtAdd);
            this.pMealA.Controls.Add(this.lblCtgy);
            this.pMealA.Location = new System.Drawing.Point(12, 43);
            this.pMealA.Name = "pMealA";
            this.pMealA.Size = new System.Drawing.Size(468, 335);
            this.pMealA.TabIndex = 22;
            // 
            // rdbHaveStock
            // 
            this.rdbHaveStock.AutoSize = true;
            this.rdbHaveStock.Location = new System.Drawing.Point(379, 199);
            this.rdbHaveStock.Name = "rdbHaveStock";
            this.rdbHaveStock.Size = new System.Drawing.Size(84, 17);
            this.rdbHaveStock.TabIndex = 20;
            this.rdbHaveStock.TabStop = true;
            this.rdbHaveStock.Text = "Track Stock";
            this.rdbHaveStock.UseVisualStyleBackColor = true;
            // 
            // MealAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 403);
            this.Controls.Add(this.pMealA);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.llblLog);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MealAdd";
            this.Text = "Dish Add";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pMealA.ResumeLayout(false);
            this.pMealA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDtAdd;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbQtyType;
        private System.Windows.Forms.ComboBox cmbCtgy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCtgy;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Panel pMealA;
        private System.Windows.Forms.RadioButton rdbHaveStock;
    }
}