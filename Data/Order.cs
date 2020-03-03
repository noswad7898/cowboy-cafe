using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private  static uint LastOrderNumber = 0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items {
            get
            {
                return items.ToArray();
            }
        }

        public double Subtotal
        {
            
            get
            {
                double Subtotal = 0.0;
                foreach(IOrderItem item in items)
                {
                    Subtotal += item.Price;
                }
                return Subtotal;
            }
        }

        public static uint OrderNumber 
        {
            get
            {
                return LastOrderNumber++;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        

        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        public void Remove(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

    }
}
