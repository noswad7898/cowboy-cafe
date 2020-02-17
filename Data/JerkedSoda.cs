using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        public SodaFlavor Flavor
        {
            get
            {
                switch (Flavor)
                {
                    case SodaFlavor.CreamSoda:
                        return SodaFlavor.CreamSoda;
                    case SodaFlavor.OrangeSoda:
                        return SodaFlavor.OrangeSoda;
                    case SodaFlavor.Sarsaparilla:
                        return SodaFlavor.Sarsaparilla;
                    case SodaFlavor.BirchBeer:
                        return SodaFlavor.BirchBeer;
                    case SodaFlavor.RootBeer:
                        return SodaFlavor.RootBeer;
                    default:
                        throw new NotImplementedException("Unknown Flavor");


                }
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
        public override bool Ice
        {
            get { return Ice; }
            set { Ice = value; }
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
    }
}
