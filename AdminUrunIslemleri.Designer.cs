namespace MarketSistemi
{
    partial class AdminUrunIslemleri
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
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.btnMW = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.tboxProductName = new System.Windows.Forms.TextBox();
            this.tboxProductPrice = new System.Windows.Forms.TextBox();
            this.tboxProductBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbl_Selected_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(80, 38);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 24;
            this.dgProduct.Size = new System.Drawing.Size(1019, 198);
            this.dgProduct.TabIndex = 0;
            this.dgProduct.SelectionChanged += new System.EventHandler(this.dgProduct_SelectionChanged);
            // 
            // btnMW
            // 
            this.btnMW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMW.Location = new System.Drawing.Point(929, 288);
            this.btnMW.Name = "btnMW";
            this.btnMW.Size = new System.Drawing.Size(170, 56);
            this.btnMW.TabIndex = 1;
            this.btnMW.Text = "Ana Ekrana Dön";
            this.btnMW.UseVisualStyleBackColor = false;
            this.btnMW.Click += new System.EventHandler(this.btnMW_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxProductBarcode);
            this.groupBox1.Controls.Add(this.tboxProductPrice);
            this.groupBox1.Controls.Add(this.tboxProductName);
            this.groupBox1.Controls.Add(this.cmbBoxCategory);
            this.groupBox1.Location = new System.Drawing.Point(80, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(7, 48);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(262, 24);
            this.cmbBoxCategory.TabIndex = 0;
            // 
            // tboxProductName
            // 
            this.tboxProductName.Location = new System.Drawing.Point(10, 107);
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(165, 22);
            this.tboxProductName.TabIndex = 3;
            // 
            // tboxProductPrice
            // 
            this.tboxProductPrice.Location = new System.Drawing.Point(10, 157);
            this.tboxProductPrice.Name = "tboxProductPrice";
            this.tboxProductPrice.Size = new System.Drawing.Size(165, 22);
            this.tboxProductPrice.TabIndex = 4;
            // 
            // tboxProductBarcode
            // 
            this.tboxProductBarcode.Location = new System.Drawing.Point(10, 208);
            this.tboxProductBarcode.Name = "tboxProductBarcode";
            this.tboxProductBarcode.Size = new System.Drawing.Size(165, 22);
            this.tboxProductBarcode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Adı Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Kategorisi Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Fiyatı Giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Barkodu Giriniz";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Ürünü Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Selected_ID);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(446, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 273);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Sil";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbl_Selected_ID
            // 
            this.lbl_Selected_ID.AutoSize = true;
            this.lbl_Selected_ID.Location = new System.Drawing.Point(69, 88);
            this.lbl_Selected_ID.Name = "lbl_Selected_ID";
            this.lbl_Selected_ID.Size = new System.Drawing.Size(0, 16);
            this.lbl_Selected_ID.TabIndex = 2;
            // 
            // AdminUrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1190, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMW);
            this.Controls.Add(this.dgProduct);
            this.Name = "AdminUrunIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUrunIslemleri";
            this.Load += new System.EventHandler(this.AdminUrunIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnMW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxProductBarcode;
        private System.Windows.Forms.TextBox tboxProductPrice;
        private System.Windows.Forms.TextBox tboxProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbl_Selected_ID;
    }
}