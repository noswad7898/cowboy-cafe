using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data;

/// <summary>
/// Author: Dawson Field
/// Class: RustlersRibsPropertyChangedTests.cs
/// Purpose: Tests PropertyChanged event handlers for RustlersRibs  entree
/// </summary>

namespace CowboyCafe.DataTests.UnitTests.PropertyChangedTests
{
    public class RustlersRibsPropertyChangedTests
    {
        //Test 1: RustlersRibs Should Implement the INotifyPropertyChanged Interface
        [Fact]
        public void RustlersRibsPorkShouldImplementINotifyPropertyChanged()
        {
            var rr = new RustlersRibs();
            Order newOrder = new Order(1);
            newOrder.Add(rr);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(newOrder);
        }
    }
}
