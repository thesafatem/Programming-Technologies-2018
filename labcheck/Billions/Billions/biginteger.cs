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
            bool minus = false;
            string f;
            string h;
            if (a.s[0] == '-' && b.s[0] == '-')
            {
                minus = true;
                f = a.s.Remove(0, 1);
                h = b.s.Remove(0, 1);
            }
            else if (a.s[0] == '-')
            {
                string l = a.s.Remove(0, 1);
                Biginteger a2 = new Biginteger(l);
                return b - a2;
            }
            else if (b.s[0] == '-')
            {
                string l = b.s.Remove(0, 1);
                Biginteger b2 = new Biginteger(l);
                return a - b2;
            }
            else
            {
                f = a.s;
                h = b.s;
            }
            int add = 0;
            string ans = "";
            int[] aa = new int[Math.Max(f.Length, h.Length)];
            int[] bb = new int[Math.Max(f.Length, h.Length)];
            int[] cc = new int[Math.Max(f.Length, h.Length)];
            for (int i = 0; i < aa.Length; i++)
            {
                aa[i] = 0;
                bb[i] = 0;
            }
            if (f.Length >= h.Length)
            {
                for (int i = 0; i < f.Length; i++)
                {
                    aa[i] = f[i] - 48;
                }
                for (int i = f.Length - h.Length; i < f.Length; i++)
                {
                    bb[i] = h[i - f.Length + h.Length] - 48;
                }
            }
            else
            {
                for (int i = 0; i < h.Length; i++)
                {
                    bb[i] = h[i] - 48;
                }
                for (int i = h.Length - f.Length; i < h.Length; i++)
                {
                    aa[i] = f[i - h.Length + f.Length] - 48;
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
            if (minus == true)
            {
                ans = ans.Insert(0, "-");
            }
            Biginteger x = new Biginteger(ans);
            return x;
        }



        public static Biginteger operator *(Biginteger a, Biginteger b)
        {
            string f = a.s;
            string h = b.s;
            bool minus = false;
            if (a.s[0] == '-' && b.s[0] == '-')
            {
                f = a.s.Remove(0, 1);
                h = b.s.Remove(0, 1);
            }
            else if (a.s[0] == '-')
            {
                f = a.s.Remove(0, 1);
                h = b.s;
                minus = true;
            }
            else if (b.s[0] == '-')
            {
                h = b.s.Remove(0, 1);
                f = a.s;
                minus = true;
            }
            if (a.s == "0" || b.s == "0")
            {
                Biginteger q = new Biginteger("0");
                return q;
            }
            int add = 0;
            string ans = "";
            int[] aa = new int[f.Length];
            int[] bb = new int[h.Length];
            int[] cc = new int[f.Length + h.Length];
            for (int i = 0; i < f.Length; i++)
            {
                aa[i] = f[f.Length - 1 - i] - 48;
            }
            for (int i = 0; i < h.Length; i++)
            {
                bb[i] = h[h.Length - 1 - i] - 48;
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
            if (minus == true) ans = ans.Insert(0, "-");
            Biginteger x = new Biginteger(ans);
            return x;
        }



        public static Biginteger operator -(Biginteger a, Biginteger b)
        {
            if (a.s[0] == '-' && b.s[0] == '-')
            {
                string f = b.s.Remove(0, 1);
                Biginteger bm2 = new Biginteger(f);
                string h = a.s.Remove(0, 1);
                Biginteger am2 = new Biginteger(h);
                return bm2 - am2;
            }
            else if (a.s[0] == '-')
            {
                string f = b.s.Insert(0, "-");
                Biginteger bm2 = new Biginteger(f);
                return a + bm2;
            }
            else if (b.s[0] == '-')
            {
                string f = b.s.Remove(0, 1);
                Biginteger bm2 = new Biginteger(f);
                return a + bm2;
            }
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
                    if (k + adder < 0) adder = -1;
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
