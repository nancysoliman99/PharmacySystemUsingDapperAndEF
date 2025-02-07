namespace Pharmacy
{
    partial class Suppliers
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
            btn_add_medc = new Button();
            btn_delete_medci = new Button();
            btn_back_edit = new Button();
            txt_address = new TextBox();
            btn_update_medci = new Button();
            mm = new Label();
            txt_contact = new TextBox();
            label1 = new Label();
            txt_supp_name = new TextBox();
            label2 = new Label();
            btn_exit = new Button();
            dgv_suppliers = new DataGridView();
            btn_product = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_suppliers).BeginInit();
            SuspendLayout();
            // 
            // btn_add_medc
            // 
            btn_add_medc.BackColor = Color.FromArgb(116, 86, 174);
            btn_add_medc.FlatAppearance.BorderSize = 0;
            btn_add_medc.FlatStyle = FlatStyle.Flat;
            btn_add_medc.ForeColor = Color.White;
            btn_add_medc.Location = new Point(25, 306);
            btn_add_medc.Name = "btn_add_medc";
            btn_add_medc.Size = new Size(245, 35);
            btn_add_medc.TabIndex = 55;
            btn_add_medc.Text = "New Supplier";
            btn_add_medc.UseVisualStyleBackColor = false;
            btn_add_medc.Click += btn_add_medc_Click;
            // 
            // btn_delete_medci
            // 
            btn_delete_medci.BackColor = Color.FromArgb(116, 86, 174);
            btn_delete_medci.FlatAppearance.BorderSize = 0;
            btn_delete_medci.FlatStyle = FlatStyle.Flat;
            btn_delete_medci.ForeColor = Color.White;
            btn_delete_medci.Location = new Point(25, 417);
            btn_delete_medci.Name = "btn_delete_medci";
            btn_delete_medci.Size = new Size(245, 35);
            btn_delete_medci.TabIndex = 54;
            btn_delete_medci.Text = "Remove Supplier";
            btn_delete_medci.UseVisualStyleBackColor = false;
            btn_delete_medci.Click += btn_delete_medci_Click;
            // 
            // btn_back_edit
            // 
            btn_back_edit.BackColor = Color.FromArgb(116, 86, 174);
            btn_back_edit.FlatAppearance.BorderSize = 0;
            btn_back_edit.FlatStyle = FlatStyle.Flat;
            btn_back_edit.ForeColor = Color.White;
            btn_back_edit.Location = new Point(608, 439);
            btn_back_edit.Name = "btn_back_edit";
            btn_back_edit.Size = new Size(92, 35);
            btn_back_edit.TabIndex = 51;
            btn_back_edit.Text = "Back";
            btn_back_edit.UseVisualStyleBackColor = false;
            btn_back_edit.Click += btn_back_edit_Click;
            // 
            // txt_address
            // 
            txt_address.BackColor = Color.FromArgb(230, 231, 233);
            txt_address.BorderStyle = BorderStyle.None;
            txt_address.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_address.Location = new Point(25, 179);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(245, 28);
            txt_address.TabIndex = 50;
            // 
            // btn_update_medci
            // 
            btn_update_medci.BackColor = Color.FromArgb(116, 86, 174);
            btn_update_medci.FlatAppearance.BorderSize = 0;
            btn_update_medci.FlatStyle = FlatStyle.Flat;
            btn_update_medci.ForeColor = Color.White;
            btn_update_medci.Location = new Point(25, 360);
            btn_update_medci.Name = "btn_update_medci";
            btn_update_medci.Size = new Size(245, 35);
            btn_update_medci.TabIndex = 49;
            btn_update_medci.Text = "Edit Supplier";
            btn_update_medci.UseVisualStyleBackColor = false;
            btn_update_medci.Click += btn_update_medci_Click;
            // 
            // mm
            // 
            mm.AutoSize = true;
            mm.Location = new Point(25, 156);
            mm.Name = "mm";
            mm.Size = new Size(62, 20);
            mm.TabIndex = 48;
            mm.Text = "Address";
            // 
            // txt_contact
            // 
            txt_contact.BackColor = Color.FromArgb(230, 231, 233);
            txt_contact.BorderStyle = BorderStyle.None;
            txt_contact.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contact.Location = new Point(25, 110);
            txt_contact.Multiline = true;
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(245, 28);
            txt_contact.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 87);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 46;
            label1.Text = "Phone";
            // 
            // txt_supp_name
            // 
            txt_supp_name.BackColor = Color.FromArgb(230, 231, 233);
            txt_supp_name.BorderStyle = BorderStyle.None;
            txt_supp_name.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_supp_name.Location = new Point(25, 45);
            txt_supp_name.Multiline = true;
            txt_supp_name.Name = "txt_supp_name";
            txt_supp_name.Size = new Size(245, 28);
            txt_supp_name.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 22);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 44;
            label2.Text = "Supplier Name";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(667, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(33, 28);
            btn_exit.TabIndex = 43;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // dgv_suppliers
            // 
            dgv_suppliers.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_suppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_suppliers.Location = new Point(291, 45);
            dgv_suppliers.Name = "dgv_suppliers";
            dgv_suppliers.RowHeadersWidth = 51;
            dgv_suppliers.Size = new Size(374, 230);
            dgv_suppliers.TabIndex = 42;
            dgv_suppliers.CellContentClick += dgv_suppliers_CellContentClick;
            dgv_suppliers.RowHeaderMouseDoubleClick += dgv_suppliers_RowHeaderMouseDoubleClick;
            // 
            // btn_product
            // 
            btn_product.BackColor = Color.FromArgb(116, 86, 174);
            btn_product.FlatAppearance.BorderSize = 0;
            btn_product.FlatStyle = FlatStyle.Flat;
            btn_product.ForeColor = Color.White;
            btn_product.Location = new Point(25, 227);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(130, 35);
            btn_product.TabIndex = 56;
            btn_product.Text = "New Medicien";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(709, 486);
            Controls.Add(btn_product);
            Controls.Add(btn_add_medc);
            Controls.Add(btn_delete_medci);
            Controls.Add(btn_back_edit);
            Controls.Add(txt_address);
            Controls.Add(btn_update_medci);
            Controls.Add(mm);
            Controls.Add(txt_contact);
            Controls.Add(label1);
            Controls.Add(txt_supp_name);
            Controls.Add(label2);
            Controls.Add(btn_exit);
            Controls.Add(dgv_suppliers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_suppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add_medc;
        private Button btn_delete_medci;
        private Button btn_back_edit;
        private TextBox txt_address;
        private Button btn_update_medci;
        private Label mm;
        private TextBox txt_contact;
        private Label label1;
        private TextBox txt_supp_name;
        private Label label2;
        private Button btn_exit;
        private DataGridView dgv_suppliers;
        private Button btn_product;
    }
}