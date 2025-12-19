using EcommerceCAPI.Data.Data;

namespace FirstMinimalAPI.Models
{
    public class Favourite
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Count { get; set; }
        public decimal BookPrice { get; set; }
    }
}
