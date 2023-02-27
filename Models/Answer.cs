namespace StackOverflow.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime PostDate { get; set; }

        public bool IsApproved { get; set; }

    }
}
