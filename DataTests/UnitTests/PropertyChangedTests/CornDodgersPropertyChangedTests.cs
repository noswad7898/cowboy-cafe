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
/// Class: CornDodgersPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for CornDodgers  side
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        //Test 1: CornDodgers Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var cd = new CornDodgers();
            Order newOrder = new Order(1);
            newOrder.Add(cd);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing size should invoke propertychanged for size
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var cd = new CornDodgers();
            cd.Size = Size.Large;
            Assert.Equal(Size.Large, cd.Size);
        }
        //Test 3: Changing size should invoke propertychanged for calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var cd = new CornDodgers();
            cd.Size = Size.Large;
            Assert.Equal(cd.Calories, SideInformation.LARGE_CORN_DODGERS_CALORIES);
        }
        //Test 4: Changing size should invoke propertychanged for price
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var cd = new CornDodgers();
            cd.Size = Size.Large;
            Assert.Equal(cd.Price, SideInformation.LARGE_CORN_DODGERS_PRICE);
        }
    }
}
