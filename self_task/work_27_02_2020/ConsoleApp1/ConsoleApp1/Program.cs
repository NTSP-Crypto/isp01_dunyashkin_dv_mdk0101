using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Private\Git\isp01_dunyashkin_dv_mdk0101\self_task\work_27_02_2020\ConsoleApp1\ConsoleApp1\sample_text_file.txt";
            if(!File.Exists(filePath))
            {
                Console.WriteLine("Файла нет!");
                Console.ReadKey();
                return;
            }
            FileStream fstream = new FileStream(@"D:\Private\Git\isp01_dunyashkin_dv_mdk0101\self_task\work_27_02_2020\ConsoleApp1\ConsoleApp1\sample_text_file.txt", FileMode.Open);

            //1 Method
            Console.WriteLine($"Количество вхождений заданного символа : {Stream.ChekerInt(fstream, '2')}");
            Console.WriteLine();

            //2 Method
            Console.WriteLine($"Количество строк в текстовом документе : {Stream.ChekerNumberOfLines(fstream)}");
            Console.WriteLine();

            //3 Method
            Console.WriteLine($"Количество цифровых символов : {Stream.ChekerNumbers(fstream)}");
            Console.ReadKey();

        }
    }
}
