using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverflow.Models
{
    public class QuestionComments
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public int QuestionId { get; set; }


    }
}
