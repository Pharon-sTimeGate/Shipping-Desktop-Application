namespace Shapping.Main_Form_Last.Clients_Last
{
    partial class frm_see_selected_client_last
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.leb_exit = new System.Windows.Forms.Label();
            this.dgv_client_data = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_client_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client_data)).BeginInit();
            this.SuspendLayout();
            // 
            // leb_exit
            // 
            this.leb_exit.AutoSize = true;
            this.leb_exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.leb_exit.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leb_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.leb_exit.Location = new System.Drawing.Point(724, -3);
            this.leb_exit.Name = "leb_exit";
            this.leb_exit.Size = new System.Drawing.Size(36, 32);
            this.leb_exit.TabIndex = 40;
            this.leb_exit.Text = "X";
            this.leb_exit.Click += new System.EventHandler(this.leb_exit_Click);
            // 
            // dgv_client_data
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_client_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_client_data.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_client_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_client_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_client_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_client_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client_data.DoubleBuffered = true;
            this.dgv_client_data.EnableHeadersVisualStyles = false;
            this.dgv_client_data.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_client_data.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_client_data.Location = new System.Drawing.Point(30, 175);
            this.dgv_client_data.Name = "dgv_client_data";
            this.dgv_client_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_client_data.Size = new System.Drawing.Size(691, 212);
            this.dgv_client_data.TabIndex = 39;
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
            this.txt_client_name.Location = new System.Drawing.Point(298, 84);
            this.txt_client_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.Size = new System.Drawing.Size(254, 29);
            this.txt_client_name.TabIndex = 38;
            this.txt_client_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(105, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Client Name";
            // 
            // frm_see_selected_client_last
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 452);
            this.Controls.Add(this.leb_exit);
            this.Controls.Add(this.dgv_client_data);
            this.Controls.Add(this.txt_client_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_see_selected_client_last";
            this.Text = "frm_see_selected_client_last";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leb_exit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_client_data;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_client_name;
        private System.Windows.Forms.Label label1;
    }
}