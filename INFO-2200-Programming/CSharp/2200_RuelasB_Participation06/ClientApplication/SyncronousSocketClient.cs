using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication
{
    public class SyncronousSocketClient
    {
        const int SERVER_PORT = 1100;//port number the client will connect to

        const string IP_ADDRESS = "127.0.0.1";//server ip address

        public SyncronousSocketClient()
        {
            
        }

        public string ContactServer(string request)
        {
            string responseString;
            try//stroe variable from server 
            {
                TcpClient tcpClient = new TcpClient();//create a new tcp client
                tcpClient.Connect(IPAddress.Parse(IP_ADDRESS), SERVER_PORT);//cnnects to server using ip and port 
                NetworkStream networkStream = tcpClient.GetStream();// allows it to be sincronized send a request

                StreamReader streamReader = new StreamReader(networkStream);//read data from network stream
                StreamWriter streamWriter = new StreamWriter(networkStream);//allows  data from network stream
                {
                    streamWriter.AutoFlush = true;//make sure there is nothing left over
                }

                streamWriter.WriteLine(request);//sends request to server
                responseString = streamReader.ReadLine();//read response form server 
                streamReader.Close();//close the reader 
                tcpClient.Close();//close the tcp client
            }
            catch (Exception ex) //exception function 
            
            {
                responseString = ex.Message;//retun server response message 
   

            }
            return responseString;//retunrn
        }
    }
}
