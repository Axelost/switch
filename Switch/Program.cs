using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("mata in ett heltal:");
            int tal = int.Parse(Console.ReadLine()); 
            switch (tal)
            {
                case 1: Console.WriteLine("ett");       break;
                case 2: Console.WriteLine("två");       break;
                case 3: Console.WriteLine("tre");       break;
                case 4: Console.WriteLine("fyra");      break;
                default: Console.WriteLine("ogiltigt"); break;

                    */
            Console.Write("mata in S,W,E eller N:");
            string bokstav = Console.ReadLine();
            switch (bokstav)
            {
                case "S": Console.WriteLine("South"); break;
                case "W": Console.WriteLine("West"); break;
                case "E": Console.WriteLine("East"); break;
                case "N": Console.WriteLine("North"); break;
                default: Console.WriteLine("ogiltigt"); break;
            }

            Console.WriteLine("mata in text");
            Console.ReadLine();

            }


        }
    }

