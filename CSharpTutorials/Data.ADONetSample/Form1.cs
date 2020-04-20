using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data.ADONetSample
{
    public partial class Form1 : Form
    {
        ProductDAL _productDAL = new ProductDAL();

        private void LoadProducts()
        {
            dataGridViewProducts.DataSource = _productDAL.GetAll();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
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
            LoadProducts();
            MessageBox.Show("Product Added!");
        }

        // DGW'de tıklanan satırın değerlerini TB'lara yazdırma 
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBrand.Text = dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
            textBoxSpecies.Text = dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
            textBoxPrice.Text = dataGridViewProducts.CurrentRow.Cells[3].Value.ToString();
            textBoxStock.Text = dataGridViewProducts.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value),
                Brand = textBoxBrand.Text,
                Species = textBoxSpecies.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text),
                Stock = Convert.ToInt32(textBoxStock.Text)
            };
            _productDAL.Update(product);
            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value);
            _productDAL.Delete(id);
            LoadProducts();
            MessageBox.Show("Deleted!");
        }


    }
}
