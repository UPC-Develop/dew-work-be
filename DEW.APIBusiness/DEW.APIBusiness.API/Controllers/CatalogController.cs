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
    [Route("api/catalog")]
    public class CatalogController : Controller
    {
        protected readonly ICatalogRepository _CatalogRepository;
        public CatalogController(ICatalogRepository item)
        {
            _CatalogRepository = item;
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("getcatalog")]
        public IActionResult GetCatalog()
        {
            var retorno = _CatalogRepository.GetCatalog();
            return Json(retorno);
        }
    }
}
