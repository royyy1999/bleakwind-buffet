﻿/*
 * Author: Zachery Brunner
 * Edited by: Roy Fernandez
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ChangingSizeNotifiesIceProperty()
        {
            var fm = new FriedMiraak();

            Assert.PropertyChanged(fm, "Size", () =>
            {
                fm.Size = Size.Small;
            });

            Assert.PropertyChanged(fm, "Size", () =>
            {
                fm.Size = Size.Medium;
            });

            Assert.PropertyChanged(fm, "Size", () =>
            {
                fm.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPrice()
        {
            var fm = new FriedMiraak();

            Assert.PropertyChanged(fm, "Price", () =>
            {
                fm.Size = Size.Small;
            });

            Assert.PropertyChanged(fm, "Price", () =>
            {
                fm.Size = Size.Medium;
            });

            Assert.PropertyChanged(fm, "Price", () =>
            {
                fm.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCalories()
        {
            var fm = new FriedMiraak();

            Assert.PropertyChanged(fm, "Calories", () =>
            {
                fm.Size = Size.Small;
            });

            Assert.PropertyChanged(fm, "Calories", () =>
            {
                fm.Size = Size.Medium;
            });

            Assert.PropertyChanged(fm, "Calories", () =>
            {
                fm.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
        }

        [Fact]
        public void ShouldBeAbleToImplementInterface()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString());
        }
    }
}