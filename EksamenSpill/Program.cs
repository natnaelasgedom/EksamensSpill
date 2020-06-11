using System;

namespace EksamenSpill
{
    class Program
    {
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        static void Main(string[] args)
        {
			Console.WriteLine("HEEELZZ YEAH!!!!");
            Console.WriteLine("Hello, world!");
            Console.WriteLine("Grevling");
            Console.WriteLine("");
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
            Console.WriteLine(spørsmål);
            return 1;
        }
    }
}
