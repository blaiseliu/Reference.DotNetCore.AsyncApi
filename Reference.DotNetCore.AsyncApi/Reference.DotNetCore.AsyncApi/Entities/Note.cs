using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reference.DotNetCore.AsyncApi.Entities
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified{ get; set; }
    }
}
