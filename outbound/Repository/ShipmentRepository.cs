using AutoMapper;
using CouponApi.DbContexts;
using outbound.Models;
using outbound.Models.Dto;
using outbound.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Repository
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public ShipmentRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<ShipmentDto> CreateUpdateShipment(ShipmentDto ShipmentDto)
        {
            Shipment shipment = _mapper.Map<ShipmentDto, Shipment>(ShipmentDto);
            if (shipment.Id > 0)
            {
                _db.Shipments.Update(shipment);
            }
            else
            {
                _db.Shipments.Add(shipment);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Shipment, ShipmentDto>(shipment);
        }

        public Task<bool> DeleteShipment(int ShipmentId)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentDto> GetShipmentById(int ShipmentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShipmentDto>> GetShipments()
        {
            throw new NotImplementedException();
        }
    }
}
