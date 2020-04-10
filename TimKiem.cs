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
using System.Data.SqlClient;
namespace GUI.UC
{ 
    public partial class TimKiem : UserControl
    {
        SqlDataAdapter da;
        DataTable dt, dt1;
        public TimKiem()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dt = BUS.xuat_NV();
            dt1 = BUS.xuat_PB();
            cmb_pb.DataSource = dt1;
            cmb_pb.DisplayMember = "Tên Phòng Ban";
            dgv_tknv.DataSource = dt;
            
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            xuat();
        }

        private void txt_tennv_TextChanged(object sender, EventArgs e)
        {
            string st = string.Format("[Tên Nhân Viên] like '%{0}%'", txt_tennv.Text);
            dt.DefaultView.RowFilter = st;
        }

        private void cmb_pb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OBFA05G\SQLEXPRESS;Initial Catalog=HumanResourceManagement;Integrated Security=True");
            con.Open();
            
            string s = "select maNV as[Mã Nhân Viên],tenNV as[Tên Nhân Viên],ngaySinh as[Ngày Sinh],gioiTinh as[Giới Tính],diaChi as[Địa Chỉ],NhanVien.SDT as[Số Điện Thoại],tenPB as[Tên Phòng Ban],Luong as[Lương] from NhanVien, PhongBan where NhanVien.maPB = PhongBan.maPB and tenpb=N'" + cmb_pb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dgv_tknv.DataSource = dt2;
        }

        private void txt_tennv_Click(object sender, EventArgs e)
        {
            txt_tennv.Text = "";
        }
    }
}
