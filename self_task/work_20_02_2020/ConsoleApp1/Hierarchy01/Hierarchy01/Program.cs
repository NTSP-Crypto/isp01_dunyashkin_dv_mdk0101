using System;

namespace Hierarchy01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3];

            person[0] = new Student("Степанов Михаил Викторович", 18, 2, "ИСП-1");
            person[1] = new Teacher("Суворов Николай Дронов", 25, "Алгебра", "Информатика");
            person[2] = new Teacher("Котлов Юрий Николаевич", 33, "Компьютерные сети");

            foreach (var item in person)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
