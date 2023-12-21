namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_id = new TextBox();
            txt_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmb_dep = new ComboBox();
            cmb_desg = new ComboBox();
            date_dob = new DateTimePicker();
            grd_data = new DataGridView();
            col_id = new DataGridViewTextBoxColumn();
            col_name = new DataGridViewTextBoxColumn();
            col_dept = new DataGridViewTextBoxColumn();
            col_desg = new DataGridViewTextBoxColumn();
            col_dob = new DataGridViewTextBoxColumn();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)grd_data).BeginInit();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.AcceptsReturn = true;
            txt_id.Location = new Point(157, 73);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(243, 27);
            txt_id.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(157, 122);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(243, 27);
            txt_name.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 73);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 3;
            label1.Text = "Emp ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 122);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 168);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 214);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 6;
            label4.Text = "Designation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 261);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 7;
            label5.Text = "DOB";
            // 
            // cmb_dep
            // 
            cmb_dep.FormattingEnabled = true;
            cmb_dep.Items.AddRange(new object[] { "IT", "Civil", "Computer" });
            cmb_dep.Location = new Point(157, 168);
            cmb_dep.Name = "cmb_dep";
            cmb_dep.Size = new Size(243, 28);
            cmb_dep.TabIndex = 8;
            // 
            // cmb_desg
            // 
            cmb_desg.FormattingEnabled = true;
            cmb_desg.Items.AddRange(new object[] { "IT engineer", "lauda", "lassan" });
            cmb_desg.Location = new Point(157, 214);
            cmb_desg.Name = "cmb_desg";
            cmb_desg.Size = new Size(243, 28);
            cmb_desg.TabIndex = 9;
            // 
            // date_dob
            // 
            date_dob.Location = new Point(157, 256);
            date_dob.Name = "date_dob";
            date_dob.Size = new Size(243, 27);
            date_dob.TabIndex = 10;
            // 
            // grd_data
            // 
            grd_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_data.Columns.AddRange(new DataGridViewColumn[] { col_id, col_name, col_dept, col_desg, col_dob });
            grd_data.Location = new Point(435, 73);
            grd_data.Name = "grd_data";
            grd_data.RowHeadersWidth = 51;
            grd_data.Size = new Size(680, 284);
            grd_data.TabIndex = 12;
            // 
            // col_id
            // 
            col_id.HeaderText = "ID";
            col_id.MinimumWidth = 6;
            col_id.Name = "col_id";
            col_id.Width = 125;
            // 
            // col_name
            // 
            col_name.HeaderText = "Name";
            col_name.MinimumWidth = 6;
            col_name.Name = "col_name";
            col_name.Width = 125;
            // 
            // col_dept
            // 
            col_dept.HeaderText = "Department";
            col_dept.MinimumWidth = 6;
            col_dept.Name = "col_dept";
            col_dept.Width = 125;
            // 
            // col_desg
            // 
            col_desg.HeaderText = "Designation";
            col_desg.MinimumWidth = 6;
            col_desg.Name = "col_desg";
            col_desg.Width = 125;
            // 
            // col_dob
            // 
            col_dob.HeaderText = "DOB";
            col_dob.MinimumWidth = 6;
            col_dob.Name = "col_dob";
            col_dob.Width = 125;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(229, 319);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 13;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 535);
            Controls.Add(btn_save);
            Controls.Add(grd_data);
            Controls.Add(date_dob);
            Controls.Add(cmb_desg);
            Controls.Add(cmb_dep);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grd_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox password;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView2;
        private Button button1;
        private TextBox txt_id;
        private TextBox txt_name;
        private ComboBox cmb_dep;
        private ComboBox cmb_desg;
        private DateTimePicker date_dob;
        private Button btn_save;
        private DataGridView grd_data;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn col_name;
        private DataGridViewTextBoxColumn col_dept;
        private DataGridViewTextBoxColumn col_desg;
        private DataGridViewTextBoxColumn col_dob;
    }
}
