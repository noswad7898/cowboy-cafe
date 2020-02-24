using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork
    /// </summary>
    public class PecosPulledPork : Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the pulled pork is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the pulled pork is served with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }
        /// <summary>
        /// The calories in the pulled pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }
        /// <summary>
        /// Special instructions for the preperation of the pulled pork
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
            return "Pecos Pulled Pork";
        }
    }
}
