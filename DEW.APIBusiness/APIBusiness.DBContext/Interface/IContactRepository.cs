using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEW.APIBusiness.DBEntity.Model;

namespace APIBusiness.DBContext.Interface
{
    public interface IContactRepository
    {
        BaseResponse SaveContact(EntityContact entityContact);
    }
}
