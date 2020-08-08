using AutoMapper;
using MiniFacebook.Models.Entities;
using MiniFacebook.ViewModel;
using MiniFacebook.ViewModel.Auth;

namespace MiniFacebook.Orchestrator.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, RegisterDto>()
                .ForMember(x => x.Email, d => d.MapFrom(f => f.Email))
                .ForMember(x => x.Phone, d => d.MapFrom(f => f.Phone))
                .ForMember(x => x.UserName, d => d.MapFrom(f =>  f.UserName))
                .ReverseMap();

            CreateMap<UserFriend, FriendRequestDto>()
                .ForMember(x => x.RequesterId, d => d.MapFrom(f => f.FriendId))
                .ReverseMap();
        }
    }
}
