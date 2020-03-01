using System;
using System.IO;

namespace ConsoleApp1
{
    class Stream
    {
        public static int ChekerInt(FileStream fstream, int symbol)
        {
            StreamReader reader = new StreamReader(fstream);
            int count = 0;
            
            while(!reader.EndOfStream)
            {
                char isSymbol = (char)reader.Read();
                if(isSymbol == symbol)
                {
                    count++;
                }
            }
            fstream.Seek(0, SeekOrigin.Begin);
            return count;
        }

        public static int ChekerNumberOfLines(FileStream fstream)
        {
            StreamReader reader = new StreamReader(fstream);
            int count = 0;

            while (!reader.EndOfStream)
            {
                char isSymbol = (char)reader.Read();
                if (isSymbol == '\n')
                {
                    count++;
                }
            }

            fstream.Seek(0, SeekOrigin.Begin);
            return count;
        }

        public static int ChekerNumbers(FileStream fstream)
        {
            StreamReader reader = new StreamReader(fstream);
            int count = 0;

            while (!reader.EndOfStream)
            {
                if (char.IsDigit((char)reader.Read()))
                    count++;
            }

            fstream.Seek(0, SeekOrigin.Begin);
            return count;
        }
    }
}
