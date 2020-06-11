using System;

namespace EksamenSpill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Terminal : IBrukergrensesnitt
    {
        public void GiStatus(string status)
        {
            Console.WriteLine(">>>Status: " + status);
        }

        public int BeOmKommando(string spørsmål, string[] alternativer)
        {
            return 1;
        }
    }
}
