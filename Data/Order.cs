using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for all order objects
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// previous ordern nuber to be inceremented
        /// </summary>
        private  static uint LastOrderNumber = 0;

        /// <summary>
        /// list of order items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// sends all items to an array
        /// </summary>
        public IEnumerable<IOrderItem> Items {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// adds price of each item to subtotal
        /// </summary>
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

        /// <summary>
        /// increments the order number with each new order object
        /// </summary>
        public static uint OrderNumber 
        {
            get
            {
                return LastOrderNumber++;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        
        
        /// <summary>
        /// implements propertychangedeventhandlers for Adding items and price to subtotal
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            //temporary hack
            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged += OnItemChanged;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            
        }

        /// <summary>
        /// implements propertychangedeventhandlers removing items and price from subtotal
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            //temporary hack
            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged -= OnItemChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

    }
}
