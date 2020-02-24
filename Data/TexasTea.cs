using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        public bool sweet = true;
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        public bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        public bool ice = true;
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        return 1.00;
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
                        
                        if (!sweet)
                        {
                            return 10/2;
                        }
                        else
                        {
                            return 10;
                        }
                    case Size.Medium:
                        if (sweet == true)
                        {
                            return 22;
                        }
                        else
                        {
                            return 11;
                        }
                    case Size.Large:
                        if (sweet == true)
                        {
                            return 36;
                        }
                        else
                        {
                            return 18;
                        }
                        
                    default:
                        if (!sweet)
                        {
                            return 10/2;
                        }
                        else
                        {
                            return 10;
                        }
                }
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        public override string ToString()
        {
            if (Sweet)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Texas Sweet Tea";
                    case Size.Medium:
                        return "Medium Texas Sweet Tea";
                    case Size.Large:
                        return "Large Texas Sweet Tea";
                    default:
                        return "Unknown Side Size";
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Texas Plain Tea";
                    case Size.Medium:
                        return "Medium Texas Plain Tea";
                    case Size.Large:
                        return "Large Texas Plain Tea";
                    default:
                        return "Unknown Side Size";
                }
            }
        }
    }
}
