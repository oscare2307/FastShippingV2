using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Producto: EntidadBase
    {
        public  int Id { get; set; }
        public  string Codigo { get; set; }
        public  string Descripcion { get; set; }
        public  string Marca { get; set; }
        public  string Categoria { get; set; }
        public  string Estado { get; set; }
    }
}
