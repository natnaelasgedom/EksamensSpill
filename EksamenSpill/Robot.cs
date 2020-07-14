using System;

namespace EksamenSpill
{
    public class Robot : IBrukergrensesnitt
    {
        //StreamReader streamReader;

        //public Terminal(StreamReader streamReader)
        //{
        //    this.streamReader = streamReader;
        //}
        public void GiStatus(string status)
        {
            Console.WriteLine(">>>Status: " + status);
        }

        public int BeOmKommando(string spørsmål, string[] alternativer)
        {
            Console.WriteLine(spørsmål);
            for (int i = 1; i <= alternativer.Length; i++)
            {
                Console.WriteLine(i + ": " + $"{alternativer[i - 1]}");
            }

            int robotValg = new Random().Next(1, alternativer.Length+1);

            return robotValg;
        }
    }
}