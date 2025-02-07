using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Products : Form
    {
        PharmaContext context;
        public Products()
        {
            InitializeComponent();
            context = new PharmaContext();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            dgv_Medci.DataSource = context.Products.Select(n => new { n.ProductId, n.Name, n.Price, n.StockQuantity, Supplier = n.Supplier.Name }).ToList();
            txt_Product_price.Text = txt_Product_username.Text = txt_Stokquentity.Text = "";
            cb_supplier.DataSource = context.Suppliers.ToList();
            cb_supplier.ValueMember = "SupplierId";
            cb_supplier.DisplayMember = "Name";

            dgv_Medci.DataSource = context.Products.Select(n => new { n.ProductId, n.Name, n.Price, n.StockQuantity, Supplier = n.Supplier.Name }).ToList();
            txt_Product_price.Text = txt_Product_username.Text = txt_Stokquentity.Text = "";

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_edit_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btn_add_medc_Click(object sender, EventArgs e)
        {
            Product prop = new Product()
            {
                Name = txt_Product_username.Text,
                Price = decimal.TryParse(txt_Product_price.Text, out decimal d) ? d : new decimal(0),
                StockQuantity = int.Parse(txt_Stokquentity.Text),
                SupplierId = (int)cb_supplier.SelectedValue

            };
            context.Products.Add(prop);
            context.SaveChanges();



            txt_Product_price.Text = txt_Product_username.Text = txt_Stokquentity.Text = "";
            dgv_Medci.DataSource = context.Products.Select(n => new { n.Name, n.Price, n.StockQuantity, Supplier = n.Supplier.Name }).ToList();
            MessageBox.Show("Product added", "imformation message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        int id;
        private void dgv_Medci_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_Medci.SelectedRows[0].Cells[0].Value;
            Product prop = context.Products.Where(n => n.ProductId == id).SingleOrDefault();
            txt_Product_price.Text = prop?.Price.ToString();
            txt_Product_username.Text = prop?.Name;
            txt_Stokquentity.Text = prop?.StockQuantity.ToString();
            cb_supplier.SelectedValue = prop.SupplierId;


        }

        private void btn_update_medci_Click(object sender, EventArgs e)
        {
            Product p = context.Products.Where(n => n.ProductId == id).SingleOrDefault();
            p.Name = txt_Product_username.Text;
            p.Price = decimal.Parse(txt_Product_price.Text);
            p.StockQuantity = int.Parse(txt_Stokquentity.Text);
            p.SupplierId = (int)cb_supplier.SelectedValue;
            context.SaveChanges();

            txt_Product_price.Text = txt_Product_username.Text = txt_Stokquentity.Text = "";
            dgv_Medci.DataSource = context.Products.Select(n => new { n.Name, n.Price, n.StockQuantity, Supplier = n.Supplier.Name }).ToList();
            MessageBox.Show("Product Updated", "imformation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_delete_medci_Click(object sender, EventArgs e)
        {
            Product p = context.Products.Where(n => n.ProductId == id).SingleOrDefault();
            if (p != null)
            {
                context.Products.Remove(p);
                context.SaveChanges();
                dgv_Medci.DataSource = context.Products.ToList();
                dgv_Medci.DataSource = context.Products.Select(n => new { n.Name, n.Price, n.StockQuantity, Supplier = n.Supplier.Name }).ToList();
                MessageBox.Show("Product deleted", "imforamtion message ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_Medci.DataSource = context.Products.Select(n => new { n.Name, n.Price, n.StockQuantity, Supplier = n.Supplier.Name }).ToList();


            }
        }

        private void dgv_Medci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
