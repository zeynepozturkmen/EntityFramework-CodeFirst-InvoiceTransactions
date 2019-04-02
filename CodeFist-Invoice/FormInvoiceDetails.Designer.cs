namespace CodeFist_Invoice
{
    partial class FormInvoiceDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoiceDetails));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtAmountWithVat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVatAmount = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnProductRemove = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductInsert = new System.Windows.Forms.Button();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnFaturaKaydet = new System.Windows.Forms.Button();
            this.dtGridInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtPckrPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtDeliveryNote = new System.Windows.Forms.TextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridInvoiceDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.txtAmountWithVat);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtProductCode);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtVatAmount);
            this.groupBox2.Controls.Add(this.txtUnitPrice);
            this.groupBox2.Controls.Add(this.btnProductRemove);
            this.groupBox2.Controls.Add(this.btnProductUpdate);
            this.groupBox2.Controls.Add(this.btnProductInsert);
            this.groupBox2.Controls.Add(this.cmbUnit);
            this.groupBox2.Controls.Add(this.cmbProduct);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(390, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Details";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(138, 229);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtAmountWithVat
            // 
            this.txtAmountWithVat.Enabled = false;
            this.txtAmountWithVat.Location = new System.Drawing.Point(138, 194);
            this.txtAmountWithVat.Name = "txtAmountWithVat";
            this.txtAmountWithVat.Size = new System.Drawing.Size(121, 20);
            this.txtAmountWithVat.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(31, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Amount With Vat :";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Enabled = false;
            this.txtProductCode.Location = new System.Drawing.Point(141, 75);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(118, 20);
            this.txtProductCode.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(34, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Product Code :";
            // 
            // txtVatAmount
            // 
            this.txtVatAmount.Enabled = false;
            this.txtVatAmount.Location = new System.Drawing.Point(141, 169);
            this.txtVatAmount.Name = "txtVatAmount";
            this.txtVatAmount.Size = new System.Drawing.Size(121, 20);
            this.txtVatAmount.TabIndex = 4;
            this.txtVatAmount.Text = "0.18";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(140, 104);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(118, 20);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // btnProductRemove
            // 
            this.btnProductRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductRemove.Location = new System.Drawing.Point(202, 259);
            this.btnProductRemove.Name = "btnProductRemove";
            this.btnProductRemove.Size = new System.Drawing.Size(75, 40);
            this.btnProductRemove.TabIndex = 2;
            this.btnProductRemove.Text = "Product Remove";
            this.btnProductRemove.UseVisualStyleBackColor = true;
            this.btnProductRemove.Click += new System.EventHandler(this.btnProductRemove_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductUpdate.Location = new System.Drawing.Point(121, 259);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnProductUpdate.TabIndex = 2;
            this.btnProductUpdate.Text = "Product Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductInsert
            // 
            this.btnProductInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductInsert.Location = new System.Drawing.Point(34, 259);
            this.btnProductInsert.Name = "btnProductInsert";
            this.btnProductInsert.Size = new System.Drawing.Size(75, 40);
            this.btnProductInsert.TabIndex = 2;
            this.btnProductInsert.Text = "Product Insert";
            this.btnProductInsert.UseVisualStyleBackColor = true;
            this.btnProductInsert.Click += new System.EventHandler(this.btnProductInsert_Click);
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(140, 135);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbUnit.TabIndex = 1;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(138, 41);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbProduct.TabIndex = 1;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(33, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quantity :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Unit :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vat Amount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(34, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Unit Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Product Name :";
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearList.Location = new System.Drawing.Point(734, 91);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(56, 39);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // btnFaturaKaydet
            // 
            this.btnFaturaKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaKaydet.Location = new System.Drawing.Point(734, 39);
            this.btnFaturaKaydet.Name = "btnFaturaKaydet";
            this.btnFaturaKaydet.Size = new System.Drawing.Size(56, 39);
            this.btnFaturaKaydet.TabIndex = 2;
            this.btnFaturaKaydet.Text = "Insert Invoice";
            this.btnFaturaKaydet.UseVisualStyleBackColor = true;
            this.btnFaturaKaydet.Click += new System.EventHandler(this.btnFaturaKaydet_Click);
            // 
            // dtGridInvoiceDetails
            // 
            this.dtGridInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridInvoiceDetails.Location = new System.Drawing.Point(33, 323);
            this.dtGridInvoiceDetails.Name = "dtGridInvoiceDetails";
            this.dtGridInvoiceDetails.ReadOnly = true;
            this.dtGridInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridInvoiceDetails.Size = new System.Drawing.Size(682, 115);
            this.dtGridInvoiceDetails.TabIndex = 3;
            this.dtGridInvoiceDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridInvoiceDetails_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.dtPckrPaymentDate);
            this.groupBox3.Controls.Add(this.txtDeliveryNote);
            this.groupBox3.Controls.Add(this.cmbCustomer);
            this.groupBox3.Controls.Add(this.cmbCounty);
            this.groupBox3.Controls.Add(this.cmbCity);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(63, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 297);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice Header";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(123, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "label14";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(34, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "Fatura ID :";
            // 
            // dtPckrPaymentDate
            // 
            this.dtPckrPaymentDate.Location = new System.Drawing.Point(126, 253);
            this.dtPckrPaymentDate.Name = "dtPckrPaymentDate";
            this.dtPckrPaymentDate.Size = new System.Drawing.Size(104, 20);
            this.dtPckrPaymentDate.TabIndex = 3;
            // 
            // txtDeliveryNote
            // 
            this.txtDeliveryNote.Location = new System.Drawing.Point(127, 211);
            this.txtDeliveryNote.Name = "txtDeliveryNote";
            this.txtDeliveryNote.Size = new System.Drawing.Size(103, 20);
            this.txtDeliveryNote.TabIndex = 2;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(126, 173);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(104, 21);
            this.cmbCustomer.TabIndex = 1;
            // 
            // cmbCounty
            // 
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(126, 135);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(104, 21);
            this.cmbCounty.TabIndex = 1;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(126, 97);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(104, 21);
            this.cmbCity.TabIndex = 1;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(34, 253);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Payment Date :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(34, 214);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Delivery Note :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(34, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Customer :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(34, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "County :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(34, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "City :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGridInvoiceDetails);
            this.Controls.Add(this.btnFaturaKaydet);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormInvoiceDetails";
            this.Text = "FormInvoiceDetails";
            this.Load += new System.EventHandler(this.FormInvoiceDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridInvoiceDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProductRemove;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductInsert;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnFaturaKaydet;
        private System.Windows.Forms.DataGridView dtGridInvoiceDetails;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtVatAmount;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAmountWithVat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtPckrPaymentDate;
        private System.Windows.Forms.TextBox txtDeliveryNote;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}