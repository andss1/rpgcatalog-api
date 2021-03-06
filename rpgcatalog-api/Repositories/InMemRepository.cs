using rpgcatalog_api.Entities;
using rpgcatalog_api.Repositories.Interfaces;
using System.Linq;

namespace rpgcatalog_api.Repositories
{
    public class InMemRepository: IItemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item {Id = Guid.NewGuid(), Name = "Poção de cura", Price = 50, CreateDate = DateTime.UtcNow},
            new Item {Id = Guid.NewGuid(), Name = "Poção de mana", Price = 100, CreateDate = DateTime.UtcNow},
            new Item {Id = Guid.NewGuid(), Name = "Espada dracônica", Price = 2000, CreateDate = DateTime.UtcNow}
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }
        
        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var idx = items.FindIndex(existingItem => existingItem.Id == item.Id);
            items[idx] = item;
        }

        public void DeleteItem(Guid id)
        {
            var idx = items.FindIndex(existingItem => existingItem.Id == id);
            items.RemoveAt(idx);
        }
    }
}
