using System;
using System.Text;

namespace HW08_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceStr = "1a!2.3!!.. 4.!.?6 7! ..?";
            int ind = sourceStr.IndexOf('?');

            StringBuilder sb1 = new StringBuilder(sourceStr.Substring(0, ind));
            for (int i = 0; i < sb1.Length; i++)
            {
                if (sb1[i] == '!' || sb1[i] == '.')
                {
                    sb1 = sb1.Remove(i, 1);
                    i--;
                }
            }

            StringBuilder sb2 = new StringBuilder(sourceStr.Substring(ind));
            sb2.Replace(" ", "_");

            sourceStr = sb1.ToString() + sb2.ToString();
            Console.WriteLine(sourceStr);

            //StringBuilder sb = new StringBuilder(sourceStr);
            //int j = 0;
            //while (sb[j] != '?')
            //{
            //    if (sb[j] == '!' || sb[j] == '.')
            //    {
            //        sb.Remove(j, 1);
            //    }
            //    else
            //    {
            //        j++;
            //    }
            //}

            //sb.Replace(' ', '_', j, sb.Length - j);
        }
    }
}
