using System;

namespace MarketSistemi
{
    partial class AdminKategoriIslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblSelectedID = new System.Windows.Forms.Label();
            this.tboxCategoryName = new System.Windows.Forms.TextBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.lblS = new System.Windows.Forms.Label();
            this.labelSelectedID = new System.Windows.Forms.Label();
            this.btnMW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCategory);
            this.groupBox1.Controls.Add(this.lblSelectedID);
            this.groupBox1.Controls.Add(this.tboxCategoryName);
            this.groupBox1.Location = new System.Drawing.Point(266, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Ekle";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(33, 141);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(223, 49);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Kategori Ekle";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.AutoSize = true;
            this.lblSelectedID.Location = new System.Drawing.Point(88, 51);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(129, 16);
            this.lblSelectedID.TabIndex = 1;
            this.lblSelectedID.Text = "Kategori Adını Giriniz";
            // 
            // tboxCategoryName
            // 
            this.tboxCategoryName.Location = new System.Drawing.Point(33, 90);
            this.tboxCategoryName.Name = "tboxCategoryName";
            this.tboxCategoryName.Size = new System.Drawing.Size(223, 22);
            this.tboxCategoryName.TabIndex = 0;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.labelSelectedID);
            this.groupBoxDelete.Controls.Add(this.btnCategoryDelete);
            this.groupBoxDelete.Controls.Add(this.lblS);
            this.groupBoxDelete.Location = new System.Drawing.Point(702, 266);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(295, 356);
            this.groupBoxDelete.TabIndex = 3;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Kategori Sil";
            this.groupBoxDelete.Enter += new System.EventHandler(this.groupBoxDelete_Enter);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(33, 141);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(223, 49);
            this.btnCategoryDelete.TabIndex = 2;
            this.btnCategoryDelete.Text = "Kategori Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(77, 51);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 16);
            this.lblS.TabIndex = 1;
            // 
            // labelSelectedID
            // 
            this.labelSelectedID.AutoSize = true;
            this.labelSelectedID.Location = new System.Drawing.Point(30, 90);
            this.labelSelectedID.Name = "labelSelectedID";
            this.labelSelectedID.Size = new System.Drawing.Size(0, 16);
            this.labelSelectedID.TabIndex = 3;
            // 
            // btnMW
            // 
            this.btnMW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMW.Location = new System.Drawing.Point(1012, 266);
            this.btnMW.Name = "btnMW";
            this.btnMW.Size = new System.Drawing.Size(170, 56);
            this.btnMW.TabIndex = 4;
            this.btnMW.Text = "Ana Ekrana Dön";
            this.btnMW.UseVisualStyleBackColor = false;
            this.btnMW.Click += new System.EventHandler(this.btnMW_Click);
            // 
            // AdminKategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1228, 657);
            this.Controls.Add(this.btnMW);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminKategoriIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminKategoriIslemleri";
            this.Load += new System.EventHandler(this.AdminKategoriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        private void groupBoxSil_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblSelectedID;
        private System.Windows.Forms.TextBox tboxCategoryName;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label labelSelectedID;
        private System.Windows.Forms.Button btnMW;
        //private System.Windows.Forms.GroupBox groupBoxSil;
        //private System.Windows.Forms.Button btnCategoryDelete;
        //private System.Windows.Forms.Label lblSelectedID;
    }
}