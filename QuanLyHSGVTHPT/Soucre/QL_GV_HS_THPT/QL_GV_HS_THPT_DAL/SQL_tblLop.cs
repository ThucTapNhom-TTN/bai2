using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QV_HS_THPT_Entity;
using System.Data;

namespace QL_GV_HS_THPT_DAL
{
    public class SQL_tblLop
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addLop(EC_tblLop et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblLop	");
        }
        //Sua du lieu
        public void updateLop(EC_tblLop et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE	tblLop	SET   ");
        }
        //Xoa du lieu
        public void delLop(EC_tblLop et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblLop WHERE MaLop = '" + et.MaLop + "'");
        }
        //select
        public DataTable getAllLop()
        {
            return cn.getDatatable(@"SELECT * FROM tblLop ");
        }
        public DataTable getLop(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblLop " + dk);
        }
    }
}
