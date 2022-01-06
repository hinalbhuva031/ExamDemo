using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using Microsoft.AspNetCore.Authorization;
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

       // [Authorize]
        [HttpPost]
        [Route("InsertExam")]
        public ActionResult InsertExam([FromBody] InsertExam exams)
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
        [Authorize]
        [Route("GetExams")]
        public ActionResult GetExams()
        {
            var exams = _examService.GetExams();
            return new JsonResult(exams);
        }
       // [Authorize]
        [HttpPost]
        [Route("CreateExamInstance")]
        public ActionResult CreateExamInstance(ExamInstance examInstance)
        {
            var exam = _examService.CreateExamInstance(examInstance);
            return new JsonResult(exam);
        }
       // [Authorize]
        [HttpGet]
        [Route("GetExamInstance/{examInstanceUniqueName}")]

        public ActionResult GetExamInstance(Guid examInstanceUniqueName)
        {
            var examInstance = _examService.GetExamInstance(examInstanceUniqueName);
            return new JsonResult(examInstance);
        }

        //[Authorize]
        [HttpPatch]
        [Route("EndExam")]
        public ActionResult EndExam(Guid examInstanceUniqueName,int userMark)
        {
            var endExam = _examService.EndExam(examInstanceUniqueName, userMark);
            return new JsonResult(endExam);
        }
    }
}
