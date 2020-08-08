using AutoMapper;
using MiniFacebook.Models.Entities;
using MiniFacebook.ViewModel;

namespace MiniFacebook.Orchestrator.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, AddPostDto>().ReverseMap();

            CreateMap<Post, PostDto>()
                .ForMember(x=>x.Date,d=>d.MapFrom(f=>f.CreatedDate))
                .ReverseMap();

        }

    }
}
