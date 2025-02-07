namespace Pharmacy
{
    partial class EditeShowUser
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
            dgv_users = new DataGridView();
            btn_exit = new Button();
            txt_edit_username = new TextBox();
            label2 = new Label();
            txt_edit_pass = new TextBox();
            label1 = new Label();
            mm = new Label();
            btn_edit_update = new Button();
            txt_emil = new TextBox();
            btn_back_edit = new Button();
            btn_delete = new Button();
            btn_adduser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            SuspendLayout();
            // 
            // dgv_users
            // 
            dgv_users.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Location = new Point(12, 330);
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersWidth = 51;
            dgv_users.Size = new Size(473, 185);
            dgv_users.TabIndex = 0;
            dgv_users.CellContentClick += dgv_users_CellContentClick;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(435, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(33, 28);
            btn_exit.TabIndex = 16;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // txt_edit_username
            // 
            txt_edit_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_edit_username.BorderStyle = BorderStyle.None;
            txt_edit_username.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_edit_username.Location = new Point(40, 42);
            txt_edit_username.Multiline = true;
            txt_edit_username.Name = "txt_edit_username";
            txt_edit_username.Size = new Size(245, 28);
            txt_edit_username.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 19);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 19;
            label2.Text = "Username";
            // 
            // txt_edit_pass
            // 
            txt_edit_pass.BackColor = Color.FromArgb(230, 231, 233);
            txt_edit_pass.BorderStyle = BorderStyle.None;
            txt_edit_pass.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_edit_pass.Location = new Point(40, 107);
            txt_edit_pass.Multiline = true;
            txt_edit_pass.Name = "txt_edit_pass";
            txt_edit_pass.Size = new Size(245, 28);
            txt_edit_pass.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 84);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 21;
            label1.Text = "Password";
            // 
            // mm
            // 
            mm.AutoSize = true;
            mm.Location = new Point(40, 153);
            mm.Name = "mm";
            mm.Size = new Size(46, 20);
            mm.TabIndex = 23;
            mm.Text = "Email";
            // 
            // btn_edit_update
            // 
            btn_edit_update.BackColor = Color.FromArgb(116, 86, 174);
            btn_edit_update.FlatAppearance.BorderSize = 0;
            btn_edit_update.FlatStyle = FlatStyle.Flat;
            btn_edit_update.ForeColor = Color.White;
            btn_edit_update.Location = new Point(75, 222);
            btn_edit_update.Name = "btn_edit_update";
            btn_edit_update.Size = new Size(183, 35);
            btn_edit_update.TabIndex = 25;
            btn_edit_update.Text = "Update user";
            btn_edit_update.UseVisualStyleBackColor = false;
            btn_edit_update.Click += btn_edit_update_Click;
            // 
            // txt_emil
            // 
            txt_emil.BackColor = Color.FromArgb(230, 231, 233);
            txt_emil.BorderStyle = BorderStyle.None;
            txt_emil.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_emil.Location = new Point(40, 176);
            txt_emil.Multiline = true;
            txt_emil.Name = "txt_emil";
            txt_emil.Size = new Size(245, 28);
            txt_emil.TabIndex = 26;
            txt_emil.TextChanged += txt_emil_TextChanged;
            // 
            // btn_back_edit
            // 
            btn_back_edit.BackColor = Color.FromArgb(116, 86, 174);
            btn_back_edit.FlatAppearance.BorderSize = 0;
            btn_back_edit.FlatStyle = FlatStyle.Flat;
            btn_back_edit.ForeColor = Color.White;
            btn_back_edit.Location = new Point(382, 521);
            btn_back_edit.Name = "btn_back_edit";
            btn_back_edit.Size = new Size(92, 35);
            btn_back_edit.TabIndex = 27;
            btn_back_edit.Text = "Back";
            btn_back_edit.UseVisualStyleBackColor = false;
            btn_back_edit.Click += btn_back_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(116, 86, 174);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(176, 276);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(183, 35);
            btn_delete.TabIndex = 28;
            btn_delete.Text = "Remove user";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_adduser
            // 
            btn_adduser.BackColor = Color.FromArgb(116, 86, 174);
            btn_adduser.FlatAppearance.BorderSize = 0;
            btn_adduser.FlatStyle = FlatStyle.Flat;
            btn_adduser.ForeColor = Color.White;
            btn_adduser.Location = new Point(291, 222);
            btn_adduser.Name = "btn_adduser";
            btn_adduser.Size = new Size(183, 35);
            btn_adduser.TabIndex = 29;
            btn_adduser.Text = "Add user";
            btn_adduser.UseVisualStyleBackColor = false;
            btn_adduser.Click += btn_adduser_Click;
            // 
            // EditeShowUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(497, 563);
            Controls.Add(btn_adduser);
            Controls.Add(btn_delete);
            Controls.Add(btn_back_edit);
            Controls.Add(txt_emil);
            Controls.Add(btn_edit_update);
            Controls.Add(mm);
            Controls.Add(txt_edit_pass);
            Controls.Add(label1);
            Controls.Add(txt_edit_username);
            Controls.Add(label2);
            Controls.Add(btn_exit);
            Controls.Add(dgv_users);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditeShowUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditeShowUser";
            Load += EditeShowUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_users;
        private Button btn_exit;
        private TextBox txt_edit_username;
        private Label label2;
        private TextBox txt_edit_pass;
        private Label label1;
        private Label mm;
        private Button btn_edit_update;
        private TextBox txt_emil;
        private Button btn_back_edit;
        private Button btn_delete;
        private Button btn_adduser;
    }
}