namespace Shapping.Main_Form_Last.Clients_Last
{
    partial class client_main_last
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_see_selected = new System.Windows.Forms.Button();
            this.btn_add_clients = new System.Windows.Forms.Button();
            this.btn_see_clients = new System.Windows.Forms.Button();
            this.dgv_show_clients = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_find_by_id = new System.Windows.Forms.Button();
            this.txt_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_find_by_name = new System.Windows.Forms.Button();
            this.txt_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_see_selected
            // 
            this.btn_see_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_see_selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_selected.ForeColor = System.Drawing.Color.Transparent;
            this.btn_see_selected.Location = new System.Drawing.Point(335, 388);
            this.btn_see_selected.Name = "btn_see_selected";
            this.btn_see_selected.Size = new System.Drawing.Size(137, 44);
            this.btn_see_selected.TabIndex = 27;
            this.btn_see_selected.Text = "See Selected Client";
            this.btn_see_selected.UseVisualStyleBackColor = false;
            this.btn_see_selected.Click += new System.EventHandler(this.btn_see_selected_Click);
            // 
            // btn_add_clients
            // 
            this.btn_add_clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_add_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_clients.ForeColor = System.Drawing.Color.Transparent;
            this.btn_add_clients.Location = new System.Drawing.Point(478, 388);
            this.btn_add_clients.Name = "btn_add_clients";
            this.btn_add_clients.Size = new System.Drawing.Size(129, 44);
            this.btn_add_clients.TabIndex = 26;
            this.btn_add_clients.Text = "Add New Client";
            this.btn_add_clients.UseVisualStyleBackColor = false;
            this.btn_add_clients.Click += new System.EventHandler(this.btn_add_clients_Click);
            // 
            // btn_see_clients
            // 
            this.btn_see_clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_see_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_clients.ForeColor = System.Drawing.Color.Transparent;
            this.btn_see_clients.Location = new System.Drawing.Point(613, 388);
            this.btn_see_clients.Name = "btn_see_clients";
            this.btn_see_clients.Size = new System.Drawing.Size(118, 44);
            this.btn_see_clients.TabIndex = 25;
            this.btn_see_clients.Text = "See All Clients";
            this.btn_see_clients.UseVisualStyleBackColor = false;
            // 
            // dgv_show_clients
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_show_clients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_show_clients.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_show_clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_show_clients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_show_clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_show_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show_clients.DoubleBuffered = true;
            this.dgv_show_clients.EnableHeadersVisualStyles = false;
            this.dgv_show_clients.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_show_clients.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_show_clients.Location = new System.Drawing.Point(39, 170);
            this.dgv_show_clients.Name = "dgv_show_clients";
            this.dgv_show_clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_show_clients.Size = new System.Drawing.Size(691, 212);
            this.dgv_show_clients.TabIndex = 24;
            // 
            // btn_find_by_id
            // 
            this.btn_find_by_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_find_by_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find_by_id.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find_by_id.Location = new System.Drawing.Point(602, 85);
            this.btn_find_by_id.Name = "btn_find_by_id";
            this.btn_find_by_id.Size = new System.Drawing.Size(118, 44);
            this.btn_find_by_id.TabIndex = 23;
            this.btn_find_by_id.Text = "Find By ID";
            this.btn_find_by_id.UseVisualStyleBackColor = false;
            // 
            // txt_id
            // 
            this.txt_id.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_id.BorderThickness = 1;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.isPassword = false;
            this.txt_id.Location = new System.Drawing.Point(297, 90);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(254, 29);
            this.txt_id.TabIndex = 22;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter Client ID";
            // 
            // btn_find_by_name
            // 
            this.btn_find_by_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_find_by_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find_by_name.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find_by_name.Location = new System.Drawing.Point(602, 21);
            this.btn_find_by_name.Name = "btn_find_by_name";
            this.btn_find_by_name.Size = new System.Drawing.Size(118, 44);
            this.btn_find_by_name.TabIndex = 20;
            this.btn_find_by_name.Text = "Find By Name";
            this.btn_find_by_name.UseVisualStyleBackColor = false;
            // 
            // txt_name
            // 
            this.txt_name.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_name.BorderThickness = 1;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.isPassword = false;
            this.txt_name.Location = new System.Drawing.Point(297, 26);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(254, 29);
            this.txt_name.TabIndex = 19;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Client Name";
            // 
            // client_main_last
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_see_selected);
            this.Controls.Add(this.btn_add_clients);
            this.Controls.Add(this.btn_see_clients);
            this.Controls.Add(this.dgv_show_clients);
            this.Controls.Add(this.btn_find_by_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_find_by_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "client_main_last";
            this.Size = new System.Drawing.Size(754, 452);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_see_selected;
        private System.Windows.Forms.Button btn_add_clients;
        private System.Windows.Forms.Button btn_see_clients;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_show_clients;
        private System.Windows.Forms.Button btn_find_by_id;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_find_by_name;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_name;
        private System.Windows.Forms.Label label1;
    }
}
