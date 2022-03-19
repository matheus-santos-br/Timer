using System;
using System.Threading;
using System.Collections.Specialized;

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
            Console.WriteLine("(S) 10 = 10s");
            Console.WriteLine("(M) 1 = 1m") ;
            Console.WriteLine("(0) - Exit.");

            var par = Console.ReadLine().ToLower();

            char type = char.Parse(par.Substring(par.Length - 1 , 1)); //Array starts at 0.

            int time = int.Parse(par.Substring(0, par.Length - 1));

            var multi = 60;

            if(type == 'm'){
                time *= multi;
            }

            if(time == 0){
                
                System.Environment.Exit(0);

            }

            PreStart(time);

        }

        static void PreStart(int time){

            Console.Clear();

            Console.WriteLine("Ready?");

            Thread.Sleep(1000);

             Console.WriteLine("Set?");

            Thread.Sleep(1000);
            
            Console.WriteLine("GO!");

            Thread.Sleep(1000);

            Start(time);

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

/*
using System;
using System.Threading;

namespace Timer2
{
    class Program2
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu(){

            comeback:

            Console.Clear();
            Console.WriteLine("Would you like to count in minutes or seconds?(m/s)");
            Console.WriteLine("(S) - Seconds");
            Console.WriteLine("(M) - Minutes") ;
            Console.WriteLine("(0) - Exit.");

            var par = Console.ReadLine().ToLower();

              if (!(par == "s") && !(par == "m") && !(par == "0")){
                
                  Console.WriteLine("Not found");
                    Console.ReadKey();
                    goto comeback;

            }

            Console.Clear();

            Console.WriteLine("For how long?");

            var time = int.Parse(Console.ReadLine());
       
            switch(par){
                case "s": StartSeconds(time); break;
                case "m": StartMinutes(time); break;
                case "0": System.Environment.Exit(0); break;

                default: Console.WriteLine(""); break;
            }

        }

        static void StartMinutes(double time){

            var c = 0;

            while (c < time){

                Console.Clear();
            
                for(var s = 0 ; s < 60 ; s+=1){
                    Console.Clear();
                    Console.WriteLine($"{c}:{s}");
                    Thread.Sleep(1000);
                }

                c += 1;

            }

            Console.Clear();
            Console.WriteLine("Finished!");
            Thread.Sleep(1500);

        }

        static void StartSeconds(double time){

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
}*/