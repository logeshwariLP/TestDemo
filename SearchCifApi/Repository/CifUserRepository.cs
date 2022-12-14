using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SearchCifApi.DbContexts;
using SearchCifApi.Models;
using SearchCifApi.Models.Dto;

namespace SearchCifApi.Repository
{
    public class CifUserRepository : ICifUserRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public CifUserRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db=db;
            _mapper=mapper;
        }
        public async Task<CifUserDto> GetCifbyemailID(string emailid)
        {
            CifUser cifUser = await _db.CifUser.Where(x => x.emailId==emailid).FirstOrDefaultAsync();
            return _mapper.Map<CifUserDto>(cifUser);
        }
    }
}
