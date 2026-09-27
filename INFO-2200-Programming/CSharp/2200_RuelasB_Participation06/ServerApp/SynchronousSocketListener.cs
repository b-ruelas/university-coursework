//#Name:Brayan Ruelas
//#Class: INFO 2200
//#Section: M06
//#Professor: Fredick
//#Date: 4/4/2026
//#Participation or Assignment #: participation 6
//#By submitting this assignment, I declare that the source code contained in this assignment was written #solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, #in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment #instructions, nor obtained from a subscription service. I understand that copying any source code, #in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that #I will receive a zero on this project if I am found in violation of this policy.





using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerApp
{
    /// <summary>
    /// This will be the main cs that allows the server app to pass/ talk with the server page
    /// </summary>
    public class SynchronousSocketListener// we create the class
    {
        const int SERVER_PORT = 1100;//the port both programs ill listent to 
        const string IP_ADDRESS = "127.0.0.1";//thier IP adress 
        const string JOKE = "JOKE";//constant string call joke
        const string CONSPIRACY = "CONSPIRACY";//constant string call conspiracy

        string[] jokes;// we create an empty string to store jokes
        string[] conspiracies;//we create an empty string calles conspiracies to store consp
        const string JOKE_FILE = "jokes.txt";//we conver the txt file readeble as jokefile
        const string CONSP_FILE = "conspiracies.txt";//we conver the xt of conspiracies readeble as consp file 
        TcpListener tcpListener;//will sit there listening the server page 

       
        public SynchronousSocketListener()//public class once it listen somthig
        {
            try//function for the files 
            {
                jokes = File.ReadAllLines(JOKE_FILE);// this will read the files/jokes 
                conspiracies = File.ReadAllLines(CONSP_FILE);//this will read the consp 
            }
            catch (Exception ex)//if there is something else/mistake
            {
                Console.WriteLine(ex.Message);//a message will be displayed 
            }
        }

        public void StartListening()//this will trigger what will happen once it listend
        {
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);//check if the ip is 4 or 6
            tcpListener = new TcpListener(iPAddress, SERVER_PORT);// check and mathc the port
            tcpListener.Start();//stars the function 
            Thread thread = new Thread(new ThreadStart(ProcessSocket));
            thread.Start();//start the thread

        }

        public void ProcessSocket()
        {
            while (true)//keeps listening indefinitely 
            {
                try
                {
                    Socket socket = tcpListener.AcceptSocket();//accept incoming client connection 
                    NetworkStream ns = new NetworkStream(socket);//create a network stram from the socket
                    StreamReader reader = new StreamReader(ns);//this makes it to read
                    StreamWriter writer = new StreamWriter(ns);//this makes it to write 
                    {
                        writer.AutoFlush = true;//this makes sure there is now extra packets left over
                    }

                     

                    string clientinput = reader.ReadLine();//read a line of input from the client 
                    Console.WriteLine($"Recived from client: {clientinput}");//displays the recived message

                    Random rand = new Random();//creates a random generator 
                    if (clientinput.ToUpper() == JOKE)//condition if for the client input , if joke is typed 
                    {
                        string joke = jokes[rand.Next(jokes.Length)];//this grabs a random joke form the file 
                        Console.WriteLine(joke);//print joke to console 
                        writer.WriteLine(joke);//print joke to client
                    }
                    else if (clientinput.ToUpper() == CONSPIRACY)//condition if for the client if conspiracy is typed 
                    {
                        string consp = conspiracies[rand.Next(conspiracies.Length)];//creates a random consp form file
                        Console.WriteLine(consp);//print conspiracy to console 
                        writer.WriteLine(consp);//print conspiracy to client
                    }
                    else//something else or wrong
                    {
                        writer.WriteLine($"Could not do anything with : {clientinput}");//error message will be dispalyed 
                    }
                }
                catch (Exception ex)//if there is an execption 
                {
                    Console.WriteLine(ex.Message);//display exception message 
                }
                
            }
        }
    }
}
