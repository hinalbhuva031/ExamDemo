using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using Microsoft.AspNetCore.Mvc;
using System;

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
        [Route("InsertExam")]
        public ActionResult InsertExam([FromBody] Exams exams)
        {
            var result = _examService.AddExam(exams);
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("GetExam/{examUniqueName}")]
        public ActionResult GetExam(Guid examUniqueName)
        {
            var result = _examService.GetExam(examUniqueName);
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("GetExams")]
        public ActionResult GetExams()
        {
            var exams = _examService.GetExams();
            return new JsonResult(exams);
        }

        [HttpPost]
        [Route("{examUniqueName}/examInstances")]
        public ActionResult CreateExamInstance(Guid examUniqueName)
        {
            var exam = _examService.CreateExamInstance(examUniqueName);
            return new JsonResult(exam);
        }
    }
}
