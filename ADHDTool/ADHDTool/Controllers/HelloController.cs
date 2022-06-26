using Microsoft.AspNetCore.Mvc;

namespace ADHDTool.Controllers
{
    [Route("Hello")]
    public class HelloController : Controller
    {
        [Route("test")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
