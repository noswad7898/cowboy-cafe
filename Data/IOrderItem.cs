using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Object class for all orderable items
    /// </summary>
    public interface IOrderItem
    {
        double Price { get; }

        List<string> SpecialInstructions { get; }
    }
}
