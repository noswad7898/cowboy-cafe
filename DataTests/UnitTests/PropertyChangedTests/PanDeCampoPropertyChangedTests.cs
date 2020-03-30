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
/// Class: PanDeCampoPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for PanDeCampo  side
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        //Test 1: PanDeCampo Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var pdc = new PanDeCampo();
            Order newOrder = new Order(1);
            newOrder.Add(pdc);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing size should invoke propertychanged for size
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var pdc = new PanDeCampo();
            pdc.Size = Size.Large;
            Assert.Equal(Size.Large, pdc.Size);
        }
        //Test 3: Changing size should invoke propertychanged for calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var pdc = new PanDeCampo();
            pdc.Size = Size.Large;
            Assert.Equal(pdc.Calories, SideInformation.LARGE_PANDECAMPO_CALORIES);
        }
        //Test 4: Changing size should invoke propertychanged for price
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var pdc = new PanDeCampo();
            pdc.Size = Size.Large;
            Assert.Equal(pdc.Price, SideInformation.LARGE_PANDECAMPO_PRICE);
        }
    }
}
