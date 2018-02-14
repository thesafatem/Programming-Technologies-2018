using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billions
{
    class Biginteger
    {
        public string s;
        public Biginteger()
        {

        }
        public Biginteger(string s)
        {
            this.s = s;
        }
        public static Biginteger operator +(Biginteger a, Biginteger b)
        {
            int add = 0;
            string ans = "";
            int[] aa = new int[Math.Max(a.s.Length, b.s.Length)];
            int[] bb = new int[Math.Max(a.s.Length, b.s.Length)];
            int[] cc = new int[Math.Max(a.s.Length, b.s.Length)];
            for (int i = 0; i < aa.Length; i++)
            {
                aa[i] = 0;
                bb[i] = 0;
            }
            if (a.s.Length >= b.s.Length)
            {
                for (int i = 0; i < a.s.Length; i++)
                {
                    aa[i] = a.s[i] - 48;
                }
                for (int i = a.s.Length - b.s.Length; i < a.s.Length; i++)
                {
                    bb[i] = b.s[i - a.s.Length + b.s.Length] - 48;
                }
            }
            else
            {
                for (int i = 0; i < b.s.Length; i++)
                {
                    bb[i] = b.s[i] - 48;
                }
                for (int i = b.s.Length - a.s.Length; i < b.s.Length; i++)
                {
                    aa[i] = a.s[i - b.s.Length + a.s.Length] - 48;
                }
            }
            for (int i = 0; i < aa.Length; i++)
            {
                cc[i] = aa[i] + bb[i];
            }
            for (int i = cc.Length - 1; i >= 0; i--)
            {
                cc[i] = (cc[i] + add) % 10;
                add = (aa[i] + bb[i]) / 10;
            }
            if (add != 0) ans += (char)(add + 48);
            for (int i = 0; i < cc.Length; i++)
            {
                ans += (char)(cc[i] + 48);
            }
            Biginteger x = new Biginteger(ans);
            return x;
        }
        public static Biginteger operator *(Biginteger a, Biginteger b)
        {
            if (a.s == "0" || b.s == "0")
            {
                Biginteger q = new Biginteger("0");
                return q;
            }
            int add = 0;
            string ans = "";
            int[] aa = new int[a.s.Length];
            int[] bb = new int[b.s.Length];
            int[] cc = new int[a.s.Length + b.s.Length];
            for (int i = 0; i < a.s.Length; i++)
            {
                aa[i] = a.s[a.s.Length - 1 - i] - 48;
            }
            for (int i = 0; i < b.s.Length; i++)
            {
                bb[i] = b.s[b.s.Length - 1 - i] - 48;
            }
            for (int i = 0; i < cc.Length; i++)
            {
                cc[i] = 0;
            }
            for (int i = 0; i < bb.Length; i++)
            {
                for (int j = 0; j < aa.Length; j++)
                {
                    cc[i + j] += aa[j] * bb[i];
                }
            }
            for (int i = 0; i < cc.Length; i++)
            {
                int k = cc[i];
                cc[i] = (cc[i] + add) % 10;
                add = (k + add) / 10;

            }
            for (int i = cc.Length - 1; i >= 0; i--)
            {
                ans += (char)(cc[i] + 48);
            }
            while(true)
            {
                if (ans[0] == '0') ans = ans.Remove(0, 1);
                else break;
            }
            Biginteger x = new Biginteger(ans);
            return x;
        }
        public static Biginteger operator -(Biginteger a, Biginteger b)
        {
            string ans = "";
            bool minus = true;
            int start = 0;
            int adder = 0;
            int[] aa = new int[Math.Max(a.s.Length, b.s.Length)];
            int[] bb = new int[Math.Max(a.s.Length, b.s.Length)];
            int[] cc = new int[Math.Max(a.s.Length, b.s.Length)];
            for (int i = 0; i < aa.Length; i++)
            {
                aa[i] = 0;
                bb[i] = 0;
            }
            if (a.s.Length >= b.s.Length)
            {
                for (int i = 0; i < a.s.Length; i++)
                {
                    aa[i] = a.s[i] - 48;
                }
                for (int i = a.s.Length - b.s.Length; i < a.s.Length; i++)
                {
                    bb[i] = b.s[i - a.s.Length + b.s.Length] - 48;
                }
            }
            else
            {
                for (int i = 0; i < b.s.Length; i++)
                {
                    bb[i] = b.s[i] - 48;
                }
                for (int i = b.s.Length - a.s.Length; i < b.s.Length; i++)
                {
                    aa[i] = a.s[i - b.s.Length + a.s.Length] - 48;
                }
            }
            for (int i = 0; i < cc.Length; i++)
            {
                cc[i] = aa[i] - bb[i];
            }
            for (int i = 0; i < cc.Length; i++)
            {
                if (cc[i] == 0 && i == cc.Length - 1)
                {
                    Biginteger t = new Biginteger("0");
                    return t;
                }
                else if (cc[i] == 0) continue;
                else if (cc[i] > 0)
                {
                    minus = false;
                    start = i;
                    break;
                }
                else
                {
                    minus = true;
                    start = i;
                    break;
                }
            }
            if (minus == false)
            {
                for (int i = cc.Length - 1; i >= start; i--)
                {
                    int k = cc[i];
                    cc[i] = (cc[i] + adder + 10) % 10;
                    if (k < 0) adder = -1;
                    else adder = 0;
                }
            }
            else
            {
                for (int i = 0; i < cc.Length; i++)
                {
                    cc[i] = bb[i] - aa[i];
                }
                for (int i = cc.Length - 1; i >= start; i--)
                {
                    int k = cc[i];
                    cc[i] = (cc[i] + adder + 10) % 10;
                    if (k < 0) adder = -1;
                    else adder = 0;
                }
            }
            for (int i = 0; i < cc.Length; i++)
            {
                ans += (char)(cc[i] + 48);
            }
            while (true)
            {
                if (ans[0] == '0') ans = ans.Remove(0, 1);
                else break;
            }
            if (minus == true) ans = ans.Insert(0, "-");
            Biginteger x = new Biginteger(ans);
            return x;
        }
        public override string ToString()
        {
            return s;
        }
    }
}
