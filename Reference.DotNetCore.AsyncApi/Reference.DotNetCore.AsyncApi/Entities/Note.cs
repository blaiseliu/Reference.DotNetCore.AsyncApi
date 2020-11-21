using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reference.DotNetCore.AsyncApi.Entities
{
    [Table("Notes")]
    public class Note
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required] 
        public DateTime DateCreated { get; set; }
        [Required] 
        public DateTime DateLastModified{ get; set; }
    }
}
