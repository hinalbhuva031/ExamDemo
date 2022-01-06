using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessEntities.Models;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamDemo.BusinessSevices.Services
{
    public class ExamService : IExamService
    {
        private readonly IExamDataService _examDataService;
        private readonly IExamInstanceDataService _examInstanceDataService;
        public ExamService(IExamDataService insertExamDataService, IExamInstanceDataService examInstanceDataService)
        {
            _examDataService = insertExamDataService;
            _examInstanceDataService = examInstanceDataService;
        }
        
        public Response AddExam(InsertExam exams)
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
           exam.ExamUniqueName = examUniqueName;
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
                exam.ExamUniqueName = examResult.UniqueName;
                exam.ExamName = examResult.ExamName;               
                exam.PassMark = examResult.PassMark;
                exam.TotalMark = examResult.TotalMark;
                exam.totalQuestions = examResult.totalQuestions;
                exams.Add(exam);
            }
            return exams;
        }

        public Response CreateExamInstance(ExamInstance examInstance)
        {
            _examDataService.InserExamInstance(examInstance);
            return   new Response { Status = "Success", Content = "Success" };
        }

        public GetExamInstanceResult GetExamInstance(Guid examInstanceUniqueName)
        {
            var examInstanceResult = _examInstanceDataService.GetExamInstance(examInstanceUniqueName);
          //  var Instance = GetExamInstance<GetExamInstanceResult>(examInstanceUniqueName, examInstanceResult);
            return examInstanceResult;
        }
        public Response EndExam (Guid examInstanceUniqueName,int userMark)
        {
             _examInstanceDataService.EndExam(examInstanceUniqueName, userMark);
            return new Response { Status = "Success", Content = "Success" };
        }
    }
}
 