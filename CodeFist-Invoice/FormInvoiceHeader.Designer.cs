namespace CodeFist_Invoice
{
    partial class FormInvoiceHeader
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertDetail = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtGridInvoiceHeader = new System.Windows.Forms.DataGridView();
            this.txtDeliveryNote = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.dtPckrPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.dtPckrInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridInvoiceHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertDetail);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.dtGridInvoiceHeader);
            this.groupBox1.Controls.Add(this.txtDeliveryNote);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.dtPckrPaymentDate);
            this.groupBox1.Controls.Add(this.dtPckrInvoiceDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 415);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Header ";
            // 
            // btnInsertDetail
            // 
            this.btnInsertDetail.Location = new System.Drawing.Point(325, 111);
            this.btnInsertDetail.Name = "btnInsertDetail";
            this.btnInsertDetail.Size = new System.Drawing.Size(86, 39);
            this.btnInsertDetail.TabIndex = 7;
            this.btnInsertDetail.Text = "Insert Detail";
            this.btnInsertDetail.UseVisualStyleBackColor = true;
            this.btnInsertDetail.Click += new System.EventHandler(this.btnInsertDetail_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(325, 35);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 39);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtGridInvoiceHeader
            // 
            this.dtGridInvoiceHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridInvoiceHeader.Location = new System.Drawing.Point(17, 274);
            this.dtGridInvoiceHeader.Name = "dtGridInvoiceHeader";
            this.dtGridInvoiceHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridInvoiceHeader.Size = new System.Drawing.Size(486, 123);
            this.dtGridInvoiceHeader.TabIndex = 6;
            // 
            // txtDeliveryNote
            // 
            this.txtDeliveryNote.Location = new System.Drawing.Point(107, 177);
            this.txtDeliveryNote.Name = "txtDeliveryNote";
            this.txtDeliveryNote.Size = new System.Drawing.Size(156, 20);
            this.txtDeliveryNote.TabIndex = 5;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(107, 224);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(156, 20);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(107, 129);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(156, 21);
            this.cmbCustomer.TabIndex = 4;
            // 
            // dtPckrPaymentDate
            // 
            this.dtPckrPaymentDate.Location = new System.Drawing.Point(107, 82);
            this.dtPckrPaymentDate.Name = "dtPckrPaymentDate";
            this.dtPckrPaymentDate.Size = new System.Drawing.Size(156, 20);
            this.dtPckrPaymentDate.TabIndex = 3;
            // 
            // dtPckrInvoiceDate
            // 
            this.dtPckrInvoiceDate.Location = new System.Drawing.Point(107, 35);
            this.dtPckrInvoiceDate.Name = "dtPckrInvoiceDate";
            this.dtPckrInvoiceDate.Size = new System.Drawing.Size(156, 20);
            this.dtPckrInvoiceDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Payment Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Delivery Note :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Amount :";
            // 
            // FormInvoiceHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInvoiceHeader";
            this.Text = "4";
            this.Load += new System.EventHandler(this.FormInvoiceHeader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridInvoiceHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtPckrPaymentDate;
        private System.Windows.Forms.DateTimePicker dtPckrInvoiceDate;
        private System.Windows.Forms.TextBox txtDeliveryNote;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtGridInvoiceHeader;
        private System.Windows.Forms.Button btnInsertDetail;
        private System.Windows.Forms.Button btnInsert;
    }
}