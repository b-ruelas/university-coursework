using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class Form1 : Form

    {
         private readonly SyncronousSocketClient syncronousSocketClient = new SyncronousSocketClient();


        public Form1()
        {
            InitializeComponent();
        }

      


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            TxtBoxResposne.Text = syncronousSocketClient.ContactServer(TxtBoxRequest.Text);//This will return the response from the server 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
