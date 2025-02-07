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
    public partial class Suppliers : Form
    {
        PharmaContext context;
        public Suppliers()
        {
            context = new PharmaContext();
            InitializeComponent();
        }

        private void btn_back_edit_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            dgv_suppliers.DataSource = context.Suppliers.Select(n => new { n.SupplierId, Suppler_Name = n.Name, Address = n.Address, Phone = n.Contact }).ToList();
            txt_supp_name.Text = txt_contact.Text = txt_address.Text = "";
            dgv_suppliers.DataSource = context.Suppliers.Select(n => new { n.SupplierId, Suppler_Name = n.Name, Address = n.Address, Phone = n.Contact }).ToList();



        }

        private void dgv_suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int id;
        private void dgv_suppliers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            id = (int)dgv_suppliers.SelectedRows[0].Cells[0].Value;
            Supplier sub = context.Suppliers.Where(n => n.SupplierId == id).SingleOrDefault();
            txt_address.Text = sub.Address;
            txt_contact.Text = sub.Contact;
            txt_supp_name.Text = sub.Name;
        }

        private void btn_add_medc_Click(object sender, EventArgs e)
        {
            Supplier sub = new Supplier()
            {
                Name = txt_supp_name.Text,
                Address = txt_address.Text,
                Contact = txt_contact.Text,
            };
            context.Suppliers.Add(sub);
            context.SaveChanges();
            txt_supp_name.Text = txt_contact.Text = txt_address.Text = "";
            dgv_suppliers.DataSource = context.Suppliers.Select(n => new { n.SupplierId, Suppler_Name = n.Name, Address = n.Address, Phone = n.Contact }).ToList();
            MessageBox.Show("Supplier added", "imformation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_update_medci_Click(object sender, EventArgs e)
        {
            Supplier s = context.Suppliers.Where(n => n.SupplierId == id).SingleOrDefault();
            s.Name = txt_supp_name.Text;
            s.Address = txt_address.Text;
            s.Contact = txt_contact.Text;
            context.Suppliers.Add(s);
            txt_supp_name.Text = txt_contact.Text = txt_address.Text = "";
            dgv_suppliers.DataSource = context.Suppliers.Select(n => new { n.SupplierId, Suppler_Name = n.Name, Address = n.Address, Phone = n.Contact }).ToList();
            MessageBox.Show("Supplier updated", "imformation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_delete_medci_Click(object sender, EventArgs e)
        {
            Supplier s = context.Suppliers.Where(su => su.SupplierId == id).SingleOrDefault();
            if (s != null)
            {
                context.Suppliers.Remove(s);
                context.SaveChanges();
                txt_supp_name.Text = txt_contact.Text = txt_address.Text = "";
                dgv_suppliers.DataSource = context.Suppliers.Select(n => new { n.SupplierId, Suppler_Name = n.Name, Address = n.Address, Phone = n.Contact }).ToList();
                MessageBox.Show("Supplier Deleted", "imformation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            new Products().Show();
            this.Hide();
        }
    }
}

