//#Name: Brayan Ruelas
//#Class: INFO 2200
//#Section: M03
//#Professor: Fredrickson
//#Date: 2/22/2026
//#Participation or Assignment #: Participation 3 Assignment
//#By submitting this assignment, I declare that the source code contained in this assignment was written #solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, #in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment #instructions, nor obtained from a subscription service. I understand that copying any source code, #in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that #I will receive a zero on this project if I am found in violation of this policy.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2200_RuelasB_Assignment03
{
    /// <summary>
    /// 
    ///This project will display 3 type of animals
    ///will give informations about each animal like food, skintype, etc.
    ///at the then will show a picute of the animal as well
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Animal animal;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This class will create the action of wha will happend if you select a specific animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Animal_Checked(object sender, RoutedEventArgs e)
        {
            if (rbDog.IsChecked == true)//if you selec Dog
            {
                animal = new Dog();//creates a new Dog
                imgAnimal.Source = new BitmapImage(new Uri("Images/Dog.jpg", UriKind.Relative));//displays a picture of the Dog
            }
            else if (rbCat.IsChecked == true)//if the cat is selected 
            {
                animal = new Cat();//passes the action
                imgAnimal.Source = new BitmapImage(new Uri("Images/Cat.jpg", UriKind.Relative));//displays a picture of the cat
            }
            else if (rbChicken.IsChecked == true)//is the Chicken is selected
            {
                animal = new Chicken();//passes the action
                imgAnimal.Source = new BitmapImage(new Uri("Images/Chicken.jpg", UriKind.Relative));//Displays a picture of the chicken 
            }
        }
        /// <summary>
        /// This class will create the action of what will happend if you click the botton skintype
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSkin_Click(object sender, RoutedEventArgs e)
        {
            if (animal != null)//this means that if an animal is selected 
            {
                txtResult.Text = animal.SkinType;//will dispaly the animal skin type 
            }
        }
        /// <summary>
        /// This class will create the action of what will happen if you click the botton food
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFood_Click(object sender, RoutedEventArgs e)
        {
            if (animal != null)//this means that if an animal is selected 
            {
                txtResult.Text = animal.FoodType;//will display the specific food they eat
            }
        }
        /// <summary>
        /// This class will create the action of what will happen if you click the botton eat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEat_Click(object sender, RoutedEventArgs e)
        {
            if (animal != null)//this means that if an animal is selected 
            {
                txtResult.Text = animal.Eat();//will display the specific sound, they do when eating
            }
        }
        /// <summary>
        /// This class will crete the action of what will happen if you cllick the botton move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMove_Click(object sender, RoutedEventArgs e)
        {
            if (animal != null)//this means that if an animal is selected 
            {
                txtResult.Text = animal.Move();//will display a specific move for the animal 
            }
        }
        /// <summary>
        /// This class will display the action of what will happen if you click the botton reproduce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReproduce_Click(object sender, RoutedEventArgs e)
        {
            if (animal != null)//this means that if an animal is selected 
            {
                txtResult.Text = animal.Reproduce();//will show you when the animal is reproduced 
            }
        }
        /// <summary>
        /// This class will create the action of what will happen if you click the botton Unique 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUnique_Click(object sender, RoutedEventArgs e)
        {
            if (animal != null)//this means that if an animal is selected
            {
                txtResult.Text = animal.Unique();//will display a unique feature of each animal
            }
        }
    }
}
