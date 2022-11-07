using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace ExamDemo.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        private readonly IDistributedCache _distributedCache;

        public ExamController(IExamService examservice, IDistributedCache distributedCache)
        {
            _examService = examservice;
            _distributedCache = distributedCache;
        }

        [HttpPost]
        [Route("InsertExam")]
        public ActionResult InsertExam(InsertExam exams)
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

            var data = JsonConvert.SerializeObject(exams);
            //await _distributedCache.SetStringAsync("DemoData", data);

            return new JsonResult(exams);
        }

        [HttpPost]
        [Route("CreateExamInstance")]
        public ActionResult CreateExamInstance(ExamInstance examInstance)
        {
            var exam = _examService.CreateExamInstance(examInstance);
            return new JsonResult(exam);
        }

        [HttpGet]
        [Route("GetExamInstance/{examInstanceUniqueName}")]

        public ActionResult GetExamInstance(Guid examInstanceUniqueName)
        {
            var examInstance = _examService.GetExamInstance(examInstanceUniqueName);
            return new JsonResult(examInstance);
        }

        [HttpPatch]
        [Route("EndExam")]
        public ActionResult EndExam(Guid examInstanceUniqueName,int userMark)
        {
            var endExam = _examService.EndExam(examInstanceUniqueName, userMark);
            return new JsonResult(endExam);
        }
    }
}
