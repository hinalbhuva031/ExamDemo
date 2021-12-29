using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamDemo.Framework.Infrastructure
{
    [Serializable]
    public abstract class BaseEntity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}
