using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using System;
using System.Collections.Generic;

namespace ExamDemo.BusinessSevices.Services
{
    public class ExamService : IExamService
    {

        private readonly IExamDataService _examDataService;

        public ExamService(IExamDataService insertExamDataService)
        {
            _examDataService = insertExamDataService;
        }
        //public ExamService()
        //{
        //    _insertExamDataService = insertExamDataService;
        //}
        public Response AddExam(Exams exams)
        {
            try
            {
                _examDataService.InsertExams(exams);
                return new Response { Status = "Success", Content = "Success" };
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public Exams GetExam(Guid examUniqueName)
        {
            try
            {
                var examResult = _examDataService.GetExam(examUniqueName);
                var result = GetExam<Exams>(examUniqueName, examResult);
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public static T GetExam<T>(Guid examUniqueName, GetExamResult examResult) where T :Exams
            {
            var exam = Activator.CreateInstance<T>();
           // exam.ExamUniqueName = examUniqueName;
            exam.ExamName = examResult.ExamName;
            exam.PassMark = examResult.PassMark;
            exam.TotalMark = examResult.TotalMark;
            exam.totalQuestions = examResult.totalQuestions;
            return exam;

        }
       
        public  List<Exams> GetExams()
        {
            try
            {
                var exams= _examDataService.GetExams();
                var result = GetExams(exams);
                return result;
               
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        public static List<Exams> GetExams(List<GetExamsResult> examsResults)
        {
            if (examsResults == null)
            {
                return null;
            }

            var exams = new List<Exams>();
            foreach (var examResult in examsResults)
            {
                var exam = new Exams();
                //exam.ExamUniqueName = examResult.UniqueName;
                exam.ExamName = examResult.ExamName;               
                exam.PassMark = examResult.PassMark;
                exam.TotalMark = examResult.TotalMark;
                exam.totalQuestions = examResult.totalQuestions;
                exams.Add(exam);
            }
            return exams;
        }

        public ExamInstanceResponse CreateExamInstance(Guid examUniqueName)
        {
            try
            {
                var examresult = _examDataService.GetExam(examUniqueName);
                var exam = GetExam(examUniqueName);
               
                var response = CreateInstance(exam, examUniqueName);
                return response;
            }
            catch (Exception ex)
            {
                throw (ex);
            }


        }
        private ExamInstanceResponse CreateInstance(Exams exam, Guid examUniqueName)
        {
            var examInstance = GetInsertInstance(exam, _examDataService);
           examInstance.ExamRegistrationUniqueName = examUniqueName;
            _examDataService.InsertInstance(examInstance);
            //return new ExamInstanceResponse
            //{
            //    ExamInstanceUniqueName = examInstance.UniqueName,
            //    ExamRegistrationUniqueName= examInstance.ExamRegistrationUniqueName,
            //    TotalMark = examInstance.TotalMark,
            //    PassMark = examInstance.PassMark,
                
            //    //UserPersantage = examInstance.UserPersantage
            //};

        }
        public static InsertExamInstanceParams GetInsertInstance(Exams exam, IExamDataService examDataService)
        {
           // var examRegistrationResult = examDataService.GetExamREgistration(examRegistration.ExamUniqueName);
            var examInstance = new InsertExamInstanceParams
            {
                //UniqueName = Guid.NewGuid(),
                //ExamRegistrationUniqueName = examResult.,
                //TotalMark = examResult.TotalMark,
                //PassMark = examResult.PassMark,
                
            };
            return examInstance;
        }



    }
}
