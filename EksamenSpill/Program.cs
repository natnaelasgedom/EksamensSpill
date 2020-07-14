using System;
using System.Collections;
using System.IO;

namespace EksamenSpill
{
    class Program
    {
        static void Main(string[] args)
        {
            Terminal t = new Terminal();
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\Users\Natnael Asgedom\Google Drive\AW Academy\Uke 02\EksamenSpill\gjenstander.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        t.GiStatus(reader.ReadLine());
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}



