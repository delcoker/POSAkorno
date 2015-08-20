namespace POS
{
    partial class Mainform
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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantityTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbMain = new System.Windows.Forms.GroupBox();
            this.btnLg = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.LinkLabel();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnMeals = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnRprt = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.gpbMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 0;
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mealToolStripMenuItem,
            this.categoryTypeToolStripMenuItem,
            this.quantityTypeToolStripMenuItem,
            this.permissionsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "&Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // mealToolStripMenuItem
            // 
            this.mealToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.viewToolStripMenuItem1});
            this.mealToolStripMenuItem.Name = "mealToolStripMenuItem";
            this.mealToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.mealToolStripMenuItem.Tag = "5";
            this.mealToolStripMenuItem.Text = "&Dish";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem2.Tag = "4";
            this.addToolStripMenuItem2.Text = "&Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.viewToolStripMenuItem1.Tag = "5";
            this.viewToolStripMenuItem1.Text = "&View/Edit";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // categoryTypeToolStripMenuItem
            // 
            this.categoryTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.categoryTypeToolStripMenuItem.Name = "categoryTypeToolStripMenuItem";
            this.categoryTypeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.categoryTypeToolStripMenuItem.Tag = "5";
            this.categoryTypeToolStripMenuItem.Text = "&Category";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem.Tag = "4";
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteToolStripMenuItem.Tag = "5";
            this.deleteToolStripMenuItem.Text = "&View/Edit";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // quantityTypeToolStripMenuItem
            // 
            this.quantityTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.viewToolStripMenuItem});
            this.quantityTypeToolStripMenuItem.Name = "quantityTypeToolStripMenuItem";
            this.quantityTypeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.quantityTypeToolStripMenuItem.Tag = "5";
            this.quantityTypeToolStripMenuItem.Text = "&Quantity Type";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem1.Tag = "4";
            this.addToolStripMenuItem1.Text = "&Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.viewToolStripMenuItem.Tag = "5";
            this.viewToolStripMenuItem.Text = "&View/Edit";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // permissionsToolStripMenuItem
            // 
            this.permissionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem3,
            this.viewToolStripMenuItem2});
            this.permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            this.permissionsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.permissionsToolStripMenuItem.Tag = "3";
            this.permissionsToolStripMenuItem.Text = "&Permissions";
            this.permissionsToolStripMenuItem.Visible = false;
            // 
            // addToolStripMenuItem3
            // 
            this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            this.addToolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem3.Tag = "3";
            this.addToolStripMenuItem3.Text = "&Add";
            this.addToolStripMenuItem3.Click += new System.EventHandler(this.addToolStripMenuItem3_Click);
            // 
            // viewToolStripMenuItem2
            // 
            this.viewToolStripMenuItem2.Name = "viewToolStripMenuItem2";
            this.viewToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.viewToolStripMenuItem2.Tag = "3";
            this.viewToolStripMenuItem2.Text = "&View/Edit";
            this.viewToolStripMenuItem2.Click += new System.EventHandler(this.viewToolStripMenuItem2_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem4,
            this.viewToolStripMenuItem3});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.inventoryToolStripMenuItem.Tag = "5";
            this.inventoryToolStripMenuItem.Text = "&Inventory";
            // 
            // addToolStripMenuItem4
            // 
            this.addToolStripMenuItem4.Name = "addToolStripMenuItem4";
            this.addToolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem4.Tag = "4";
            this.addToolStripMenuItem4.Text = "&Add";
            this.addToolStripMenuItem4.Click += new System.EventHandler(this.addToolStripMenuItem4_Click);
            // 
            // viewToolStripMenuItem3
            // 
            this.viewToolStripMenuItem3.Name = "viewToolStripMenuItem3";
            this.viewToolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.viewToolStripMenuItem3.Tag = "5";
            this.viewToolStripMenuItem3.Text = "&View/Edit";
            this.viewToolStripMenuItem3.Click += new System.EventHandler(this.viewToolStripMenuItem3_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem5,
            this.viewToolStripMenuItem4});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.usersToolStripMenuItem.Tag = "3";
            this.usersToolStripMenuItem.Text = "&Users";
            // 
            // addToolStripMenuItem5
            // 
            this.addToolStripMenuItem5.Name = "addToolStripMenuItem5";
            this.addToolStripMenuItem5.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem5.Tag = "3";
            this.addToolStripMenuItem5.Text = "&Add";
            this.addToolStripMenuItem5.Click += new System.EventHandler(this.addToolStripMenuItem5_Click);
            // 
            // viewToolStripMenuItem4
            // 
            this.viewToolStripMenuItem4.Name = "viewToolStripMenuItem4";
            this.viewToolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
            this.viewToolStripMenuItem4.Tag = "3";
            this.viewToolStripMenuItem4.Text = "&View/Edit";
            this.viewToolStripMenuItem4.Click += new System.EventHandler(this.viewToolStripMenuItem4_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // gpbMain
            // 
            this.gpbMain.Controls.Add(this.btnLg);
            this.gpbMain.Controls.Add(this.lblLog);
            this.gpbMain.Controls.Add(this.btnExt);
            this.gpbMain.Controls.Add(this.btnMeals);
            this.gpbMain.Controls.Add(this.btnInv);
            this.gpbMain.Controls.Add(this.btnRprt);
            this.gpbMain.Controls.Add(this.btnSale);
            this.gpbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbMain.Location = new System.Drawing.Point(0, 24);
            this.gpbMain.Name = "gpbMain";
            this.gpbMain.Size = new System.Drawing.Size(954, 641);
            this.gpbMain.TabIndex = 1;
            this.gpbMain.TabStop = false;
            // 
            // btnLg
            // 
            this.btnLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLg.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLg.Image = global::POS.Properties.Resources.login2;
            this.btnLg.Location = new System.Drawing.Point(12, 419);
            this.btnLg.Name = "btnLg";
            this.btnLg.Size = new System.Drawing.Size(462, 192);
            this.btnLg.TabIndex = 7;
            this.btnLg.Text = "&Login / Logout";
            this.btnLg.UseVisualStyleBackColor = true;
            this.btnLg.Click += new System.EventHandler(this.btnLg_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(12, 1);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(51, 16);
            this.lblLog.TabIndex = 0;
            this.lblLog.TabStop = true;
            this.lblLog.Text = "Log In?";
            // 
            // btnExt
            // 
            this.btnExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExt.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.Image = global::POS.Properties.Resources.exit2;
            this.btnExt.Location = new System.Drawing.Point(480, 419);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(462, 192);
            this.btnExt.TabIndex = 6;
            this.btnExt.Text = "&Exit";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnMeals
            // 
            this.btnMeals.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMeals.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeals.Image = global::POS.Properties.Resources.dishes1;
            this.btnMeals.Location = new System.Drawing.Point(12, 219);
            this.btnMeals.Name = "btnMeals";
            this.btnMeals.Size = new System.Drawing.Size(462, 192);
            this.btnMeals.TabIndex = 4;
            this.btnMeals.Tag = "5";
            this.btnMeals.Text = "&Items";
            this.btnMeals.UseVisualStyleBackColor = true;
            this.btnMeals.Click += new System.EventHandler(this.btnMeals_Click);
            // 
            // btnInv
            // 
            this.btnInv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInv.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInv.Image = global::POS.Properties.Resources.inventory;
            this.btnInv.Location = new System.Drawing.Point(480, 219);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(462, 192);
            this.btnInv.TabIndex = 2;
            this.btnInv.Tag = "5";
            this.btnInv.Text = "Stock";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnRprt
            // 
            this.btnRprt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRprt.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRprt.Image = global::POS.Properties.Resources.report;
            this.btnRprt.Location = new System.Drawing.Point(480, 20);
            this.btnRprt.Name = "btnRprt";
            this.btnRprt.Size = new System.Drawing.Size(462, 192);
            this.btnRprt.TabIndex = 1;
            this.btnRprt.Tag = "5";
            this.btnRprt.Text = "&Report";
            this.btnRprt.UseVisualStyleBackColor = true;
            this.btnRprt.Click += new System.EventHandler(this.btnRprt_Click);
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Image = global::POS.Properties.Resources.sale2;
            this.btnSale.Location = new System.Drawing.Point(12, 20);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(462, 192);
            this.btnSale.TabIndex = 0;
            this.btnSale.Tag = "5";
            this.btnSale.Text = "&Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCompany,
            this.toolStripStatusLabelUser,
            this.toolStripStatusLabelDate,
            this.toolStripProgressBarMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(954, 27);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCompany
            // 
            this.toolStripStatusLabelCompany.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelCompany.Name = "toolStripStatusLabelCompany";
            this.toolStripStatusLabelCompany.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.toolStripStatusLabelCompany.Size = new System.Drawing.Size(88, 22);
            this.toolStripStatusLabelCompany.Text = "Company";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(80, 22);
            this.toolStripStatusLabelUser.Text = "User  ";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(75, 22);
            this.toolStripStatusLabelDate.Text = "Date";
            // 
            // toolStripProgressBarMain
            // 
            this.toolStripProgressBarMain.Name = "toolStripProgressBarMain";
            this.toolStripProgressBarMain.Size = new System.Drawing.Size(117, 21);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExt;
            this.ClientSize = new System.Drawing.Size(954, 665);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gpbMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(970, 704);
            this.Name = "Mainform";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbMain.ResumeLayout(false);
            this.gpbMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbMain;
        private System.Windows.Forms.Button btnLg;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnMeals;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnRprt;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantityTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lblLog;
        private System.Windows.Forms.ToolStripMenuItem mealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem permissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCompany;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarMain;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem4;
    }
}

