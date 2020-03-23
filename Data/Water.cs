using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// calss for the water object
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged
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
        /// handler for is lemon is included
        /// </summary>
        public bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set 
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// handler for is ice is included
        /// </summary>
        public bool ice = true;
        public override bool Ice
        {
            get { return ice; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// handler for price
        /// </summary>
        public override double Price
        {
            get { return .12; }
        }
        /// <summary>
        /// handler for calories
        /// </summary>
        public override uint Calories
        {
            get { return 0; }
        }

        /// <summary>
        /// handler for specialinstructions
        /// </summary>
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
        /// <summary>
        /// Order item description
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Large:
                    return "Large Water";
                default:
                    return "Unknown Size";
            }
        }
    }
}
