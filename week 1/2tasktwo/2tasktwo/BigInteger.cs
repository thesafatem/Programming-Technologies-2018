using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2tasktwo
{
    class BigInteger
    {
        public string s;
        public BigInteger()
        {

        }
        public BigInteger(string s)
        {
            this.s = s;
        }

        public static BigInteger operator +(BigInteger a, BigInteger b)
        {
            string ans = "";
            int c = 0;
            int x;
            if (a.s.Length > b.s.Length)
            {
                x = a.s.Length;
                ans = a.s;
                string g = b.s;
                b.s = "";
                for (int i = 0; i < a.s.Length - b.s.Length; i++)
                {
                    b.s += "0";
                }
                b.s += g;
            }
            else
            {
                x = b.s.Length;
                ans = b.s;
                string g = a.s;
                a.s = "";
                for (int i = 0; i < b.s.Length - a.s.Length; i++)
                {
                    a.s += "0";
                }
                a.s += g;
            }
            for (int i = x-1; i >= 0; i--)
            {
                char f = (char)((a.s[i] + b.s[i] - 96) % 10 + c);
                ans += f;
                if ((a.s[i] + b.s[i] - 96) >= 10)
                {
                    c = 1;
                }
                else c = 0;
            }
            string d = ans;
            ans = "";
            for (int i = d.Length; i > 0; i--)
            {
                ans += d[i];
            }
            BigInteger e = new BigInteger(ans);
            return e;
        }

    }
}
