using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_RuelasB_Assignment03
{
    internal class Chicken : Animal
    {
        // Constructor: must call base with 2 arguments
        public Chicken() : base("Silkie", "Seeds")
        {
        }

        // Override the virtual Move method
        public override string Move()
        {
            return "jump jump jump";
        }

        // Override the abstract Unique method
        public override string Unique()
        {
            return "cluck CLUCKKKKKKKKK";
        }
    }
}