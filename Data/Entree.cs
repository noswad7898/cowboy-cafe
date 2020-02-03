﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract class for Entree items
    /// </summary>
    public abstract class Entree
    {
        public abstract double Price { get; set; }

        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }

    }
}