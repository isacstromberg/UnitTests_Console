using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests_Console
{
    public class PracticeFunction
    {
        public string ReturnsSomethingIfZero(int num)
        {
          
            if (num == 0)
            {
                return "Something!";
            }
            else
            {
               return "Nothing!";
            }
             

        }
    }
}
