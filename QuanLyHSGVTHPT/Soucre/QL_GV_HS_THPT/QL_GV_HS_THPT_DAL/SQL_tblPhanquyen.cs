﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QV_HS_THPT_Entity;
using System.Data;

namespace QL_GV_HS_THPT_DAL
{
    public class SQL_tblPhanquyen
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addPhanquyen(EC_tblPhanquyen et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblPhanquyen	");
        }
        //Sua du lieu
        public void updatePhanquyen(EC_tblPhanquyen et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE	tblPhanquyen	SET   ");
        }
        //Xoa du lieu
        public void delPhanquyen(EC_tblPhanquyen et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblPhanquyen WHERE Quyen = '" + et.Quyen + "'");
        }
        //select
        public DataTable getAllPhanquyen()
        {
            return cn.getDatatable(@"SELECT * FROM tblPhanquyen ");
        }
        public DataTable getPhanquyen(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblPhanquyen " + dk);
        }
    }
}
