using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: TrailBurgerPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for TrailBurger  entree
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        //Test 1: TrailBurger Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var tb = new TrailBurger();
            Order newOrder = new Order(1);
            newOrder.Add(tb);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing the "Bun" property should invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var tb = new TrailBurger();
            tb.Bun = false;
            Assert.False(tb.Bun);
        }
        //Test 3: Changing the "Bun" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            tb.Bun = false;
            Assert.NotNull(tb.SpecialInstructions);
        }
        //Test 4: Changing the "Ketchup" property should invoke PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var tb = new TrailBurger();
            tb.Ketchup = false;
            Assert.False(tb.Ketchup);
        }
        //Test 5: Changing the "Ketchup" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            tb.Ketchup = false;
            Assert.NotNull(tb.SpecialInstructions);
        }
        //Test 6: Changing the "Mustard" property should invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var tb = new TrailBurger();
            tb.Mustard = false;
            Assert.False(tb.Mustard);
        }
        //Test 7: Changing the "Mustard" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            tb.Mustard = false;
            Assert.NotNull(tb.SpecialInstructions);
        }
        //Test 8: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var tb = new TrailBurger();
            tb.Pickle = false;
            Assert.False(tb.Pickle);
        }
        //Test 9: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            tb.Pickle = false;
            Assert.NotNull(tb.SpecialInstructions);
        }
        //Test 10: Changing the "Cheese" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var tb = new TrailBurger();
            tb.Cheese = false;
            Assert.False(tb.Cheese);
        }
        //Test 11: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tb = new TrailBurger();
            tb.Cheese = false;
            Assert.NotNull(tb.SpecialInstructions);
        }
    }
}
