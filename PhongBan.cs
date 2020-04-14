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
    public partial class PhongBan : UserControl
    {
        public PhongBan()
        {
            InitializeComponent();
        }
        private void loadtodgv()
        {
            dgvPB.DataSource = BUS.xuat_PB();

        }
        private void loadtotext()
        {
            txtmapb.Text = dgvPB.CurrentRow.Cells[0].Value.ToString();
            txttenpb.Text = dgvPB.CurrentRow.Cells[1].Value.ToString();
            txtemail.Text = dgvPB.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = dgvPB.CurrentRow.Cells[3].Value.ToString();
        }
        private void disableInput()
        {
            txtmapb.Enabled = false;
            txttenpb.Enabled = false;
            txtemail.Enabled = false;
            txtsdt.Enabled = false;
           
        }

        private void enableInput()
        {
            txtmapb.Enabled = true;
            txttenpb.Enabled = true;
            txtemail.Enabled = true;
            txtsdt.Enabled = true;
        
        }

        private void clearInput()
        {
            txtmapb.Clear();
            txttenpb.Clear();
            txtsdt.Clear();
            txtemail.Clear();
         
        }


        private void PhongBan_Load(object sender, EventArgs e)
        {
            disableInput();
            btn_sua.Enabled = false;
            loadtodgv();
        }

        private void dgvPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            loadtotext();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Text = "Xóa";
            btn_xoa.Active = true;
            txttenpb.Enabled = true;
            txtsdt.Enabled = true;
            txtemail.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            clearInput();
            enableInput();


        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            enableInput();
            txtmapb.Enabled = false;
            QLNS.ValueObject.PhongBan a = new QLNS.ValueObject.PhongBan();
            a.MaPB = txtmapb.Text.Trim();
            a.TenPB = txttenpb.Text.Trim();
            a.Email1 = txtemail.Text.Trim();
            a.SDT1 = txtsdt.Text.Trim();


            if (a.MaPB == null || a.MaPB == "") throw new Exception();
            if (BUS.sua_PB(a) == 1)
            {
                loadtodgv();
                MessageBox.Show("Sửa Thành Công");
            }
            else throw new Exception();


        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            QLNS.ValueObject.PhongBan a = new QLNS.ValueObject.PhongBan();
            a.MaPB = txtmapb.Text.Trim();
            a.TenPB = txttenpb.Text.Trim();
            a.Email1 = txtemail.Text.Trim();
            a.SDT1 = txtsdt.Text.Trim();


            if (a.MaPB == null || a.MaPB == "") throw new Exception();
            if (BUS.them_PB(a) == 1)
            {
                loadtodgv();
                MessageBox.Show("Thêm Thành Công");
            }



            clearInput();
            disableInput();
            btn_xoa.Active = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = false;


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
                QLNS.ValueObject.PhongBan a = new QLNS.ValueObject.PhongBan();
                a.MaPB = txtmapb.Text.Trim();
                if (BUS.xoa_PB(a) != 1)
                    MessageBox.Show("Không xóa được");
                else
                {
                    loadtodgv();
                    MessageBox.Show("Xóa Thành Công");
                }
                clearInput();
                disableInput();
            }
        }
    }
}
