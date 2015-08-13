namespace POS
{
    partial class Print
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDtAdd = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.p1 = new System.Windows.Forms.Panel();
            this.llblLog = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numChange = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pPrnt = new System.Windows.Forms.Panel();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.numCash = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.print_Total = new System.Windows.Forms.Label();
            this.lstVwItms = new System.Windows.Forms.ListView();
            this.clmn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrnt = new System.Windows.Forms.Button();
            this.prntDoc = new System.Drawing.Printing.PrintDocument();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.menuStrip1.SuspendLayout();
            this.p1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).BeginInit();
            this.pPrnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCash)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 22;
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
            // dtpDtAdd
            // 
            this.dtpDtAdd.Enabled = false;
            this.dtpDtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtAdd.Location = new System.Drawing.Point(3, 380);
            this.dtpDtAdd.Name = "dtpDtAdd";
            this.dtpDtAdd.Size = new System.Drawing.Size(213, 22);
            this.dtpDtAdd.TabIndex = 23;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(583, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.llblLog);
            this.p1.Controls.Add(this.btnCancel);
            this.p1.Controls.Add(this.numChange);
            this.p1.Controls.Add(this.label2);
            this.p1.Controls.Add(this.pPrnt);
            this.p1.Controls.Add(this.btnPrnt);
            this.p1.Controls.Add(this.dtpDtAdd);
            this.p1.Location = new System.Drawing.Point(12, 27);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(559, 405);
            this.p1.TabIndex = 25;
            // 
            // llblLog
            // 
            this.llblLog.AutoSize = true;
            this.llblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblLog.Location = new System.Drawing.Point(0, 0);
            this.llblLog.Name = "llblLog";
            this.llblLog.Size = new System.Drawing.Size(51, 16);
            this.llblLog.TabIndex = 34;
            this.llblLog.TabStop = true;
            this.llblLog.Text = "Log In?";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(222, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(334, 128);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numChange
            // 
            this.numChange.DecimalPlaces = 2;
            this.numChange.Enabled = false;
            this.numChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChange.Location = new System.Drawing.Point(222, 40);
            this.numChange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numChange.Name = "numChange";
            this.numChange.ReadOnly = true;
            this.numChange.Size = new System.Drawing.Size(334, 116);
            this.numChange.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Change:";
            // 
            // pPrnt
            // 
            this.pPrnt.Controls.Add(this.numTotal);
            this.pPrnt.Controls.Add(this.numCash);
            this.pPrnt.Controls.Add(this.label1);
            this.pPrnt.Controls.Add(this.print_Total);
            this.pPrnt.Controls.Add(this.lstVwItms);
            this.pPrnt.Location = new System.Drawing.Point(3, 19);
            this.pPrnt.Name = "pPrnt";
            this.pPrnt.Size = new System.Drawing.Size(213, 355);
            this.pPrnt.TabIndex = 26;
            // 
            // numTotal
            // 
            this.numTotal.DecimalPlaces = 2;
            this.numTotal.Enabled = false;
            this.numTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotal.Location = new System.Drawing.Point(71, 300);
            this.numTotal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTotal.Name = "numTotal";
            this.numTotal.ReadOnly = true;
            this.numTotal.Size = new System.Drawing.Size(138, 26);
            this.numTotal.TabIndex = 34;
            // 
            // numCash
            // 
            this.numCash.DecimalPlaces = 2;
            this.numCash.Enabled = false;
            this.numCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCash.Location = new System.Drawing.Point(71, 265);
            this.numCash.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCash.Name = "numCash";
            this.numCash.Size = new System.Drawing.Size(138, 26);
            this.numCash.TabIndex = 32;
            this.numCash.ValueChanged += new System.EventHandler(this.numCash_ValueChanged);
            this.numCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numCash_KeyDown);
            this.numCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numCash_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cash:";
            // 
            // print_Total
            // 
            this.print_Total.AutoSize = true;
            this.print_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_Total.Location = new System.Drawing.Point(5, 303);
            this.print_Total.Name = "print_Total";
            this.print_Total.Size = new System.Drawing.Size(45, 18);
            this.print_Total.TabIndex = 26;
            this.print_Total.Text = "Total:";
            // 
            // lstVwItms
            // 
            this.lstVwItms.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstVwItms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmn1,
            this.clmn2,
            this.clmn3,
            this.clmn4});
            this.lstVwItms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVwItms.Location = new System.Drawing.Point(3, 3);
            this.lstVwItms.Name = "lstVwItms";
            this.lstVwItms.Size = new System.Drawing.Size(206, 256);
            this.lstVwItms.TabIndex = 25;
            this.lstVwItms.UseCompatibleStateImageBehavior = false;
            this.lstVwItms.View = System.Windows.Forms.View.Details;
            // 
            // clmn1
            // 
            this.clmn1.Text = "Name";
            this.clmn1.Width = 72;
            // 
            // clmn2
            // 
            this.clmn2.Text = "Price/Por";
            this.clmn2.Width = 54;
            // 
            // clmn3
            // 
            this.clmn3.Text = "Qty";
            this.clmn3.Width = 34;
            // 
            // clmn4
            // 
            this.clmn4.Text = "Type";
            this.clmn4.Width = 40;
            // 
            // btnPrnt
            // 
            this.btnPrnt.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrnt.Location = new System.Drawing.Point(222, 162);
            this.btnPrnt.Name = "btnPrnt";
            this.btnPrnt.Size = new System.Drawing.Size(334, 106);
            this.btnPrnt.TabIndex = 24;
            this.btnPrnt.Text = "Print";
            this.btnPrnt.UseVisualStyleBackColor = true;
            this.btnPrnt.Click += new System.EventHandler(this.btnPrnt_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 457);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(599, 496);
            this.MinimumSize = new System.Drawing.Size(599, 496);
            this.Name = "Print";
            this.Text = "Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).EndInit();
            this.pPrnt.ResumeLayout(false);
            this.pPrnt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpDtAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Button btnPrnt;
        private System.Windows.Forms.ListView lstVwItms;
        private System.Windows.Forms.ColumnHeader clmn1;
        private System.Windows.Forms.ColumnHeader clmn2;
        private System.Windows.Forms.ColumnHeader clmn3;
        private System.Windows.Forms.ColumnHeader clmn4;
        private System.Drawing.Printing.PrintDocument prntDoc;
        private System.Windows.Forms.Panel pPrnt;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Label print_Total;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCash;
        private System.Windows.Forms.NumericUpDown numChange;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.LinkLabel llblLog;

    }
}