using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data.EntityFrameworkSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDAL _productDAL = new ProductDAL();
         
        private void LoadProducts()
        {
            dataGridViewProducts.DataSource = _productDAL.GetAll();
        }

        // Arayüzdeki liste üzerinden arama gerçekleştiriliyor...
        private void SearchProducts(string key)
        {
            var result = _productDAL.GetAll().Where(p => p.Brand.Contains(key)).ToList(); ;
            dataGridViewProducts.DataSource = result;
        }

        // ProductDAL ile DB üzerinde arama gerçekleştiriliyor...
        private void SearchProductsDB(string key)
        {
            var result = _productDAL.GetByName(key);
            dataGridViewProducts.DataSource = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBrand.Text = dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
            textBoxSpecies.Text = dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
            textBoxPrice.Text = dataGridViewProducts.CurrentRow.Cells[3].Value.ToString();
            textBoxStock.Text = dataGridViewProducts.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _productDAL.Add(new Product
            {
                Brand = textBoxBrand.Text,
                Species = textBoxSpecies.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text),
                Stock = Convert.ToInt32(textBoxStock.Text)
            });
            MessageBox.Show("Product Added!");
            LoadProducts();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _productDAL.Update(new Product
            {
                Id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value),
                Brand = textBoxBrand.Text,
                Species = textBoxSpecies.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text),
                Stock = Convert.ToInt32(textBoxStock.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Updated");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            _productDAL.Delete(new Product 
            {
                Id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Product Deleted");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(textBoxSearch.Text);
        }

        private void textBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            SearchProductsDB(textBoxSearch2.Text);
        }

        private void textBoxOnPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBetweenPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetById_Click(object sender, EventArgs e)
        {
            
        }
    }
}
