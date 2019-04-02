namespace CodeFist_Invoice
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supportTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportTablesToolStripMenuItem,
            this.ınvoiceTransactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // supportTablesToolStripMenuItem
            // 
            this.supportTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cityToolStripMenuItem,
            this.countyToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.unitToolStripMenuItem,
            this.productToolStripMenuItem});
            this.supportTablesToolStripMenuItem.Name = "supportTablesToolStripMenuItem";
            this.supportTablesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.supportTablesToolStripMenuItem.Text = "Support Tables";
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // countyToolStripMenuItem
            // 
            this.countyToolStripMenuItem.Name = "countyToolStripMenuItem";
            this.countyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.countyToolStripMenuItem.Text = "County";
            this.countyToolStripMenuItem.Click += new System.EventHandler(this.countyToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // unitToolStripMenuItem
            // 
            this.unitToolStripMenuItem.Name = "unitToolStripMenuItem";
            this.unitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unitToolStripMenuItem.Text = "Unit";
            this.unitToolStripMenuItem.Click += new System.EventHandler(this.unitToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // ınvoiceTransactionsToolStripMenuItem
            // 
            this.ınvoiceTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınvoiceHeaderToolStripMenuItem,
            this.ınvoiceDetailsToolStripMenuItem});
            this.ınvoiceTransactionsToolStripMenuItem.Name = "ınvoiceTransactionsToolStripMenuItem";
            this.ınvoiceTransactionsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.ınvoiceTransactionsToolStripMenuItem.Text = "Invoice Transactions";
            // 
            // ınvoiceHeaderToolStripMenuItem
            // 
            this.ınvoiceHeaderToolStripMenuItem.Name = "ınvoiceHeaderToolStripMenuItem";
            this.ınvoiceHeaderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ınvoiceHeaderToolStripMenuItem.Text = "Invoice Query";
            this.ınvoiceHeaderToolStripMenuItem.Click += new System.EventHandler(this.ınvoiceHeaderToolStripMenuItem_Click);
            // 
            // ınvoiceDetailsToolStripMenuItem
            // 
            this.ınvoiceDetailsToolStripMenuItem.Name = "ınvoiceDetailsToolStripMenuItem";
            this.ınvoiceDetailsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ınvoiceDetailsToolStripMenuItem.Text = "Invoice Details";
            this.ınvoiceDetailsToolStripMenuItem.Click += new System.EventHandler(this.ınvoiceDetailsToolStripMenuItem_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGiris";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supportTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceDetailsToolStripMenuItem;
    }
}

