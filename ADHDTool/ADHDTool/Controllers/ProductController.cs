using Microsoft.AspNetCore.Mvc;

namespace ADHDTool.Controllers
{
    
    public class ProductController : Controller
    {
        [Route("index/{string}")]
        public IActionResult Index(string i)
        {
            return View();
        }
    }
}
