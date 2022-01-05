using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using ExamDemo;
using ExamDemo.Common;

namespace ExamDemo.BusinessSevices.Services
{
    public class ExamRegistrationService : IExamRegistrationService
    {
        private readonly IExamRegistrationDataService _examRegistrationDataService;
        private readonly IExamDataService _examDataService;

        public ExamRegistrationService(IExamRegistrationDataService examRegistrationDataService, IExamDataService examDataService)
        {
            _examRegistrationDataService = examRegistrationDataService;
            _examDataService = examDataService;
        }

        public Response InsertUserData(string userEmail)
        {
            try
            {
                var result = _examRegistrationDataService.InsertUserData(userEmail);
                if (result == null)
                {
                    return null;
                }
                else
                {
                    return new Response { Status = "Success", Content = result };
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public Response UserExamRegistration(ExamRegistration examRegistration)
        {
            try
            {
                var examResults = _examDataService.GetExams();
                var exams = GetExams(examResults);
                var registrationParam = GetInsertExamRegistrationParams(examRegistration, exams);

                _examRegistrationDataService.InsertExamRegistration(registrationParam);


                return new Response { Status = "Success", Content = "Success" };
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public Response GetExamRegistrationbyUser(string userEmail)
        {
            try
            {
                var examRegistrationsData = _examRegistrationDataService.GetExamRegistrationbyUser(userEmail);
                var exams = _examDataService.GetExams();
                var result = GetExams(exams);
                var examRegistrations = new List<ExamRegistrationbyUserDto>();
                foreach (var examRegistrationData in examRegistrationsData)
                {
                    var exam = result?.FirstOrDefault(e => e.ExamUniqueName == examRegistrationData.ExamUniqueName);

                    examRegistrations.Add(new ExamRegistrationbyUserDto
                    {
                        ExamRegistrationUniqueName = examRegistrationData.ExamregistrationuniqueName,
                        ExamId = examRegistrationData.ExamId,
                        ExamName = examRegistrationData.ExamName,
                        UserId = examRegistrationData.UserId,
                        UserEmail = examRegistrationData.UserEmail
                    });
                }
                return new Response { Status = "Success", Content = examRegistrations };

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public static List<Exams> GetExams(List<GetExamsResult> examResults)
        {
            if (examResults == null)
            {
                return null;
            }

            var exams = new List<Exams>();
            foreach (var examResult in examResults)
            {
                var exam = new Exams();
                exam.ExamUniqueName = examResult.UniqueName;
                exam.ExamName = examResult.ExamName;
                exam.PassMark = examResult.PassMark;
                exam.TotalMark = examResult.TotalMark;
                exam.totalQuestions = examResult.totalQuestions;
                exams.Add(exam);
            }
            return exams;
        }

        public static InsertExamRegistrationParams GetInsertExamRegistrationParams(ExamRegistration examRegistration, List<Exams> exams)
        {
            var exam = exams?.FirstOrDefault(e => e.ExamUniqueName.Equals(examRegistration.ExamUniqueName));
            if (exam == null)
            {
                throw new Exception(message: "No Exam with this ExamUniqueName");
            }

            return new InsertExamRegistrationParams
            {
                ExamUniqueName = exam.ExamUniqueName,
                UserEmail = examRegistration.UserEmail
            };


        }
    }
}
