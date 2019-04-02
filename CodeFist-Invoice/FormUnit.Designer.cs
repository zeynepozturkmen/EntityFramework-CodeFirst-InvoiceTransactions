namespace CodeFist_Invoice
{
    partial class FormUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.dtGridUnit = new System.Windows.Forms.DataGridView();
            this.btnUnitAdd = new System.Windows.Forms.Button();
            this.btnUnitUpdate = new System.Windows.Forms.Button();
            this.btnUnitDelete = new System.Windows.Forms.Button();
            this.btnUnitMultiDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit Name :";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(97, 39);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(98, 22);
            this.txtUnitName.TabIndex = 1;
            // 
            // dtGridUnit
            // 
            this.dtGridUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUnit.Location = new System.Drawing.Point(25, 153);
            this.dtGridUnit.Name = "dtGridUnit";
            this.dtGridUnit.Size = new System.Drawing.Size(396, 114);
            this.dtGridUnit.TabIndex = 2;
            this.dtGridUnit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridUnit_CellClick);
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitAdd.Location = new System.Drawing.Point(25, 88);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.btnUnitAdd.Size = new System.Drawing.Size(75, 42);
            this.btnUnitAdd.TabIndex = 3;
            this.btnUnitAdd.Text = "Add";
            this.btnUnitAdd.UseVisualStyleBackColor = true;
            this.btnUnitAdd.Click += new System.EventHandler(this.btnUnitAdd_Click);
            // 
            // btnUnitUpdate
            // 
            this.btnUnitUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitUpdate.Location = new System.Drawing.Point(137, 88);
            this.btnUnitUpdate.Name = "btnUnitUpdate";
            this.btnUnitUpdate.Size = new System.Drawing.Size(75, 42);
            this.btnUnitUpdate.TabIndex = 4;
            this.btnUnitUpdate.Text = "Update";
            this.btnUnitUpdate.UseVisualStyleBackColor = true;
            this.btnUnitUpdate.Click += new System.EventHandler(this.btnUnitUpdate_Click);
            // 
            // btnUnitDelete
            // 
            this.btnUnitDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitDelete.Location = new System.Drawing.Point(247, 88);
            this.btnUnitDelete.Name = "btnUnitDelete";
            this.btnUnitDelete.Size = new System.Drawing.Size(75, 42);
            this.btnUnitDelete.TabIndex = 4;
            this.btnUnitDelete.Text = "Delete";
            this.btnUnitDelete.UseVisualStyleBackColor = true;
            this.btnUnitDelete.Click += new System.EventHandler(this.btnUnitDelete_Click);
            // 
            // btnUnitMultiDelete
            // 
            this.btnUnitMultiDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitMultiDelete.Location = new System.Drawing.Point(344, 88);
            this.btnUnitMultiDelete.Name = "btnUnitMultiDelete";
            this.btnUnitMultiDelete.Size = new System.Drawing.Size(75, 42);
            this.btnUnitMultiDelete.TabIndex = 4;
            this.btnUnitMultiDelete.Text = "Multi Delete";
            this.btnUnitMultiDelete.UseVisualStyleBackColor = true;
            this.btnUnitMultiDelete.Click += new System.EventHandler(this.btnUnitMultiDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnUnitMultiDelete);
            this.groupBox1.Controls.Add(this.btnUnitDelete);
            this.groupBox1.Controls.Add(this.btnUnitUpdate);
            this.groupBox1.Controls.Add(this.btnUnitAdd);
            this.groupBox1.Controls.Add(this.dtGridUnit);
            this.groupBox1.Controls.Add(this.txtUnitName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(118, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 287);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUnit";
            this.Text = "FormUnit";
            this.Load += new System.EventHandler(this.FormUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.DataGridView dtGridUnit;
        private System.Windows.Forms.Button btnUnitAdd;
        private System.Windows.Forms.Button btnUnitUpdate;
        private System.Windows.Forms.Button btnUnitDelete;
        private System.Windows.Forms.Button btnUnitMultiDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}