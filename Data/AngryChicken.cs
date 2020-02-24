using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the AngryChicken entree
    /// </summary>
    public class AngryChicken : Entree
    {
        private bool bread = true;
        /// <summary>
        /// If AngryChicken is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If AngryChicken is servced with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// The price of AngryChicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }
        /// <summary>
        /// The calories in the AngryChicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }
        /// <summary>
        /// Special instructions for items withels from the AngryChicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
