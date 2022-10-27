using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemManagement.DbContexts;
using SystemManagement.Models.Dto;
using SystemManagement.Services;

namespace SystemManagement.Repository
{
    public class LpnRepository : ILpn
    {
        private readonly ApplicationDbContext _dbcontext;
        private IMapper _mapper;

        public LpnRepository(ApplicationDbContext dbContext, IMapper mapper
            )
        {
            _dbcontext = dbContext;
            _mapper = mapper;

        }
        public async Task<LpnDto> GetLpnById(int lpnId)
        {
            
        }
    }
}
