using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Talabat.BLL.Interfaces;
using Talabat.BLL.Specifications;
using Talabat.DAL.Entities;

namespace Talabat.API.Controllers
{

    public class ProductsController : BaseController
    {
        public IGenaricRepository<Product> ProductsRepository { get; }
        public ProductsController(IGenaricRepository<Product> ProductsRepository)
        {
            this.ProductsRepository = ProductsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts()
        {
            // var Products = await ProductsRepository.GetAllAsync();
            var specifitions = new ProductWithTypeAndBrandSpecifictions();
            var products = await ProductsRepository.GetAllWithSpecifitionAsync(specifitions);
            return  Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProduct(int id)
        {
            var specifitions = new ProductWithTypeAndBrandSpecifictions(id);
            var product = await ProductsRepository.GetByIdWithSpecifitionAsync(specifitions);
            return Ok(product);
        }



    }

}
