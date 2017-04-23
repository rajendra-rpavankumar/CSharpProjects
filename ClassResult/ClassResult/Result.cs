using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassResult
{
    public class Result
    {
        public string FindRank(float input)
        {
            if (input > 90 && input <= 100)
                return "Distinction";
            if (input > 60 && input <= 90)
                return "First";
            if (input > 50 && input <= 60)
                return "Second";
            if (input > 35 && input <= 50)
                return "Pass";
            if (input >= 0 && input <= 35)
                return "Fail";            
            return "Not Valid";
        }
    }
}
