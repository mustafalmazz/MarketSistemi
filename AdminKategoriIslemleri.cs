using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MarketSistemi.Classes;

namespace MarketSistemi
{
    public partial class AdminKategoriIslemleri : Form
    {
        public AdminKategoriIslemleri()
        {
            InitializeComponent();
        }
        public void LoadCategories()
        {
            SqlCommand commandListCategories = new SqlCommand("Select * from TableCategory", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConneciton(SqlConnectionClass.connect);

            SqlDataAdapter da = new SqlDataAdapter(commandListCategories);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void AdminKategoriIslemleri_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            SqlCommand commandAddCategory = new SqlCommand("Insert into TableCategory (CategoryName) values (@pname)", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConneciton(SqlConnectionClass.connect);

            commandAddCategory.Parameters.AddWithValue("@pname", tboxCategoryName.Text);

            commandAddCategory.ExecuteNonQuery();

            LoadCategories();
        }

        private void groupBoxDelete_Enter(object sender, EventArgs e)
        {

        }

        string SelectedID ;
        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from TableCategory where CategoryID=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConneciton(SqlConnectionClass.connect);
            commandDelete.Parameters.AddWithValue("@pid",Convert.ToInt32(SelectedID));
            commandDelete.ExecuteNonQuery();
            
            LoadCategories();
            MessageBox.Show("Veri Başarıyla Silindi");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SelectedID = dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString();
            labelSelectedID.Text = " Seçilen Kategori : " + SelectedID;
            
        }

        private void btnMW_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
