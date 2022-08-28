using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HCG_N10
{
    class luatxl
    {
        ketnoi kn = new ketnoi();
        public void them(luat l)
        {
            
            String sql = "insert into TapLuat values('" + l.MaLuat + "',N'" + l.NoiDung + "')";
            kn.thuchien(sql);

        }
        
        public void sua(luat l)
        {
            String sql = "update TapLuat set NoiDung = N'" + l.NoiDung + "' where MaLuat = '" + l.MaLuat + "' ";
            kn.thuchien(sql);
        }
        public void xoa(String mal)
        {
            String sql = "delete from TapLuat where MaLuat ='" + mal + "'";
            kn.thuchien(sql);


        }
        public DataTable timkiem(String mal)
        {
            String sql = "select * from TapLuat where MaLuat ='" + mal + "'";
            return kn.getTable(sql);
        }
        public DataTable loadluat()
        {
            String sql = "select * from TapLuat";
            return kn.getTable(sql);
        }
    }
}
