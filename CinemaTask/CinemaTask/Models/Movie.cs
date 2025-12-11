namespace CinemaTask.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public string MainImg { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }

        public bool Status { get; set; } = true;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;

        public int CinemaId { get; set; }     // ✅ تم الإصلاح
        public Cinema Cinema { get; set; } = default!;
    }
}
