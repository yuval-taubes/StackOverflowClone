﻿namespace StackOverflow.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime PostTime { get; set; }
    }
}
