using CQRS.Commands;
using CQRS.Data;
using CQRS.Handlers;
using CQRS.Models;
using CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var handler = new GetAllProductsQueryHandler();
            var products = handler.Handle(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("getallwithoutcqrs")]
        public IActionResult GetAllWithoutCQRS()
        {
            return Ok(ProductStore.Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var handler = new GetProductByIdQueryHandler();
            var product = handler.Handle(new GetProductByIdQuery { Id = id });
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateProductCommand command)
        {
            var handler = new CreateProductCommandHandler();
            var product = handler.Handle(command);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateProductCommand command)
        {
            command.Id = id;
            var handler = new UpdateProductCommandHandler();
            var product = handler.Handle(command);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var handler = new DeleteProductCommandHandler();
            var result = handler.Handle(new DeleteProductCommand { Id = id });
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
