using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem
    {
        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }

        public virtual Size Size { get; set; }

        public virtual bool Ice { get; set; }
    }
}
