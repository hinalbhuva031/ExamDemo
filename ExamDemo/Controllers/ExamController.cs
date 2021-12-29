using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        [HttpPost]
        [Route("AddExams")]
        public ActionResult AddExams()
        {
            return new JsonResult();
        }

    }


}
