using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: TexasTripleBurgerPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for TexasTripleBurger  entree
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        //Test 1: TexasTripleBurger Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var ttb = new TexasTripleBurger();
            Order newOrder = new Order(1);
            newOrder.Add(ttb);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing the "Bun" property should invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var ttb = new TexasTripleBurger();
            ttb.Bun = false;
            Assert.False(ttb.Bun);
        }
        //Test 3: Changing the "Bun" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Bun = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
        //Test 4: Changing the "Ketchup" property should invoke PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var ttb = new TexasTripleBurger();
            ttb.Ketchup = false;
            Assert.False(ttb.Ketchup);
        }
        //Test 5: Changing the "Ketchup" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Ketchup = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
        //Test 6: Changing the "Mustard" property should invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var ttb = new TexasTripleBurger();
            ttb.Mustard = false;
            Assert.False(ttb.Mustard);
        }
        //Test 7: Changing the "Mustard" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Mustard = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
        //Test 8: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var ttb = new TexasTripleBurger();
            ttb.Pickle = false;
            Assert.False(ttb.Pickle);
        }
        //Test 9: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Pickle = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
        //Test 10: Changing the "Cheese" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var ttb = new TexasTripleBurger();
            ttb.Cheese = false;
            Assert.False(ttb.Cheese);
        }
        //Test 11: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Cheese = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
        //Test 12: Changing the "Tomato" property should invoke PropertyChanged for "Tomato"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var ttb = new TexasTripleBurger();
            ttb.Tomato = false;
            Assert.False(ttb.Tomato);
        }
        //Test 13: Changing the "Tomato" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Tomato = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
        //Test 14: Changing the "Lettuce" property should invoke PropertyChanged for "Lettuce"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var ttb = new TexasTripleBurger();
            ttb.Lettuce = false;
            Assert.False(ttb.Lettuce);
        }
        //Test 15: Changing the "Lettuce" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Lettuce = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
        //Test 16: Changing the "Bacon" property should invoke PropertyChanged for "Bacon"
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var ttb = new TexasTripleBurger();
            ttb.Bacon = false;
            Assert.False(ttb.Bacon);
        }
        //Test 17: Changing the "Bacon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Bacon = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
        //Test 18: Changing the "Egg" property should invoke PropertyChanged for "Egg"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var ttb = new TexasTripleBurger();
            ttb.Egg = false;
            Assert.False(ttb.Egg);
        }
        //Test 19: Changing the "Egg" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Mayo = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
        //Test 20: Changing the "Mayo" property should invoke PropertyChanged for "Mayo"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var ttb = new TexasTripleBurger();
            ttb.Mayo = false;
            Assert.False(ttb.Mayo);
        }
        //Test 21: Changing the "Mayo" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ttb = new TexasTripleBurger();
            ttb.Mayo = false;
            Assert.NotNull(ttb.SpecialInstructions);
        }
    }
}
