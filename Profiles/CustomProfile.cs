using AutoMapper;

namespace ShowsProject.Profiles
{
    public class CustomProfile : Profile
    {
        public CustomProfile() {
            CreateMap<Models.Show, DTOs.ShowDTO>().ReverseMap();
            CreateMap<Models.Owner, DTOs.OwnerDTO>().ReverseMap();
            CreateMap<Models.Application, DTOs.ApplicationDTO>().ReverseMap();
            CreateMap<Models.Performer, DTOs.PerformerDTO>().ReverseMap();

        }
    }
}
