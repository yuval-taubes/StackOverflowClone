using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StackOverflow.Models;

namespace StackOverflow.Data
{
    public class StackOverflowContext : DbContext
    {
        public StackOverflowContext (DbContextOptions<StackOverflowContext> options)
            : base(options)
        {
        }

        public DbSet<StackOverflow.Models.Question> Question { get; set; } = default!;

        public DbSet<StackOverflow.Models.QuestionComments> QuestionComments { get; set; } = default!;

    }
}
