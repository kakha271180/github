using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DLLFILE
{
    public static class sqlisadgili
    {
        public static string shesanaxiadgili { get; set; }
    }
    public class gayiduliproduqtebi
    {
    }

    public class soldproductday
    {
        public  int ID{ get; set; }
        public string name { get; set; }
    }

    public class soldproduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int raodenoba { get; set; }
        public double fasi { get; set; }
        public double gadaxdilitanxa { get; set; }
        public DateTime gayidvistarigi { get; set; }
    }
}
