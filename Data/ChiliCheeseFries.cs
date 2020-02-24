using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the ChiliCheeseFries Side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// an override class representing calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
        /// <summary>
        /// an override class representing price
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Chili Cheese Fries";
                case Size.Medium:
                    return "Medium Chili Cheese Fries";
                case Size.Large:
                    return "Large Chili Cheese Fries";
                default:
                    return "Unknown Side Size";
            }
        }
    }
}
