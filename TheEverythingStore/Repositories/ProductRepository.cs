using System;
using System.Linq;
using System.Collections.Generic;
using TheEverythingStore.Models;

namespace TheEverythingStore.Repositories {

   public class ProductRepository: IProductRepository {
      private readonly List<Product> products = new List<Product>() {

         // List of Products

         new Product {
            Sku   = 1017853,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 99.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1017862,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 119.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1017871,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 139.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1017899,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 159.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1017908,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 189.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1017917,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 219.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1017926,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 249.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1017935,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 279.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1017944,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 309.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1017953,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 349.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1018121,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 449.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1018237,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 499.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1018246,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 569.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1018255,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 599.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1018952,
            Name  = "Greenberg [DVD] [2010]",
            Price = 9.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1018/1018952_sa.jpg"
         },
         new Product {
            Sku   = 1018961,
            Name  = "Greenberg [Blu-ray] [2010]",
            Price = 9.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1018/1018961_sa.jpg"
         },
         new Product {
            Sku   = 1019003,
            Name  = "When the Game Stands Tall [Includes Digital Copy] [DVD] [2014]",
            Price = 7.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1019/1019003_sa.jpg"
         },
         new Product {
            Sku   = 1019005,
            Name  = "Cloudy with a Chance of Meatballs [3D] [Blu-ray] [Blu-ray/Blu-ray 3D] [2009]",
            Price = 5.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1019/1019005_sa.jpg"
         },
         new Product {
            Sku   = 1019012,
            Name  = "When the Game Stands Tall [2 Discs] [Includes Digital Copy] [Blu-ray/DVD] [2014]",
            Price = 9.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1019/1019012_sa.jpg"
         },
         new Product {
            Sku   = 1019021,
            Name  = "Day of the Mummy [DVD] [2014]",
            Price = 13.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1019/1019021_sa.jpg"
         },
         new Product {
            Sku   = 1019049,
            Name  = "Justified = The Complete Fifth Season [3 Discs] [Includes Digital Copy] [UltraViolet] [Blu-ray]",
            Price = 22.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1019/1019049_sa.jpg"
         },
         new Product {
            Sku   = 1019058,
            Name  = "Justified: The Complete Fifth Season [3 Discs] [DVD]",
            Price = 19.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1019/1019058_sa.jpg"
         },
         new Product {
            Sku   = 1019281,
            Name  = "Metra - Dash Kit for Select 2012-2013 Nissan Versa/Versa S/S+ and SV with no options - Black",
            Price = 16.99,
            Image = "https://pisces.bbystatic.com/prescaled/500/500/image2/BestBuy_US/images/products/1019/1019281_sa.jpg"
         },
         new Product {
            Sku   = 1019306,
            Name  = "Apple - MagSafe 60W Power Adapter for MacBook® and 13\" MacBook® Pro - White",
            Price = 79,
            Image = "https://pisces.bbystatic.com/prescaled/500/500/image2/BestBuy_US/images/products/1019/1019306_sa.jpg"
         },
         new Product {
            Sku   = 1019518,
            Name  = "Metra - 99-7803G Mounting Kit Replacement Pocket for 2003-2007 Honda Accord Vehicles - Black",
            Price = 16.99,
            Image = "https://pisces.bbystatic.com/prescaled/500/500/image2/BestBuy_US/images/products/1019/1019518_sa.jpg"
         },
         new Product {
            Sku   = 1019527,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 56.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019536,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 99.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019554,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 119.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019563,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 139.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019581,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 159.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019606,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 189.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019615,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 219.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019624,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 249.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019633,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 279.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019642,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 309.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019651,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 349.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019679,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 449.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019688,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 499.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019706,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 569.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 1019715,
            Name  = "5-Year Protection Plan - Geek Squad",
            Price = 599.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/nonsku/default_hardlines_l.jpg"
         },
         new Product {
            Sku   = 10198895,
            Name  = "Richard III [DVD] [1912]",
            Price = 22.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1019/10198895_sa.jpg"
         },
         new Product {
            Sku   = 1020017,
            Name  = "The Simpsons = The Seventeenth Season [4 Discs] [DVD]",
            Price = 21.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1020/1020017_sa.jpg"
         },
         new Product {
            Sku   = 1020205,
            Name  = "Metra - Double DIN Installation Kit for 2013 and Later Hyundai Santa Fe Vehicles - Black",
            Price = 49.99,
            Image = "https://pisces.bbystatic.com/prescaled/500/500/image2/BestBuy_US/images/products/1020/1020205_sa.jpg"
         },
         new Product {
            Sku   = 1020241,
            Name  = "Magikano = The Complete Series [S.A.V.E.] [2 Discs] [DVD]",
            Price = 13.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1020/1020241_sa.jpg"
         },
         new Product {
            Sku   = 1020278,
            Name  = "The Girl With the Dragon Tattoo [DVD] [2009]",
            Price = 4.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1020/1020278_sa.jpg"
         },
         new Product {
            Sku   = 1020296,
            Name  = "The Girl With the Dragon Tattoo [Blu-ray] [2009]",
            Price = 7.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1020/1020296_sa.jpg"
         },
         new Product {
            Sku   = 1020302,
            Name  = "Survival of the Dead [Ultimate Edition] [2 Discs] [DVD] [2009]",
            Price = 9.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1020/1020302_sa.jpg"
         },
         new Product {
            Sku   = 1020348,
            Name  = "DragonBall = Season Five [5 Discs] [DVD]",
            Price = 22.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1020/1020348_sa.jpg"
         },
         new Product {
            Sku   = 1020366,
            Name  = "Survival of the Dead [Blu-ray] [2009]",
            Price = 12.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1020/1020366_sa.jpg"
         },
         new Product {
            Sku   = 1020384,
            Name  = "RIN = Daughters of Mnemosyne - The Complete Series [2 Discs] [Blu-ray]",
            Price = 42.99,
            Image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1020/1020384_sa.jpg"
         }
      };

      public IEnumerable<Product> GetProducts() {
         return products;
      }

      public Product GetProduct(long sku) {
         return products.Where(product => product.Sku == sku).SingleOrDefault();
      }

      public void CreateProduct(Product product) {

         var existingProduct = this.GetProduct(product.Sku);
         
         if (existingProduct is null) {
            
            // Using the New() method to create a Product from another Product - [Extensions.cs].
            products.Add(product.New());
         
         }

      }
   }
}
