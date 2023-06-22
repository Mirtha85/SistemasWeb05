namespace SistemasWeb01.Models
{
    public interface InterfazContacto
    {
        IEnumerable<Contacto> AllCantactos { get; }

        void CreateContacto(Contacto contacto);
    }
}
