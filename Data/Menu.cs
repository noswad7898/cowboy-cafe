using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Sides;
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
            BakedBeans bakedBeans = new BakedBeans();
            sides.Add(bakedBeans);
            ChiliCheeseFries chiliCheeseFries = new ChiliCheeseFries();
            sides.Add(chiliCheeseFries);
            CornDodgers cornDodgers = new CornDodgers();
            sides.Add(cornDodgers);
            PanDeCampo panDeCampo = new PanDeCampo();
            sides.Add(panDeCampo);
            return sides;
        }
        /// <summary>
        /// list of all drink items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            var drinks = new List<IOrderItem>();
            CowboyCoffee cowboyCoffee = new CowboyCoffee();
            drinks.Add(cowboyCoffee);
            JerkedSoda jerkedSoda = new JerkedSoda();
            drinks.Add(jerkedSoda);
            TexasTea texasTea = new TexasTea();
            drinks.Add(texasTea);
            Water water = new Water();
            drinks.Add(water);
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

            BakedBeans bakedBeans = new BakedBeans();
            all.Add(bakedBeans);
            ChiliCheeseFries chiliCheeseFries = new ChiliCheeseFries();
            all.Add(chiliCheeseFries);
            CornDodgers cornDodgers = new CornDodgers();
            all.Add(cornDodgers);
            PanDeCampo panDeCampo = new PanDeCampo();
            all.Add(panDeCampo);

            CowboyCoffee cowboyCoffee = new CowboyCoffee();
            all.Add(cowboyCoffee);
            JerkedSoda jerkedSoda = new JerkedSoda();
            all.Add(jerkedSoda);
            TexasTea texasTea = new TexasTea();
            all.Add(texasTea);
            Water water = new Water();
            all.Add(water);

            return (all);
        }

    }
}
