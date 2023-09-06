using smartapi.Dtos;
using smartapi.Models;
using AutoMapper;

namespace smartapi.Profiles
{
    public class AccessRightProfile:Profile
    {
        public AccessRightProfile()
        {
            CreateMap<AccessRight,AccessRightReadDto>()
                .ForMember(att => att.Doors, act => act.MapFrom(src => src.AccessRightDoors.Select(x => x.Door).ToList()));

            CreateMap<AccessRight,AccessRightBasicDto>();
            CreateMap<AccessRightInsertDto,AccessRight>();
            CreateMap<AccessRightDoorInsertDto,AccessRightDoor>();
            CreateMap<AccessRightHolderInsertDto,AccessRightHolder>();


        }
        
    }    

}