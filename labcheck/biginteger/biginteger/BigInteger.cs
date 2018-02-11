using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biginteger
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
            if (a.s.Length >= b.s.Length)
            {
                x = a.s.Length;
                string g = b.s;
                b.s = "";
                for (int i = 0; i < a.s.Length - g.Length; i++)
                {
                    b.s += '0';
                }
                b.s += g;
            }
            else
            {
                x = b.s.Length;
                string g = a.s;
                a.s = "";
                for (int i = 0; i < b.s.Length - g.Length; i++)
                {
                    a.s += '0';
                }
                a.s += g;
            }
            for (int i = x - 1; i >= 0; i--)
            {
                char f = (char)((a.s[i] + b.s[i] - 96 + c) % 10 + 48);
                ans += f;
                if ((a.s[i] + b.s[i] - 96 + c) >= 10)
                {
                    c = 1;
                }
                else c = 0;
                if (i == 0 && c == 1) ans += '1';
            }
            string d = ans;
            ans = "";
            for (int i = d.Length - 1; i >= 0; i--)
            {
                ans += d[i];
            }
            BigInteger e = new BigInteger(ans);
            return e;
        }
        public static BigInteger operator -(BigInteger a, BigInteger b)
        {
            string ans="";
            int x;
            int c = 0;
            if (a.s.Length > b.s.Length) x = 1;
            else if (a.s.Length < b.s.Length) x = 2;
            else x = 3;
            if (x == 1)
            {
                string g = b.s;
                b.s = "";
                for (int i = 0; i < a.s.Length - g.Length; i++)
                {
                    b.s += '0';
                }
                b.s += g;
            }
            else if (x == 2)
            {
                string g = a.s;
                a.s = "";
                for (int i = 0; i < b.s.Length - g.Length; i++)
                {
                    a.s += '0';
                }
                a.s += g;
            }
            else
            {
                for (int i = 0; i < a.s.Length; i++)
                {
                    if (a.s[i] == b.s[i] && i == a.s.Length - 1)
                    {
                        ans = "0";
                        x = 4;
                        break;
                    }
                    if (a.s[i] < b.s[i]) break;
                    else if (a.s[i] > b.s[i])
                    {
                        x = 0;
                        break;
                    }
                }
            }
            if (x == 0 || x == 1)
            {
                for (int i = a.s.Length - 1; i >= 0 ; i--)
                {
                    if (a.s[i] - b.s[i] - c < 0)
                    {
                        ans += (char)(a.s[i] - b.s[i] - c + 10 + 48);
                        c = 1;
                    }
                    else
                    {
                        ans += (char)(a.s[i] - b.s[i] - c + 48);
                        c = 0;
                    }
                }
                string d = "";
                for (int i = ans.Length - 1; i >= 0; i--)
                {
                    d += ans[i];
                }
                ans = "";
                int k;
                for (int i = 0; ; i++)
                {
                    if (d[i] != '0')
                    {
                        k = i;
                        break;
                    }
                }
                for (int i = k; i < d.Length; i++)
                {
                    ans += d[i];
                }
            }
            else if (x != 4)
            {
                for (int i = b.s.Length - 1; i >= 0; i--)
                {
                    if (b.s[i] - a.s[i] - c < 0)
                    {
                        ans += (char)(b.s[i] - a.s[i] - c + 10 + 48);
                        c = 1;
                    }
                    else
                    {
                        ans += (char)(b.s[i] - a.s[i] - c + 48);
                        c = 0;
                    }
                }
                string d = "";
                for (int i = ans.Length - 1; i >= 0; i--)
                {
                    d += ans[i];
                }
                ans = "-";
                int k;
                for (int i = 0; ; i++)
                {
                    if (d[i] != '0')
                    {
                        k = i;
                        break;
                    }
                }
                for (int i = k; i < d.Length; i++)
                {
                    ans += d[i];
                }
            }
            BigInteger e = new BigInteger(ans);
            return e;
        }
        public static BigInteger operator *(BigInteger a, BigInteger b)
        {
            BigInteger ans = new BigInteger("0");
            int c = 0;
            string zero = "";
            for (int i = b.s.Length - 1; i >= 0; i--)
            {
                string add = "";
                add += zero;
                zero += '0';
                for (int j = a.s.Length - 1; j >= 0; j--)
                {
                    add += (char)(((a.s[j] - 48) * (b.s[i] - 48) + c) % 10 + 48);
                    c = ((a.s[j] - 48) * (b.s[i] - 48) + c) / 10;
                }
                if (c != 0) add += (char)(c + 48);
                string k = "";
                for (int o = add.Length - 1; o >= 0; o--)
                {
                    k += add[o];
                }
                BigInteger plus = new BigInteger(k);
                ans = ans + plus;
            }
            return ans;
        }
        public override string ToString()
        {
            return s;
        }
    }
}
