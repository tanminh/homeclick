﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCMS.Lib.Models.Datatables
{
    public class dt_product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public Dictionary<string,int> options { get; set; }
        public bool status { get; set; }
    }
}
