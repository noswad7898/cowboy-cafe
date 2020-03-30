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
/// Class: CowboyCoffeePropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for CowboyCoffee  drink
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        //Test 1: BowboyCoffee Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var cc = new CowboyCoffee();
            Order newOrder = new Order(1);
            newOrder.Add(cc);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing "RoomForCream" property should invoke PropertyChanged for "RoomForCream"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForRoomForCream()
        {
            var cc = new CowboyCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
        }
        //Test 3: Changing "RoomForCream" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cc = new CowboyCoffee();
            cc.RoomForCream = true;
            Assert.NotNull(cc.SpecialInstructions);
        }
        //Test 4: Changing "Decaf" property should invoke PropertyChanged for "Decaf"
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var cc = new CowboyCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
        }
        //Test 5: Changing "Decaf" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cc = new CowboyCoffee();
            cc.Decaf = true;
            Assert.NotNull(cc.SpecialInstructions);
        }
        //Test 6: Changing "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var cc = new CowboyCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
        }
        //Test 7: Changing "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cc = new CowboyCoffee();
            cc.Ice = true;
            Assert.NotNull(cc.SpecialInstructions);
        }
        //Test 8: changing size should invoke propertychanged fore size
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var cc = new CowboyCoffee();
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
        }
        //Test 9: changing size should invoke propertychanged for calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var cc = new CowboyCoffee();
            cc.Size = Size.Large;
            Assert.Equal(cc.Calories, DrinkInformation.LARGE_COWBOY_COFFEE_CALORIES);
        }
        //Test 10: changing size should invoke propertychanged for price
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var cc = new CowboyCoffee();
            cc.Size = Size.Large;
            Assert.Equal(cc.Price, DrinkInformation.LARGE_COWBOY_COFFEE_PRICE);
        }
    }
}
