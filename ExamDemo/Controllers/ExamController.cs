using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using Microsoft.AspNetCore.Mvc;


namespace ExamDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        public ExamController(IExamService examservice)
        {
            _examService = examservice;
        }
        [HttpPost]
        [Route("InsertExams")]
        public ActionResult InsertExams(Exams exams)
        {
            var result = _examService.AddExam(exams);
            return new JsonResult(result);
        }
    }
}
