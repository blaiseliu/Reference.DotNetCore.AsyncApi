using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Reference.DotNetCore.AsyncApi.Entities;

namespace Reference.DotNetCore.AsyncApi.Repositories
{
    public interface INoteRepository
    {
        Task<IEnumerable<Note>> GetAllAsync();
        Task<Note> FindAsync(Guid id);
    }
}
