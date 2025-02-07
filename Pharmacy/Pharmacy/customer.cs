using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pharmacy
{
    public partial class customer : Form
    {
        /*string connect = "Server=DESKTOP-74IJSUN\\SQLEXPRESS;Database=iti;trusted_Connection=true;Trust Server Certificate =True";
        SqlConnection conn;*/
        string connection = "Server=DESKTOP-74IJSUN\\SQLEXPRESS;Database=PharmacyDB;Trusted_Connection=True; TrustServerCertificate=True;";
        SqlConnection conn;
        public customer()
        {
            InitializeComponent();
            conn = new SqlConnection(connection);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            conn.Open();
            var customers = conn.Query<Customer>("select * FROM Customers").ToList();
            dgv_customers.DataSource = customers;
        }

        private void dgv_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_edit_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btn_add_medc_Click(object sender, EventArgs e)
        {
            var add = conn.Execute("insert into Customers values(@Name,@Phone,@eemail)", new {Name=txt_supp_name.Text, Phone =txt_phone.Text, eemail =txt_email.Text});
            dgv_customers.DataSource = add;
            MessageBox.Show("Customer Added", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_update_medci_Click(object sender, EventArgs e)
        {
            var update = conn.Execute("Update Customers set FullName=@name,PhoneNumber=@phon,Email=@email where CustomerId=@id", new {id,name=txt_supp_name.Text,phon=txt_phone.Text,email=txt_email.Text});
            dgv_customers.DataSource = update;
            MessageBox.Show("Customer Updated", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        int id;
        private void dgv_customers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_customers.SelectedRows[0].Cells[0].Value;
            var s = conn.QueryFirstOrDefault<Customer>("select * from Customers where CustomerId=@id", new {id});
            txt_supp_name.Text = s.FullName;
            txt_phone.Text = s.PhoneNumber;
            txt_email.Text = s.Email;

        }

        private void btn_delete_medci_Click(object sender, EventArgs e)
        {
            var delete = conn.Execute("delete from Customers where CustomerId=@id", new { id });
            dgv_customers.DataSource = delete;
            MessageBox.Show("Customer Deleted", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
