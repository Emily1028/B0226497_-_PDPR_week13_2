using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week13_2
{
    class STUDENT
    {
        protected int stdNO { set; get; }
        protected string NAME { set; get; }
        protected string ADDRESS { set; get; }
        public double GRADE { set; get; }
        public int getNO()
        {
            return stdNO;
        }
        public string getNAME()
        {
            return NAME;
        }
        public string getADDRESS()
        {
            return ADDRESS;
        }
        public double getGRADE()
        {
            return GRADE;
        }
    }
}
