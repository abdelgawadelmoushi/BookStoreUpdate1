public class UpdateProductDto
{
    public bool Status { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string MainImg { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public int Quantity { get; set; }
    public double Rate { get; set; }
    public int BrandId { get; set; }
    public int CategoryId { get; set; }
    public string ImgPath { get; set; }

}
