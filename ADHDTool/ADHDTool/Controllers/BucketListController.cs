using ADHDTool.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADHDTool.Controllers
{
    public class BucketListController : Controller
    {
        private BucketlistService _bucketListService = new BucketlistService();
        public IActionResult Index()
        {
            
            _bucketListService.addBucketListEntry("lol");
            var bucketList = _bucketListService.GetBucketList();
            return View(bucketList);
        }
        [Route("addEntry")]
        public IActionResult addEntry()
        {
            
            var bucketList = _bucketListService.GetBucketList();
            return View(bucketList);
        }
    }
}
