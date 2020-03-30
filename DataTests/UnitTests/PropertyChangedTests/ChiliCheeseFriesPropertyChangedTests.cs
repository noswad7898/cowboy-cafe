using System.ComponentModel;
using Xunit;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Enums;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: ChiliCheeseFriesPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for ChiliCheeseFries  side
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        //Test 1: ChiliCheeseFries Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var ccf = new ChiliCheeseFries();
            Order newOrder = new Order(1);
            newOrder.Add(ccf);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
        //Test 2: Changing size should invoke propertychanged for size
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var ccf = new ChiliCheeseFries();
            ccf.Size = Size.Large;
            Assert.Equal(Size.Large, ccf.Size);
        }
        //Test 3: Changing size should invoke propertychanged for calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var ccf = new ChiliCheeseFries();
            ccf.Size = Size.Large;
            Assert.Equal(ccf.Calories, SideInformation.LARGE_CHILI_CHEESE_FRIES_CALORIES);
        }
        //Test 4: Changing size should invoke propertychanged for price
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var ccf = new ChiliCheeseFries();
            ccf.Size = Size.Large;
            Assert.Equal(ccf.Price, SideInformation.LARGE_CHILI_CHEESE_FRIES_PRICE);
        }
    }
}
