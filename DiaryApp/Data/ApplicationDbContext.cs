using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DateTime current = DateTime.Today;

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Domain Driven Design",
                    Content = "DDD is actually my prefered way to approach Software Design; as someone interested in deep and complex games, I love when the experience of using a game's mechanic matches or closely resembles the way you might go about it in real life. And I take this perspective when designing software as well, focusing on understanding the problem entirely and breaking it down into individual steps, especially where user experience is involved.",
                    Created = current,
                    Tags = new List<string> { "introspection", "habits", "health", "struggle", "exercise" }
                },
                 new DiaryEntry
                 {
                     Id = 2,
                     Title = "I really love my cat!",
                     Content = "I have a cat named Shebby and she is so very cute. Every day she makes me happy and ensures I can stay calm and focused on the things I need to do. I love her!",
                     Created = current,
                     Tags = new List<string> { "pets", "love", "cat", "cats", "pet" }
                 },
                  new DiaryEntry
                  {
                      Id = 3,
                      Title = "Hi BTG!",
                      Content = "Hopefully this supplemental repo finds you well!",
                      Created = current,
                      Tags = new List<string> { "introspection", "professional", "life", "work", "usingLINQWhere" }
                  },
                  new DiaryEntry
                  {
                      Id = 4,
                      Title = "SQL Statements",
                      Content = "Let me tell you, when I walked out of that office and my brain thought about a simple GROUP BY command to finish the SQL I was supposed to write. I clicked my tongue and shook my head, but every time I interview, I learn. Every problem I face is a challenge to be better. Thank you all for the learning I got to do!",
                      Created = current,
                      Tags = new List<string> {  "numbah4", "WeMakeItWork" }
                  },
                 new DiaryEntry
                 {
                     Id = 5,
                     Title = "Blog5",
                     Content = "This is the content for blog 5",
                     Created = current,
                     Tags = new List<string> { "numbah5" }
                 },
                  new DiaryEntry
                  {
                      Id = 6,
                      Title = "Blog6",
                      Content = "This is the content for blog 6",
                      Created = current,
                      Tags = new List<string> { "numbah6" }
                  },
                  new DiaryEntry
                  {
                      Id = 7,
                      Title = "Blog7",
                      Content = "This is the content for blog 7",
                      Created = current,
                      Tags = new List<string> { "numbah7", "WeMakeItWork" }
                  },
                 new DiaryEntry
                 {
                     Id = 8,
                     Title = "Blog8",
                     Content = "This is the content for blog 8",
                     Created = current,
                     Tags = new List<string> { "numbah8", "WeMakeItWork" }
                 },
                  new DiaryEntry
                  {
                      Id = 9,
                      Title = "Blog9",
                      Content = "This is the content for blog 9",
                      Created = current.AddHours(3),
                      Tags = new List<string> { "numbah9", "WeMakeItWork" }
                  },
                  new DiaryEntry
                  {
                      Id = 10,
                      Title = "Blog10",
                      Content = "This is the content for blog 10",
                      Created = current.AddDays(10),
                      Tags = new List<string> { "numbah10", "WeMakeItWork" }
                  },
                 new DiaryEntry
                 {
                     Id = 11,
                     Title = "Blog11",
                     Content = "This is the content for blog 11",
                     Created = current.AddDays(11),
                     Tags = new List<string> { "numbah11", "WeMakeItWork" }
                 },
                  new DiaryEntry
                  {
                      Id = 12,
                      Title = "Hi BTG 12!",
                      Content = "diary12",
                      Created = current.AddDays(12),
                      Tags = new List<string> { "WeMakeItWork", "usingLINQWhere" }
                  }
                );
        }
    }
}
