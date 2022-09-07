using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {

        static void Main(string[] args)
        {

            // Set the Frequency
            int frequency = 800;

            // Set the Duration
            int duration = 200;

            // Play beep sound once
            Console.Beep(frequency, duration);

            for (int i = 0; i < 9; i++)
            {
                Console.Beep(frequency, duration);
                frequency = frequency + 100;
            }
        }
    }
}