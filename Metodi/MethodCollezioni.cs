using System;

namespace Method
{
    public class MethodCollezioni
    {
        public static bool Uguali(string a, string b)
        {
            if (a != b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ContainsDoubleChar(string c)
        {
            int m = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (char.IsUpper(c[i]) == true)
                    m++;
            }
            if (m < 0)
                return false;
            else
                return true;
        }
    }
}

