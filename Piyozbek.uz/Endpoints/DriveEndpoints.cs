using Piyozbek.uz.DataAccess.Repositories;
using Piyozbek.uz.Dtos;
using Piyozbek.uz.Maps;

namespace Piyozbek.uz.Endpoints
{


    public static class DriverEndpoints
    {
        public static IEndpointRouteBuilder MapDriverENdPoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/drivers/add", async (DriverDto dto, IDriverRepository driverRepository) =>
                {
                    var driverMapper = new DriverMapper();
                    var driver = driverMapper.DriverDtoToDriver(dto);
                    await driverRepository.Add(driver);
                    await driverRepository.SaveChangesAsync();
                })
                .WithName("CreateDriver")
                .WithOpenApi();

            app.MapGet("/api/drivers/{id}", async (int id, IDriverRepository driverRepository) =>
            {
                var driver = await driverRepository.GetById(id);
                if (driver is null)
                {
                    return Results.NotFound();
                }

                var driverMapper = new DriverMapper();
                var driverDto = driverMapper.DriverToDriverDto(driver);
                return Results.Ok(driverDto);
            });

            app.MapPut("/api/drivers/{id}", async (int id, DriverDto dto, IDriverRepository driverRepository) =>
            {
                var existingDriver = await driverRepository.GetById(id);
                var driverMapper = new DriverMapper();
                driverMapper.UpdateDriverDto(existingDriver, dto);

                // reposi

                return Results.Ok(driverMapper.DriverToDriverDto(existingDriver));
            });
            return app;
        }
    }
}
