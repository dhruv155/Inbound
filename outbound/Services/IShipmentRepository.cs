using outbound.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Services
{
   public interface IShipmentRepository
    {
        Task<IEnumerable<ShipmentDto>> GetShipments();

        Task<ShipmentDto> GetShipmentById(int ShipmentId);

        Task<ShipmentDto> CreateUpdateShipment(ShipmentDto ShipmentDto);

        Task<bool> DeleteShipment(int ShipmentId);
    }
}
