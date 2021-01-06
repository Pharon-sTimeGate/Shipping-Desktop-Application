namespace Shapping.Main_Form_Last.Deliver_Last
{
    partial class deliver_main_last
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
            this.btn_edit_deliver_data = new System.Windows.Forms.Button();
            this.btn_add_deliver = new System.Windows.Forms.Button();
            this.btn_show_all_delivers = new System.Windows.Forms.Button();
            this.dgv_show_delivers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_find_by_name = new System.Windows.Forms.Button();
            this.txt_deliver_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_delivers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit_deliver_data
            // 
            this.btn_edit_deliver_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_edit_deliver_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_deliver_data.ForeColor = System.Drawing.Color.Transparent;
            this.btn_edit_deliver_data.Location = new System.Drawing.Point(303, 369);
            this.btn_edit_deliver_data.Name = "btn_edit_deliver_data";
            this.btn_edit_deliver_data.Size = new System.Drawing.Size(143, 44);
            this.btn_edit_deliver_data.TabIndex = 42;
            this.btn_edit_deliver_data.Text = "Edit Deliver Info";
            this.btn_edit_deliver_data.UseVisualStyleBackColor = false;
            this.btn_edit_deliver_data.Click += new System.EventHandler(this.btn_edit_deliver_data_Click);
            // 
            // btn_add_deliver
            // 
            this.btn_add_deliver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_add_deliver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_deliver.ForeColor = System.Drawing.Color.Transparent;
            this.btn_add_deliver.Location = new System.Drawing.Point(457, 369);
            this.btn_add_deliver.Name = "btn_add_deliver";
            this.btn_add_deliver.Size = new System.Drawing.Size(141, 44);
            this.btn_add_deliver.TabIndex = 41;
            this.btn_add_deliver.Text = "Add New Deliver";
            this.btn_add_deliver.UseVisualStyleBackColor = false;
            this.btn_add_deliver.Click += new System.EventHandler(this.btn_add_deliver_Click);
            // 
            // btn_show_all_delivers
            // 
            this.btn_show_all_delivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_show_all_delivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_all_delivers.ForeColor = System.Drawing.Color.Transparent;
            this.btn_show_all_delivers.Location = new System.Drawing.Point(609, 369);
            this.btn_show_all_delivers.Name = "btn_show_all_delivers";
            this.btn_show_all_delivers.Size = new System.Drawing.Size(118, 44);
            this.btn_show_all_delivers.TabIndex = 40;
            this.btn_show_all_delivers.Text = "All Delivers";
            this.btn_show_all_delivers.UseVisualStyleBackColor = false;
            // 
            // dgv_show_delivers
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_show_delivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_show_delivers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_show_delivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_show_delivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_show_delivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_show_delivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show_delivers.DoubleBuffered = true;
            this.dgv_show_delivers.EnableHeadersVisualStyles = false;
            this.dgv_show_delivers.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_show_delivers.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_show_delivers.Location = new System.Drawing.Point(35, 125);
            this.dgv_show_delivers.Name = "dgv_show_delivers";
            this.dgv_show_delivers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_show_delivers.Size = new System.Drawing.Size(691, 212);
            this.dgv_show_delivers.TabIndex = 39;
            // 
            // btn_find_by_name
            // 
            this.btn_find_by_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_find_by_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find_by_name.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find_by_name.Location = new System.Drawing.Point(608, 29);
            this.btn_find_by_name.Name = "btn_find_by_name";
            this.btn_find_by_name.Size = new System.Drawing.Size(118, 44);
            this.btn_find_by_name.TabIndex = 38;
            this.btn_find_by_name.Text = "Find By Name";
            this.btn_find_by_name.UseVisualStyleBackColor = false;
            // 
            // txt_deliver_name
            // 
            this.txt_deliver_name.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_deliver_name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_deliver_name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_deliver_name.BorderThickness = 1;
            this.txt_deliver_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_deliver_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_deliver_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_deliver_name.isPassword = false;
            this.txt_deliver_name.Location = new System.Drawing.Point(303, 34);
            this.txt_deliver_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_deliver_name.Name = "txt_deliver_name";
            this.txt_deliver_name.Size = new System.Drawing.Size(254, 29);
            this.txt_deliver_name.TabIndex = 37;
            this.txt_deliver_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Enter Deliver Name";
            // 
            // deliver_main_last
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_edit_deliver_data);
            this.Controls.Add(this.btn_add_deliver);
            this.Controls.Add(this.btn_show_all_delivers);
            this.Controls.Add(this.dgv_show_delivers);
            this.Controls.Add(this.btn_find_by_name);
            this.Controls.Add(this.txt_deliver_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "deliver_main_last";
            this.Size = new System.Drawing.Size(754, 452);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_delivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit_deliver_data;
        private System.Windows.Forms.Button btn_add_deliver;
        private System.Windows.Forms.Button btn_show_all_delivers;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_show_delivers;
        private System.Windows.Forms.Button btn_find_by_name;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_deliver_name;
        private System.Windows.Forms.Label label1;
    }
}
