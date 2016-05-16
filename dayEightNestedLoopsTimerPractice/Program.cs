using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayEightNestedLoopsTimerPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int hour = 12; hour >= 1; hour--)
            {
                for(int min = 60; min > 1; min--)
                {
                    for(int sec = 60; sec > 1; sec--)
                    {
                        Console.WriteLine(hour + ":" + min + ":" + sec);
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
