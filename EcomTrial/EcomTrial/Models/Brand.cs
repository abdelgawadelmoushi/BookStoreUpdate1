namespace EcomTrial.Models
{
    public class Brand
    {
        // Many
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }
        public string Img { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }

}
