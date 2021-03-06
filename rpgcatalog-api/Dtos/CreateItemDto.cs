using System.ComponentModel.DataAnnotations;

namespace rpgcatalog_api.Dtos
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; init; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; init; }
    }
}
