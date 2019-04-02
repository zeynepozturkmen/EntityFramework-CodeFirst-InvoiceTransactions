namespace CodeFist_Invoice
{
    partial class FormCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCity));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.GroupBox();
            this.btnCityMultipleDelete = new System.Windows.Forms.Button();
            this.dtGridCity = new System.Windows.Forms.DataGridView();
            this.btnCityDelete = new System.Windows.Forms.Button();
            this.btnCityUpdate = new System.Windows.Forms.Button();
            this.btnCityAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.City.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name :";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(122, 23);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(104, 24);
            this.txtCityName.TabIndex = 1;
            // 
            // City
            // 
            this.City.BackColor = System.Drawing.Color.Silver;
            this.City.Controls.Add(this.btnCityMultipleDelete);
            this.City.Controls.Add(this.dtGridCity);
            this.City.Controls.Add(this.btnCityDelete);
            this.City.Controls.Add(this.btnCityUpdate);
            this.City.Controls.Add(this.btnCityAdd);
            this.City.Controls.Add(this.txtCityName);
            this.City.Controls.Add(this.label1);
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.City.Location = new System.Drawing.Point(154, 55);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(479, 328);
            this.City.TabIndex = 2;
            this.City.TabStop = false;
            this.City.Text = "City";
            // 
            // btnCityMultipleDelete
            // 
            this.btnCityMultipleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCityMultipleDelete.Location = new System.Drawing.Point(342, 90);
            this.btnCityMultipleDelete.Name = "btnCityMultipleDelete";
            this.btnCityMultipleDelete.Size = new System.Drawing.Size(75, 34);
            this.btnCityMultipleDelete.TabIndex = 6;
            this.btnCityMultipleDelete.Text = "Multiple Delete";
            this.btnCityMultipleDelete.UseVisualStyleBackColor = true;
            this.btnCityMultipleDelete.Click += new System.EventHandler(this.btnCityMultipleDelete_Click);
            // 
            // dtGridCity
            // 
            this.dtGridCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCity.Location = new System.Drawing.Point(50, 172);
            this.dtGridCity.Name = "dtGridCity";
            this.dtGridCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridCity.Size = new System.Drawing.Size(401, 150);
            this.dtGridCity.TabIndex = 5;
            this.dtGridCity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCity_CellClick);
            // 
            // btnCityDelete
            // 
            this.btnCityDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCityDelete.Location = new System.Drawing.Point(250, 92);
            this.btnCityDelete.Name = "btnCityDelete";
            this.btnCityDelete.Size = new System.Drawing.Size(75, 34);
            this.btnCityDelete.TabIndex = 4;
            this.btnCityDelete.Text = "Delete";
            this.btnCityDelete.UseVisualStyleBackColor = true;
            this.btnCityDelete.Click += new System.EventHandler(this.btnCityDelete_Click);
            // 
            // btnCityUpdate
            // 
            this.btnCityUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCityUpdate.Location = new System.Drawing.Point(151, 92);
            this.btnCityUpdate.Name = "btnCityUpdate";
            this.btnCityUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnCityUpdate.TabIndex = 3;
            this.btnCityUpdate.Text = "Update";
            this.btnCityUpdate.UseVisualStyleBackColor = true;
            this.btnCityUpdate.Click += new System.EventHandler(this.btnCityUpdate_Click);
            // 
            // btnCityAdd
            // 
            this.btnCityAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCityAdd.Location = new System.Drawing.Point(50, 92);
            this.btnCityAdd.Name = "btnCityAdd";
            this.btnCityAdd.Size = new System.Drawing.Size(75, 34);
            this.btnCityAdd.TabIndex = 2;
            this.btnCityAdd.Text = "Add";
            this.btnCityAdd.UseVisualStyleBackColor = true;
            this.btnCityAdd.Click += new System.EventHandler(this.btnCityAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.City);
            this.Name = "FormCity";
            this.Text = "FormCity";
            this.Load += new System.EventHandler(this.FormCity_Load);
            this.City.ResumeLayout(false);
            this.City.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.GroupBox City;
        private System.Windows.Forms.DataGridView dtGridCity;
        private System.Windows.Forms.Button btnCityDelete;
        private System.Windows.Forms.Button btnCityUpdate;
        private System.Windows.Forms.Button btnCityAdd;
        private System.Windows.Forms.Button btnCityMultipleDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}