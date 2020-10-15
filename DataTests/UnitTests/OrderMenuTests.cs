/*
 * Author: Roy Fernandez
 * Class: OrderMenuTets.cs
 * Purpose: Test the OrderMenu.cs class in the Data library
 */
using Xunit;
using System.Collections.Generic;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderMenuTests
    {
        [Fact]
        public void ShouldBeAbleToImplementINotifyPropertyChangedInterface()
        {
            var c = new OrderMenu();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        public void ShouldAddItem()
        {

        }
    }
}
