namespace ECommerce522.Areas.Admin.Views.ViewModel
{
    public class ProdVM
    {
        public List<Product> products { get; set; }=new List<Product>();
        public List<Category> categories { get; set; } = new List<Category>();
        public List<Brand> brands { get; set; } = new List<Brand>();

        public string? Name { get; set; }

       public int Page { get; set; }
       public decimal MinPrice { get; set; }


    }
}
