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
    [Route("api/subscription")]
    public class SubscriptionController : Controller
    {

        protected readonly ISubscriptionRepository _SubscriptionRepository;



        public SubscriptionController(ISubscriptionRepository SubscriptionRepository)
        {
            _SubscriptionRepository = SubscriptionRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullName"></param>
        /// /// <param name="email"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpPost]
        [Route("savesubscription")]
        public ActionResult SaveSubscription([FromBody] EntitySubscription entitySubscription)
        {
            var ret = _SubscriptionRepository.SaveSubscription(entitySubscription);
            return Json(ret);
        }


    }
}
