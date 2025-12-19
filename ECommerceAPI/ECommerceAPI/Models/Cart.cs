using EcommerceCAPI.Data.Data;

namespace FirstMinimalAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int PoductId { get; set; }
        public Product Product { get; set; }
        
        public int Count { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
