using challenge_back.Entities;

namespace challenge_back.Interfaces
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetAll();
    }
}
