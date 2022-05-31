using rpgcatalog_api.Entities;

namespace rpgcatalog_api.Repositories.Interfaces
{
    public interface IItemRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}
