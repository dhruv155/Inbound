using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemManagement.Models.Dto;

namespace SystemManagement.Services
{
    public interface ILpn
    {
        Task<LpnDto> GetLpnById(int lpnId);
    }
}
