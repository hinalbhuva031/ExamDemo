using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamDemo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExamRegistrationController : ControllerBase
    {
        private readonly IExamRegistrationService _examRegistrationService;

        public ExamRegistrationController(IExamRegistrationService examRegistrationService)
        {
            _examRegistrationService = examRegistrationService;
        }

        [HttpPost]
        [Route("InsertUser")]
        public ActionResult InsertUser(string userEmail)
        {
            var result = _examRegistrationService.InsertUserData(userEmail);

            return new JsonResult(result);
        }

        [HttpPost]
        [Route("UserExamRegistration")]
        public ActionResult UserExamRegistration(ExamRegistration examRegistration)
        {
            var result = _examRegistrationService.UserExamRegistration(examRegistration);

            return new JsonResult(result);
        }

        [HttpGet]
        [Route("GetExamRegistrationbyUser")]
        public ActionResult GetExamRegistrationbyUser(string userEmail)
        {
            var examRegistrations = _examRegistrationService.GetExamRegistrationbyUser(userEmail);
            if (examRegistrations == null)
            {
                return NotFound();
            }
            return new JsonResult(examRegistrations);
        }


    }
}
