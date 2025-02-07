namespace Pharmacy
{
    partial class Products
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
            txt_Stokquentity = new TextBox();
            btn_update_medci = new Button();
            mm = new Label();
            txt_Product_price = new TextBox();
            label1 = new Label();
            txt_Product_username = new TextBox();
            label2 = new Label();
            btn_exit = new Button();
            dgv_Medci = new DataGridView();
            cb_supplier = new ComboBox();
            label3 = new Label();
            btn_delete_medci = new Button();
            btn_add_medc = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Medci).BeginInit();
            SuspendLayout();
            // 
            // btn_back_edit
            // 
            btn_back_edit.BackColor = Color.FromArgb(116, 86, 174);
            btn_back_edit.FlatAppearance.BorderSize = 0;
            btn_back_edit.FlatStyle = FlatStyle.Flat;
            btn_back_edit.ForeColor = Color.White;
            btn_back_edit.Location = new Point(696, 449);
            btn_back_edit.Name = "btn_back_edit";
            btn_back_edit.Size = new Size(92, 35);
            btn_back_edit.TabIndex = 37;
            btn_back_edit.Text = "Back";
            btn_back_edit.UseVisualStyleBackColor = false;
            btn_back_edit.Click += btn_back_edit_Click;
            // 
            // txt_Stokquentity
            // 
            txt_Stokquentity.BackColor = Color.FromArgb(230, 231, 233);
            txt_Stokquentity.BorderStyle = BorderStyle.None;
            txt_Stokquentity.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Stokquentity.Location = new Point(25, 183);
            txt_Stokquentity.Multiline = true;
            txt_Stokquentity.Name = "txt_Stokquentity";
            txt_Stokquentity.Size = new Size(245, 28);
            txt_Stokquentity.TabIndex = 36;
            // 
            // btn_update_medci
            // 
            btn_update_medci.BackColor = Color.FromArgb(116, 86, 174);
            btn_update_medci.FlatAppearance.BorderSize = 0;
            btn_update_medci.FlatStyle = FlatStyle.Flat;
            btn_update_medci.ForeColor = Color.White;
            btn_update_medci.Location = new Point(25, 364);
            btn_update_medci.Name = "btn_update_medci";
            btn_update_medci.Size = new Size(245, 35);
            btn_update_medci.TabIndex = 35;
            btn_update_medci.Text = "Update Medicine";
            btn_update_medci.UseVisualStyleBackColor = false;
            btn_update_medci.Click += btn_update_medci_Click;
            // 
            // mm
            // 
            mm.AutoSize = true;
            mm.Location = new Point(25, 160);
            mm.Name = "mm";
            mm.Size = new Size(105, 20);
            mm.TabIndex = 34;
            mm.Text = "Stock Quentity";
            // 
            // txt_Product_price
            // 
            txt_Product_price.BackColor = Color.FromArgb(230, 231, 233);
            txt_Product_price.BorderStyle = BorderStyle.None;
            txt_Product_price.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Product_price.Location = new Point(25, 114);
            txt_Product_price.Multiline = true;
            txt_Product_price.Name = "txt_Product_price";
            txt_Product_price.Size = new Size(245, 28);
            txt_Product_price.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 91);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 32;
            label1.Text = "Price";
            // 
            // txt_Product_username
            // 
            txt_Product_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_Product_username.BorderStyle = BorderStyle.None;
            txt_Product_username.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Product_username.Location = new Point(25, 49);
            txt_Product_username.Multiline = true;
            txt_Product_username.Name = "txt_Product_username";
            txt_Product_username.Size = new Size(245, 28);
            txt_Product_username.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 26);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 30;
            label2.Text = "Medicine Name";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(755, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(33, 28);
            btn_exit.TabIndex = 29;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // dgv_Medci
            // 
            dgv_Medci.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Medci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Medci.Location = new Point(276, 49);
            dgv_Medci.Name = "dgv_Medci";
            dgv_Medci.RowHeadersWidth = 51;
            dgv_Medci.Size = new Size(512, 230);
            dgv_Medci.TabIndex = 28;
            dgv_Medci.CellContentClick += dgv_Medci_CellContentClick;
            dgv_Medci.RowHeaderMouseDoubleClick += dgv_Medci_RowHeaderMouseDoubleClick;
            // 
            // cb_supplier
            // 
            cb_supplier.BackColor = Color.FromArgb(230, 231, 233);
            cb_supplier.FormattingEnabled = true;
            cb_supplier.Location = new Point(25, 248);
            cb_supplier.Name = "cb_supplier";
            cb_supplier.Size = new Size(245, 28);
            cb_supplier.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 225);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 39;
            label3.Text = "Supplier";
            // 
            // btn_delete_medci
            // 
            btn_delete_medci.BackColor = Color.FromArgb(116, 86, 174);
            btn_delete_medci.FlatAppearance.BorderSize = 0;
            btn_delete_medci.FlatStyle = FlatStyle.Flat;
            btn_delete_medci.ForeColor = Color.White;
            btn_delete_medci.Location = new Point(25, 421);
            btn_delete_medci.Name = "btn_delete_medci";
            btn_delete_medci.Size = new Size(245, 35);
            btn_delete_medci.TabIndex = 40;
            btn_delete_medci.Text = "Remove Medicine";
            btn_delete_medci.UseVisualStyleBackColor = false;
            btn_delete_medci.Click += btn_delete_medci_Click;
            // 
            // btn_add_medc
            // 
            btn_add_medc.BackColor = Color.FromArgb(116, 86, 174);
            btn_add_medc.FlatAppearance.BorderSize = 0;
            btn_add_medc.FlatStyle = FlatStyle.Flat;
            btn_add_medc.ForeColor = Color.White;
            btn_add_medc.Location = new Point(25, 310);
            btn_add_medc.Name = "btn_add_medc";
            btn_add_medc.Size = new Size(245, 35);
            btn_add_medc.TabIndex = 41;
            btn_add_medc.Text = "Add Medicine";
            btn_add_medc.UseVisualStyleBackColor = false;
            btn_add_medc.Click += btn_add_medc_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 513);
            Controls.Add(btn_add_medc);
            Controls.Add(btn_delete_medci);
            Controls.Add(label3);
            Controls.Add(cb_supplier);
            Controls.Add(btn_back_edit);
            Controls.Add(txt_Stokquentity);
            Controls.Add(btn_update_medci);
            Controls.Add(mm);
            Controls.Add(txt_Product_price);
            Controls.Add(label1);
            Controls.Add(txt_Product_username);
            Controls.Add(label2);
            Controls.Add(btn_exit);
            Controls.Add(dgv_Medci);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Medci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back_edit;
        private TextBox txt_Stokquentity;
        private Button btn_update_medci;
        private Label mm;
        private TextBox txt_Product_price;
        private Label label1;
        private TextBox txt_Product_username;
        private Label label2;
        private Button btn_exit;
        private DataGridView dgv_Medci;
        private ComboBox cb_supplier;
        private Label label3;
        private Button btn_delete_medci;
        private Button btn_add_medc;
    }
}