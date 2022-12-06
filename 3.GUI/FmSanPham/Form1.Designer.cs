namespace _3.GUI.FmSanPham
{
    partial class Form1
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
            this.tbt_SoLuongCon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Size = new System.Windows.Forms.ComboBox();
            this.rb_ConHang = new System.Windows.Forms.RadioButton();
            this.rb_HetHang = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbt_GiaBan = new System.Windows.Forms.TextBox();
            this.tbt_TenSP = new System.Windows.Forms.TextBox();
            this.tbt_MaSP = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.ptb_Avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Tong = new System.Windows.Forms.Label();
            this.dtgv_SanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbt_TimTen = new System.Windows.Forms.TextBox();
            this.tbt_TimMa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_TimMa = new System.Windows.Forms.Button();
            this.btn_TimTen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ThemSize = new System.Windows.Forms.Button();
            this.btn_SuaSize = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.dtgv_slton = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_slton)).BeginInit();
            this.SuspendLayout();
            // 
            // tbt_SoLuongCon
            // 
            this.tbt_SoLuongCon.Location = new System.Drawing.Point(113, 251);
            this.tbt_SoLuongCon.Name = "tbt_SoLuongCon";
            this.tbt_SoLuongCon.Size = new System.Drawing.Size(190, 27);
            this.tbt_SoLuongCon.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số lượng ";
            // 
            // cb_Size
            // 
            this.cb_Size.FormattingEnabled = true;
            this.cb_Size.Items.AddRange(new object[] {
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44"});
            this.cb_Size.Location = new System.Drawing.Point(113, 205);
            this.cb_Size.Name = "cb_Size";
            this.cb_Size.Size = new System.Drawing.Size(187, 28);
            this.cb_Size.TabIndex = 16;
            // 
            // rb_ConHang
            // 
            this.rb_ConHang.AutoSize = true;
            this.rb_ConHang.Location = new System.Drawing.Point(112, 166);
            this.rb_ConHang.Name = "rb_ConHang";
            this.rb_ConHang.Size = new System.Drawing.Size(96, 24);
            this.rb_ConHang.TabIndex = 15;
            this.rb_ConHang.TabStop = true;
            this.rb_ConHang.Text = "Còn hàng";
            this.rb_ConHang.UseVisualStyleBackColor = true;
            // 
            // rb_HetHang
            // 
            this.rb_HetHang.AutoSize = true;
            this.rb_HetHang.Location = new System.Drawing.Point(209, 166);
            this.rb_HetHang.Name = "rb_HetHang";
            this.rb_HetHang.Size = new System.Drawing.Size(94, 24);
            this.rb_HetHang.TabIndex = 14;
            this.rb_HetHang.TabStop = true;
            this.rb_HetHang.Text = "Hết hàng";
            this.rb_HetHang.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên sản phẩm";
            // 
            // tbt_GiaBan
            // 
            this.tbt_GiaBan.Location = new System.Drawing.Point(112, 128);
            this.tbt_GiaBan.Name = "tbt_GiaBan";
            this.tbt_GiaBan.Size = new System.Drawing.Size(190, 27);
            this.tbt_GiaBan.TabIndex = 2;
            // 
            // tbt_TenSP
            // 
            this.tbt_TenSP.Location = new System.Drawing.Point(113, 80);
            this.tbt_TenSP.Name = "tbt_TenSP";
            this.tbt_TenSP.Size = new System.Drawing.Size(187, 27);
            this.tbt_TenSP.TabIndex = 1;
            // 
            // tbt_MaSP
            // 
            this.tbt_MaSP.Location = new System.Drawing.Point(112, 37);
            this.tbt_MaSP.Name = "tbt_MaSP";
            this.tbt_MaSP.Size = new System.Drawing.Size(188, 27);
            this.tbt_MaSP.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::_3.GUI.Properties.Resources.plus;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(6, 38);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(170, 58);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::_3.GUI.Properties.Resources.settings_gears_outlines_interface_symbol;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(182, 38);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(173, 58);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // ptb_Avatar
            // 
            this.ptb_Avatar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptb_Avatar.Location = new System.Drawing.Point(891, 49);
            this.ptb_Avatar.Name = "ptb_Avatar";
            this.ptb_Avatar.Size = new System.Drawing.Size(342, 345);
            this.ptb_Avatar.TabIndex = 29;
            this.ptb_Avatar.TabStop = false;
            this.ptb_Avatar.Click += new System.EventHandler(this.ptb_Avatar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã sản phẩm";
            // 
            // lbl_Tong
            // 
            this.lbl_Tong.AutoSize = true;
            this.lbl_Tong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tong.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tong.Location = new System.Drawing.Point(65, 680);
            this.lbl_Tong.Name = "lbl_Tong";
            this.lbl_Tong.Size = new System.Drawing.Size(170, 23);
            this.lbl_Tong.TabIndex = 30;
            this.lbl_Tong.Text = "Tổng số sản phẩm:  ";
            // 
            // dtgv_SanPham
            // 
            this.dtgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgv_SanPham.Location = new System.Drawing.Point(65, 433);
            this.dtgv_SanPham.Name = "dtgv_SanPham";
            this.dtgv_SanPham.RowHeadersWidth = 51;
            this.dtgv_SanPham.RowTemplate.Height = 29;
            this.dtgv_SanPham.Size = new System.Drawing.Size(579, 225);
            this.dtgv_SanPham.TabIndex = 28;
            this.dtgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_SanPham_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá Bán";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tình Trạng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbt_SoLuongCon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_Size);
            this.groupBox1.Controls.Add(this.rb_ConHang);
            this.groupBox1.Controls.Add(this.rb_HetHang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbt_GiaBan);
            this.groupBox1.Controls.Add(this.tbt_TenSP);
            this.groupBox1.Controls.Add(this.tbt_MaSP);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(65, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 345);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(525, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 31);
            this.label9.TabIndex = 27;
            this.label9.Text = "Danh sách sản phẩm";
            // 
            // tbt_TimTen
            // 
            this.tbt_TimTen.Location = new System.Drawing.Point(115, 108);
            this.tbt_TimTen.Name = "tbt_TimTen";
            this.tbt_TimTen.Size = new System.Drawing.Size(240, 27);
            this.tbt_TimTen.TabIndex = 19;
            // 
            // tbt_TimMa
            // 
            this.tbt_TimMa.Location = new System.Drawing.Point(115, 46);
            this.tbt_TimMa.Name = "tbt_TimMa";
            this.tbt_TimMa.Size = new System.Drawing.Size(240, 27);
            this.tbt_TimMa.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã sản phẩm";
            // 
            // btn_TimMa
            // 
            this.btn_TimMa.Location = new System.Drawing.Point(390, 91);
            this.btn_TimMa.Name = "btn_TimMa";
            this.btn_TimMa.Size = new System.Drawing.Size(104, 52);
            this.btn_TimMa.TabIndex = 1;
            this.btn_TimMa.Text = "Tìm Kiếm Theo Mã";
            this.btn_TimMa.UseVisualStyleBackColor = true;
            this.btn_TimMa.Click += new System.EventHandler(this.btn_TimMa_Click);
            // 
            // btn_TimTen
            // 
            this.btn_TimTen.Location = new System.Drawing.Point(390, 33);
            this.btn_TimTen.Name = "btn_TimTen";
            this.btn_TimTen.Size = new System.Drawing.Size(104, 52);
            this.btn_TimTen.TabIndex = 0;
            this.btn_TimTen.Text = "Tìm Kiếm Theo Tên";
            this.btn_TimTen.UseVisualStyleBackColor = true;
            this.btn_TimTen.Click += new System.EventHandler(this.btn_TimTen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbt_TimTen);
            this.groupBox2.Controls.Add(this.tbt_TimMa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_TimMa);
            this.groupBox2.Controls.Add(this.btn_TimTen);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(377, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 155);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm sản phẩm";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Image = global::_3.GUI.Properties.Resources.x_mark;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(369, 102);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(133, 58);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ThemSize);
            this.groupBox3.Controls.Add(this.btn_SuaSize);
            this.groupBox3.Controls.Add(this.btn_Thoat);
            this.groupBox3.Controls.Add(this.btn_LamMoi);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(377, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 179);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_ThemSize
            // 
            this.btn_ThemSize.Image = global::_3.GUI.Properties.Resources.plus;
            this.btn_ThemSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemSize.Location = new System.Drawing.Point(6, 102);
            this.btn_ThemSize.Name = "btn_ThemSize";
            this.btn_ThemSize.Size = new System.Drawing.Size(170, 58);
            this.btn_ThemSize.TabIndex = 6;
            this.btn_ThemSize.Text = "Thêm Size và SL";
            this.btn_ThemSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemSize.UseVisualStyleBackColor = true;
            this.btn_ThemSize.Click += new System.EventHandler(this.btn_ThemSize_Click);
            // 
            // btn_SuaSize
            // 
            this.btn_SuaSize.Image = global::_3.GUI.Properties.Resources.settings_gears_outlines_interface_symbol;
            this.btn_SuaSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaSize.Location = new System.Drawing.Point(182, 102);
            this.btn_SuaSize.Name = "btn_SuaSize";
            this.btn_SuaSize.Size = new System.Drawing.Size(173, 58);
            this.btn_SuaSize.TabIndex = 7;
            this.btn_SuaSize.Text = "Sửa size và SL";
            this.btn_SuaSize.UseVisualStyleBackColor = true;
            this.btn_SuaSize.Click += new System.EventHandler(this.btn_SuaSize_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = global::_3.GUI.Properties.Resources.refresh;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(369, 38);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(133, 58);
            this.btn_LamMoi.TabIndex = 4;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // dtgv_slton
            // 
            this.dtgv_slton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_slton.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgv_slton.Location = new System.Drawing.Point(682, 433);
            this.dtgv_slton.Name = "dtgv_slton";
            this.dtgv_slton.RowHeadersWidth = 51;
            this.dtgv_slton.RowTemplate.Height = 29;
            this.dtgv_slton.Size = new System.Drawing.Size(551, 225);
            this.dtgv_slton.TabIndex = 31;
            this.dtgv_slton.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_slton_CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên sản phẩm";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Size";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số lượng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 722);
            this.Controls.Add(this.dtgv_slton);
            this.Controls.Add(this.ptb_Avatar);
            this.Controls.Add(this.lbl_Tong);
            this.Controls.Add(this.dtgv_SanPham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_slton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbt_SoLuongCon;
        private Label label6;
        private ComboBox cb_Size;
        private RadioButton rb_ConHang;
        private RadioButton rb_HetHang;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox tbt_GiaBan;
        private TextBox tbt_TenSP;
        private TextBox tbt_MaSP;
        private Button btn_Them;
        private Button btn_sua;
        private PictureBox ptb_Avatar;
        private Label label1;
        private Label lbl_Tong;
        private DataGridView dtgv_SanPham;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox tbt_TimTen;
        private TextBox tbt_TimMa;
        private Label label8;
        private Label label4;
        private Button btn_TimMa;
        private Button btn_TimTen;
        private GroupBox groupBox2;
        private Button btn_Thoat;
        private GroupBox groupBox3;
        private Button btn_LamMoi;
        private DataGridView dtgv_slton;
        private Button btn_ThemSize;
        private Button btn_SuaSize;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}