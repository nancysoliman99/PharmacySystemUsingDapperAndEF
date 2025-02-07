namespace Pharmacy
{
    partial class FormResgister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            txt_pass = new TextBox();
            label3 = new Label();
            txt_confirm = new TextBox();
            label4 = new Label();
            check_showpass = new CheckBox();
            btn_regsiter = new Button();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            Text_email = new TextBox();
            label7 = new Label();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(68, 64);
            label1.Name = "label1";
            label1.Size = new Size(131, 34);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 129);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(28, 164);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(245, 28);
            txt_username.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.FromArgb(230, 231, 233);
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(28, 240);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(245, 28);
            txt_pass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 205);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txt_confirm
            // 
            txt_confirm.BackColor = Color.FromArgb(230, 231, 233);
            txt_confirm.BorderStyle = BorderStyle.None;
            txt_confirm.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_confirm.Location = new Point(28, 322);
            txt_confirm.Multiline = true;
            txt_confirm.Name = "txt_confirm";
            txt_confirm.PasswordChar = '*';
            txt_confirm.Size = new Size(245, 28);
            txt_confirm.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 287);
            label4.Name = "label4";
            label4.Size = new Size(150, 23);
            label4.TabIndex = 5;
            label4.Text = "Confrm Password";
            // 
            // check_showpass
            // 
            check_showpass.AutoSize = true;
            check_showpass.Cursor = Cursors.Hand;
            check_showpass.FlatStyle = FlatStyle.Flat;
            check_showpass.Location = new Point(122, 356);
            check_showpass.Name = "check_showpass";
            check_showpass.Size = new Size(151, 27);
            check_showpass.TabIndex = 7;
            check_showpass.Text = "Show Password";
            check_showpass.UseVisualStyleBackColor = true;
            check_showpass.CheckedChanged += check_showpass_CheckedChanged;
            // 
            // btn_regsiter
            // 
            btn_regsiter.BackColor = Color.FromArgb(116, 86, 174);
            btn_regsiter.FlatAppearance.BorderSize = 0;
            btn_regsiter.FlatStyle = FlatStyle.Flat;
            btn_regsiter.ForeColor = Color.White;
            btn_regsiter.Location = new Point(28, 493);
            btn_regsiter.Name = "btn_regsiter";
            btn_regsiter.Size = new Size(245, 35);
            btn_regsiter.TabIndex = 8;
            btn_regsiter.Text = "REGISTER";
            btn_regsiter.UseVisualStyleBackColor = false;
            btn_regsiter.Click += btn_regsiter_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(28, 549);
            button1.Name = "button1";
            button1.Size = new Size(245, 35);
            button1.TabIndex = 9;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 598);
            label5.Name = "label5";
            label5.Size = new Size(211, 23);
            label5.TabIndex = 10;
            label5.Text = "Already Have an Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(68, 631);
            label6.Name = "label6";
            label6.Size = new Size(127, 23);
            label6.TabIndex = 11;
            label6.Text = "Back To LOGIN";
            label6.Click += label6_Click;
            // 
            // Text_email
            // 
            Text_email.BackColor = Color.FromArgb(230, 231, 233);
            Text_email.BorderStyle = BorderStyle.None;
            Text_email.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_email.Location = new Point(28, 405);
            Text_email.Multiline = true;
            Text_email.Name = "Text_email";
            Text_email.Size = new Size(245, 28);
            Text_email.TabIndex = 13;
            Text_email.TextChanged += Text_email_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 370);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 12;
            label7.Text = "Email";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(260, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(33, 28);
            btn_exit.TabIndex = 14;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // FormResgister
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(305, 699);
            Controls.Add(btn_exit);
            Controls.Add(Text_email);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btn_regsiter);
            Controls.Add(check_showpass);
            Controls.Add(txt_confirm);
            Controls.Add(label4);
            Controls.Add(txt_pass);
            Controls.Add(label3);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormResgister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_pass;
        private Label label3;
        private TextBox txt_confirm;
        private Label label4;
        private CheckBox check_showpass;
        private Button btn_regsiter;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox Text_email;
        private Label label7;
        private Button btn_exit;
    }
}
