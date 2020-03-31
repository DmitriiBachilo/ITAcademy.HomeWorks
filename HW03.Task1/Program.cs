using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 1;
            double doubleValue = 123.456;
            decimal decimalValue = 165601651605656;
            sbyte sbyteValue = 127;
            float floatValue = 5.7979f;
            char charValue = 'Z';

            // a (explicit conversion)
            char expConv1 = (char)intValue;
            int expConv2 = (int)doubleValue;
            long expConv3 = (long)decimalValue;

            // b (implicit conversion)
            short impConv1 = sbyteValue;
            double impConv2 = floatValue;
            long impConv3 = intValue;

            // c (boxing)
            object obj1 = intValue;
            object obj2 = doubleValue;
            object obj3 = floatValue;
            
            // d (unboxing)
            int intForUnboxing = (int)obj1;
            double doubleForUnboxing = (double)obj2;
            float floatForUnboxing = (float)obj3;

            // three examples
            obj1 = intValue;
            ushort ushortForUnboxing = (ushort)(int)obj1;

            obj2 = false;
            byte byteForUnboxing = Convert.ToByte((bool)obj2);

            obj3 = charValue;
            intForUnboxing = (char)obj3;
        }
    }
}
