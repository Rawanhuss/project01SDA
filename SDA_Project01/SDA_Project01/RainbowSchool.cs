using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace SDA_Project01
{
    class RainbowSchool
    {   public int ID { get; set; }
        public string TName { get; set; }
        public string Tclass { get; set; }
        public string TSection { get; set; }
        public RainbowSchool(int TI, string TN, string TC, string TS)
        {
            this.ID = TI;
            this.TName = TN;
            this.Tclass = TC;
            this.TSection = TS;
        }
    }
}
