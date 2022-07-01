using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week13_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String str = "";
        Random rnd = new Random();
        private void btnOK_Click(object sender, EventArgs e)
        {
            List<GRADUATESTUDENT> listgGRADUATESTUDENT = new List<GRADUATESTUDENT>();
            for (int i = 0; i < 10; i++)
            {
                GRADUATESTUDENT graduatestudent = new GRADUATESTUDENT(rnd.Next(100000, 999999), $"段昱如_{i+1}","oo市oo路oo巷oo號",rnd.Next(0,100),"資管系");
                str += graduatestudent.printGRADUATE();
            }
            lblRESULT.Text = str;
        }
    }
}
