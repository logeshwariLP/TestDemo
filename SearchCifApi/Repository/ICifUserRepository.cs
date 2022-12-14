using SearchCifApi.Models.Dto;

namespace SearchCifApi.Repository
{
    public interface ICifUserRepository
    {
        //  Task<IEnumerable<CifUserDto>> GetCifUsers();
        Task<CifUserDto> GetCifbyemailID(string emailid);
        //  Task<CifUserDto> CreateCifId(CifUserDto cifUserDto);

    }
}
