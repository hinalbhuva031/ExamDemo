using System.ComponentModel.DataAnnotations.Schema;

namespace ExamDemo.Framework.Infrastructure
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}
