using Microsoft.EntityFrameworkCore;

namespace SistemasWeb01.Models
{
    public class RepositorioProducto : InterfazProducto
    {
        private readonly BethesdaPieShopDbContext _bethesdaPieShopDbContext;

        public RepositorioProducto(BethesdaPieShopDbContext BethesdaPieShopDbContext)
        {
            _bethesdaPieShopDbContext = BethesdaPieShopDbContext;
        }
        public Producto? GetcatById(int id)
        {
            return _bethesdaPieShopDbContext.Productosdb.FirstOrDefault(p => p.ProductoId == id);
        }
        public void agregar(Producto producto)
        {
            _bethesdaPieShopDbContext.Productosdb.Add(producto);
            _bethesdaPieShopDbContext.SaveChanges();
        }
        public void UpdateProducto(Producto producto)
        {

            try
            {
                _bethesdaPieShopDbContext.Productosdb.Update(producto);
                _bethesdaPieShopDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Delete(Producto producto)
        {

            _bethesdaPieShopDbContext.Productosdb.Remove(producto);
            _bethesdaPieShopDbContext.SaveChanges();

        }
        public void Deletet(Producto producto)
        {

            _bethesdaPieShopDbContext.Productosdb.Update(producto);
            _bethesdaPieShopDbContext.SaveChanges();

        }
        //extraer a todos los productos
        public IEnumerable<Producto> AllProductos
        {
            get
            {
                return _bethesdaPieShopDbContext.Productosdb.Include(c => c.Categoria);
            }
        }
        public IEnumerable<Producto> productosList => _bethesdaPieShopDbContext.Productosdb.ToList();
        public IEnumerable<Producto> filtroDelete => _bethesdaPieShopDbContext.Productosdb.ToList();
        public IEnumerable<Producto> listaproducto()
        {
            return _bethesdaPieShopDbContext.Productosdb.ToList();
        }
    }
}
