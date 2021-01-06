namespace Shapping.Main_Form_Last.Staf
{
    partial class staf_main_last
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_staf = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_admins = new System.Windows.Forms.Button();
            this.btn_emp = new System.Windows.Forms.Button();
            this.dgv_staf = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staf)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.Transparent;
            this.btn_delete.Location = new System.Drawing.Point(32, 389);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 32);
            this.btn_delete.TabIndex = 57;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_staf
            // 
            this.btn_staf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_staf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staf.ForeColor = System.Drawing.Color.Transparent;
            this.btn_staf.Location = new System.Drawing.Point(383, 389);
            this.btn_staf.Name = "btn_staf";
            this.btn_staf.Size = new System.Drawing.Size(96, 32);
            this.btn_staf.TabIndex = 56;
            this.btn_staf.Text = "All Staf";
            this.btn_staf.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.Transparent;
            this.btn_add.Location = new System.Drawing.Point(500, 376);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(96, 45);
            this.btn_add.TabIndex = 55;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_edit.Location = new System.Drawing.Point(617, 376);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(96, 45);
            this.btn_edit.TabIndex = 54;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_admins
            // 
            this.btn_admins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_admins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admins.ForeColor = System.Drawing.Color.Transparent;
            this.btn_admins.Location = new System.Drawing.Point(149, 389);
            this.btn_admins.Name = "btn_admins";
            this.btn_admins.Size = new System.Drawing.Size(96, 32);
            this.btn_admins.TabIndex = 53;
            this.btn_admins.Text = "Admins";
            this.btn_admins.UseVisualStyleBackColor = false;
            // 
            // btn_emp
            // 
            this.btn_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp.ForeColor = System.Drawing.Color.Transparent;
            this.btn_emp.Location = new System.Drawing.Point(266, 389);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(96, 32);
            this.btn_emp.TabIndex = 52;
            this.btn_emp.Text = "Employees";
            this.btn_emp.UseVisualStyleBackColor = false;
            // 
            // dgv_staf
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_staf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_staf.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_staf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_staf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_staf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_staf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staf.DoubleBuffered = true;
            this.dgv_staf.EnableHeadersVisualStyles = false;
            this.dgv_staf.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_staf.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_staf.Location = new System.Drawing.Point(30, 88);
            this.dgv_staf.Name = "dgv_staf";
            this.dgv_staf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_staf.Size = new System.Drawing.Size(691, 254);
            this.dgv_staf.TabIndex = 51;
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find.Location = new System.Drawing.Point(554, 27);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(96, 32);
            this.btn_find.TabIndex = 50;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = false;
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
            this.txt_name.Location = new System.Drawing.Point(250, 30);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(254, 29);
            this.txt_name.TabIndex = 49;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(80, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "Enter Name";
            // 
            // staf_main_last
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_staf);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_admins);
            this.Controls.Add(this.btn_emp);
            this.Controls.Add(this.dgv_staf);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "staf_main_last";
            this.Size = new System.Drawing.Size(754, 452);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_staf;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_admins;
        private System.Windows.Forms.Button btn_emp;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_staf;
        private System.Windows.Forms.Button btn_find;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_name;
        private System.Windows.Forms.Label label1;
    }
}
