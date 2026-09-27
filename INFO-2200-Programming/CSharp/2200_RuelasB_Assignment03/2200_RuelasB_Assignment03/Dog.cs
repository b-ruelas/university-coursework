using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_RuelasB_Assignment03
{
    internal class Dog : Animal
    {
        // Constructor: must call base with 2 arguments
        public Dog() : base("Fluffy", "Meat")
        {
        }

        // Override the virtual Move method
        public override string Move()
        {
            return "runs and jumps";
        }

        // Override the abstract Unique method
        public override string Unique()
        {
            return "wags tail";
        }
    }
}