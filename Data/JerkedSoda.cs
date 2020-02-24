using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        public SodaFlavor flavor;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default: return 1.59;
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
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default: return 110;
                }
            }
        }
        public bool ice = true;
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        public override string ToString()
        {
            if(Flavor == SodaFlavor.OrangeSoda)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Orange Soda Jerked Soda";
                    case Size.Medium:
                        return "Medium Orange Soda Jerked Soda";
                    case Size.Large:
                        return "Large Orange Soda Jerked Soda";
                    default:
                        return "Unknown Size";
                }
            }
            else if (Flavor == SodaFlavor.CreamSoda)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Cream Soda Jerked Soda";
                    case Size.Medium:
                        return "Medium Cream Soda Jerked Soda";
                    case Size.Large:
                        return "Large Cream Soda Jerked Soda";
                    default:
                        return "Unknown Size";
                }
            }
            else if (Flavor == SodaFlavor.Sarsparilla)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Sarsparilla Jerked Soda";
                    case Size.Medium:
                        return "Medium Sarsparilla Jerked Soda";
                    case Size.Large:
                        return "Large Sarsparilla Jerked Soda";
                    default:
                        return "Unknown Size";
                }
            }
            else if (Flavor == SodaFlavor.RootBeer)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Root Beer Jerked Soda";
                    case Size.Medium:
                        return "Medium Root Beer Jerked Soda";
                    case Size.Large:
                        return "Large Root Beer Jerked Soda";
                    default:
                        return "Unknown Size";
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Birch Beer Jerked Soda";
                    case Size.Medium:
                        return "Medium Birch Beer Jerked Soda";
                    case Size.Large:
                        return "Large Birch Beer Jerked Soda";
                    default:
                        return "Unknown Size";
                }
            }
        }
    }
}
