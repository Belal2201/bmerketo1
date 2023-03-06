using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public string ArticleNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public string? Category { get; set; }
        public int Rating { get; set; }
        public string? ProductDescriptionShort { get; set; }
        public string? ProductDescriptionLong { get; set; }
        public string? ProductImageName { get; set; }
    }
}
