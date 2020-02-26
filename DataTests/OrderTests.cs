using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class OrderTests 
    {

        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public List<string> SpecialIntsructions { get; set; }
        }
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }
        // should be able to add items
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }
        // shold be able to remove items
        [Fact]
        public void ShouldBeAbleToGetEnumerationOfItems()
        {
            var order = new Order();
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item1);
            Assert.Collection(order.Items,
            item => Assert.Equal( item0, item ),
            item => Assert.Equal( item1, item ),
            item => Assert.Equal( item2, item ));
        }
        // should be able to get Getting enumeration of items
        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0, 0, 0 })]
        [InlineData(new double[] { 199.34, 799 })]
        [InlineData(new double[] { 798 })]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] { -4, 10, 8 })]
        [InlineData(new double[] {3.14125975})]
        [InlineData(new double[] { double.NaN})]
        public void SubtotalShouldBeTheSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem(){Price = price});
            }
        }
        // subtotal should be the sum of item prices
        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        public void AddingAnItemShoulTriggerPropertyChangedForPrice(string propertyname)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyname, () =>
            {
                order.Add(item);
            });
        }
        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        public void RemovingAnItemShoulTriggerPropertyChangedForPrice(string propertyname)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyname, () =>
            {
                order.Remove(item);
            });
        }
        //? should trigger PropertyVhanged for Price
        //? should trigger PropertyVhanged for Items
    }
}
