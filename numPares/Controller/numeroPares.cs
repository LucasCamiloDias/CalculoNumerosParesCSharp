using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numPares.Controller
{
    internal class numeroPares
    {
        public int i = 0;
        public string res = "";
        public numeroPares() { }
        public string Calcular(string v)
        {
            res = "";
            int i = Convert.ToInt32(v);
                 
            while (i > 0)
            { 
                
                if (i % 2 == 0)
                {
         
                    i = i - 2; 
                    res +=  Convert.ToString(i) + ", ";
                }
                else
                {
                    i = i - 1;
                    res += Convert.ToString(i) + ", ";
                }
            }
           
            return res;
        }
    }
}
