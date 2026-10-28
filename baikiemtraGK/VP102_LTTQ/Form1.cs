using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace VP102_LTTQ;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private SqlConnection GetConnection()
    {
        try
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DuLieu;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            return conn;
        }
        catch
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=DuLieu;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            return conn;
        }
    }

    private void LoadData()
    {
        try
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT MaSinhVien, TenSinhVien, DiemTrungBinh FROM SinhVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
            }

            if (dgvSinhVien.Columns.Count >= 3)
            {
                dgvSinhVien.Columns[0].HeaderText = "Mã Sinh Viên";
                dgvSinhVien.Columns[1].HeaderText = "Tên Sinh Viên";
                dgvSinhVien.Columns[2].HeaderText = "Điểm Trung Bình";
            }
            dgvSinhVien.ClearSelection();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        btnSua.Enabled = false;
        btnXoa.Enabled = false;
        btnThem.Enabled = true;
        btnThoat.Enabled = true;
        LoadData();
    }

    private void txtDiemTrungBinh_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        {
            e.Handled = true;
        }

        if (e.KeyChar == '.' && (sender as TextBox)!.Text.IndexOf('.') > -1)
        {
            e.Handled = true;
        }
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            this.Close();
        }
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaSinhVien.Text) ||
            string.IsNullOrWhiteSpace(txtTenSinhVien.Text) ||
            string.IsNullOrWhiteSpace(txtDiemTrungBinh.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô TextBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            using (SqlConnection conn = GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM SinhVien WHERE MaSinhVien = @MaSV";
                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@MaSV", txtMaSinhVien.Text.Trim());
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaSinhVien.Focus();
                        return;
                    }
                }

                string insertQuery = "INSERT INTO SinhVien (MaSinhVien, TenSinhVien, DiemTrungBinh) VALUES (@MaSV, @TenSV, @DiemTB)";
                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@MaSV", txtMaSinhVien.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@TenSV", txtTenSinhVien.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@DiemTB", txtDiemTrungBinh.Text.Trim());
                    cmdInsert.ExecuteNonQuery();
                }
            }

            LoadData();
            txtMaSinhVien.Clear();
            txtTenSinhVien.Clear();
            txtDiemTrungBinh.Clear();
            btnThem.Enabled = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void txtMaSinhVien_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtMaSinhVien.Text))
        {
            btnThem.Enabled = true;
        }
    }

    private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
        {
            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
            txtMaSinhVien.Text = row.Cells[0].Value?.ToString();
            txtTenSinhVien.Text = row.Cells[1].Value?.ToString();
            txtDiemTrungBinh.Text = row.Cells[2].Value?.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    string deleteQuery = "DELETE FROM SinhVien WHERE MaSinhVien = @MaSV";
                    using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn))
                    {
                        cmdDelete.Parameters.AddWithValue("@MaSV", txtMaSinhVien.Text.Trim());
                        cmdDelete.ExecuteNonQuery();
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        txtMaSinhVien.Clear();
        txtTenSinhVien.Clear();
        txtDiemTrungBinh.Clear();
        btnSua.Enabled = false;
        btnXoa.Enabled = false;
        btnThem.Enabled = true;
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaSinhVien.Text) ||
            string.IsNullOrWhiteSpace(txtTenSinhVien.Text) ||
            string.IsNullOrWhiteSpace(txtDiemTrungBinh.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            using (SqlConnection conn = GetConnection())
            {
                string updateQuery = "UPDATE SinhVien SET TenSinhVien = @TenSV, DiemTrungBinh = @DiemTB WHERE MaSinhVien = @MaSV";
                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@MaSV", txtMaSinhVien.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@TenSV", txtTenSinhVien.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@DiemTB", txtDiemTrungBinh.Text.Trim());
                    cmdUpdate.ExecuteNonQuery();
                }
            }

            LoadData();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi sửa thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        txtMaSinhVien.Clear();
        txtTenSinhVien.Clear();
        txtDiemTrungBinh.Clear();
        btnSua.Enabled = false;
        btnXoa.Enabled = false;
        btnThem.Enabled = true;
    }

    private void txtDiemTrungBinh_TextChanged(object sender, EventArgs e)
    {

    }

    private void lblDiemTrungBinh_Click(object sender, EventArgs e)
    {

    }

    private void txtTenSinhVien_TextChanged(object sender, EventArgs e)
    {

    }

    private void lblTenSinhVien_Click(object sender, EventArgs e)
    {

    }

    private void lblMaSinhVien_Click(object sender, EventArgs e)
    {

    }
}
