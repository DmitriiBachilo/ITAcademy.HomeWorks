using System;
using System.IO;

namespace HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Чтение файла по пути C:\Temp\image.txt
            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();

            // 2. Создание массива, который будет хранить текстовое представление чисел из исходного файла
            string[] arrayOfTextResult = textReaderResult.Split(' ');
           
            textReader.Dispose();

            // 3. Создание массива, который будет хранить числовое представление чисел из исходного файла
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            // 4. Цикл конвертирующий массив текстовых представлений в массив числовых представлений
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            // 5. Записать все полученные численные значения в файл по указанному пути
            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
        }
    }
}
