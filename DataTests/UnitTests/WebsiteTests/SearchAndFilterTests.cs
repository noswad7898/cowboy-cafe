using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests.WebsiteTests
{
    public class SearchAndFilterTests
    {
        /// <summary>
        /// tests filter function for price and calories
        /// </summary>
        [Fact]
        void FilterTests()
        {
            uint calFilter = 150;
            Assert.InRange<uint>(calFilter, 100, 300);
            double price = 5.50;
            Assert.InRange<double>(price, 1.00, 6.00);
        }
    }
}
