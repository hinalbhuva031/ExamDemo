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
            catch(Exception ex)
            {
                throw (ex);
            }
        }
    

        public Response GetExam(Guid examUniqueName)
        {
            try
            {
               var response= _examDataService.GetExam(examUniqueName);
                return new Response { Status = "Success", Content = response };
            }
            catch(Exception ex)
            {
                throw (ex);
            }
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
                exam.ExamUniqueName = examResult.UniqueName;
                exam.ExamName = examResult.ExamName;
                exam.IsActive = examResult.IsActive;
                exam.PassMark = examResult.PassMark;
                exam.TotalMark = examResult.TotalMark;
                exam.totalQuestions = examResult.totalQuestions;
                exams.Add(exam);
            }
            return exams;
        }

        public ExamInstanceResponse CreateExamInstance(Guid examUniqueName)
        {
            return examUniqueName;
        }
    }
}
