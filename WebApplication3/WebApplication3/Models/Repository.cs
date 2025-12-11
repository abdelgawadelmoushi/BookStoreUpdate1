namespace WebApplication3.Models
{
    public class Repository
    {
    public static List <Product> ProductList = new List <Product> ();
        public static IEnumerable<Product> GetProducts()=> ProductList;

        public static void addProduct (Product product)
        {

            ProductList.Add (product);
        }
    }
}
