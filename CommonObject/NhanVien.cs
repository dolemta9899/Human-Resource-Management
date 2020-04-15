using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.ValueObject
{
    public class NhanVien

    {
        private string maNV;
        private string tenNV;
        private DateTime ngaySinh;

        private string gioiTinh;
        private string diaChi;
        private string SDT;
        private string maPB;
        private float Luong;
        public string MaPB
        {
            get { return maPB; }
            set { maPB = value; }
        }
        public string MaNV

        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string SDT1
        {
            get { return SDT; }
            set { SDT = value; }
        }
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public float Luong1
        {
            get { return Luong; }
            set { Luong = value; }
        }


    }
}
