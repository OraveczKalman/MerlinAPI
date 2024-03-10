using MerlinAPI.CoreClasses;
using MerlinAPI.DataClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MerlinAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactFormController : ControllerBase
    {
        private SHA256Class crypt;
        private ContactDataClass contactDataClass = new();

        public ContactFormController()
        {
            crypt = new SHA256Class(ApiData.CryptPass);
        }


    }
}
