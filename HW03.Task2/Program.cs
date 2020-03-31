using System;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a1 = 1;
            SByte a2 = 2;

            short b1 = 1;
            Int16 b2 = 2;

            int c1 = 1;
            Int32 c2 = 2;

            long d1 = 1;
            Int64 d2 = 2;

            byte e1 = 1;
            Byte e2 = 2;

            ushort f1 = 1;
            UInt16 f2 = 2;

            char g1 = '1';
            Char g2 = '2';

            uint h1 = 1;
            UInt16 h2 = 2;

            ulong i1 = 1;
            UInt64 i2 = 2;

            float j1 = 1;
            Single j2 = 2;

            double k1 = 1;
            Double k2 = 2;

            decimal l1 = 1;
            Decimal l2 = 2;

            object m1 = new object();
            Object m2 = new Object();

            string n1 = "one";
            String n2 = "two";

            Console.WriteLine(a1.GetType().FullName);
            Console.WriteLine(a2.GetType().FullName);
            Console.WriteLine(b1.GetType().FullName);
            Console.WriteLine(b2.GetType().FullName);
            Console.WriteLine(c1.GetType().FullName);
            Console.WriteLine(c2.GetType().FullName);
            Console.WriteLine(d1.GetType().FullName);
            Console.WriteLine(d2.GetType().FullName);
            Console.WriteLine(e1.GetType().FullName);
            Console.WriteLine(e2.GetType().FullName);
            Console.WriteLine(f1.GetType().FullName);
            Console.WriteLine(f2.GetType().FullName);
            Console.WriteLine(g1.GetType().FullName);
            Console.WriteLine(g2.GetType().FullName);
            Console.WriteLine(h1.GetType().FullName);
            Console.WriteLine(h2.GetType().FullName);
            Console.WriteLine(i1.GetType().FullName);
            Console.WriteLine(i2.GetType().FullName);
            Console.WriteLine(j1.GetType().FullName);
            Console.WriteLine(j2.GetType().FullName);
            Console.WriteLine(k1.GetType().FullName);
            Console.WriteLine(k2.GetType().FullName);
            Console.WriteLine(l1.GetType().FullName);
            Console.WriteLine(l2.GetType().FullName);
            Console.WriteLine(m1.GetType().FullName);
            Console.WriteLine(m2.GetType().FullName);
            Console.WriteLine(n1.GetType().FullName);
            Console.WriteLine(n2.GetType().FullName);

            Console.ReadLine();
        }
    }
}
