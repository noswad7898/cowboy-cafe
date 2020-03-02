﻿using System;
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

        public double Subtotal { get;  }

        public static uint OrderNumber { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        
        

        public void Add(IOrderItem item)
        {

        }

        public void Remove(IOrderItem item)
        {

        }

    }
}
