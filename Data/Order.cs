using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private uint LastOrderNumber = 0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items { get; }

        public double Subtotal
        {
            
            get
            {
                foreach(item in items)
                {
                    Subtotal += IOrderItem.Price;
                }
                return Subtotal;
            }
        }

        public static uint OrderNumber { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        
        

        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        public void Remove(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

    }
}
