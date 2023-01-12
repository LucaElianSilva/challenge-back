using challenge_back.Entities;
using challenge_back.Interfaces;
using challenge_back.Models;

namespace challenge_back.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ChallengeContext _dbContext;
        public ProductoRepository(ChallengeContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<Producto> GetAll() {
            return _dbContext.Productos;
        }
    }
}
