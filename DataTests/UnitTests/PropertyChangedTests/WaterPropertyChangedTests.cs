using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Enums;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: WaterPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for Water  drink
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        //Test 1: Water Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var w = new Water();
            Order newOrder = new Order(1);
            newOrder.Add(w);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var w = new Water();
            w.Ice = false;
            Assert.False(w.Ice);
        }
        //Test 3: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var w = new Water();
            w.Ice = false;
            Assert.NotNull(w.SpecialInstructions);
        }
        //Test 4: changing the "Lemon" property should invoke PropertyChanged for "Lemon"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var w = new Water();
            w.Lemon = true;
            Assert.True(w.Lemon);
        }
        //Test 5: Changing the "Lemon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var w = new Water();
            w.Lemon = false;
            Assert.NotNull(w.SpecialInstructions);
        }
        //Test 6: changing size should invoke propertychanged fore size
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var w = new Water();
            w.Size = Size.Large;
            Assert.Equal(Size.Large, w.Size);
        }
        //Test 7: changing size should invoke propertychanged for calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var w = new Water();
            w.Size = Size.Large;
            Assert.Equal(w.Calories, DrinkInformation.WATER_CALORIES);
        }
        //Test 8: changing size should invoke propertychanged for price
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var w = new Water();
            w.Size = Size.Large;
            Assert.Equal(w.Price, DrinkInformation.WATER_PRICE);
        }
    }
}
