using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reference.DotNetCore.AsyncApi.Context;
using Reference.DotNetCore.AsyncApi.Entities;

namespace Reference.DotNetCore.AsyncApi.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private NotesDbContext _context;

        public NoteRepository(NotesDbContext context)
        {
            _context = context ?? throw  new ArgumentNullException();
        }
        public async Task<IEnumerable<Note>> GetAllAsync()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<Note> FindAsync(Guid id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (_context == null) return;

            _context.Dispose();
            _context = null;
        }
    }
}