using rpgcatalog_api.Entities;

namespace rpgcatalog_api.Repositories.Interfaces
{
    public interface IItemRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();

        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }
}
