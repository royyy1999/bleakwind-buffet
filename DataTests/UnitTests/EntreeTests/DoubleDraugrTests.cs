/*
 * Author: Zachery Brunner
 * Edited by: Roy Fernandez
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    { 
        [Fact]
        public void ShouldBeAbleToImplementINotifyPropertyChangedInterface()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }

        [Fact]
        public void ChangingBunNotifiesIceProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = true;
            });

            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesIceProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = true;
            });

            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesIceProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = true;
            });

            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesIceProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = true;
            });

            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesIceProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = true;
            });

            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesIceProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = true;
            });

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesIceProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = true;
            });

            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesIceProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = true;
            });

            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = false;
            });
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        [Fact]
        public void ShouldBeAbleToImplementInterface()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        { DoubleDraugr dd = new DoubleDraugr();
           
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);

        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);

        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(843.0, dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo)
            {
                Assert.Empty(dd.SpecialInstructions);
            }

            if (!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese && !includeTomato && !includeLettuce && !includeMayo)
            {
                Assert.Contains("Hold bun", dd.SpecialInstructions);
                Assert.Contains("Hold ketchup", dd.SpecialInstructions);
                Assert.Contains("Hold mustard", dd.SpecialInstructions);
                Assert.Contains("Hold pickle", dd.SpecialInstructions);
                Assert.Contains("Hold cheese", dd.SpecialInstructions);
                Assert.Contains("Hold lettuce", dd.SpecialInstructions);
                Assert.Contains("Hold tomato", dd.SpecialInstructions);
                Assert.Contains("Hold mayo", dd.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }
    }
}