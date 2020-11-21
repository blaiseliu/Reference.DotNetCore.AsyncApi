using Microsoft.EntityFrameworkCore;
using Reference.DotNetCore.AsyncApi.Entities;
using Reference.DotNetCore.AsyncApi.SeedData;

namespace Reference.DotNetCore.AsyncApi.Context
{
    public class NotesDbContext: DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(new NotesData().Seed());
        }
    }
}
