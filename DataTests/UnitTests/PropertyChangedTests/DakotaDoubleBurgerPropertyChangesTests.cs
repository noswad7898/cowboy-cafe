using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: DakotaDoubleBurgerPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for DakotaDoubleBurger  entree
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class DakotaDoubleBurgerPropertyChangesTests
    {
        //Test 1: DakotaDoubleBurger Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var ddb = new DakotaDoubleBurger();
            Order newOrder = new Order(1);
            newOrder.Add(ddb);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing the "Bun" property should invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Bun = false;
            Assert.False(ddb.Bun);
        }
        //Test 3: Changing the "Bun" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Bun = false;
            Assert.NotNull(ddb.SpecialInstructions);
        }
        //Test 4: Changing the "Ketchup" property should invoke PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Ketchup = false;
            Assert.False(ddb.Ketchup);
        }
        //Test 5: Changing the "Ketchup" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Ketchup = false;
            Assert.NotNull(ddb.SpecialInstructions);
        }
        //Test 6: Changing the "Mustard" property should invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Mustard = false;
            Assert.False(ddb.Mustard);
        }
        //Test 7: Changing the "Mustard" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Mustard = false;
            Assert.NotNull(ddb.SpecialInstructions);
        }
        //Test 8: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Pickle = false;
            Assert.False(ddb.Pickle);
        }
        //Test 9: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Pickle = false;
            Assert.NotNull(ddb.SpecialInstructions);
        }
        //Test 10: Changing the "Cheese" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Cheese = false;
            Assert.False(ddb.Cheese);
        }
        //Test 11: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Cheese = false;
            Assert.NotNull(ddb.SpecialInstructions);
        }
        //Test 12: Changing the "Tomato" property should invoke PropertyChanged for "Tomato"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Tomato = false;
            Assert.False(ddb.Tomato);
        }
        //Test 13: Changing the "Tomato" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Tomato = false;
            Assert.NotNull(ddb.SpecialInstructions);
        }
        //Test 14: Changing the "Lettuce" property should invoke PropertyChanged for "Lettuce"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Lettuce = false;
            Assert.False(ddb.Lettuce);
        }
        //Test 15: Changing the "Lettuce" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Lettuce = false;
            Assert.NotNull(ddb.SpecialInstructions);
        }
        //Test 16: Changing the "Mayo" property should invoke PropertyChanged for "Mayo"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Mayo = false;
            Assert.False(ddb.Mayo);
        }
        //Test 17: Changing the "Lettuce" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var ddb = new DakotaDoubleBurger();
            ddb.Mayo = false;
            Assert.NotNull(ddb.SpecialInstructions);
        }
    }
}
