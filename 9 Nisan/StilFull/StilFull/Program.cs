using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StilFull
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  //random sayı yapar

            while (true)
            {
                      for (int i = 0; i < 39; i++)
                {
                    Console.Write(" "+rnd.Next(10));  //0 dan 9 a kadar random sayı verır 72 tane
                }
                      Console.WriteLine();
                      Thread.Sleep(80);  //random sonsuz gelen sayıların hızını ayarladık
            }
         
            

        }
    }
}
