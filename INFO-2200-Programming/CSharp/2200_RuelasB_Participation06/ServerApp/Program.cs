using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    internal class Program
    {
        static void Main()//main functionn
        {
            TempServer tempServer = new TempServer();//new tcp server variable 
            tempServer.LoadFiles();//store the files 

            Console.WriteLine("Welcome to Ruelas' Joke/Conspiracy Server");//message welcome displayed 
            Console.WriteLine("------------------------------------------");//better look 

            SynchronousSocketListener ssl = new SynchronousSocketListener();//this will trigget the program ssl 
            ssl.StartListening();//this will sit there until catches something


            //while (true)
            //{
            //    Console.WriteLine("Type q to quit");
            //    string userInput = Console.ReadLine();

            //    if (userInput == "q")
            //    {
            //        break;
            //    }
            //    Console.WriteLine($"Joke: {tempServer.GetRandomJoke()}");                  proffesor deleted this but i would love to keep it to study later 
            //    Console.WriteLine($"conspiracy: {tempServer.GetRandomConspiracy()}");
            //}
        }
        

    }
}
