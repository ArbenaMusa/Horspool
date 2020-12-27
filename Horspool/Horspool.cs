using System;
using System.Collections.Generic;
using System.Text;

namespace Horspool
{
    class Horspool
    {

        public static int SIZE = 500;
        public static int[] table = new int[SIZE];


        public void shifttable(string pattern)
        {
            char[] patternArray = pattern.ToCharArray();
            int m = pattern.Length;

            for (int i = 0; i < SIZE; i++)
                table[i] = m;

            for (int j = 0; j < m - 1; j++)
                table[patternArray[j]] = m - 1 - j;
        }
        public int horspool(string source, string pattern)
        {
            int k;
            char[] sourceArray = source.ToCharArray();
            char[] patternArray = pattern.ToCharArray();
            int m = pattern.Length;

            int i = m - 1;

            while(i < source.Length)
            {
                k = 0;
                while ((k < m) && (patternArray[m - 1 - k] == sourceArray[i - k]))
                    k++;
                if (k == m)
                    return i - m + 1;
                else
                    i += table[sourceArray[i]];
            }
            return -1;
        }
    }
}
