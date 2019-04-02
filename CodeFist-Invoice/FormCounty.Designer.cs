namespace CodeFist_Invoice
{
    partial class FormCounty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCounty));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountyName = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dtGridCounty = new System.Windows.Forms.DataGridView();
            this.btnAddCounty = new System.Windows.Forms.Button();
            this.btnUpdateCounty = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbMultiDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCounty)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "County Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "City Name :";
            // 
            // txtCountyName
            // 
            this.txtCountyName.Location = new System.Drawing.Point(135, 32);
            this.txtCountyName.Name = "txtCountyName";
            this.txtCountyName.Size = new System.Drawing.Size(100, 24);
            this.txtCountyName.TabIndex = 2;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(135, 72);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(100, 26);
            this.cmbCity.TabIndex = 3;
            // 
            // dtGridCounty
            // 
            this.dtGridCounty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCounty.Location = new System.Drawing.Point(47, 179);
            this.dtGridCounty.Name = "dtGridCounty";
            this.dtGridCounty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCounty.Size = new System.Drawing.Size(395, 148);
            this.dtGridCounty.TabIndex = 4;
            this.dtGridCounty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCounty_CellClick);
            // 
            // btnAddCounty
            // 
            this.btnAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCounty.Location = new System.Drawing.Point(47, 117);
            this.btnAddCounty.Name = "btnAddCounty";
            this.btnAddCounty.Size = new System.Drawing.Size(75, 41);
            this.btnAddCounty.TabIndex = 5;
            this.btnAddCounty.Text = "Add";
            this.btnAddCounty.UseVisualStyleBackColor = true;
            this.btnAddCounty.Click += new System.EventHandler(this.btnAddCounty_Click);
            // 
            // btnUpdateCounty
            // 
            this.btnUpdateCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCounty.Location = new System.Drawing.Point(139, 117);
            this.btnUpdateCounty.Name = "btnUpdateCounty";
            this.btnUpdateCounty.Size = new System.Drawing.Size(75, 41);
            this.btnUpdateCounty.TabIndex = 6;
            this.btnUpdateCounty.Text = "Update";
            this.btnUpdateCounty.UseVisualStyleBackColor = true;
            this.btnUpdateCounty.Click += new System.EventHandler(this.btnUpdateCounty_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(241, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 41);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbMultiDelete
            // 
            this.cmbMultiDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMultiDelete.Location = new System.Drawing.Point(334, 117);
            this.cmbMultiDelete.Name = "cmbMultiDelete";
            this.cmbMultiDelete.Size = new System.Drawing.Size(108, 41);
            this.cmbMultiDelete.TabIndex = 6;
            this.cmbMultiDelete.Text = "Multi Delete";
            this.cmbMultiDelete.UseVisualStyleBackColor = true;
            this.cmbMultiDelete.Click += new System.EventHandler(this.cmbMultiDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.cmbMultiDelete);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdateCounty);
            this.groupBox1.Controls.Add(this.btnAddCounty);
            this.groupBox1.Controls.Add(this.dtGridCounty);
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.txtCountyName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(135, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 333);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "County";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormCounty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCounty";
            this.Text = "FormCounty";
            this.Load += new System.EventHandler(this.FormCounty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCounty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountyName;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.DataGridView dtGridCounty;
        private System.Windows.Forms.Button btnAddCounty;
        private System.Windows.Forms.Button btnUpdateCounty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button cmbMultiDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}