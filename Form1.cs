using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;

namespace MarketSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminKategoriIslemleri categoryPage = new AdminKategoriIslemleri();
            categoryPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUrunIslemleri productPage = new AdminUrunIslemleri();
            productPage.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo cihaz in Cihazlar)
            {
                cmbKamera.Items.Add(cihaz.Name);
            }

            cmbKamera.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);

            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap GoruntulenenBarkod = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader okuyucu = new BarcodeReader();
            var sonuc = okuyucu.Decode(GoruntulenenBarkod);

            if (sonuc != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate
                {
                    txtBarcode.Text = sonuc.Text;
                }));
            }
            pictureBox1.Image = GoruntulenenBarkod;


        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kameram != null )
            {
                if (kameram.IsRunning)
                {
                    kameram.Stop();
                }
            }
        }
    }
}
