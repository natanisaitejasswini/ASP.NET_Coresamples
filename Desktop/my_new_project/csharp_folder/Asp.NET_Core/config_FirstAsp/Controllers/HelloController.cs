using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
 public class HelloController : Controller
 {
  [HttpGet]
  [Route("index")] //localhost5000/index
  public IActionResult Index()
  {
   return View();
  }
 }
}