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

    public interface IBrukergrensesnitt
    {
        void giStatus(string status);
        int beOmKommando(string spørsmål, string[] alternativet);
    }
}
