﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QV_HS_THPT_Entity
{
    public class EC_tblPhanquyen
    {
        private string _Quyen;

        public string Quyen
        {
            get { return _Quyen; }
            set { _Quyen = value; }
        }
        private string _TenQuyen;

        public string TenQuyen
        {
            get { return _TenQuyen; }
            set { _TenQuyen = value; }
        }
    }
}
