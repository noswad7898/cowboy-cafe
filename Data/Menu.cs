using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Sides;

using CowboyCafe.Data.Enums;
/// <summary>
/// Author: Dawson Field
/// Class: Manu.cs
/// About: Refactors all menu items in the data project into lists for each item type and a list for all items
/// </summary>
namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// List of all entree items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            var entrees = new List<IOrderItem>();
            AngryChicken angryChicken = new AngryChicken();
            entrees.Add(angryChicken);
            CowpokeChili cowpokeChili = new CowpokeChili();
            entrees.Add(cowpokeChili);
            PecosPulledPork pecosPulledPork = new PecosPulledPork();
            entrees.Add(pecosPulledPork);
            RustlersRibs rustlersRibs = new RustlersRibs();
            entrees.Add(rustlersRibs);
            TrailBurger trailBurger = new TrailBurger();
            entrees.Add(trailBurger);
            DakotaDoubleBurger dakotaDoubleBurger = new DakotaDoubleBurger();
            entrees.Add(dakotaDoubleBurger);
            TexasTripleBurger texasTripleBurger = new TexasTripleBurger();
            entrees.Add(texasTripleBurger);
            return entrees;
        }
        /// <summary>
        /// lis tof all side items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            var sides = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                BakedBeans bakedBeans = new BakedBeans();
                bakedBeans.Size = size;
                sides.Add(bakedBeans);
                ChiliCheeseFries chiliCheeseFries = new ChiliCheeseFries();
                chiliCheeseFries.Size = size;
                sides.Add(chiliCheeseFries);
                CornDodgers cornDodgers = new CornDodgers();
                cornDodgers.Size = size;
                sides.Add(cornDodgers);
                PanDeCampo panDeCampo = new PanDeCampo();
                panDeCampo.Size = size;
                sides.Add(panDeCampo);
            }
            return sides;
        }
        /// <summary>
        /// list of all drink items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            var drinks = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                CowboyCoffee cowboyCoffee = new CowboyCoffee();
                cowboyCoffee.Size = size;
                drinks.Add(cowboyCoffee);
                JerkedSoda jerkedSoda = new JerkedSoda();
                jerkedSoda.Size = size;
                drinks.Add(jerkedSoda);
                TexasTea texasTea = new TexasTea();
                texasTea.Size = size;
                drinks.Add(texasTea);
                Water water = new Water();
                water.Size = size;
                drinks.Add(water);
            }
            return drinks;
        }
        /// <summary>
        /// list of all menu items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            var all = new List<IOrderItem>();
            AngryChicken angryChicken = new AngryChicken();
            all.Add(angryChicken);
            CowpokeChili cowpokeChili = new CowpokeChili();
            all.Add(cowpokeChili);
            PecosPulledPork pecosPulledPork = new PecosPulledPork();
            all.Add(pecosPulledPork);
            RustlersRibs rustlersRibs = new RustlersRibs();
            all.Add(rustlersRibs);
            TrailBurger trailBurger = new TrailBurger();
            all.Add(trailBurger);
            DakotaDoubleBurger dakotaDoubleBurger = new DakotaDoubleBurger();
            all.Add(dakotaDoubleBurger);
            TexasTripleBurger texasTripleBurger = new TexasTripleBurger();
            all.Add(texasTripleBurger);
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                BakedBeans bakedBeans = new BakedBeans();
                bakedBeans.Size = size;
                all.Add(bakedBeans);
                ChiliCheeseFries chiliCheeseFries = new ChiliCheeseFries();
                chiliCheeseFries.Size = size;
                all.Add(chiliCheeseFries);
                CornDodgers cornDodgers = new CornDodgers();
                cornDodgers.Size = size;
                all.Add(cornDodgers);
                PanDeCampo panDeCampo = new PanDeCampo();
                panDeCampo.Size = size;
                all.Add(panDeCampo);

                CowboyCoffee cowboyCoffee = new CowboyCoffee();
                cowboyCoffee.Size = size;
                all.Add(cowboyCoffee);
                JerkedSoda jerkedSoda = new JerkedSoda();
                jerkedSoda.Size = size;
                all.Add(jerkedSoda);
                TexasTea texasTea = new TexasTea();
                texasTea.Size = size;
                all.Add(texasTea);
                Water water = new Water();
                water.Size = size;
                all.Add(water);
            }
            return (all);
        }

    }
}
