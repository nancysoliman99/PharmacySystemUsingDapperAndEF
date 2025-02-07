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
    public partial class EditeShowUser : Form
    {
        PharmaContext context;
        public EditeShowUser()
        {
            InitializeComponent();
            context = new PharmaContext();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void EditeShowUser_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = context.Users.Select(n => new { n.Id, n.Username, n.Password, n.Email }).ToList();
            txt_emil.Text = txt_edit_pass.Text = txt_edit_username.Text = "";


        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id;
        private void dgv_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_users.SelectedRows[0].Cells[0].Value;
            User s = context.Users.Where(n => n.Id == id).SingleOrDefault();
            txt_emil.Text = s.Email;
            txt_edit_pass.Text = s.Password;
            txt_edit_username.Text = s.Username;


        }

        private void btn_edit_update_Click(object sender, EventArgs e)
        {
            User s = context.Users.Where(n => n.Id == id).SingleOrDefault();
            s.Email = txt_emil.Text;
            s.Username = txt_edit_username.Text;
            s.Password = txt_edit_pass.Text;
            context.SaveChanges();
            MessageBox.Show("Updated Successfuly", "Informative window", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_users.DataSource = context.Users.Select(n => new { n.Id, n.Username, n.Password }).ToList();
            txt_emil.Text = txt_edit_pass.Text = txt_edit_username.Text = "";

        }

        private void btn_back_edit_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void txt_emil_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = txt_edit_username.Text,
                Email = txt_emil.Text,
                Password = txt_edit_pass.Text
            };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show(" User Added Successfuly", "Informative window", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_users.DataSource = context.Users.Select(n => new { n.Id, n.Username, n.Password }).ToList();
            txt_emil.Text = txt_edit_pass.Text = txt_edit_username.Text = "";

            dgv_users.DataSource = context.Users.Select(n => new { n.Id, n.Username, n.Password }).ToList();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            User u = context.Users.Where(n=>n.Id==id).SingleOrDefault();
            if (u != null) { 
            context.Users.Remove(u);
            context.SaveChanges();
                dgv_users.DataSource=context.Users.ToList();
                dgv_users.DataSource = context.Users.Select(n => new { n.Id, n.Username, n.Password }).ToList();
                MessageBox.Show("User deleted", "imforamtion message ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
    }
}
