using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_RuelasB_Assignment04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet1.CountMovieCategory' table. You can move, or remove it, as needed.
            this.countMovieCategoryTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet1.CountMovieCategory);

        }
    }
}
