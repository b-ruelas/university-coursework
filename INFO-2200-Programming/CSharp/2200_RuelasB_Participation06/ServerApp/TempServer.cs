using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    public class TempServer
    {
        Random rand = new Random(); //create random generator
        string[] Jokes; //array to store jokes
        string[] Conspiracies; //array to store conspiracies
        const string Joke_File = "jokes.txt"; //file containing jokes
        const string Conspirscies_File = "conspiracies.txt"; //file containing conspiracies

        public TempServer()
        {
            //constructor, currently does nothing, professor had it on his
        }

        public void LoadFiles()//load the files
        {
            try//this functions will trigger the program 
            {
                Jokes = File.ReadAllLines(Joke_File); //read all jokes from file into array
                Conspiracies = File.ReadAllLines(Conspirscies_File); //read all conspiracies from file into array
            }
            catch (Exception ex)//exception fucntionn
            {
                Console.WriteLine(ex.Message); //print any exception that occurs while loading files
            }
        }

        public string GetRandomJoke()
        {
            return Jokes[rand.Next(Jokes.Length)];  //gets random joke
        }

        public string GetRandomConspiracy()
        {
            return Conspiracies[rand.Next(Conspiracies.Length)]; //gets random conspiracy
        }
    }
}