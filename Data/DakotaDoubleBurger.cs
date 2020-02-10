using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        private bool bun = true;
        /// <summary>
        /// if the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool ketchup = true;
        /// <summary>
        /// if the burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// if the burger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// if the burger has pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        private bool cheese = true;
        /// <summary>
        /// if the burger has cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool tomato = true;
        /// <summary>
        /// If the burger has tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool lettuce = true;
        /// <summary>
        /// if the burger has tomato
        /// </summary>
        public bool Lettuce
        {
            get { return Lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// if the burger has mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }
        /// <summary>
        /// price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// calories in the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }
        /// <summary>
        /// special instrucions for Dakota Double Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");

                return instructions;
            }
        }
    }
}
