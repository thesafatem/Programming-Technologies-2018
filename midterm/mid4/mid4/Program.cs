using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mid4
{
    class Program
    {
        public static int k;
        public static void forthread()
        {
            Write write = new Write();
            while(true)
            {
                Console.Clear();
                switch (k)
                {
                    case 1:
                        write.Draw1();
                        break;
                    case 2:
                        write.Draw2();
                        break;
                    case 3:
                        write.Draw3();
                        break;
                }
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(8, 15);
            Thread thread = new Thread(forthread);
            thread.Start();
            int x = 0;
            while (true)
            {
                if (x % 3 == 0)
                {
                    k = 1;
                }
                if (x % 3 == 1)
                {
                    k = 2;
                }
                if (x % 3 == 2)
                {
                    k = 3;
                }
                x++;
                Thread.Sleep(1000);
            }
        }
    }
}
