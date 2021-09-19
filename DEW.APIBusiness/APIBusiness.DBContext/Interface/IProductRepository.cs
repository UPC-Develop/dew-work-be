using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBusiness.DBContext.Interface
{
    public interface IProductRepository
    {
        BaseResponse GetProductByCategoryId(Int32 categoryId);
    }
}
