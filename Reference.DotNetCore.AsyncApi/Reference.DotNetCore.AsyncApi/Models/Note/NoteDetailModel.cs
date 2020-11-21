using System;

namespace Reference.DotNetCore.AsyncApi.Models.Note
{
    public class NoteDetailModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified{ get; set; }
    }
}