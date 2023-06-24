using Microsoft.EntityFrameworkCore;

namespace SistemasWeb01.Models
{
    public class RepositorioCategoria : InterfazCategoria
    {
        private readonly BethesdaPieShopDbContext _bethesdaPieShopDbContext;

        public RepositorioCategoria(BethesdaPieShopDbContext bethesdaPieShopDbContext)
        {
            _bethesdaPieShopDbContext = bethesdaPieShopDbContext;
        }
        public IEnumerable<Categoria> Categorias => _bethesdaPieShopDbContext.Categoriasdb.ToList();
        /* Buscar por ID*/
        public Categoria GetcatById(int id)
        {
            return  _bethesdaPieShopDbContext.Categoriasdb.FirstOrDefault(p => p.CategoriaId == id);
        }
        public IEnumerable<Categoria> AllCategorias => _bethesdaPieShopDbContext.Categoriasdb.OrderBy(p => p.NombreCategoria);
        public void CreateCategoria(Categoria categoria)
        {
            categoria.Productos = new List<Producto>();
            _bethesdaPieShopDbContext.Categoriasdb.Add(categoria);
            _bethesdaPieShopDbContext.SaveChanges();

        }
        public void UpdateCategoria(Categoria categoria)
        {
            categoria.Productos = new List<Producto>();
            _bethesdaPieShopDbContext.Categoriasdb.Update(categoria);
            _bethesdaPieShopDbContext.SaveChanges();

        }
        public void DeleteCategoria(Categoria categoria)
        {
            categoria.Productos = new List<Producto>();
            _bethesdaPieShopDbContext.Categoriasdb.Remove(categoria);
            _bethesdaPieShopDbContext.SaveChanges();
        }
    }
}
