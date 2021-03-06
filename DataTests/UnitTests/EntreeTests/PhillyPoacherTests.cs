﻿/*
 * Author: Zachery Brunner
 * Edited by: Roy Fernandez
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAbleToImplementINotifyPropertyChangedInterface()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pp);
        }

        [Fact]
        public void ChangingsSirloinNotifiesIceProperty()
        {
            var pp = new PhillyPoacher();

            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = true;
            });

            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = false;
            });
        }

        [Fact]
        public void ChangingsOnionNotifiesIceProperty()
        {
            var pp = new PhillyPoacher();

            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = true;
            });

            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = false;
            });
        }

        [Fact]
        public void ChangingsRollNotifiesIceProperty()
        {
            var pp = new PhillyPoacher();

            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = true;
            });

            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = false;
            });
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        [Fact]
        public void ShouldBeAbleToImplementInterface()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(784.0, pp.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;

            if(includeSirloin && includeOnion && includeRoll)
            {
                Assert.Empty(pp.SpecialInstructions);
            }

            if (!includeSirloin && !includeOnion && !includeRoll)
            {
                Assert.Contains("Hold sirloin", pp.SpecialInstructions);
                Assert.Contains("Hold onions", pp.SpecialInstructions);
                Assert.Contains("Hold roll", pp.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }
    }
}