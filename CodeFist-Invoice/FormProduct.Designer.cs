namespace CodeFist_Invoice
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.cmbUnitName = new System.Windows.Forms.ComboBox();
            this.btnProductName = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductMultiDelete = new System.Windows.Forms.Button();
            this.dtGridProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Unit Price :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(138, 23);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(97, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(138, 66);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(97, 22);
            this.txtProductCode.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(138, 136);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(97, 22);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // cmbUnitName
            // 
            this.cmbUnitName.FormattingEnabled = true;
            this.cmbUnitName.Location = new System.Drawing.Point(138, 105);
            this.cmbUnitName.Name = "cmbUnitName";
            this.cmbUnitName.Size = new System.Drawing.Size(97, 24);
            this.cmbUnitName.TabIndex = 3;
            // 
            // btnProductName
            // 
            this.btnProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductName.Location = new System.Drawing.Point(271, 21);
            this.btnProductName.Name = "btnProductName";
            this.btnProductName.Size = new System.Drawing.Size(81, 51);
            this.btnProductName.TabIndex = 4;
            this.btnProductName.Text = "Add";
            this.btnProductName.UseVisualStyleBackColor = true;
            this.btnProductName.Click += new System.EventHandler(this.btnProductName_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductUpdate.Location = new System.Drawing.Point(271, 87);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(81, 51);
            this.btnProductUpdate.TabIndex = 4;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductDelete.Location = new System.Drawing.Point(368, 21);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(81, 51);
            this.btnProductDelete.TabIndex = 4;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductMultiDelete
            // 
            this.btnProductMultiDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductMultiDelete.Location = new System.Drawing.Point(368, 87);
            this.btnProductMultiDelete.Name = "btnProductMultiDelete";
            this.btnProductMultiDelete.Size = new System.Drawing.Size(81, 51);
            this.btnProductMultiDelete.TabIndex = 4;
            this.btnProductMultiDelete.Text = "Multi Delete";
            this.btnProductMultiDelete.UseVisualStyleBackColor = true;
            this.btnProductMultiDelete.Click += new System.EventHandler(this.btnProductMultiDelete_Click);
            // 
            // dtGridProduct
            // 
            this.dtGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProduct.Location = new System.Drawing.Point(22, 181);
            this.dtGridProduct.Name = "dtGridProduct";
            this.dtGridProduct.Size = new System.Drawing.Size(539, 160);
            this.dtGridProduct.TabIndex = 5;
            this.dtGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProduct_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.dtGridProduct);
            this.groupBox1.Controls.Add(this.btnProductMultiDelete);
            this.groupBox1.Controls.Add(this.btnProductDelete);
            this.groupBox1.Controls.Add(this.btnProductUpdate);
            this.groupBox1.Controls.Add(this.btnProductName);
            this.groupBox1.Controls.Add(this.cmbUnitName);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(123, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 386);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.ComboBox cmbUnitName;
        private System.Windows.Forms.Button btnProductName;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductMultiDelete;
        private System.Windows.Forms.DataGridView dtGridProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}