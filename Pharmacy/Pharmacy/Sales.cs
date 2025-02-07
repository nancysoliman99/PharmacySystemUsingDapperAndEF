using Microsoft.EntityFrameworkCore;
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
    public partial class Sales : Form
    {
        PharmaContext context;
        public Sales()
        {
            InitializeComponent();
            context = new PharmaContext();
        }

        private void btn_back_edit_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            var sales = context.SaleDetails.Select(s => new { customername = s.Sale.Customer.FullName, Product =s.Product.Name, date = s.Sale.SaleDate, productprice=s.Product.Price,Quantity=s.Quantity}).ToList();
            dgv_Sales.DataSource = sales;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
