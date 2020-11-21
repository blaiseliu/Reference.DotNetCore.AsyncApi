using AutoMapper;
using Reference.DotNetCore.AsyncApi.Entities;
using Reference.DotNetCore.AsyncApi.Models.Note;

namespace Reference.DotNetCore.AsyncApi.AutoMapperProfiles
{
    public class NoteProfile:Profile
    {
        public override string ProfileName => "Note Profile";

        public NoteProfile()
        {
            CreateMap<Note,NoteSummaryModel>();
        }
    }
}
