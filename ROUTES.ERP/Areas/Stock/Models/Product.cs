namespace ROUTES.ERP.Areas.Stock.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
