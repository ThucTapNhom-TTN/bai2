using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QV_HS_THPT_Entity
{
    public class EC_tblLop
    {
        private string _MaLop;

        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private string _TenLop;

        public string TenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }
        private string _GVCN;

        public string GVCN
        {
            get { return _GVCN; }
            set { _GVCN = value; }
        }
    }
}
