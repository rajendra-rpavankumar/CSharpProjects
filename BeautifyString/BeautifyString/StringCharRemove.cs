using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifyString
{
    public class StringCharRemove
    {
        public string Cleanstring(string input)
        {
            StringBuilder sBuilder = new StringBuilder();
            foreach(char charact in input)
            {
                if ((charact >= 'a' && charact <= 'z') || (charact >= 'A' && charact <= 'Z'))
                    sBuilder.Append(charact);
            }
            return sBuilder.ToString();
        }
    }
}
