using System.Numerics;

namespace PruebaPro.Models
{
    public class Funcionarios
    {
        public int Id_funcionarios { get; set; }
        public int Id_tipoDocumento {  get; set; }
        public int NumeroIdentificacion {  get; set; }
        public BigInteger Telefono { get; set; }
        public int Fax { get; set; }
        public string Email { get; set;}
        public int Id_ubicacion { get; set; }
        public int PaginaWeb { get; set; }

    }
}
