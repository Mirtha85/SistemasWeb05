namespace SistemasWeb01.Models
{
    public interface InterfazCategoria
    {
        //IEnumerable ? permite que mas metodos que recopilen
        IEnumerable<Categoria> AllCategorias { get; }
        IEnumerable<Categoria> Categorias { get; }
        void CreateCategoria(Categoria categoria);
        void UpdateCategoria(Categoria categoria);
        void DeleteCategoria(Categoria categoria);
        Categoria? GetcatById(int productoId);
    }
}
