using System.ComponentModel.DataAnnotations;

namespace ROUTES.ERP.Areas.Stock.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Description { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Category { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
