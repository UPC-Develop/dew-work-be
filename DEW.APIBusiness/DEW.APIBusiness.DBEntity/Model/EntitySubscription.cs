using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBEntity;

namespace DEW.APIBusiness.DBEntity.Model
{
    class EntitySubscription : EntityBase
    {
        public String FullName { get; set; }
        public String Email { get; set; }
    }
}
