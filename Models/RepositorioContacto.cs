namespace SistemasWeb01.Models
{
    public class RepositorioContacto : InterfazContacto
    {

        private readonly BethesdaPieShopDbContext _BethesdaPieShopDbContext;

        public RepositorioContacto(BethesdaPieShopDbContext BethesdaPieShopDbContext)
        {
            _BethesdaPieShopDbContext = BethesdaPieShopDbContext;
        }

        public IEnumerable<Contacto> AllCantactos => _BethesdaPieShopDbContext.Contactosdbcontex.OrderBy(c => c.NombreContacto);

        public void CreateContacto(Contacto contacto)
        {

            _BethesdaPieShopDbContext.Contactosdbcontex.Add(contacto);
            _BethesdaPieShopDbContext.SaveChanges();

        }
    }
}
