namespace Shapping.Main_Form_Last.Notification
{
    partial class frm_assign_deliver
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_see_orders = new System.Windows.Forms.Button();
            this.dgv_orders = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lab_exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(471, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 27);
            this.comboBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(134, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Select Deliver";
            // 
            // btn_see_orders
            // 
            this.btn_see_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_see_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_orders.ForeColor = System.Drawing.Color.Transparent;
            this.btn_see_orders.Location = new System.Drawing.Point(605, 325);
            this.btn_see_orders.Name = "btn_see_orders";
            this.btn_see_orders.Size = new System.Drawing.Size(118, 44);
            this.btn_see_orders.TabIndex = 22;
            this.btn_see_orders.Text = "Print Bill";
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
            this.dgv_orders.Location = new System.Drawing.Point(42, 85);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_orders.Size = new System.Drawing.Size(691, 234);
            this.dgv_orders.TabIndex = 21;
            // 
            // lab_exit
            // 
            this.lab_exit.AutoSize = true;
            this.lab_exit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lab_exit.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.lab_exit.Location = new System.Drawing.Point(720, 0);
            this.lab_exit.Name = "lab_exit";
            this.lab_exit.Size = new System.Drawing.Size(36, 32);
            this.lab_exit.TabIndex = 67;
            this.lab_exit.Text = "X";
            this.lab_exit.Click += new System.EventHandler(this.lab_exit_Click);
            // 
            // frm_assign_deliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 452);
            this.Controls.Add(this.lab_exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_see_orders);
            this.Controls.Add(this.dgv_orders);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_assign_deliver";
            this.Text = "frm_assign_deliver";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_see_orders;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_orders;
        private System.Windows.Forms.Label lab_exit;
    }
}