using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: CowpokeChiliPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for CowpokeChili  entree
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        //Test 1: Cowpoke Chili Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Order newOrder = new Order(1);
            newOrder.Add(chili);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing the "Cheese" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            chili.Cheese = false;
            Assert.False(chili.Cheese);
        }
        //Test 3: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            chili.Cheese = false;
            Assert.NotNull(chili.SpecialInstructions);
        }
        //Test 4: Changing the "SourCream" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            chili.SourCream = false;
            Assert.False(chili.SourCream);
        }
        //Test 5: Changing the "SourCream" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            chili.SourCream = false;
            Assert.NotNull(chili.SpecialInstructions);
        }
        //Test 5: Changing the "GreenOnions" property should invoke PropertyChanged for "GreenOnions"
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            chili.GreenOnions = false;
            Assert.False(chili.GreenOnions);
        }
        //Test 6: Changing the "GreenOnions" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            chili.GreenOnions = false;
            Assert.NotNull(chili.SpecialInstructions);
        }
        //Test 7: Changing the "TortillaStrips" property should invoke PropertyChanged for "TortillaStrips"
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStripss()
        {
            var chili = new CowpokeChili();
            chili.TortillaStrips = false;
            Assert.False(chili.TortillaStrips);
        }
        //Test 8: Changing the "TortillaStrips" property should invoke PropertyChanged for "TortillaStrips"
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            chili.TortillaStrips = false;
            Assert.NotNull(chili.SpecialInstructions);
        }
    }
}
