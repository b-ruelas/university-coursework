//Name: Brayan Ruelas
//Class: INFO 2200
//Section: M04
//Professor: Fredickson
//Date: 03/14/2026
//Participation or Assignment #: Assigment 04
//By submitting this assignment, I declare that the source code contained in this assignment was written #solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, #in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment #instructions, nor obtained from a subscription service. I understand that copying any source code, #in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that #I will receive a zero on this project if I am found in violation of this policy.


using _2200_RuelasB_Assignment04.INFO2200_CrandallSayDataSet1TableAdapters;
using _2200_RuelasB_Assignment04.INFO2200_CrandallSayDataSetTableAdapters;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

        }

        private void movieBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.Movie);

        }

        private void movieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// This Form will exlain the function of each bottom from the Design page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        //this private void function is the Sort ascendent botton 
        private void BtnSortAZ_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByAsc(this.iNFO2200_CrandallSayDataSet.Movie);//after createing the sql query, this will sort the movie titles ascending 

        }
        //this private void function is the Sort descendent botton 
        private void BtnSortZA_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByDesc(this.iNFO2200_CrandallSayDataSet.Movie);//after createing the sql query, this will sort the movie titles descending
        }
        //this private void function will sort the firsts 20 movies
        private void BtnFirst20_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByFirst20(this.iNFO2200_CrandallSayDataSet.Movie);//after creating the sql query, this function will sort the first 20 movies of the list
        }
        //in this fuction i connect the other data base or Form 2 to the same fucntion so everytime the bottom is click the other db pups up
        private void BtnDisplayCountCategories_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();//we grab the other data base call Form2
            frm.ShowDialog(); // modal window, a new window will display
        }
        //this function will filter a specific movies the user types, wherever the user types also will be filter in the first 20 bottom is selected
        private void BtnMovieSearch_TextChanged(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillBySearch(this.iNFO2200_CrandallSayDataSet.Movie, BtnMovieSearch.Text);//after creating the sql query, this function will find specific movies
        }
    }
}
