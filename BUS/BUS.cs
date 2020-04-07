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

    }


}

