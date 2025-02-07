namespace Pharmacy
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            btn_regsiter = new Button();
            check_showpass = new CheckBox();
            txt_pass = new TextBox();
            label3 = new Label();
            txt_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(116, 557);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 27;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 521);
            label5.Name = "label5";
            label5.Size = new Size(189, 23);
            label5.TabIndex = 26;
            label5.Text = "Dont Have an Account";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(63, 462);
            button1.Name = "button1";
            button1.Size = new Size(245, 35);
            button1.TabIndex = 25;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_regsiter
            // 
            btn_regsiter.BackColor = Color.FromArgb(116, 86, 174);
            btn_regsiter.FlatAppearance.BorderSize = 0;
            btn_regsiter.FlatStyle = FlatStyle.Flat;
            btn_regsiter.ForeColor = Color.White;
            btn_regsiter.Location = new Point(63, 406);
            btn_regsiter.Name = "btn_regsiter";
            btn_regsiter.Size = new Size(245, 35);
            btn_regsiter.TabIndex = 24;
            btn_regsiter.Text = "LOGIN";
            btn_regsiter.UseVisualStyleBackColor = false;
            btn_regsiter.Click += btn_regsiter_Click;
            // 
            // check_showpass
            // 
            check_showpass.AutoSize = true;
            check_showpass.Cursor = Cursors.Hand;
            check_showpass.FlatStyle = FlatStyle.Flat;
            check_showpass.Location = new Point(157, 347);
            check_showpass.Name = "check_showpass";
            check_showpass.Size = new Size(151, 27);
            check_showpass.TabIndex = 23;
            check_showpass.Text = "Show Password";
            check_showpass.UseVisualStyleBackColor = true;
            check_showpass.CheckedChanged += check_showpass_CheckedChanged;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.FromArgb(230, 231, 233);
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(63, 320);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(245, 28);
            txt_pass.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 285);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 19;
            label3.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(63, 244);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(245, 28);
            txt_username.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 209);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(116, 119);
            label1.Name = "label1";
            label1.Size = new Size(117, 34);
            label1.TabIndex = 16;
            label1.Text = "Sign In";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(-39, 486);
            label9.Name = "label9";
            label9.Size = new Size(45, 23);
            label9.TabIndex = 31;
            label9.Text = "Role";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(314, 25);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(33, 28);
            btn_exit.TabIndex = 32;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(359, 705);
            Controls.Add(btn_exit);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btn_regsiter);
            Controls.Add(check_showpass);
            Controls.Add(txt_pass);
            Controls.Add(label3);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button1;
        private Button btn_regsiter;
        private CheckBox check_showpass;
        private TextBox txt_pass;
        private Label label3;
        private TextBox txt_username;
        private Label label2;
        private Label label1;
        private Label label9;
        private Button btn_exit;
    }
}