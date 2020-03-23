using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink, INotifyPropertyChanged
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
        /// handler for if sweetner is included
        /// </summary>
        public bool sweet = true;
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// handler fo if lemon is included
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
        /// handler for if ice is included
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
        /// handler for the price based on size
        /// </summary>
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
        /// <summary>
        /// Handler for special instructions
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
        /// order item description
        /// </summary>
        /// <returns></returns>
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
