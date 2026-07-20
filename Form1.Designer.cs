namespace MarketSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeaderLine = new System.Windows.Forms.Panel();
            this.cartPanel = new System.Windows.Forms.Panel();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.listViewCart = new System.Windows.Forms.ListView();
            this.colUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblKdvInfo = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelHizli = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHizliF1 = new System.Windows.Forms.Button();
            this.btnHizliF2 = new System.Windows.Forms.Button();
            this.btnHizliF3 = new System.Windows.Forms.Button();
            this.btnHizliF4 = new System.Windows.Forms.Button();
            this.btnHizliF5 = new System.Windows.Forms.Button();
            this.btnHizliF6 = new System.Windows.Forms.Button();
            this.panelCamera = new System.Windows.Forms.Panel();
            this.cmbKamera = new System.Windows.Forms.ComboBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnArtir = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.cartPanel.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.flowLayoutPanelHizli.SuspendLayout();
            this.panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.headerPanel.Controls.Add(this.lblHeader);
            this.headerPanel.Controls.Add(this.panelHeaderLine);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1261, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(262, 41);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "MARKET SİSTEMİ";
            // 
            // panelHeaderLine
            // 
            this.panelHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.panelHeaderLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeaderLine.Location = new System.Drawing.Point(0, 67);
            this.panelHeaderLine.Name = "panelHeaderLine";
            this.panelHeaderLine.Size = new System.Drawing.Size(1261, 3);
            this.panelHeaderLine.TabIndex = 0;
            // 
            // cartPanel
            // 
            this.cartPanel.BackColor = System.Drawing.Color.White;
            this.cartPanel.Controls.Add(this.listViewCart);
            this.cartPanel.Controls.Add(this.lblCartTitle);
            this.cartPanel.Controls.Add(this.panelTotal);
            this.cartPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cartPanel.Location = new System.Drawing.Point(0, 70);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Padding = new System.Windows.Forms.Padding(10);
            this.cartPanel.Size = new System.Drawing.Size(420, 627);
            this.cartPanel.TabIndex = 1;
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblCartTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(400, 40);
            this.lblCartTitle.TabIndex = 0;
            this.lblCartTitle.Text = "SEPETİM";
            this.lblCartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewCart
            // 
            this.listViewCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUrunAdi,
            this.colAdet,
            this.colToplam});
            this.listViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.listViewCart.FullRowSelect = true;
            this.listViewCart.GridLines = true;
            this.listViewCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(10, 50);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(400, 417);
            this.listViewCart.TabIndex = 1;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Text = "Ürün Adı";
            this.colUrunAdi.Width = 200;
            // 
            // colAdet
            // 
            this.colAdet.Text = "Adet";
            this.colAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAdet.Width = 70;
            // 
            // colToplam
            // 
            this.colToplam.Text = "Toplam";
            this.colToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colToplam.Width = 100;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panelTotal.Controls.Add(this.lblKdvInfo);
            this.panelTotal.Controls.Add(this.lblTotalAmount);
            this.panelTotal.Controls.Add(this.lblTotalTitle);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotal.Location = new System.Drawing.Point(10, 467);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(400, 150);
            this.panelTotal.TabIndex = 2;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalTitle.Location = new System.Drawing.Point(15, 20);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(167, 32);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "Genel Toplam";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(20, 60);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(360, 60);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "0,00 TL";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKdvInfo
            // 
            this.lblKdvInfo.AutoSize = true;
            this.lblKdvInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKdvInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblKdvInfo.Location = new System.Drawing.Point(17, 120);
            this.lblKdvInfo.Name = "lblKdvInfo";
            this.lblKdvInfo.Size = new System.Drawing.Size(183, 23);
            this.lblKdvInfo.TabIndex = 2;
            this.lblKdvInfo.Text = "KDV Dahil / 0 Ürün";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.mainPanel.Controls.Add(this.flowLayoutPanelHizli);
            this.mainPanel.Controls.Add(this.panelCamera);
            this.mainPanel.Controls.Add(this.panelActions);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(420, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(15);
            this.mainPanel.Size = new System.Drawing.Size(841, 627);
            this.mainPanel.TabIndex = 2;
            // 
            // flowLayoutPanelHizli
            // 
            this.flowLayoutPanelHizli.Controls.Add(this.btnHizliF1);
            this.flowLayoutPanelHizli.Controls.Add(this.btnHizliF2);
            this.flowLayoutPanelHizli.Controls.Add(this.btnHizliF3);
            this.flowLayoutPanelHizli.Controls.Add(this.btnHizliF4);
            this.flowLayoutPanelHizli.Controls.Add(this.btnHizliF5);
            this.flowLayoutPanelHizli.Controls.Add(this.btnHizliF6);
            this.flowLayoutPanelHizli.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelHizli.Location = new System.Drawing.Point(15, 15);
            this.flowLayoutPanelHizli.Name = "flowLayoutPanelHizli";
            this.flowLayoutPanelHizli.Size = new System.Drawing.Size(811, 150);
            this.flowLayoutPanelHizli.TabIndex = 0;
            // 
            // btnHizliF1
            // 
            this.btnHizliF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnHizliF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizliF1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHizliF1.ForeColor = System.Drawing.Color.White;
            this.btnHizliF1.Location = new System.Drawing.Point(3, 3);
            this.btnHizliF1.Name = "btnHizliF1";
            this.btnHizliF1.Size = new System.Drawing.Size(125, 120);
            this.btnHizliF1.TabIndex = 0;
            this.btnHizliF1.Text = "Ekmek\r\n\r\n10 TL";
            this.btnHizliF1.UseVisualStyleBackColor = false;
            // 
            // btnHizliF2
            // 
            this.btnHizliF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnHizliF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizliF2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHizliF2.ForeColor = System.Drawing.Color.White;
            this.btnHizliF2.Location = new System.Drawing.Point(134, 3);
            this.btnHizliF2.Name = "btnHizliF2";
            this.btnHizliF2.Size = new System.Drawing.Size(125, 120);
            this.btnHizliF2.TabIndex = 1;
            this.btnHizliF2.Text = "Su (0.5L)\r\n\r\n5 TL";
            this.btnHizliF2.UseVisualStyleBackColor = false;
            // 
            // btnHizliF3
            // 
            this.btnHizliF3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnHizliF3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHizliF3.FlatAppearance.BorderSize = 2;
            this.btnHizliF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizliF3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHizliF3.ForeColor = System.Drawing.Color.DimGray;
            this.btnHizliF3.Location = new System.Drawing.Point(265, 3);
            this.btnHizliF3.Name = "btnHizliF3";
            this.btnHizliF3.Size = new System.Drawing.Size(125, 120);
            this.btnHizliF3.TabIndex = 2;
            this.btnHizliF3.Text = "+\r\nSağ Tıkla\r\nAta";
            this.btnHizliF3.UseVisualStyleBackColor = false;
            // 
            // btnHizliF4
            // 
            this.btnHizliF4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnHizliF4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHizliF4.FlatAppearance.BorderSize = 2;
            this.btnHizliF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizliF4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHizliF4.ForeColor = System.Drawing.Color.DimGray;
            this.btnHizliF4.Location = new System.Drawing.Point(396, 3);
            this.btnHizliF4.Name = "btnHizliF4";
            this.btnHizliF4.Size = new System.Drawing.Size(125, 120);
            this.btnHizliF4.TabIndex = 3;
            this.btnHizliF4.Text = "+\r\nSağ Tıkla\r\nAta";
            this.btnHizliF4.UseVisualStyleBackColor = false;
            // 
            // btnHizliF5
            // 
            this.btnHizliF5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnHizliF5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHizliF5.FlatAppearance.BorderSize = 2;
            this.btnHizliF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizliF5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHizliF5.ForeColor = System.Drawing.Color.DimGray;
            this.btnHizliF5.Location = new System.Drawing.Point(527, 3);
            this.btnHizliF5.Name = "btnHizliF5";
            this.btnHizliF5.Size = new System.Drawing.Size(125, 120);
            this.btnHizliF5.TabIndex = 4;
            this.btnHizliF5.Text = "+\r\nSağ Tıkla\r\nAta";
            this.btnHizliF5.UseVisualStyleBackColor = false;
            // 
            // btnHizliF6
            // 
            this.btnHizliF6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnHizliF6.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHizliF6.FlatAppearance.BorderSize = 2;
            this.btnHizliF6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizliF6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHizliF6.ForeColor = System.Drawing.Color.DimGray;
            this.btnHizliF6.Location = new System.Drawing.Point(658, 3);
            this.btnHizliF6.Name = "btnHizliF6";
            this.btnHizliF6.Size = new System.Drawing.Size(125, 120);
            this.btnHizliF6.TabIndex = 5;
            this.btnHizliF6.Text = "+\r\nSağ Tıkla\r\nAta";
            this.btnHizliF6.UseVisualStyleBackColor = false;
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.Add(this.cmbKamera);
            this.panelCamera.Controls.Add(this.btnBaslat);
            this.panelCamera.Controls.Add(this.txtBarcode);
            this.panelCamera.Controls.Add(this.pictureBox1);
            this.panelCamera.Location = new System.Drawing.Point(15, 180);
            this.panelCamera.Name = "panelCamera";
            this.panelCamera.Size = new System.Drawing.Size(490, 430);
            this.panelCamera.TabIndex = 1;
            // 
            // cmbKamera
            // 
            this.cmbKamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKamera.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbKamera.FormattingEnabled = true;
            this.cmbKamera.Location = new System.Drawing.Point(0, 0);
            this.cmbKamera.Name = "cmbKamera";
            this.cmbKamera.Size = new System.Drawing.Size(350, 33);
            this.cmbKamera.TabIndex = 0;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBaslat.ForeColor = System.Drawing.Color.White;
            this.btnBaslat.Location = new System.Drawing.Point(360, 0);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(130, 35);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBarcode.Location = new System.Drawing.Point(0, 385);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(490, 39);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnArtir);
            this.panelActions.Controls.Add(this.btnAzalt);
            this.panelActions.Controls.Add(this.btnOdeme);
            this.panelActions.Controls.Add(this.btnIptal);
            this.panelActions.Controls.Add(this.btnUrunler);
            this.panelActions.Controls.Add(this.btnKategoriler);
            this.panelActions.Location = new System.Drawing.Point(520, 180);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(300, 430);
            this.panelActions.TabIndex = 2;
            // 
            // btnArtir
            // 
            this.btnArtir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnArtir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnArtir.ForeColor = System.Drawing.Color.White;
            this.btnArtir.Location = new System.Drawing.Point(155, 0);
            this.btnArtir.Name = "btnArtir";
            this.btnArtir.Size = new System.Drawing.Size(145, 60);
            this.btnArtir.TabIndex = 1;
            this.btnArtir.Text = "+";
            this.btnArtir.UseVisualStyleBackColor = false;
            // 
            // btnAzalt
            // 
            this.btnAzalt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnAzalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzalt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnAzalt.ForeColor = System.Drawing.Color.White;
            this.btnAzalt.Location = new System.Drawing.Point(0, 0);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(145, 60);
            this.btnAzalt.TabIndex = 0;
            this.btnAzalt.Text = "-";
            this.btnAzalt.UseVisualStyleBackColor = false;
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdeme.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnOdeme.ForeColor = System.Drawing.Color.Black;
            this.btnOdeme.Location = new System.Drawing.Point(0, 80);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(300, 80);
            this.btnOdeme.TabIndex = 2;
            this.btnOdeme.Text = "ÖDEME AL";
            this.btnOdeme.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(0, 180);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(300, 60);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "Satışı İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUrunler.ForeColor = System.Drawing.Color.White;
            this.btnUrunler.Location = new System.Drawing.Point(0, 260);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(300, 60);
            this.btnUrunler.TabIndex = 4;
            this.btnUrunler.Text = "Ürün İşlemleri";
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.btnKategoriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKategoriler.ForeColor = System.Drawing.Color.White;
            this.btnKategoriler.Location = new System.Drawing.Point(0, 340);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(300, 60);
            this.btnKategoriler.TabIndex = 5;
            this.btnKategoriler.Text = "Kategori İşlemleri";
            this.btnKategoriler.UseVisualStyleBackColor = false;
            this.btnKategoriler.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 697);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.cartPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market POS Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.cartPanel.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.flowLayoutPanelHizli.ResumeLayout(false);
            this.panelCamera.ResumeLayout(false);
            this.panelCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panelHeaderLine;
        private System.Windows.Forms.Label lblHeader;
        
        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader colUrunAdi;
        private System.Windows.Forms.ColumnHeader colAdet;
        private System.Windows.Forms.ColumnHeader colToplam;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblKdvInfo;

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHizli;
        private System.Windows.Forms.Button btnHizliF1;
        private System.Windows.Forms.Button btnHizliF2;
        private System.Windows.Forms.Button btnHizliF3;
        private System.Windows.Forms.Button btnHizliF4;
        private System.Windows.Forms.Button btnHizliF5;
        private System.Windows.Forms.Button btnHizliF6;

        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.ComboBox cmbKamera;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBarcode;

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnArtir;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnKategoriler;
    }
}
