namespace CodeFist_Invoice
{
    partial class FormInvoiceQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoiceQuery));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.btnTumSiparisleriGoster = new System.Windows.Forms.Button();
            this.dtGridInvoiceQuery = new System.Windows.Forms.DataGridView();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridInvoiceQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(282, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer City  :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.cmbCustomerName);
            this.groupBox1.Controls.Add(this.cmbCounty);
            this.groupBox1.Controls.Add(this.btnTumSiparisleriGoster);
            this.groupBox1.Controls.Add(this.dtGridInvoiceQuery);
            this.groupBox1.Controls.Add(this.txtInvoiceID);
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(149, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 415);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice  ";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(393, 107);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(98, 21);
            this.cmbCustomerName.TabIndex = 8;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // cmbCounty
            // 
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(393, 57);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(98, 21);
            this.cmbCounty.TabIndex = 8;
            this.cmbCounty.SelectedIndexChanged += new System.EventHandler(this.cmbCounty_SelectedIndexChanged);
            // 
            // btnTumSiparisleriGoster
            // 
            this.btnTumSiparisleriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumSiparisleriGoster.Location = new System.Drawing.Point(144, 82);
            this.btnTumSiparisleriGoster.Name = "btnTumSiparisleriGoster";
            this.btnTumSiparisleriGoster.Size = new System.Drawing.Size(119, 46);
            this.btnTumSiparisleriGoster.TabIndex = 7;
            this.btnTumSiparisleriGoster.Text = "Tüm siparişleri göster";
            this.btnTumSiparisleriGoster.UseVisualStyleBackColor = true;
            this.btnTumSiparisleriGoster.Click += new System.EventHandler(this.btnTumSiparisleriGoster_Click);
            // 
            // dtGridInvoiceQuery
            // 
            this.dtGridInvoiceQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridInvoiceQuery.Location = new System.Drawing.Point(24, 191);
            this.dtGridInvoiceQuery.Name = "dtGridInvoiceQuery";
            this.dtGridInvoiceQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridInvoiceQuery.Size = new System.Drawing.Size(457, 123);
            this.dtGridInvoiceQuery.TabIndex = 6;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(132, 19);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(131, 20);
            this.txtInvoiceID.TabIndex = 5;
            this.txtInvoiceID.TextChanged += new System.EventHandler(this.txtInvoiceID_TextChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(393, 19);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(98, 21);
            this.cmbCity.TabIndex = 4;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(282, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer County :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(282, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormInvoiceQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInvoiceQuery";
            this.Text = "FormInvoiceQuery";
            this.Load += new System.EventHandler(this.FormInvoiceQuery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridInvoiceQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtGridInvoiceQuery;
        private System.Windows.Forms.Button btnTumSiparisleriGoster;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}