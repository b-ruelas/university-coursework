using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_RuelasB_Assignment03
{
    internal class Cat : Animal
    {
        // Constructor: must call base with 2 arguments
        public Cat() : base("Hairless", "Fish")
        {
        }

        // Override the virtual Move method
        public override string Move()
        {
            return "Sneaks quietly";
        }

        // Override the abstract Unique method
        public override string Unique()
        {
            return "clibsw trees ";
        }
    }
}