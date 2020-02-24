using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        public bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        public bool roomForCream = false;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        public bool ice = false;
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default: return .60;
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default: return 3;
                }
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        public override string ToString()
        {
            if (decaf)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Decaf Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Decaf Cowboy Coffee";
                    case Size.Large:
                        return "Large Decaf Cowboy Coffee";
                    default:
                        return "Unknown Side Size";
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Cowboy Coffee";
                    case Size.Large:
                        return "Large Cowboy Coffee";
                    default:
                        return "Unknown Side Size";
                }
            }
        }
    }
}
