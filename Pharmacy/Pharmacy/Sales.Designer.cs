namespace Pharmacy
{
    partial class Sales
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
            dgv_Sales = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Sales).BeginInit();
            SuspendLayout();
            // 
            // btn_back_edit
            // 
            btn_back_edit.BackColor = Color.FromArgb(116, 86, 174);
            btn_back_edit.FlatAppearance.BorderSize = 0;
            btn_back_edit.FlatStyle = FlatStyle.Flat;
            btn_back_edit.ForeColor = Color.White;
            btn_back_edit.Location = new Point(481, 471);
            btn_back_edit.Name = "btn_back_edit";
            btn_back_edit.Size = new Size(92, 35);
            btn_back_edit.TabIndex = 39;
            btn_back_edit.Text = "Back";
            btn_back_edit.UseVisualStyleBackColor = false;
            btn_back_edit.Click += btn_back_edit_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(553, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(33, 28);
            btn_exit.TabIndex = 31;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // dgv_Sales
            // 
            dgv_Sales.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Sales.Location = new Point(12, 98);
            dgv_Sales.Name = "dgv_Sales";
            dgv_Sales.RowHeadersWidth = 51;
            dgv_Sales.Size = new Size(397, 319);
            dgv_Sales.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(211, 34);
            label1.TabIndex = 40;
            label1.Text = "Sales Details";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(590, 517);
            Controls.Add(label1);
            Controls.Add(btn_back_edit);
            Controls.Add(btn_exit);
            Controls.Add(dgv_Sales);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Sales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_back_edit;
        private Button btn_exit;
        private DataGridView dgv_Sales;
        private Label label1;
    }
}