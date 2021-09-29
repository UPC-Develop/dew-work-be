using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBEntity;

namespace DEW.APIBusiness.DBEntity.Model
{
    public class EntityBuyProduct
    {
        public String tipodocumento { get; set; }
        public String nrodocumento { get; set; }
        public String nombre { get; set; }
        public String direccion { get; set; }
        public String distrito { get; set; }
        public String departamento { get; set; }
        public String provincia { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public String articulo { get; set; }
        public int cantidad { get; set; }
        public decimal costo { get; set; }
        public decimal total { get; set; }
    }
}
