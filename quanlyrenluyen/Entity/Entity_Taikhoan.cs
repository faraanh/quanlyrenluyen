using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyrenluyen.Entity
{
    class Entity_Taikhoan
    {
        private string MaTk;
        public string MaTk1
        {
            get { return MaTk; }
            set { MaTk = value; }
        }
      
        private string Matkhau;

        public string Matkhau1
        {
            get { return Matkhau; }
            set { Matkhau = value; }
        }
        private string Phanquyen;

        public string Phanquyen1
        {
            get { return Phanquyen; }
            set { Phanquyen = value; }
        }
    }
}
