using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class Menu : BaseEntity
    {
        [Key]
        public int IdMenu { get; set; }
        public String? Descripcion { get; set; }
        public int IdMenuPadre { get; set; }
        public String Icono { get; set; }
        public String? Controlador { get; set; }
        public String? PaginaAccion { get; set; }
    }
}
