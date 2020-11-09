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

        [Theory]
        [InlineData("Burger")]
        [InlineData("ar")]
        [InlineData("Small")]
        public void MenuCanBeFilteredBySearch(string word)
        {
            List<IOrderItem> menu = (List<IOrderItem>)Menu.FullMenu();
            Assert.Contains(Menu.Search(menu, word), (item) => { return item.ToString().Equals("Briarheart Burger"); });
        }

        [Theory]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
        public void MenuCanBeFilteredByCategory(string type)
        {
            List<IOrderItem> menu = (List<IOrderItem>)Menu.FullMenu();
            List<string> name = new List<string>();
            name.Add(type);
            Assert.Contains(Menu.FilterByCategory(menu, name), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });
        }

        [Fact]
        public void MenuCanBeFilteredByCalories()
        {
            IEnumerable<IOrderItem> food = Menu.FilterByPrice(Menu.FullMenu(), 1, 980);
            Assert.Collection<IOrderItem>(food, item => item.ToString().Contains("Briarheart Burger"),
                item => item.ToString().Contains("Double Draugr"),
                item => item.ToString().Contains("Garden Orc Omelette"),
                item => item.ToString().Contains("Philly Poacher"),
                item => item.ToString().Contains("Smokehouse Skeleton"),
                item => item.ToString().Contains("Thalmor Triple"),

                item => item.ToString().Contains("Small Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Medium Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Large Dragonborn Waffle"),

                item => item.ToString().Contains("Small Fried Miraak"),
                item => item.ToString().Contains("Medium Fried Miraak"),
                item => item.ToString().Contains("Large Fried Miraak"),

                item => item.ToString().Contains("Small Mad Otar Grits"),
                item => item.ToString().Contains("Medium Mad Otar Grits"),
                item => item.ToString().Contains("Large Mad Otar Grits"),

                item => item.ToString().Contains("Small Vokun Salad"),
                item => item.ToString().Contains("Medium Vokun Salad"),
                item => item.ToString().Contains("Large Vokun Salad"),

                item => item.ToString().Contains("Small Aretino Apple Juice"),
                item => item.ToString().Contains("Medium Aretino Apple Juice"),
                item => item.ToString().Contains("Large Aretino Apple Juice"),

                item => item.ToString().Contains("Small CandleHearth Coffee"),
                item => item.ToString().Contains("Medium CandleHearth Coffee"),
                item => item.ToString().Contains("Large CandleHearth Coffee"),

                item => item.ToString().Contains("Small Markath Milk"),
                item => item.ToString().Contains("Medium Markath Milk"),
                item => item.ToString().Contains("Large Markath Milk"),

                item => item.ToString().Contains("Small Blackberry Sailor Soda"),
                item => item.ToString().Contains("Medium Blackberry Sailor Soda"),
                item => item.ToString().Contains("Large Blackberry Sailor Soda"),

                item => item.ToString().Contains("Small Cherry Sailor Soda"),
                item => item.ToString().Contains("Medium Cherry Sailor Soda"),
                item => item.ToString().Contains("Large Cherry Sailor Soda"),

                item => item.ToString().Contains("Small Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Medium Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Large Grapefruit Sailor Soda"),

                item => item.ToString().Contains("Small Lemon Sailor Soda"),
                item => item.ToString().Contains("Medium Lemon Sailor Soda"),
                item => item.ToString().Contains("Large Lemon Sailor Soda"),

                item => item.ToString().Contains("Small Peach Sailor Soda"),
                item => item.ToString().Contains("Medium Peach Sailor Soda"),
                item => item.ToString().Contains("Large Peach Sailor Soda"),

                item => item.ToString().Contains("Small Watermelon Sailor Soda"),
                item => item.ToString().Contains("Medium Watermelon Sailor Soda"),
                item => item.ToString().Contains("Large Watermelon Sailor Soda")
                );
        }

            [Fact]
        public void MenuCanBeFilteredByPrice()
        {
            IEnumerable<IOrderItem> food = Menu.FilterByPrice(Menu.FullMenu(), 0.01, 8.40);
            Assert.Collection<IOrderItem>(food, item => item.ToString().Contains("Briarheart Burger"),
                item => item.ToString().Contains("Double Draugr"),
                item => item.ToString().Contains("Garden Orc Omelette"),
                item => item.ToString().Contains("Philly Poacher"),
                item => item.ToString().Contains("Smokehouse Skeleton"),
                item => item.ToString().Contains("Thugs T-Bone"),

                item => item.ToString().Contains("Small Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Medium Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Large Dragonborn Waffle"),

                item => item.ToString().Contains("Small Fried Miraak"),
                item => item.ToString().Contains("Medium Fried Miraak"),
                item => item.ToString().Contains("Large Fried Miraak"),

                item => item.ToString().Contains("Small Mad Otar Grits"),
                item => item.ToString().Contains("Medium Mad Otar Grits"),
                item => item.ToString().Contains("Large Mad Otar Grits"),

                item => item.ToString().Contains("Small Vokun Salad"),
                item => item.ToString().Contains("Medium Vokun Salad"),
                item => item.ToString().Contains("Large Vokun Salad"),

                item => item.ToString().Contains("Small Aretino Apple Juice"),
                item => item.ToString().Contains("Medium Aretino Apple Juice"),
                item => item.ToString().Contains("Large Aretino Apple Juice"),

                item => item.ToString().Contains("Small CandleHearth Coffee"),
                item => item.ToString().Contains("Medium CandleHearth Coffee"),
                item => item.ToString().Contains("Large CandleHearth Coffee"),

                item => item.ToString().Contains("Small Markath Milk"),
                item => item.ToString().Contains("Medium Markath Milk"),
                item => item.ToString().Contains("Large Markath Milk"),

                item => item.ToString().Contains("Small Blackberry Sailor Soda"),
                item => item.ToString().Contains("Medium Blackberry Sailor Soda"),
                item => item.ToString().Contains("Large Blackberry Sailor Soda"),

                item => item.ToString().Contains("Small Cherry Sailor Soda"),
                item => item.ToString().Contains("Medium Cherry Sailor Soda"),
                item => item.ToString().Contains("Large Cherry Sailor Soda"),

                item => item.ToString().Contains("Small Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Medium Grapefruit Sailor Soda"),
                item => item.ToString().Contains("Large Grapefruit Sailor Soda"),

                item => item.ToString().Contains("Small Lemon Sailor Soda"),
                item => item.ToString().Contains("Medium Lemon Sailor Soda"),
                item => item.ToString().Contains("Large Lemon Sailor Soda"),

                item => item.ToString().Contains("Small Peach Sailor Soda"),
                item => item.ToString().Contains("Medium Peach Sailor Soda"),
                item => item.ToString().Contains("Large Peach Sailor Soda"),

                item => item.ToString().Contains("Small Watermelon Sailor Soda"),
                item => item.ToString().Contains("Medium Watermelon Sailor Soda"),
                item => item.ToString().Contains("Large Watermelon Sailor Soda")
                ); 
        }
    }
}
        
