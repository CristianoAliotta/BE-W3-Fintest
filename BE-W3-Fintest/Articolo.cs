using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BE_W3_Fintest
{
    public class Articolo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public static List<Articolo> Catalog { get; set; } = new List<Articolo>();
        public static List<Articolo> Cart { get; set; } = new List<Articolo>();
        public static List<Articolo> GetList()
        {
            Articolo articolo1 = new Articolo
            {
                 Id = 1,
                Name = "GRANDADDY PLUTO - HHC DISPOSABLE VAPE",
                Price = 32.99,
                Description = "A brand new way to vape your favorite Cookies flavors." +
                " Our HHC Disposable Vape Pens are filled with a full gram of premium HHC distillate and terpenes inspired by exclusive Cookies strains. " +
                "Cookies HHC pens are ready to vape right out the box and never need a charge for an immediate and potent, long-lasting psychoactive experience." +
                " Grandaddy Pluto HHC Disposable Vapes feature a smooth dark berry flavor with a prominent minty finish and an aroma that combines bright blueberry and subtle menthol notes.",
                Img = "~/Img/Pluto.PNG" 
            };
            Articolo articolo2 = new Articolo
            {
                Id = 2,
                Name = "BERRY PIE - HHC DISPOSABLE VAPE",
                Price = 32.99,
                Description = "A brand new way to vape your favorite Cookies flavors." +
                " Our HHC Disposable Vape Pens are filled with a full gram of premium HHC distillate and terpenes inspired by exclusive Cookies strains." +
                " Cookies HHC pens are ready to vape right out the box and never need a charge for an immediate and potent, long-lasting psychoactive experience." +
                "Berry Pie HHC Disposable Vapes feature a smooth, fruity berry and cream flavor with a breakfast aroma bursting with floral notes and the wafting scent of blueberry waffle batter.",
                Img = "~/Img/BerryPie.PNG"
            };
            Articolo articolo3 = new Articolo
            {
                Id = 3,
                Name = "LONDON POUND CAKE 75 - DISPOSABLE VAPE",
                Price = 29.99,
                Description = "Elevated effects and full flavor in every hit." +
                " Cookies’ Delta 8 Disposable Vape Pens combine a full gram of premium Delta 8 distillate and terpenes inspired by your favorite Cookies flavors with ready-to-vape hardware that heats to the perfect temp and never needs a charge. " +
                "London Pound Cake 75 Delta 8 Disposable Vapes pack a flavorful punch of menthol and OG musk with a strong aroma of sweet blueberries, lemongrass, and gas for a euphoric experience that’s always ready.",
                Img = "~/Img/London.PNG"
            };
            Articolo articolo4 = new Articolo
            {
                Id = 4,
                Name = "CHEETAH PISS - HHC DISPOSABLE VAPE",
                Price = 32.99,
                Description = " A brand new way to vape your favorite Cookies flavors. " +
                "Our HHC Disposable Vape Pens are filled with a full gram of premium HHC distillate and terpenes inspired by exclusive Cookies strains. " +
                "Cookies HHC pens are ready to vape right out the box and never need a charge for an immediate and potent, long-lasting psychoactive experience." +
                "Cheetah Piss HHC Disposable Vapes feature a sweet gelato flavor on the front end with a funky, cakey finish on the exhale that fuels a strong funky lemon cake aroma.",
                Img = "~/Img/Cheeta.PNG"
            };
            Articolo articolo5 = new Articolo
            {
                Id = 5,
                Name = "PANCAKES - DELTA 8 DISPOSABLE VAPE",
                Price = 29.99,
                Description = "Elevated effects and full flavor in every hit." +
                " Cookies’ Delta 8 Disposable Vape Pens combine a full gram of premium Delta 8 distillate and terpenes inspired by your favorite Cookies flavors with ready-to-vape hardware that heats to the perfect temp and never needs a charge." +
                "Pancakes Delta 8 Disposable Vapes pack a flavorful punch of buttery sweet berries paired with the unmistakable aroma of hot-off-the-griddle blueberry pancakes for a euphoric experience that’s always ready.",
                Img = "~/Img/Pancakes.PNG"
            };
            Articolo articolo6 = new Articolo
            {
                Id = 6,
                Name = "GEORGIA PIE - HHC DISPOSABLE VAPE",
                Price = 32.99,
                Description = "A brand new way to vape your favorite Cookies flavors. " +
                "Our HHC Disposable Vape Pens are filled with a full gram of premium HHC distillate and terpenes inspired by exclusive Cookies strains." +
                " Cookies HHC pens are ready to vape right out the box and never need a charge for an immediate and potent, long-lasting psychoactive experience." +
                "Georgia Pie HHC Disposable Vapes feature a strong savory baked fruit flavor and a straight-out-the-oven peach cobbler aroma for a fresh-baked hit on every draw.",
                Img = "~/Img/Georgia.PNG"
            };
            Articolo articolo7 = new Articolo
            {
                Id = 7,
                Name = "HONEY BUN - HHC DISPOSABLE VAPE",
                Price = 32.99,
                Description = "A brand new way to vape your favorite Cookies flavors." +
                " Our HHC Disposable Vape Pens are filled with a full gram of premium HHC distillate and terpenes inspired by exclusive Cookies strains." +
                " Cookies HHC pens are ready to vape right out the box and never need a charge for an immediate and potent, long-lasting psychoactive experience." +
                "Honey Bun HHC Disposable Vapes are true to their name with a prominent honey glazed donut flavor accentuated by a head-turning citrus blossom and honey aroma.",
                Img = "~/Img/honey.PNG"
            };
            Articolo articolo8 = new Articolo
            {
                Id = 8,
                Name = "GRENADINE - HHC DISPOSABLE VAPE",
                Price = 32.99,
                Description = "A brand new way to vape your favorite Cookies flavors. " +
                "Our HHC Disposable Vape Pens are filled with a full gram of premium HHC distillate and terpenes inspired by exclusive Cookies strains." +
                " Cookies HHC pens are ready to vape right out the box and never need a charge for an immediate and potent, long-lasting psychoactive experience." +
                "Grenadine HHC Disposable Vapes feature a mouth-covering pomegranate and cherry flavor accentuated by a matching aroma of sweet pomegranates and cherries. ",
                Img = "~/Img/Grena.PNG"
            };
            Catalog.Add(articolo1);
            Catalog.Add(articolo2); 
            Catalog.Add(articolo3);
            Catalog.Add(articolo4);
            Catalog.Add(articolo5);
            Catalog.Add(articolo6);
            Catalog.Add(articolo7);
            Catalog.Add(articolo8);
            
                  
            return Catalog;
        } 



    }
}