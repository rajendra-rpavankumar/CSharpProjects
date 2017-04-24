using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRemoveSpace
{
    public class RemoveEmptySpace
    {
        public string RemoveSpace(string input)
        {
            //StringBuilder sbRemoveSpace = new StringBuilder();
            //for(int i=0;i<input.Length;i++)
            //{
            //    char c = input[i];
            //    if(Char.IsWhiteSpace(input[i]))
            //    {
            //        continue;
            //    }
            //    sbRemoveSpace.Append(input[i]);
            //}
            //return sbRemoveSpace.ToString(); ;
            var sb = new StringBuilder();
            var prevIsWhitespace = false;
            foreach (var ch in input)
            {
                var isWhitespace = char.IsWhiteSpace(ch);
                if (prevIsWhitespace && isWhitespace)
                {
                    continue;
                }
                sb.Append(ch);
                prevIsWhitespace = isWhitespace;
            }
            return sb.ToString();           
        }
    }
}
