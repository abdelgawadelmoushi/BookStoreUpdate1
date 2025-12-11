using System.Threading.Tasks;

namespace CinemaTask.Repositories
{
    public class ProductSubImageRepository : Repository<ProductSubImage>
    {
        private readonly ApplicationDbContext _context = new();

        public void RemoveRange(IEnumerable<ProductSubImage> items)
        {
            _context.ProductSubImages.RemoveRange(items);
        }

        public async Task AddRangeAsync(IEnumerable<ProductSubImage> items, CancellationToken cancellationToken = default)
        {
            await _context.AddAsync(items, cancellationToken);
        }
    }
}
