using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.LAB4;

namespace WebApplication1.Controllers.LAB4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController : Controller
    {
        [HttpGet]
        public string GetLang()
        {
            var lang = new Polish("pl");
            return lang.getLang();
        }
    }
}
