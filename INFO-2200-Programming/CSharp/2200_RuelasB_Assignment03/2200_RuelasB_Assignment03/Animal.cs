using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_RuelasB_Assignment03
{
    public abstract class Animal
    {
        public string SkinType { get; set; }
        public string FoodType { get; set; }

        public Animal(string SkinType, string FoodType)
        {
            this.SkinType = SkinType;
            this.FoodType = FoodType;
        }
        public string Eat()// concrete methods
        {
            return "chomp chomp";//message print
        }
        public string Reproduce()// concreete methods
        {
            return "create offspring";//message print
        }
        public virtual string Move()//virtual method
        {
            return "hippity hop";//message print0
        }
        public abstract string Unique();// unique string
    }
}