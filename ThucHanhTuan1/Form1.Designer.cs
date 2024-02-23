namespace ThucHanhTuan1
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
            label1 = new Label();
            dtb1 = new DateTimePicker();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            label2 = new Label();
            txtHovaten = new TextBox();
            txtDiachi = new TextBox();
            txtCmnd = new TextBox();
            btnSua = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(78, 104);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // dtb1
            // 
            dtb1.Location = new Point(335, 488);
            dtb1.Name = "dtb1";
            dtb1.Size = new Size(350, 31);
            dtb1.TabIndex = 1;
            dtb1.ValueChanged += dtb1_ValueChanged;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(381, 621);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(169, 30);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(784, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(570, 428);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(156, 619);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(151, 34);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(78, 225);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 5;
            label2.Text = "Địa Chỉ";
            // 
            // txtHovaten
            // 
            txtHovaten.Location = new Point(335, 101);
            txtHovaten.Name = "txtHovaten";
            txtHovaten.Size = new Size(350, 31);
            txtHovaten.TabIndex = 6;
            txtHovaten.TextChanged += textBox1_TextChanged;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(335, 222);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(350, 31);
            txtDiachi.TabIndex = 7;
            // 
            // txtCmnd
            // 
            txtCmnd.Location = new Point(335, 362);
            txtCmnd.Name = "txtCmnd";
            txtCmnd.Size = new Size(350, 31);
            txtCmnd.TabIndex = 8;
            txtCmnd.TextChanged += textBox3_TextChanged;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(614, 621);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(169, 30);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(78, 368);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 10;
            label3.Text = "CMND";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(78, 488);
            label4.Name = "label4";
            label4.Size = new Size(190, 25);
            label4.TabIndex = 11;
            label4.Text = "Ngày Tháng Năm Sinh";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 732);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSua);
            Controls.Add(txtCmnd);
            Controls.Add(txtDiachi);
            Controls.Add(txtHovaten);
            Controls.Add(label2);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(dtb1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FHocSinh";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtb1;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Label label2;
        private TextBox txtHovaten;
        private TextBox txtDiachi;
        private TextBox txtCmnd;
        private Button btnSua;
        private Label label3;
        private Label label4;
    }
}
