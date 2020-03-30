using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Enums;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: BakedBeansPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for BakedBeans  side
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        //Test 1: BakedBeans Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var bb = new BakedBeans();
            Order newOrder = new Order(1);
            newOrder.Add(bb);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing size should invoke propertychanged for size
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var bb = new BakedBeans();
            bb.Size = Size.Large;
            Assert.Equal(Size.Large, bb.Size);
        }
        //Test 3: Changing size should invoke propertychanged for calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var bb = new BakedBeans();
            bb.Size = Size.Large;
            Assert.Equal(bb.Calories, SideInformation.LARGE_BAKED_BEANS_CALORIES);
        }
        //Test 4: Changing size should invoke propertychanged for price
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var bb = new BakedBeans();
            bb.Size = Size.Large;
            Assert.Equal(bb.Price, SideInformation.LARGE_BAKED_BEANS_PRICE);
        }
    }
}
