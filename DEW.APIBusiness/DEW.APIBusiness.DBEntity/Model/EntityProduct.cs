using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEW.APIBusiness.DBEntity.Model
{
    public class EntityProduct : EntityBase
    {
        public Int32 ProductId { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public String Weight { get; set; }

        public Int32 CategoryId { get; set; }

    }
}
