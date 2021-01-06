namespace Shapping.Main_Form_Last.Reports_Last
{
    partial class report_main_last
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
            this.btn_staf = new System.Windows.Forms.Button();
            this.btn_delivers = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_admins = new System.Windows.Forms.Button();
            this.btn_monthly = new System.Windows.Forms.Button();
            this.btn_Daily = new System.Windows.Forms.Button();
            this.dgv_reports = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_print = new System.Windows.Forms.Button();
            this.txt_end_date = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_start_date = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_staf
            // 
            this.btn_staf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_staf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staf.ForeColor = System.Drawing.Color.Transparent;
            this.btn_staf.Location = new System.Drawing.Point(70, 390);
            this.btn_staf.Name = "btn_staf";
            this.btn_staf.Size = new System.Drawing.Size(98, 32);
            this.btn_staf.TabIndex = 52;
            this.btn_staf.Text = "All Staf";
            this.btn_staf.UseVisualStyleBackColor = false;
            // 
            // btn_delivers
            // 
            this.btn_delivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_delivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivers.ForeColor = System.Drawing.Color.Transparent;
            this.btn_delivers.Location = new System.Drawing.Point(174, 390);
            this.btn_delivers.Name = "btn_delivers";
            this.btn_delivers.Size = new System.Drawing.Size(98, 32);
            this.btn_delivers.TabIndex = 51;
            this.btn_delivers.Text = "Delivers";
            this.btn_delivers.UseVisualStyleBackColor = false;
            // 
            // btn_employees
            // 
            this.btn_employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employees.ForeColor = System.Drawing.Color.Transparent;
            this.btn_employees.Location = new System.Drawing.Point(275, 390);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(98, 32);
            this.btn_employees.TabIndex = 50;
            this.btn_employees.Text = "Employees ";
            this.btn_employees.UseVisualStyleBackColor = false;
            // 
            // btn_admins
            // 
            this.btn_admins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_admins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admins.ForeColor = System.Drawing.Color.Transparent;
            this.btn_admins.Location = new System.Drawing.Point(379, 390);
            this.btn_admins.Name = "btn_admins";
            this.btn_admins.Size = new System.Drawing.Size(98, 32);
            this.btn_admins.TabIndex = 49;
            this.btn_admins.Text = "Admins";
            this.btn_admins.UseVisualStyleBackColor = false;
            // 
            // btn_monthly
            // 
            this.btn_monthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_monthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monthly.ForeColor = System.Drawing.Color.Transparent;
            this.btn_monthly.Location = new System.Drawing.Point(483, 390);
            this.btn_monthly.Name = "btn_monthly";
            this.btn_monthly.Size = new System.Drawing.Size(98, 32);
            this.btn_monthly.TabIndex = 48;
            this.btn_monthly.Text = "Monthly";
            this.btn_monthly.UseVisualStyleBackColor = false;
            // 
            // btn_Daily
            // 
            this.btn_Daily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Daily.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Daily.Location = new System.Drawing.Point(587, 390);
            this.btn_Daily.Name = "btn_Daily";
            this.btn_Daily.Size = new System.Drawing.Size(98, 32);
            this.btn_Daily.TabIndex = 47;
            this.btn_Daily.Text = "Daily";
            this.btn_Daily.UseVisualStyleBackColor = false;
            // 
            // dgv_reports
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_reports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_reports.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_reports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_reports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reports.DoubleBuffered = true;
            this.dgv_reports.EnableHeadersVisualStyles = false;
            this.dgv_reports.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_reports.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_reports.Location = new System.Drawing.Point(35, 160);
            this.dgv_reports.Name = "dgv_reports";
            this.dgv_reports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_reports.Size = new System.Drawing.Size(691, 212);
            this.dgv_reports.TabIndex = 46;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.Transparent;
            this.btn_print.Location = new System.Drawing.Point(608, 95);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(118, 44);
            this.btn_print.TabIndex = 45;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // txt_end_date
            // 
            this.txt_end_date.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_end_date.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_end_date.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_end_date.BorderThickness = 1;
            this.txt_end_date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_end_date.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_end_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_end_date.isPassword = false;
            this.txt_end_date.Location = new System.Drawing.Point(303, 100);
            this.txt_end_date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_end_date.Name = "txt_end_date";
            this.txt_end_date.Size = new System.Drawing.Size(254, 29);
            this.txt_end_date.TabIndex = 44;
            this.txt_end_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "Enter End Date";
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))));
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.ForeColor = System.Drawing.Color.Transparent;
            this.btn_find.Location = new System.Drawing.Point(608, 31);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(118, 44);
            this.btn_find.TabIndex = 42;
            this.btn_find.Text = "Find ";
            this.btn_find.UseVisualStyleBackColor = false;
            // 
            // txt_start_date
            // 
            this.txt_start_date.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_start_date.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_start_date.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_start_date.BorderThickness = 1;
            this.txt_start_date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_start_date.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_start_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_start_date.isPassword = false;
            this.txt_start_date.Location = new System.Drawing.Point(303, 36);
            this.txt_start_date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_start_date.Name = "txt_start_date";
            this.txt_start_date.Size = new System.Drawing.Size(254, 29);
            this.txt_start_date.TabIndex = 41;
            this.txt_start_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Enter Start Date";
            // 
            // report_main_last
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_staf);
            this.Controls.Add(this.btn_delivers);
            this.Controls.Add(this.btn_employees);
            this.Controls.Add(this.btn_admins);
            this.Controls.Add(this.btn_monthly);
            this.Controls.Add(this.btn_Daily);
            this.Controls.Add(this.dgv_reports);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txt_end_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.txt_start_date);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "report_main_last";
            this.Size = new System.Drawing.Size(754, 452);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_staf;
        private System.Windows.Forms.Button btn_delivers;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_admins;
        private System.Windows.Forms.Button btn_monthly;
        private System.Windows.Forms.Button btn_Daily;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_reports;
        private System.Windows.Forms.Button btn_print;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_end_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_find;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_start_date;
        private System.Windows.Forms.Label label1;
    }
}
