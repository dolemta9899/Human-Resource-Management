using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNS.DataAccessLayer;
using QLNS.ValueObject;

namespace QLNS.BUSLayer
{
    public class BUS
    {
      
        public static int them_TK(TaiKhoan a)
        {
            return DAO.them_TK(a);
        }
        //phong ban
        public static int them_PB(PhongBan a)
        {
            return DAO.them_PB(a);
        }
        //nhan vien
        public static int them_NV(NhanVien a)
        {
            return DAO.them_NV(a);
        }
        public static DataTable xuat_NV()
        {
            return DAO.xuat_NV();
        }
        public static DataTable xuat_PB()
        {
            return DAO.xuat_PB();
        }

    }


}

