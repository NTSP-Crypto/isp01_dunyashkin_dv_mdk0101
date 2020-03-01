using System;

namespace ConsoleApp1
{
    class Test
    {
        public string Examinator { get; set; }
        public string Examiner { get; set; }
        public DateTime Date { get; set; }
        public int Estimation { get; set; }

        public Test(string examinator, string examiner, DateTime date, int estimation)
        {
            Examinator = examinator;
            Examiner = examiner;
            Date = date;
            Estimation = estimation;
        }

        public override string ToString()
        {
            return string.Format($"ФИО экзаменуемого: {Examinator}, ФИО экзаменатора: {Examiner}, дата: {Date}, оценка: {Estimation}");
        }
    }
}
