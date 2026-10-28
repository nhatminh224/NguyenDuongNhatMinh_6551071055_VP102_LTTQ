namespace VP102_LTTQ;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnThoat = new Button();
        grpDanhSach = new GroupBox();
        dgvSinhVien = new DataGridView();
        grpThongTin = new GroupBox();
        txtDiemTrungBinh = new TextBox();
        lblDiemTrungBinh = new Label();
        txtTenSinhVien = new TextBox();
        lblTenSinhVien = new Label();
        txtMaSinhVien = new TextBox();
        lblMaSinhVien = new Label();
        grpDanhSach.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
        grpThongTin.SuspendLayout();
        SuspendLayout();
        // 
        // btnThem
        // 
        btnThem.Location = new Point(34, 27);
        btnThem.Margin = new Padding(3, 4, 3, 4);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(109, 47);
        btnThem.TabIndex = 0;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        // 
        // btnSua
        // 
        btnSua.Location = new Point(190, 27);
        btnSua.Margin = new Padding(3, 4, 3, 4);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(109, 47);
        btnSua.TabIndex = 1;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        // 
        // btnXoa
        // 
        btnXoa.Location = new Point(333, 27);
        btnXoa.Margin = new Padding(3, 4, 3, 4);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(109, 47);
        btnXoa.TabIndex = 2;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnThoat
        // 
        btnThoat.Location = new Point(485, 27);
        btnThoat.Margin = new Padding(3, 4, 3, 4);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(109, 47);
        btnThoat.TabIndex = 3;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        btnThoat.Click += btnThoat_Click;
        // 
        // grpDanhSach
        // 
        grpDanhSach.Controls.Add(dgvSinhVien);
        grpDanhSach.Location = new Point(34, 100);
        grpDanhSach.Margin = new Padding(3, 4, 3, 4);
        grpDanhSach.Name = "grpDanhSach";
        grpDanhSach.Padding = new Padding(3, 4, 3, 4);
        grpDanhSach.Size = new Size(497, 440);
        grpDanhSach.TabIndex = 4;
        grpDanhSach.TabStop = false;
        grpDanhSach.Text = "Danh sách sinh viên";
        // 
        // dgvSinhVien
        // 
        dgvSinhVien.AllowUserToAddRows = false;
        dgvSinhVien.AllowUserToDeleteRows = false;
        dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSinhVien.Dock = DockStyle.Fill;
        dgvSinhVien.Location = new Point(3, 24);
        dgvSinhVien.Margin = new Padding(3, 4, 3, 4);
        dgvSinhVien.MultiSelect = false;
        dgvSinhVien.Name = "dgvSinhVien";
        dgvSinhVien.ReadOnly = true;
        dgvSinhVien.RowHeadersWidth = 51;
        dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSinhVien.Size = new Size(491, 412);
        dgvSinhVien.TabIndex = 0;
        dgvSinhVien.CellClick += dgvSinhVien_CellClick;
        // 
        // grpThongTin
        // 
        grpThongTin.Controls.Add(txtDiemTrungBinh);
        grpThongTin.Controls.Add(lblDiemTrungBinh);
        grpThongTin.Controls.Add(txtTenSinhVien);
        grpThongTin.Controls.Add(lblTenSinhVien);
        grpThongTin.Controls.Add(txtMaSinhVien);
        grpThongTin.Controls.Add(lblMaSinhVien);
        grpThongTin.Location = new Point(554, 100);
        grpThongTin.Margin = new Padding(3, 4, 3, 4);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Padding = new Padding(3, 4, 3, 4);
        grpThongTin.Size = new Size(343, 440);
        grpThongTin.TabIndex = 5;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông tin sinh viên";
        // 
        // txtDiemTrungBinh
        // 
        txtDiemTrungBinh.Location = new Point(29, 309);
        txtDiemTrungBinh.Margin = new Padding(3, 4, 3, 4);
        txtDiemTrungBinh.Name = "txtDiemTrungBinh";
        txtDiemTrungBinh.Size = new Size(285, 27);
        txtDiemTrungBinh.TabIndex = 5;
        txtDiemTrungBinh.TextChanged += txtDiemTrungBinh_TextChanged;
        txtDiemTrungBinh.KeyPress += txtDiemTrungBinh_KeyPress;
        // 
        // lblDiemTrungBinh
        // 
        lblDiemTrungBinh.AutoSize = true;
        lblDiemTrungBinh.Location = new Point(29, 285);
        lblDiemTrungBinh.Name = "lblDiemTrungBinh";
        lblDiemTrungBinh.Size = new Size(120, 20);
        lblDiemTrungBinh.TabIndex = 4;
        lblDiemTrungBinh.Text = "Điểm trung bình:";
        lblDiemTrungBinh.Click += lblDiemTrungBinh_Click;
        // 
        // txtTenSinhVien
        // 
        txtTenSinhVien.Location = new Point(29, 212);
        txtTenSinhVien.Margin = new Padding(3, 4, 3, 4);
        txtTenSinhVien.Name = "txtTenSinhVien";
        txtTenSinhVien.Size = new Size(285, 27);
        txtTenSinhVien.TabIndex = 3;
        txtTenSinhVien.TextChanged += txtTenSinhVien_TextChanged;
        // 
        // lblTenSinhVien
        // 
        lblTenSinhVien.AutoSize = true;
        lblTenSinhVien.Location = new Point(29, 188);
        lblTenSinhVien.Name = "lblTenSinhVien";
        lblTenSinhVien.Size = new Size(96, 20);
        lblTenSinhVien.TabIndex = 2;
        lblTenSinhVien.Text = "Tên sinh viên:";
        lblTenSinhVien.Click += lblTenSinhVien_Click;
        // 
        // txtMaSinhVien
        // 
        txtMaSinhVien.Location = new Point(29, 117);
        txtMaSinhVien.Margin = new Padding(3, 4, 3, 4);
        txtMaSinhVien.Name = "txtMaSinhVien";
        txtMaSinhVien.Size = new Size(285, 27);
        txtMaSinhVien.TabIndex = 1;
        txtMaSinhVien.TextChanged += txtMaSinhVien_TextChanged;
        // 
        // lblMaSinhVien
        // 
        lblMaSinhVien.AutoSize = true;
        lblMaSinhVien.Location = new Point(29, 93);
        lblMaSinhVien.Name = "lblMaSinhVien";
        lblMaSinhVien.Size = new Size(94, 20);
        lblMaSinhVien.TabIndex = 0;
        lblMaSinhVien.Text = "Mã sinh viên:";
        lblMaSinhVien.Click += lblMaSinhVien_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(931, 580);
        Controls.Add(grpThongTin);
        Controls.Add(grpDanhSach);
        Controls.Add(btnThoat);
        Controls.Add(btnXoa);
        Controls.Add(btnSua);
        Controls.Add(btnThem);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý hồ sơ sinh viên / Học phần - VP102";
        Load += Form1_Load;
        grpDanhSach.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
        grpThongTin.ResumeLayout(false);
        grpThongTin.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnThoat;
    private GroupBox grpDanhSach;
    private DataGridView dgvSinhVien;
    private GroupBox grpThongTin;
    private TextBox txtDiemTrungBinh;
    private Label lblDiemTrungBinh;
    private TextBox txtTenSinhVien;
    private Label lblTenSinhVien;
    private TextBox txtMaSinhVien;
    private Label lblMaSinhVien;
}
