namespace Pharmacy
{
    partial class customer
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
            btn_back_edit = new Button();
            btn_exit = new Button();
            btn_add_medc = new Button();
            btn_delete_medci = new Button();
            txt_email = new TextBox();
            btn_update_medci = new Button();
            mm = new Label();
            txt_phone = new TextBox();
            label1 = new Label();
            txt_supp_name = new TextBox();
            label2 = new Label();
            dgv_customers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_customers).BeginInit();
            SuspendLayout();
            // 
            // btn_back_edit
            // 
            btn_back_edit.BackColor = Color.FromArgb(116, 86, 174);
            btn_back_edit.FlatAppearance.BorderSize = 0;
            btn_back_edit.FlatStyle = FlatStyle.Flat;
            btn_back_edit.ForeColor = Color.White;
            btn_back_edit.Location = new Point(657, 393);
            btn_back_edit.Name = "btn_back_edit";
            btn_back_edit.Size = new Size(92, 35);
            btn_back_edit.TabIndex = 41;
            btn_back_edit.Text = "Back";
            btn_back_edit.UseVisualStyleBackColor = false;
            btn_back_edit.Click += btn_back_edit_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(716, 10);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(33, 28);
            btn_exit.TabIndex = 40;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_add_medc
            // 
            btn_add_medc.BackColor = Color.FromArgb(116, 86, 174);
            btn_add_medc.FlatAppearance.BorderSize = 0;
            btn_add_medc.FlatStyle = FlatStyle.Flat;
            btn_add_medc.ForeColor = Color.White;
            btn_add_medc.Location = new Point(56, 294);
            btn_add_medc.Name = "btn_add_medc";
            btn_add_medc.Size = new Size(245, 35);
            btn_add_medc.TabIndex = 67;
            btn_add_medc.Text = "New Customer";
            btn_add_medc.UseVisualStyleBackColor = false;
            btn_add_medc.Click += btn_add_medc_Click;
            // 
            // btn_delete_medci
            // 
            btn_delete_medci.BackColor = Color.FromArgb(116, 86, 174);
            btn_delete_medci.FlatAppearance.BorderSize = 0;
            btn_delete_medci.FlatStyle = FlatStyle.Flat;
            btn_delete_medci.ForeColor = Color.White;
            btn_delete_medci.Location = new Point(56, 405);
            btn_delete_medci.Name = "btn_delete_medci";
            btn_delete_medci.Size = new Size(245, 35);
            btn_delete_medci.TabIndex = 66;
            btn_delete_medci.Text = "Remove Customer";
            btn_delete_medci.UseVisualStyleBackColor = false;
            btn_delete_medci.Click += btn_delete_medci_Click;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.FromArgb(230, 231, 233);
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(56, 167);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(245, 28);
            txt_email.TabIndex = 64;
            // 
            // btn_update_medci
            // 
            btn_update_medci.BackColor = Color.FromArgb(116, 86, 174);
            btn_update_medci.FlatAppearance.BorderSize = 0;
            btn_update_medci.FlatStyle = FlatStyle.Flat;
            btn_update_medci.ForeColor = Color.White;
            btn_update_medci.Location = new Point(56, 348);
            btn_update_medci.Name = "btn_update_medci";
            btn_update_medci.Size = new Size(245, 35);
            btn_update_medci.TabIndex = 63;
            btn_update_medci.Text = "Edit Customer";
            btn_update_medci.UseVisualStyleBackColor = false;
            btn_update_medci.Click += btn_update_medci_Click;
            // 
            // mm
            // 
            mm.AutoSize = true;
            mm.Location = new Point(56, 144);
            mm.Name = "mm";
            mm.Size = new Size(46, 20);
            mm.TabIndex = 62;
            mm.Text = "Email";
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.FromArgb(230, 231, 233);
            txt_phone.BorderStyle = BorderStyle.None;
            txt_phone.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_phone.Location = new Point(56, 98);
            txt_phone.Multiline = true;
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(245, 28);
            txt_phone.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 75);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 60;
            label1.Text = "Phone";
            // 
            // txt_supp_name
            // 
            txt_supp_name.BackColor = Color.FromArgb(230, 231, 233);
            txt_supp_name.BorderStyle = BorderStyle.None;
            txt_supp_name.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_supp_name.Location = new Point(56, 33);
            txt_supp_name.Multiline = true;
            txt_supp_name.Name = "txt_supp_name";
            txt_supp_name.Size = new Size(245, 28);
            txt_supp_name.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 10);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 58;
            label2.Text = "Customer Name";
            // 
            // dgv_customers
            // 
            dgv_customers.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customers.Location = new Point(322, 33);
            dgv_customers.Name = "dgv_customers";
            dgv_customers.RowHeadersWidth = 51;
            dgv_customers.Size = new Size(374, 230);
            dgv_customers.TabIndex = 56;
            dgv_customers.CellContentClick += dgv_customers_CellContentClick;
            dgv_customers.RowHeaderMouseDoubleClick += dgv_customers_RowHeaderMouseDoubleClick;
            // 
            // customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(761, 450);
            Controls.Add(btn_add_medc);
            Controls.Add(btn_delete_medci);
            Controls.Add(txt_email);
            Controls.Add(btn_update_medci);
            Controls.Add(mm);
            Controls.Add(txt_phone);
            Controls.Add(label1);
            Controls.Add(txt_supp_name);
            Controls.Add(label2);
            Controls.Add(dgv_customers);
            Controls.Add(btn_back_edit);
            Controls.Add(btn_exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "customer";
            Text = "customer";
            Load += customer_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_customers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back_edit;
        private Button btn_exit;
        private Button btn_add_medc;
        private Button btn_delete_medci;
        private TextBox txt_email;
        private Button btn_update_medci;
        private Label mm;
        private TextBox txt_phone;
        private Label label1;
        private TextBox txt_supp_name;
        private Label label2;
        private DataGridView dgv_customers;
    }
}