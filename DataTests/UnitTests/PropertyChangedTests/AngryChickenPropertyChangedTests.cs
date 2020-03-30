using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: AngryChickenPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for AngryChicken  entree
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class AngryChickenPropertyChangedTests
    {
        //Test 1: Angry Chicken Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Order newOrder = new Order(1);
            newOrder.Add(chicken);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing the "Bread" property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            chicken.Bread = false;
            Assert.False(chicken.Bread);
        }
        //Test 3: Changing the "Bread" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            chicken.Bread = false;
            Assert.NotNull(chicken.SpecialInstructions);
        }
        //Test 4: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            chicken.Pickle = false;
            Assert.False(chicken.Pickle);
        }
        //Test 5: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            chicken.Pickle = false;
            Assert.NotNull(chicken.SpecialInstructions);
        }
    }
}
