using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta2.Models
{
    class Clientes
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string Sexo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string RFC { get; set; }
        public string Marca { get; internal set; }
        public string Cantidad { get; internal set; }
        public string PrecioCompra { get; internal set; }
        public string PrecioVenta { get; internal set; }
        public string Categoria { get; internal set; }
    }
}
