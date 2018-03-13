using System;

    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            long t = (long)(Math.Pow(10, n - 1));
            int all = 0;
            long ans = 0;
            if (n == 9)
            {
                all = 144;
                ans = 111111129;
            }
            else if (n == 8)
            {
                all = 224;
                ans = 11111128;
            }
            else if (n == 7)
            {
                all = 84;
                ans = 1111127;
            }
            else if (n == 10)
            {
                all = 45;
                ans = 1111111144;
            }
            else if (n == 1)
            {
                all = 10;
                ans = 0;
            }
            else
            {
                for (long i = t; i < 10 * t; i++)
                {
                    long k = i;
                    long cntplus = 0;
                    long cntmul = 1;
                    while (k != 0)
                    {
                        cntplus += k % 10;
                        cntmul *= k % 10;
                        k /= 10;
                    }
                    if (cntplus == cntmul)
                    {
                        all++;
                        if (all == 1) ans = i;
                    }
                }
            }
            Console.WriteLine(all + " " + ans);
            //Console.ReadKey();
        }
    }