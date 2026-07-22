using AutoMapper;
using WebApiCsharp.Domain.Dtos;
using WebApiCsharp.Domain.UserDomain.UserModel;

namespace WebApiCsharp.Aplication.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<User, UserDTO>().ForMember(dest => dest.nome, m => m.MapFrom(orig => orig.Nome));
        }
    }
}
