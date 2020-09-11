/*
 * Author: Roy Fernandez
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;
using System.Collections.Generic;
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
            bool includesBB = false;
            bool includesDD = false;
            bool includesGO = false;
            bool includesPP = false;
            bool includesSS = false;
            bool includesTT = false;
            bool includesTB = false;

            int expLength = 7;

            IEnumerable<IOrderItem> entree = Menu.Entrees();
            List<IOrderItem> list = (List<IOrderItem>)entree;

            foreach (IOrderItem item in list)
            {
                if (item is BriarheartBurger)
                {
                    includesBB = true;
                }
                else if (item is DoubleDraugr) {
                    includesDD = true;
                }
                else if (item is GardenOrcOmelette)
                {
                    includesGO = true;
                }
                else if (item is PhillyPoacher)
                {
                    includesPP = true;
                }
                else if (item is SmokehouseSkeleton)
                {
                    includesSS = true;
                }
                else if (item is ThalmorTriple)
                {
                    includesTT = true;
                }
                else if (item is ThugsTBone)
                {
                    includesTB = true;
                }
            }

            Assert.True(includesBB);
            Assert.True(includesDD);
            Assert.True(includesGO);
            Assert.True(includesPP);
            Assert.True(includesSS);
            Assert.True(includesTT);
            Assert.True(includesTB);
            Assert.Equal(expLength, list.Count);

        }


        [Fact]
        public void ShouldHaveCorrectListOfSides()
        {
            bool includesDW = false;
            bool includesFM = false;
            bool includesMO = false;
            bool includesVS = false;

            int expLength = 12;

            IEnumerable<IOrderItem> side = Menu.Sides();
            List<IOrderItem> list = (List<IOrderItem>)side;

            foreach (IOrderItem item in list)
            {
                if (item is DragonbornWaffleFries)
                {
                    includesDW = true;
                }
                else if (item is FriedMiraak)
                {
                    includesFM = true;
                }
                else if (item is MadOtarGrits)
                {
                    includesMO = true;
                }
                else if (item is VokunSalad)
                {
                    includesVS = true;
                }
            }

            Assert.True(includesDW);
            Assert.True(includesFM);
            Assert.True(includesMO);
            Assert.True(includesVS);
            Assert.Equal(expLength, list.Count);
        }

        [Fact]
        public void ShouldHaveCorrectListOfDrinks()
        {

            bool includesAJ = false;
            bool includesCC = false;
            bool includesMM = false;
            bool includesSS = false;
            bool includesWW = false;

            int expLength = 30;

            IEnumerable<IOrderItem> drink = Menu.Drinks();
            List<IOrderItem> list = (List<IOrderItem>)drink;

            foreach (IOrderItem item in list)
            {
                if (item is AretinoAppleJuice)
                {
                    includesAJ = true;
                }
                else if (item is CandlehearthCoffee)
                {
                    includesCC = true;
                }
                else if (item is MarkarthMilk)
                {
                    includesMM = true;
                }
                else if (item is SailorSoda)
                {
                    includesSS = true;
                }
                else if (item is WarriorWater)
                {
                    includesWW = true;
                }          
            }

            Assert.True(includesAJ);
            Assert.True(includesCC);
            Assert.True(includesMM);
            Assert.True(includesSS);
            Assert.True(includesWW);
            Assert.Equal(expLength, list.Count);
        }
    

        
        [Fact]
        public void ShouldHaveCorrectListOfFullMenu()
        {
            int expLength = 49;
            IEnumerable<IOrderItem> menu = Menu.FullMenu();
            List<IOrderItem> list = (List<IOrderItem>)menu;

            Assert.Equal(expLength, list.Count);
        }
        
        
    }
}
        
