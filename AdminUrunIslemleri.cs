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
    public partial class AdminUrunIslemleri : Form
    {
        public AdminUrunIslemleri()
        {
            InitializeComponent();
        }
        public void LoadProducts()
        {
            SqlCommand commandList = new SqlCommand("Select ProductID,ProductName,ProductPrice,ProductBarcode,CategoryName from TableProduct inner join TableCategory on TableProduct.ProductCategory= TableCategory.CategoryID", SqlConnectionClass.connect);
            SqlConnectionClass.CheckConneciton(SqlConnectionClass.connect);
            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgProduct.DataSource = dt;
        }
        public void LoadCategories()
        {
            SqlCommand commandLoadCategories = new SqlCommand("Select * from TableCategory",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConneciton(SqlConnectionClass.connect);
            

            cmbBoxCategory.DisplayMember = "CategoryName";
            cmbBoxCategory.ValueMember = "CategoryID";

            SqlDataAdapter daLoadCategories = new SqlDataAdapter(commandLoadCategories);
            DataTable dtLoadCategories = new DataTable();

            daLoadCategories.Fill(dtLoadCategories);

            cmbBoxCategory.DataSource = dtLoadCategories;
        }
        private void AdminUrunIslemleri_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void btnMW_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into TableProduct(ProductName,ProductCategory,ProductPrice,ProductBarcode) values (@pname,@pcategory,@pprice,@pbarcode)",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConneciton(SqlConnectionClass.connect);

            commandAdd.Parameters.AddWithValue("@pname", tboxProductName.Text);
            commandAdd.Parameters.AddWithValue("@pcategory",Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandAdd.Parameters.AddWithValue("@pprice", tboxProductPrice.Text);
            commandAdd.Parameters.AddWithValue("@pbarcode", tboxProductBarcode.Text);

            commandAdd.ExecuteNonQuery();

            IncreaseCategoryCount();
            LoadProducts();
            MessageBox.Show("Ürün Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from TableProduct where ProductID=@pid", SqlConnectionClass.connect);

            SqlConnectionClass.CheckConneciton(SqlConnectionClass.connect);
            commandDelete.Parameters.AddWithValue("@pid", Convert.ToInt32(SelectedID));
            commandDelete.ExecuteNonQuery();
            DecreaseCategoryCount();
            LoadProducts();
            MessageBox.Show("Ürün Başarıyla Silindi");
        }
        string SelectedID;

        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProduct.CurrentRow==null)
            {

            }
            else
            {
                SelectedID = dgProduct.CurrentRow.Cells["ProductID"].Value.ToString();
                lbl_Selected_ID.Text = "Seçilen Ürün : " + SelectedID;
            }
            
        }

        public  void IncreaseCategoryCount()
        {
            SqlCommand commandIncrease = new SqlCommand("Update TableCategory set CategoryCount +=1 where CategoryID=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConneciton(SqlConnectionClass.connect);
            commandIncrease.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandIncrease.ExecuteNonQuery();

        }
        public  void DecreaseCategoryCount()
        {
            SqlCommand commandIncrease = new SqlCommand("Update TableCategory set CategoryCount -=1 where CategoryID=@pid",SqlConnectionClass.connect);
            SqlConnectionClass.CheckConneciton(SqlConnectionClass.connect);
            commandIncrease.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandIncrease.ExecuteNonQuery();

        }
    }
}
