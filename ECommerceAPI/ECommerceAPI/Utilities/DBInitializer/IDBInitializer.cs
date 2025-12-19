using System.Threading.Tasks;

namespace FirstMinimalAPI.Utilities.DBInitializer
{
    public interface IDBInitializer
    {
        Task InitializeAsync();
    }
}
