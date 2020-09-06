/* Author: Roy Fernandez
 * Class: Menu.cs
 * Purpose: 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
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
                    ss.Flavor = flavor;
                    ss.Size = size;
                    drink.Add(ss);
                }
            }


            SailorSoda ssS = new SailorSoda();
            ssS.Size = Size.Small;
            drink.Add(ssS);
            SailorSoda ssM = new SailorSoda();
            ssM.Size = Size.Medium;
            drink.Add(ssM);
            SailorSoda ssL = new SailorSoda();
            ssL.Size = Size.Large;
            drink.Add(ssL);

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

        public static IEnumerable<IOrderItem> FullMenu()
        {

        }
    }
}
