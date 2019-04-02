namespace CodeFist_Invoice
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.cmbCustomerCity = new System.Windows.Forms.ComboBox();
            this.cmbCustomerCounty = new System.Windows.Forms.ComboBox();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnMultiDelete = new System.Windows.Forms.Button();
            this.dtGridCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer City :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer County :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adress :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(162, 39);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(121, 24);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(162, 179);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(121, 20);
            this.txtAdress.TabIndex = 2;
            // 
            // cmbCustomerCity
            // 
            this.cmbCustomerCity.FormattingEnabled = true;
            this.cmbCustomerCity.Location = new System.Drawing.Point(162, 86);
            this.cmbCustomerCity.Name = "cmbCustomerCity";
            this.cmbCustomerCity.Size = new System.Drawing.Size(121, 26);
            this.cmbCustomerCity.TabIndex = 3;
            this.cmbCustomerCity.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerCity_SelectedIndexChanged);
            // 
            // cmbCustomerCounty
            // 
            this.cmbCustomerCounty.FormattingEnabled = true;
            this.cmbCustomerCounty.Location = new System.Drawing.Point(162, 134);
            this.cmbCustomerCounty.Name = "cmbCustomerCounty";
            this.cmbCustomerCounty.Size = new System.Drawing.Size(121, 26);
            this.cmbCustomerCounty.TabIndex = 4;
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerAdd.Location = new System.Drawing.Point(32, 216);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(75, 40);
            this.btnCustomerAdd.TabIndex = 5;
            this.btnCustomerAdd.Text = "Add ";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerUpdate.Location = new System.Drawing.Point(135, 215);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnCustomerUpdate.TabIndex = 6;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(246, 216);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(75, 40);
            this.btnCustomerDelete.TabIndex = 7;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnMultiDelete
            // 
            this.btnMultiDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMultiDelete.Location = new System.Drawing.Point(343, 216);
            this.btnMultiDelete.Name = "btnMultiDelete";
            this.btnMultiDelete.Size = new System.Drawing.Size(108, 40);
            this.btnMultiDelete.TabIndex = 8;
            this.btnMultiDelete.Text = "Multi Delete";
            this.btnMultiDelete.UseVisualStyleBackColor = true;
            this.btnMultiDelete.Click += new System.EventHandler(this.btnMultiDelete_Click);
            // 
            // dtGridCustomer
            // 
            this.dtGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCustomer.Location = new System.Drawing.Point(25, 262);
            this.dtGridCustomer.Name = "dtGridCustomer";
            this.dtGridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCustomer.Size = new System.Drawing.Size(426, 150);
            this.dtGridCustomer.TabIndex = 9;
            this.dtGridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCustomer_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.dtGridCustomer);
            this.groupBox1.Controls.Add(this.btnMultiDelete);
            this.groupBox1.Controls.Add(this.btnCustomerDelete);
            this.groupBox1.Controls.Add(this.btnCustomerUpdate);
            this.groupBox1.Controls.Add(this.btnCustomerAdd);
            this.groupBox1.Controls.Add(this.cmbCustomerCounty);
            this.groupBox1.Controls.Add(this.cmbCustomerCity);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(154, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 426);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCustomer)).EndInit();
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
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.ComboBox cmbCustomerCity;
        private System.Windows.Forms.ComboBox cmbCustomerCounty;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnMultiDelete;
        private System.Windows.Forms.DataGridView dtGridCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}