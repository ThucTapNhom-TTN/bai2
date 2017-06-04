using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_GV_HS_THPT_DAL;
using QL_QV_HS_THPT_Entity;
using System.Data;

namespace QL_GV_HS_THPT_BUS
{
    public class BUS_tblHocSinh
    {
        SQL_tblHocsinh bus = new SQL_tblHocsinh();
        public void addHocsinh(EC_tblHocsinh et)
        {
            bus.addHocsinh(et);
        }
        //Sua du lieu
        public void updateHocsinh(EC_tblHocsinh et)
        {
            bus.updateHocsinh(et);
        }
        //Xoa du lieu
        public void delHocsinh(EC_tblHocsinh et)
        {
            bus.delHocsinh(et);
        }
        //select
        public DataTable getAllHocsinh()
        {
            return bus.getAllHocsinh();
        }
        public DataTable getHocsinh(string dk)
        {
            return bus.getHocsinh(dk);
        }
        public DataTable getField(string Field)
        {
            return bus.getField(Field);
        }
        public DataTable DoDLMaLop(string dk)
        {
            return bus.DoDLMaLop(dk);
        }
        public DataTable LayMaHS()
        {
            return bus.LayRaMaHS();
        }
    }
}
