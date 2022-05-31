using Microsoft.AspNetCore.Mvc;
using rpgcatalog_api.Entities;
using rpgcatalog_api.Repositories;

namespace rpgcatalog_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController: ControllerBase
    {
        private readonly InMemRepository repository;

        public ItemsController()
        {
            repository = new InMemRepository();
        }

        //GET /Items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }

        //GET /Items{id}
        [HttpGet("{id}")]
        public Item GetItem(Guid id)
        {
            return repository.GetItem(id);
        }
    }
}
