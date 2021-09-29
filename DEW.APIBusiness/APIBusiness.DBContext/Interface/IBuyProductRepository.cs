using DBEntity;
using DEW.APIBusiness.DBEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBusiness.DBContext.Interface
{
    public interface IBuyProductRepository
    {
        BaseResponse SaveBuyProduct(EntityBuyProduct entityBuyProduct);
    }
}