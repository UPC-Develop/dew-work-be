using APIBusiness.DBContext.Interface;
using DEW.APIBusiness.DBEntity.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEW.APIBusiness.API.Controllers
{
    [Produces("application/json")]
    [Route("api/buyproduct")]
    public class BuyProductController : Controller
    {
        protected readonly IBuyProductRepository _BuyProductRepository;

        public BuyProductController(IBuyProductRepository BuyProductRepository)
        {
            _BuyProductRepository = BuyProductRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpPost]
        [Route("savebuyproduct")]
        public ActionResult SaveBuyProduct([FromBody] EntityBuyProduct entityBuyProduct)
        {
            var ret = _BuyProductRepository.SaveBuyProduct(entityBuyProduct);
            return Json(ret);
        }
    }
}
