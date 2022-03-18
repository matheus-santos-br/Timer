using System;
using System.Threading;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu(){

            Console.Clear();
            Console.WriteLine("Would you like to count in minutes or seconds?(m/s)");
            Console.WriteLine("(S)");
            Console.WriteLine("(M)");
            Console.WriteLine("(0) - Exit.");
        }

        static void Start(int time){

            var c = 1;

            while (c <= time){

                Console.Clear();

                Console.WriteLine(c);

                c += 1;

                Thread.Sleep(1000); //1 second

            }

            Console.Clear();
            Console.WriteLine("Finished!");
            Thread.Sleep(1500);

        }

    }
}
