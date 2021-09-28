using DBContext;
using DBEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSwag.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DEW.APIBusiness.API.Controllers
{
    [Produces("application/json")]
    [Route("api/offer")]

    public class OfferController : Controller
    {
        protected readonly IOfferRepository _OfferRepository;
        public OfferController(IOfferRepository item)
        {
            _OfferRepository = item;
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getoffers")]
        public ActionResult GetOffers()
        {
            var retorno = _OfferRepository.GetOffers();
            return Json(retorno);
        }

    }
}
