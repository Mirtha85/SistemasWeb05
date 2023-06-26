namespace SistemasWeb01.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; } = string.Empty;
        public string? DescripcionCategoria { get; set; }
        public List<Producto>? Productos { get; set; }
    }
}
