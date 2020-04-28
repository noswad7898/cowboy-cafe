using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: MenuPropertiesTests
/// Functions: Tests For Menu Properties
/// </summary>
namespace CowboyCafe.DataTests.UnitTests.WebsiteTests
{
    public class MenuPropertiesTests
    {
        [Fact]
        public void TypePropertiesShouldBeCorrect()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            Assert.Equal(entrees.ToString(), Menu.Entrees().ToString());
            IEnumerable<IOrderItem> sides = Menu.Sides();
            Assert.Equal(sides.ToString(), Menu.Sides().ToString());
            IEnumerable<IOrderItem> drinks = Menu.Drinks();
            Assert.Equal(drinks.ToString(), Menu.Drinks().ToString());
            IEnumerable<IOrderItem> all = Menu.CompleteMenu();
            Assert.Equal(all.ToString(), Menu.CompleteMenu().ToString());
        }
    }
}
