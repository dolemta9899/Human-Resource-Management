using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.BUSLayer;
namespace GUI.UC
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        private void loadtodgv()
        {
            dgvNV.DataSource = BUS.xuat_NV();
            com_pb.DataSource = BUS.xuat_PB();
            com_pb.DisplayMember = "Tên Phòng Ban";
            com_pb.ValueMember = "Mã Phòng Ban";
        }

        private void loadtotext()
        {
            txtmanv.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txttennv.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
            datepk.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
            com_gt.Text= dgvNV.CurrentRow.Cells[3].Value.ToString();
            txtdc.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();
            com_pb.Text= dgvNV.CurrentRow.Cells[6].Value.ToString();
            txtluong.Text = dgvNV.CurrentRow.Cells[7].Value.ToString();

        }
        private void disableInput()
        {
            txtmanv.Enabled = false;
            txttennv.Enabled = false;
            txtluong.Enabled = false;
            txtdc.Enabled = false;
            txtsdt.Enabled = false;
            datepk.Enabled = false;
            com_pb.Enabled = false;
            com_gt.Enabled = false;

        }

        private void enableInput()
        {
            txtmanv.Enabled = true;
            txttennv.Enabled = true;
            txtluong.Enabled = true;
            txtdc.Enabled = true;
            txtsdt.Enabled = true;
            datepk.Enabled = true;
            com_pb.Enabled = true;
            com_gt.Enabled = true;

        }

        private void clearInput()
        {
            txtmanv.Clear();
            txttennv.Clear();
            txtsdt.Clear();
            txtdc.Clear();
            txtluong.Clear();
            com_gt.Text = "";
            com_pb.Text = "";

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadtodgv();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadtotext();
            enableInput();
            txtmanv.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            clearInput();
            enableInput();
         
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            QLNS.ValueObject.NhanVien a = new QLNS.ValueObject.NhanVien();
            a.MaNV = txtmanv.Text.Trim();
            a.TenNV = txttennv.Text.Trim();
            a.NgaySinh = datepk.Value;
            a.GioiTinh = com_gt.Text.Trim();
            a.MaPB = com_pb.SelectedValue.ToString();
            a.Luong1 = float.Parse(txtluong.Text);
            a.DiaChi = txtdc.Text;
            a.SDT1 = txtsdt.Text.Trim();


            if (a.MaNV == null || a.MaNV == "") throw new Exception();
            if (BUS.them_NV(a) == 1)
            {
                loadtodgv();
                MessageBox.Show("Thêm Thành Công");
            }
			   clearInput();
            disableInput();
            btn_xoa.Active = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (btn_them.Active || btn_sua.Active)
            {
                clearInput();
                disableInput();
                btn_xoa.Text = "Xóa";
                btn_xoa.Active = true;
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
            }
            else
            {
                btn_xoa.Text = "Xóa";
                btn_xoa.Active = true;
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                QLNS.ValueObject.NhanVien a = new QLNS.ValueObject.NhanVien();
                a.MaNV = txtmanv.Text.Trim();
                if (BUS.xoa_NV(a) != 1)
                    MessageBox.Show("Không xóa ðý?c");
                else
                {
                    loadtodgv();
                    MessageBox.Show("Xóa Thành Công");
                }
                clearInput();
                disableInput();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
           QLNS.ValueObject.NhanVien a = new QLNS.ValueObject.NhanVien();
            a.MaNV = txtmanv.Text.Trim();
            a.TenNV = txttennv.Text.Trim();
            a.NgaySinh = datepk.Value;
            a.GioiTinh = com_gt.Text.Trim();
            a.DiaChi = txtdc.Text.Trim();
            a.MaPB = com_pb.SelectedValue.ToString();
            a.SDT1 = txtsdt.Text.Trim();
            a.Luong1 = float.Parse(txtluong.Text);


            if (a.MaNV == null || a.MaNV == "") throw new Exception();
            if (BUS.sua_NV(a) == 1)
            {
                loadtodgv();
                MessageBox.Show("Sua Thành Công");
            }
            else throw new Exception();

        }
    }
}
