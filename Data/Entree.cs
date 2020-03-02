using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract class for Entree items
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }

    }
}
