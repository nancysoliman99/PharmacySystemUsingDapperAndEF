namespace Pharmacy
{
    partial class Form2
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
            btn_exit = new Button();
            label1 = new Label();
            btn_edit = new Button();
            btn_Customer = new Button();
            btn_Order = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            button1 = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(399, 15);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(33, 28);
            btn_exit.TabIndex = 15;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(131, 48);
            label1.Name = "label1";
            label1.Size = new Size(174, 34);
            label1.TabIndex = 16;
            label1.Text = "Dashboard";
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(116, 86, 174);
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(100, 174);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(245, 35);
            btn_edit.TabIndex = 17;
            btn_edit.Text = "Edit Profile";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_Customer
            // 
            btn_Customer.BackColor = Color.FromArgb(116, 86, 174);
            btn_Customer.FlatAppearance.BorderSize = 0;
            btn_Customer.FlatStyle = FlatStyle.Flat;
            btn_Customer.ForeColor = Color.White;
            btn_Customer.Location = new Point(100, 349);
            btn_Customer.Name = "btn_Customer";
            btn_Customer.Size = new Size(245, 35);
            btn_Customer.TabIndex = 18;
            btn_Customer.Text = "Customer";
            btn_Customer.UseVisualStyleBackColor = false;
            btn_Customer.Click += btn_Customer_Click;
            // 
            // btn_Order
            // 
            btn_Order.BackColor = Color.FromArgb(116, 86, 174);
            btn_Order.FlatAppearance.BorderSize = 0;
            btn_Order.FlatStyle = FlatStyle.Flat;
            btn_Order.ForeColor = Color.White;
            btn_Order.Location = new Point(100, 230);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(245, 35);
            btn_Order.TabIndex = 19;
            btn_Order.Text = "Sales";
            btn_Order.UseVisualStyleBackColor = false;
            btn_Order.Click += btn_Order_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(100, 288);
            button1.Name = "button1";
            button1.Size = new Size(245, 35);
            button1.TabIndex = 21;
            button1.Text = "Suppliers";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(116, 86, 174);
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(12, 496);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(92, 35);
            btn_back.TabIndex = 38;
            btn_back.Text = "log out";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(459, 543);
            Controls.Add(btn_back);
            Controls.Add(button1);
            Controls.Add(btn_Order);
            Controls.Add(btn_Customer);
            Controls.Add(btn_edit);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_exit;
        private Label label1;
        private Button btn_edit;
        private Button btn_Customer;
        private Button btn_Order;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button1;
        private Button btn_back;
    }
}