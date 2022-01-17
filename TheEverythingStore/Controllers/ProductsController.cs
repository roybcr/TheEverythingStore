using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheEverythingStore.Repositories;
using TheEverythingStore.Dtos;

namespace TheEverythingStore.Controllers
{

    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {

        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository repository)
        {
            this.productRepository = repository;
        }

        // GET /products
        [HttpGet]
        public IEnumerable<ProductDto> Get()
        {
            return productRepository.GetProducts().Select(p => p.AsProductDto());
        }

        // GET /products/{sku}
        [HttpGet("{sku}")]
        public ActionResult<ProductDto> Get(long sku)
        {

            var product = productRepository.GetProduct(sku);
            return product is null ? (NotFound()) : (product.AsProductDto());

        }
    }
}
