using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamDemo.Database.Models
{
    public class StoredProcedures
    {
       
        public const string CREATE_TOKEN = "sp_GetAuthorizeUser";
        //public const string INSERT_USER = "sp_"

        public const string GET_EXAM = "sp_GetExam";
        public const string GET_EXAMS = "sp_GetExams";
        public const string GET_EXAM_REGISTRATION_FOR_USER = "sp_GetExamRegistrationsForUser";
        public const string GET_EXAM_INSTANCE = "sp_GetExamInstance";

        public const string INSERT_EXAM_RECORD = "sp_InsertExamRecord";
        public const string INSERT_EXAM_INSTANCES = "sp_InsertExamInstance";
        public const string INSERT_USER = "sp_InsertUser";
        public const string INSERT_EXAM_REGISTRATION = "sp_InsertExamRegistration";

        public const string END_EXAM = "sp_EndExam";

    }
}
