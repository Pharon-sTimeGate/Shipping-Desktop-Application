namespace Shapping.Main_Form_Last.Orders
{
    partial class order_main_last
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_see_orders = new System.Windows.Forms.Button();
            this.dgv_orders = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_find_by_id = new System.Windows.Forms.Button();
            this.txt_client_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_find_by_name = new System.Windows.Forms.Button();
            this.txt_client_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_see_orders
            // 
            this.btn_see_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_see_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_orders.ForeColor = System.Drawing.Color.Transparent;
            this.btn_see_orders.Location = new System.Drawing.Point(604, 390);
            this.btn_see_orders.Name = "btn_see_orders";
            this.btn_see_orders.Size = new System.Drawing.Size(118, 44);
            this.btn_see_orders.TabIndex = 15;
            this.btn_see_orders.Text = "See All Orders";
            this.btn_see_orders.UseVisualStyleBackColor = false;
            // 
            // dgv_orders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_orders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_orders.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.DoubleBuffered = true;
            this.dgv_orders.EnableHeadersVisualStyles = false;
            this.dgv_orders.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_orders.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_orders.Location = new System.Drawing.Point(41, 172);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_orders.Size = new System.Drawing.Size(691, 212);
            this.dgv_orders.TabIndex = 14;
            // 
            // btn_find_by_id
            // 
            this.btn_find_by_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_find_by_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find_by_id.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find_by_id.Location = new System.Drawing.Point(604, 87);
            this.btn_find_by_id.Name = "btn_find_by_id";
            this.btn_find_by_id.Size = new System.Drawing.Size(118, 44);
            this.btn_find_by_id.TabIndex = 13;
            this.btn_find_by_id.Text = "Find By ID";
            this.btn_find_by_id.UseVisualStyleBackColor = false;
            // 
            // txt_client_id
            // 
            this.txt_client_id.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_client_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_client_id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_client_id.BorderThickness = 1;
            this.txt_client_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_client_id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_client_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_client_id.isPassword = false;
            this.txt_client_id.Location = new System.Drawing.Point(299, 92);
            this.txt_client_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_client_id.Name = "txt_client_id";
            this.txt_client_id.Size = new System.Drawing.Size(254, 29);
            this.txt_client_id.TabIndex = 12;
            this.txt_client_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Order ID";
            // 
            // btn_find_by_name
            // 
            this.btn_find_by_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_find_by_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find_by_name.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find_by_name.Location = new System.Drawing.Point(604, 23);
            this.btn_find_by_name.Name = "btn_find_by_name";
            this.btn_find_by_name.Size = new System.Drawing.Size(118, 44);
            this.btn_find_by_name.TabIndex = 10;
            this.btn_find_by_name.Text = "Find By Name";
            this.btn_find_by_name.UseVisualStyleBackColor = false;
            // 
            // txt_client_name
            // 
            this.txt_client_name.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_client_name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_client_name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_client_name.BorderThickness = 1;
            this.txt_client_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_client_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_client_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_client_name.isPassword = false;
            this.txt_client_name.Location = new System.Drawing.Point(299, 28);
            this.txt_client_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.Size = new System.Drawing.Size(254, 29);
            this.txt_client_name.TabIndex = 9;
            this.txt_client_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Client Name";
            // 
            // order_main_last
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_see_orders);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.btn_find_by_id);
            this.Controls.Add(this.txt_client_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_find_by_name);
            this.Controls.Add(this.txt_client_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "order_main_last";
            this.Size = new System.Drawing.Size(754, 452);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_see_orders;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_orders;
        private System.Windows.Forms.Button btn_find_by_id;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_client_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_find_by_name;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_client_name;
        private System.Windows.Forms.Label label1;
    }
}
