using Basket.Application.Interfaces;
using Basket.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet("id")]
        public ActionResult<BasketModel> Get(int id)
        {
            var basket = _basketService.Get(id);
            if(basket == null)
            {
                return NotFound();
            }
            return basket;
        }

        [HttpPost]
        public ActionResult<BasketModel> Create(BasketModel model)
        {
            var createdSepet = _basketService.Create(model);
            return CreatedAtAction(nameof(Get), new { id = createdSepet.Id }, createdSepet);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, BasketModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }
            _basketService.Update(model);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _basketService.Delete(id);
            return NoContent();
        }
    }
}
