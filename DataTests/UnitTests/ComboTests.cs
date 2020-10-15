/*
 * Author: Roy Fernandez
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 */
using Xunit;
using System.Collections.Generic;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldBeAbleToImplementINotifyPropertyChangedInterface()
        {
            var c = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        [Fact]
        public void ShouldBeAbleToImplementIOrderItemInterface()
        {
            var o = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(o);
        }

        [Fact]
        public void ChangingEntreeNotifiesPrice()
        {
            Combo c = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Entree = bb;
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesCalories()
        {
            Combo c = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Entree = bb;
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesSpecialInstructions()
        {
            Combo c = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Entree = bb;
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesEntree()
        {
            Combo c = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = bb;
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesPrice()
        {
            Combo c = new Combo();
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink = ss;
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesCalories()
        {
            Combo c = new Combo();
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink = ss;
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesSpecialInstructions()
        {
            Combo c = new Combo();
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Drink = ss;
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesDrink()
        {
            Combo c = new Combo();
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = ss;
            });
        }

        [Fact]
        public void ChangingSideNotifiesPrice()
        {
            Combo c = new Combo();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = vs;
            });
        }


        [Fact]
        public void ChangingSideNotifiesCalories()
        {
            Combo c = new Combo();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side = vs;
            });
        }

        [Fact]
        public void ChangingSideNotifiesSpecialInsturctions()
        {
            Combo c = new Combo();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Side = vs;
            });
        }

        [Fact]
        public void ChangingSideNotifiesSide()
        {
            Combo c = new Combo();
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = vs;
            });      
        }
    }
}
