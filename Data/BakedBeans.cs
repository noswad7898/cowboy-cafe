using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the ChiliCheeseFries Side
    /// </summary>
    public class BakedBeans : Side
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
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
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
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
    }
}
