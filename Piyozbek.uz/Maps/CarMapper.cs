using Piyozbek.uz.DataAccess.Entities;
using Piyozbek.uz.Dtos;
using Riok.Mapperly.Abstractions;

namespace Piyozbek.uz.Maps
{
    [Mapper]
    public partial class CarMapper
    {

        public partial CreateCarDto CarToCarDto(Car car);

        public partial Car CarDtoToCar(CreateCarDto dto);

        public partial void UpdateCarDto(Car car, CreateCarDto dto);
    }
}
