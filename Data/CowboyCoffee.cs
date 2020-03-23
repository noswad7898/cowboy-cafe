using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink, INotifyPropertyChanged
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
        /// handler for if the Coffee is caffinated
        /// </summary>
        public bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// handler for if there is room for cream
        /// </summary>
        public bool roomForCream = false;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// handler for if drink includes ice
        /// </summary>
        public bool ice = false;
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// handler for price based on size
        /// </summary>
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
        /// <summary>
        /// handler for calories based on size
        /// </summary>
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
        /// <summary>
        /// handler for special instructions
        /// </summary>
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
        /// <summary>
        /// order item description
        /// </summary>
        /// <returns></returns>
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
