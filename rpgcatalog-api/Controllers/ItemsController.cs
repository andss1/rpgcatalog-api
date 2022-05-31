using Microsoft.AspNetCore.Mvc;
using rpgcatalog_api.Dtos;
using rpgcatalog_api.Entities;
using rpgcatalog_api.Repositories;
using rpgcatalog_api.Repositories.Interfaces;

namespace rpgcatalog_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController: ControllerBase
    {
        private readonly IItemRepository repository;

        public ItemsController(IItemRepository repository)
        {
            this.repository = repository;
        }

        //GET /Items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            return repository.GetItems().Select(item => item.AsDto());
        }

        //GET /Items{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if (item is null)
                return NotFound();

            return item.AsDto();
        }
    }
}
