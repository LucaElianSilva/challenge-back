using challenge_back.Entities;
using challenge_back.Interfaces;
using challenge_back.Models;

namespace challenge_back.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;
        public ProductoService(IProductoRepository productoRepository) {
            _productoRepository = productoRepository;
        }

        public List<Producto> GetProductos() {
            return _productoRepository.GetAll().ToList();
        }
    }
}
