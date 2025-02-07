using Pharmacy.Models;

namespace Pharmacy
{
    public partial class FormResgister : Form
    {
        PharmaContext db;
        public FormResgister()
        {
            InitializeComponent();
            db = new PharmaContext();
        }

        private void Text_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_regsiter_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_pass.Text == "" && txt_confirm.Text == "" && Text_email.Text == "")
            {
                MessageBox.Show("Username , Password and Email fileds are empty", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pass.Text == txt_confirm.Text)
            {
                User user = new User()
                {
                    Password = txt_pass.Text,
                    Username = txt_username.Text,
                    Email = Text_email.Text
                };
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Your Account has been Successfuly Created", "Registraiton Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Passwords does not match ,Please Re_enter", "Registraion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confirm.Text = "";
                txt_pass.Text = "";
                txt_pass.Focus();
            }
        }
        void clear()
        {
            txt_confirm.Text = "";
            txt_pass.Text = "";
            txt_username.Text = "";
            Text_email.Text = "";
        }

        private void check_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showpass.Checked)
            {
                txt_pass.PasswordChar = '\0';
                txt_confirm.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
                txt_confirm.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            txt_username.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
