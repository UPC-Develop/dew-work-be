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
    [Route("api/contact")]
    [ApiController]
    public class ContactController : Controller
    {
        protected readonly IContactRepository _ContactRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ContactRepository"></param>
        public ContactController(IContactRepository ContactRepository)
        {
            _ContactRepository = ContactRepository;
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpPost]
        [Route("savecontact")]
        public ActionResult SaveContact([FromBody] EntityContact entityContact)//string phone, string email)
        {
            var ret = _ContactRepository.SaveContact(entityContact);
            return Json(ret);
        }

    }
}