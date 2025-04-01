using Piyozbek.uz.DataAccess.Entities;
using Piyozbek.uz.Dtos;
using Riok.Mapperly.Abstractions;

namespace Piyozbek.uz.Maps
{
    [Mapper]
    public partial class DriverMapper
    {
        public partial DriverDto DriverToDriverDto(Driver driver);
        public partial Driver DriverDtoToDriver(DriverDto dto);
        public partial void UpdateDriverDto(Driver driver, DriverDto dto);


    }
}
