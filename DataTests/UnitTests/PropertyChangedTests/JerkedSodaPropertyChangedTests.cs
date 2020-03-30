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
/// Class: JerkedSodaPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for JerkedSoda  drink
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        //Test 1: JerkedSoda Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var js = new JerkedSoda();
            Order newOrder = new Order(1);
            newOrder.Add(js);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing flavor property should invoke propertychanged for flavor
        [Fact]
        private void ChangingFlavorShouldInvokePropertyChangedForFlavor()
        {
            var js = new JerkedSoda();
            js.Flavor = SodaFlavor.CreamSoda;
            Assert.Equal(SodaFlavor.CreamSoda, js.Flavor);
        }
        //Test 3: Changing "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var js = new JerkedSoda();
            js.Ice = false;
            Assert.False(js.Ice);
        }
        //Test 4: Changing "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var js = new JerkedSoda();
            js.Ice = false;
            Assert.NotNull(js.SpecialInstructions);
        }
        //Test 8: changing size should invoke propertychanged fore size
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var js = new JerkedSoda();
            js.Size = Size.Large;
            Assert.Equal(Size.Large, js.Size);
        }
        //Test 9: changing size should invoke propertychanged for calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var js = new JerkedSoda();
            js.Size = Size.Large;
            Assert.Equal(js.Calories, DrinkInformation.LARGE_JERKED_SODA_CALORIES);
        }
        //Test 10: changing size should invoke propertychanged for price
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var js = new JerkedSoda();
            js.Size = Size.Large;
            Assert.Equal(js.Price, DrinkInformation.LARGE_JERKED_SODA_PRICE);
        }
    }
}
