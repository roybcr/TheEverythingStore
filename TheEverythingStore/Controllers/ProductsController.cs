using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheEverythingStore.Repositories;
using TheEverythingStore.Dtos;
using System.Threading.Tasks;
using TheEverythingStore.Models;
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

        // GET /products/{name}
        [HttpGet("{name}")]
        public async Task<IEnumerable<ProductDto>> Get(string name)
        {
            IEnumerable<Product> products = (await this.productRepository.GetProductsByName(name));
            return products.Select((p => p.AsProductDto()));
        }
    }
}
