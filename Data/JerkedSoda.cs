using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// event handler for when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// handler for the case when the side/drink is small
        /// </summary>
        public bool isSmall = true;
        public bool IsSmall
        {
            get
            {
                return isSmall;
            }
            set
            {
                Size = Size.Small;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// handler for when the side/drink is medium
        /// </summary>
        public bool isMedium = false;
        public bool IsMedium
        {
            get
            {
                return isMedium;
            }
            set
            {
                Size = Size.Medium;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }

        }
        /// <summary>
        /// handler for when the side/drink is large
        /// </summary>
        public bool isLarge = false;
        public bool IsLarge
        {
            get
            {
                return isLarge;
            }
            set
            {
                Size = Size.Large;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// handler for flavor enum
        /// </summary>
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// price based on size
        /// </summary>
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
        /// <summary>
        /// calories based on size
        /// </summary>
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
        /// <summary>
        /// handler for if there is ice
        /// </summary>
        public bool ice = true;
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// handler for special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
        /// <summary>
        /// order item description
        /// </summary>
        /// <returns></returns>
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
