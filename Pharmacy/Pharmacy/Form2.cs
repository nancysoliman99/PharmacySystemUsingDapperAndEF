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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            new EditeShowUser().Show();
            this.Hide();
        }

        private void btn_Medicine_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            new Sales().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Suppliers().Show();
            this.Hide();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            new customer().Show();
            this.Hide();
        }
    }
}
