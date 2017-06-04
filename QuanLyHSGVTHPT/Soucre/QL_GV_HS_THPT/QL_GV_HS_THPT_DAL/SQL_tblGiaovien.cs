using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_QV_HS_THPT_Entity;
using System.Data;

namespace QL_GV_HS_THPT_DAL
{
    public class SQL_tblGiaovien
    {
        KetNoiDB cn = new KetNoiDB();
        //Them du lieu
        public void addGiaovien(EC_tblGiaovien et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblGiaovien	(MaGV, Ho, Ten, GT, SDT, NgaySinh, DiaChi, Luong, MaMon)    VALUES   ( '"+et.MaGV+"' , N'"+et.Ho+"', N'"+et.Ten+"', N'"+et.GT+"', '"+et.SDT+"', '"+et.NgaySinh+"', N'"+et.DiaChi+"', "+et.Luong+", '"+et.MaMon+"')");
        }
        //Sua du lieu
        public void updateGiaovien(EC_tblGiaovien et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE   tblGiaovien   SET  Ho =N'"+et.Ho+"', Ten =N'"+et.Ten+"', GT =N'"+et.GT+"', NgaySinh = '"+et.NgaySinh+"', SDT = '"+et.SDT+"', Luong = '"+et.Luong+"', DiaChi = N'"+et.DiaChi+"', MaMon = '"+et.MaMon+"' WHERE MaGV = '"+et.MaGV+"'");
        }
        //Xoa du lieu
        public void delGiaovien(EC_tblGiaovien et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblGiaovien WHERE MaGV = '"+et.MaGV+"'");
        }
        //select
        public DataTable getAllgiaovien()
        {
            return cn.getDatatable(@"SELECT * FROM tblGiaovien ");
        }
        public DataTable getAllgiaovien(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblGiaovien " + dk);
        }
        //select chi tiet
        public DataTable getThongTinGV()
        {
            return cn.getDatatable(@"SELECT MaGV, (Ho+' '+Ten) as HoTen, GT, NgaySinh, SDT, DiaChi, Luong, MaMon FROM tblGiaovien");
        }
        public DataTable getThongTinGV(string dk)
        {
            return cn.getDatatable(@"SELECT MaGV, (Ho+' '+Ten) as HoTen, GT, NgaySinh, SDT, DiaChi, Luong, MaMon FROM tblGiaovien where " + dk);
        }
        public DataTable getField(string Field)
        {
            return cn.getDatatable(String.Format(@"SELECT distinct {0} FROM tblGiaovien", Field));
        }
        public DataTable getGiaovien(string dk)
        {
            return cn.getDatatable(@"SELECT * FROM tblGiaovien " + dk);
        }
        public DataTable getGT()
        {
            return cn.getDatatable(@"SELECT distinct GT FROM tblGiaovien");
        }
    }
}
