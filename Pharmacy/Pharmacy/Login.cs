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
    public partial class Login : Form
    {
        PharmaContext db;

        public Login()
        {
            InitializeComponent();
            db = new PharmaContext();

        }
        void clear()
        {
            txt_pass.Text = "";
            txt_username.Text = "";
        }

        private void check_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showpass.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }

        }

        private void btn_regsiter_Click(object sender, EventArgs e)
        {
            var user = db.Users.FirstOrDefault(u => u.Username == txt_username.Text && u.Password == txt_pass.Text);
            if (user != null)
            {
                if (user.Username != "Admin" && user.Password != "Admin")
                {
                    MessageBox.Show("Login Successful!", "Loign information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Sales().Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Successful!", "Loign information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Form2().Show();

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password,Please Try Agin ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                txt_username.Focus();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormResgister().Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
