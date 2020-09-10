/*
 * Author: Roy Fernandez
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldHaveCorrectListOfEntrees()
        {
            Assert.Collection<Entree>(Menu.Entrees());
            
        }

        [Fact]
        public void ShouldHaveCorrectListOfSides()
        {
            Assert.Collection<Side>();
        }

        [Fact]
        public void ShouldHaveCorrectListOfDrinks()
        {
            Assert.Collection<Drink>();
        }

        [Fact]
        public void ShouldHaveCorrectListOfFullMenu()
        {
            Assert.Collection<IOrderItem>(Menu.FullMenu());
        }
    }
}
