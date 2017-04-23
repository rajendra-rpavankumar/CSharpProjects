using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheck
{
    public class StringCompare
    {
        public int CompareString(string first, string second)
        {
            int firstlength = first.Length;
            int secondlength = second.Length;
            int min = GetMinim(firstlength, secondlength);
            int result = Compare(first, second, min);
            if (result != 0)
                return result;
            if (firstlength > secondlength)
                return 1;
            if (firstlength < secondlength)
                return -1;
            return 0;
        }

        private int GetMinim(int firstl,int secondl)
        {
            if (firstl < secondl)
                return firstl;
            return secondl;

        }
        private int Compare(string first,string second,int min)
        {
            char[] firstch = first.ToCharArray();
            char[] secondch = second.ToCharArray();
            for(int i=0;i<min;i++)
            {
                if (firstch[i] == second[i])
                    continue;
                else if (firstch[i] > second[i])
                    return 1;
                else 
                    return -1;

            }
            return 0;
        }

        //public int CompareString(string first, string second)
        //{
        //    //char[] firstchar = first.ToCharArray();
        //    //char[] secondchar = second.ToCharArray();
        //    ////int result = Compare(first, second);
        //    ////if (result != 0)
        //    ////    return result;
        //    //if (first.Length < second.Length)
        //    //    return 1;
        //    //if (first.Length > second.Length)
        //    //    return -1;
        //    //return 0;
        //    int result = compare(first, second);
        //    if (result != 0)
        //        return result;
        //    if (first.Length < second.Length)
        //        return 1;
        //    if (first.Length > second.Length)
        //        return -1;
        //    return 0;
        //    if (first.Length == second.Length)
        //        return 0;
        //    if (first.Length < second.Length)
        //        return 1;
        //    if (first.Length > GetMin(first, second))
        //        return 1;
        //    if (first.Length > second.Length)
        //        return -1;
        //    if (first.Length < second.Length)
        //        return -1;
        //    GetMinSize(first, second);
        //    for (int i = 0; i < firstchar.Length; i++)
        //    {
        //        for (int j = 0; j < secondchar.Length; j++)
        //        {

        //        }
        //    }
        //    return 2;
        //}

        //private int GetMin(string first, string second)
        //{
        //    if (first.Length < second.Length)
        //        return first.Length;
        //    else
        //        return second.Length;
        //}

        //private int GetMax(string first, string second)
        //{
        //    if (first.Length > second.Length)
        //        return first.Length;
        //    else
        //        return second.Length;
        //}


        //private int Compare(string first, string second)
        //{
        //    char[] firstchar = first.ToCharArray();
        //    char[] secondchar = second.ToCharArray();
        //    for(int i=0;i<GetMin(first,second);i++)
        //    {
        //        if (first.Length > i + 1 && firstchar[i].Equals(secondchar[i]))
        //            return 1;
        //        else
        //            return -1;
        //    }
        //    return 0;
        //}
        //private int GetLHSSize(string first)
        //{
        //    return first.Length;
        //}
        //private int GetRHSSize(string second)
        //{
        //    return second.Length;
        //}


        //private int compare(string first,string second)
        //{
        //    if (first.Length > GetMin(first, second))
        //        return 1;
        //    //return -1;
        //    else if (first.Length < GetMax(first, second))
        //        return -1;
        //    //return 1;
        //    else
        //        return 0;
        //}

        //private int compare(string first, string second)
        //{
        //    char[] firstchar = first.ToCharArray();
        //    char[] secondchar = second.ToCharArray();
        //    for (int i=0;i<GetMin(first,second);i++)
        //    {
        //        if()
        //    }
        //    return 0;
        //}

    }
}
