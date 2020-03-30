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
/// Class: TexasTeaPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for TexasTea  drink
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        //Test 1: TexasTea Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var tt = new TexasTea();
            Order newOrder = new Order(1);
            newOrder.Add(tt);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var tt = new TexasTea();
            tt.Ice = false;
            Assert.False(tt.Ice);
        }
        //Test 3: Changing "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tt = new TexasTea();
            tt.Ice = false;
            Assert.NotNull(tt.SpecialInstructions);
        }
        //Test 4: Changing "Sweet" property should invoke PropertyChanged for "Sweet"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var tt = new TexasTea();
            tt.Sweet = false;
            Assert.False(tt.Sweet);
        }
        //Test 5: Changing "Sweet" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tt = new TexasTea();
            tt.Sweet = false;
            Assert.NotNull(tt.SpecialInstructions);
        }
        //Test 6: changing the "Lemon" property should invoke PropertyChanged for "Lemon"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var tt = new TexasTea();
            tt.Lemon = true;
            Assert.True(tt.Lemon);
        }
        //Test 7: Changing the "Lemon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tt = new TexasTea();
            tt.Lemon = true;
            Assert.NotNull(tt.SpecialInstructions);
        }
        //Test 8: changing size should invoke propertychanged fore size
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var tt = new TexasTea();
            tt.Size = Size.Large;
            Assert.Equal(Size.Large, tt.Size);
        }
        //Test 9: changing size should invoke propertychanged for calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var tt = new TexasTea();
            tt.Size = Size.Large;
            Assert.Equal(tt.Calories, DrinkInformation.LARGE_TEXAS_TEA_CALORIES);
        }
        //Test 10: changing size should invoke propertychanged for price
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var tt = new TexasTea();
            tt.Size = Size.Large;
            Assert.Equal(tt.Price, DrinkInformation.LARGE_TEXAS_TEA_PRICE);
        }
    }
}
