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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Note>(typeBuilder =>
            {
                typeBuilder.ToTable("Notes");
                typeBuilder.HasKey(x => x.Id);
                typeBuilder.Property(x => x.Id)
                    .HasDefaultValueSql("newsequentialid()");
                typeBuilder.Property(x => x.Title)
                    .IsRequired()
                    .HasMaxLength(200);
                typeBuilder.Property(x => x.Content)
                    .IsRequired();
                typeBuilder.Property(x => x.DateCreated)
                    .IsRequired();
                typeBuilder.Property(x => x.DateLastModified)
                    .IsRequired();

            });
                
            modelBuilder.Entity<Note>().HasData(new NotesData().Seed());
        }
    }
}
