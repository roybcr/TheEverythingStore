using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheEverythingStore.Repositories;
using TheEverythingStore.Dtos;
using TheEverythingStore.Models;

namespace TheEverythingStore.Controllers {

   [ApiController]
   [Route("products")]
   public class ProductsController: ControllerBase {

      private readonly IProductRepository productRepository;

      public ProductsController(IProductRepository repository) {
         this.productRepository = repository;
      }

      // GET /products
      [HttpGet]
      public IEnumerable<ProductDto> Get() {
         return productRepository.GetProducts().Select(p => p.AsProductDto());
      }

      // GET /products/{sku}
      [HttpGet("{sku}")]
      public ActionResult<ProductDto> Get(long sku) {

         var product = productRepository.GetProduct(sku);
         return product is null ? (NotFound()) : (product.AsProductDto());

      }

      // POST /products
      [HttpPost]
      public ActionResult<ProductDto> Create(ProductInfoDto productInfo) {

         Product product = new() {
            Sku   = productInfo.Sku,
            Name  = productInfo.Name,
            Price = productInfo.Price,
            Image = productInfo.Image
         };

         productRepository.CreateProduct(product);

         return CreatedAtAction(nameof(Get), new {
            Sku = product.Sku
         }, product.AsProductDto());

      }
   }
}
