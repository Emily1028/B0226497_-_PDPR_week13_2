using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week13_2
{
    class GRADUATESTUDENT: STUDENT
    {
        public string DEPARTMENT { set; get; }
        public GRADUATESTUDENT(int s, string n, string a, double g, string d)
        {
            stdNO = s;
            NAME = n;
            ADDRESS = a;
            GRADE = g;
            DEPARTMENT = d;
        }
        public string printGRADUATE()
        {
            
            return $"\n學號:{getNO()}，姓名:{getNAME()}，地址:{getADDRESS()}，成績:{getGRADE()}，科系:{DEPARTMENT}";
        }
    }
}
