﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustlers Ribs entree
    /// </summary>
    public class RustlersRibs
    {
        /// <summary>
        /// The price of the Rustlers Ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// The calories in the Rustlers Ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }
        /// <summary>
        /// no special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
    }
}