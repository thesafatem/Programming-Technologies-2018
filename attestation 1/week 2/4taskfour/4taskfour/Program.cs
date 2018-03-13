using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace _4taskfour
{
    class Program
    {
        static void SaveComplex(Complex a, Complex b, Complex c, Complex d)
        {
            XmlSerializer save = new XmlSerializer(typeof(SerializedData));
            FileStream fs = new FileStream("save.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            List<Complex> list = new List<Complex>();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            SerializedData s = new SerializedData();
            s.numbers = list;
            save.Serialize(fs, s);
            fs.Close();
        }
        static void OpenComplex()
        {
            try
            {
                XmlSerializer open = new XmlSerializer(typeof(SerializedData));
                FileStream fs = new FileStream("save.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                SerializedData sd = open.Deserialize(fs) as SerializedData;
                foreach (Complex p in sd.numbers)
                {
                    Console.WriteLine(p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            Complex q = new Complex(a1, a2);
            Complex w = new Complex(b1, b2);
            Complex d = q + w;
            Complex t = q * w;
            Complex e = q / w;
            Complex p = q - w;
            Console.WriteLine(d);
            Console.WriteLine(t);
            Console.WriteLine(e);
            Console.WriteLine(p);
            SaveComplex(d, t, e, p);
            OpenComplex();
            Console.ReadKey();
        }
    }
}
