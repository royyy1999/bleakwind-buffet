/* Author: Roy Fernandez
 * Class: Menu.cs
 * Purpose: This class represents the menu of all possible items
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {

        /// <summary>
        /// Returns a List of all entrees offered
        /// </summary>
        /// <returns>A List of entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();
            entree.Add(bb);

            DoubleDraugr dd = new DoubleDraugr();
            entree.Add(dd);

            GardenOrcOmelette go = new GardenOrcOmelette();
            entree.Add(go);

            PhillyPoacher pp = new PhillyPoacher();
            entree.Add(pp);

            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            entree.Add(ss);

            ThalmorTriple tt = new ThalmorTriple();
            entree.Add(tt);

            ThugsTBone tb = new ThugsTBone();
            entree.Add(tb);

            return entree;
        }

        /// <summary>
        /// Returns a List of sides offered
        /// </summary>
        /// <returns>A List of sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> side = new List<IOrderItem>();

            DragonbornWaffleFries dfS = new DragonbornWaffleFries();
            dfS.Size = Size.Small;
            side.Add(dfS);
            DragonbornWaffleFries dfM = new DragonbornWaffleFries();
            dfM.Size = Size.Medium;
            side.Add(dfM);
            DragonbornWaffleFries dfL = new DragonbornWaffleFries();
            dfL.Size = Size.Large;
            side.Add(dfL);

            FriedMiraak fmS = new FriedMiraak();
            fmS.Size = Size.Small;
            side.Add(fmS);
            FriedMiraak fmM = new FriedMiraak();
            fmM.Size = Size.Medium;
            side.Add(fmM);
            FriedMiraak fmL = new FriedMiraak();
            fmL.Size = Size.Large;
            side.Add(fmL);

            MadOtarGrits mgS = new MadOtarGrits();
            mgS.Size = Size.Small;
            side.Add(mgS);
            MadOtarGrits mgM = new MadOtarGrits();
            mgM.Size = Size.Medium;
            side.Add(mgM);
            MadOtarGrits mgL = new MadOtarGrits();
            mgL.Size = Size.Large;
            side.Add(mgL);

            VokunSalad vsS = new VokunSalad();
            vsS.Size = Size.Small;
            side.Add(vsS);
            VokunSalad vsM = new VokunSalad();
            vsM.Size = Size.Medium;
            side.Add(vsM);
            VokunSalad vsL = new VokunSalad();
            vsL.Size = Size.Large;
            side.Add(vsL);

            return side;
        }

        /// <summary>
        /// Returns a List of all drinks offered
        /// </summary>
        /// <returns>A List of drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drink = new List<IOrderItem>();

            AretinoAppleJuice ajS = new AretinoAppleJuice();
            ajS.Size = Size.Small;
            drink.Add(ajS);
            AretinoAppleJuice ajM = new AretinoAppleJuice();
            ajM.Size = Size.Medium;
            drink.Add(ajM);
            AretinoAppleJuice ajL = new AretinoAppleJuice();
            ajL.Size = Size.Large;
            drink.Add(ajL);

            CandlehearthCoffee ccS = new CandlehearthCoffee();
            ccS.Size = Size.Small;
            drink.Add(ccS);
            CandlehearthCoffee ccM = new CandlehearthCoffee();
            ccM.Size = Size.Medium;
            drink.Add(ccM);
            CandlehearthCoffee ccL = new CandlehearthCoffee();
            ccL.Size = Size.Large;
            drink.Add(ccL);

            MarkarthMilk mmS = new MarkarthMilk();
            mmS.Size = Size.Small;
            drink.Add(mmS);
            MarkarthMilk mmM = new MarkarthMilk();
            mmM.Size = Size.Medium;
            drink.Add(mmM);
            MarkarthMilk mmL = new MarkarthMilk();
            mmL.Size = Size.Large;
            drink.Add(mmL);
       
            foreach(string flavor in Enum.GetNames(typeof(SodaFlavor)))
            {
                foreach (string size in Enum.GetNames(typeof(Size)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Flavor = (SodaFlavor)Enum.Parse(typeof(SodaFlavor), flavor);
                    ss.Size = (Size)Enum.Parse(typeof(Size), size);
                    drink.Add(ss);
                }
            }

            WarriorWater wwS = new WarriorWater();
            wwS.Size = Size.Small;
            drink.Add(wwS);
            WarriorWater wwM = new WarriorWater();
            wwM.Size = Size.Medium;
            drink.Add(wwM);
            WarriorWater wwL = new WarriorWater();
            wwL.Size = Size.Large;
            drink.Add(wwL);

            return drink;
        }

        /// <summary>
        /// Returns a List of the full menu of the restraunt
        /// </summary>
        /// <returns>A List of the full menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> wholeMenu = new List<IOrderItem>();
            wholeMenu.AddRange(Entrees());
            wholeMenu.AddRange(Sides());
            wholeMenu.AddRange(Drinks());

            return wholeMenu;
        }

        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> list, string s)
        {
            List<IOrderItem> result = new List<IOrderItem>();
            
            if(s == null)
            {
                return FullMenu();
            }

            foreach(IOrderItem item in list)
            {
                if (item.ToString() != null && item.ToString().ToLower().Contains(s.ToLower()))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> list, IEnumerable<string> s)
        {
            if (s == null || s.Count() == 0)
            {
                return list;
            }

            var result = new List<IOrderItem>();

            foreach(IOrderItem item in list)
            {
                if (s.Contains("Entree"))
                {
                    if(item is Entree)
                    {
                        result.Add(item);
                    }
                }
                if (s.Contains("Side"))
                {
                    if (item is Side)
                    {
                        result.Add(item);
                    }
                }
                if (s.Contains("Drink"))
                {
                    if (item is Drink)
                    {
                        result.Add(item);
                    }
                }
            }

            return result;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> item, int? min, int? max)
        {
            if (min == null && max == null) return item;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem food in FullMenu())
                {
                    if (food.Calories <= max) results.Add(food);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem food in FullMenu())
                {
                    if (food.Calories >= min) results.Add(food);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem food in FullMenu())
            {
                if (food.Calories >= min && food.Calories <= max)
                {
                    results.Add(food);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> item, double? min, double? max)
        {
            if (min == null && max == null) return item;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem food in FullMenu())
                {
                    if (food.Price <= max) results.Add(food);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem food in FullMenu())
                {
                    if (food.Price >= min) results.Add(food);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem food in FullMenu())
            {
                if (food.Price >= min && food.Price <= max)
                {
                    results.Add(food);
                }
            }
            return results;

        }

    }
}

