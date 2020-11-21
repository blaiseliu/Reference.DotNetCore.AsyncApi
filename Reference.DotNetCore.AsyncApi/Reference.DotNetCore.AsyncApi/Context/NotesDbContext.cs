using Microsoft.EntityFrameworkCore;
using Reference.DotNetCore.AsyncApi.Entities;

namespace Reference.DotNetCore.AsyncApi.Context
{
    public class NotesDbContext: DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options):base(options)
        {
            
        }
    }
}
