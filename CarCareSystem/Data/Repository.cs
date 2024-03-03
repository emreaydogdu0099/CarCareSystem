using CarCareSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarCareSystem.Data;
public class Repository
{
    public async Task<Car?> GetCarByPlate(string licencePlate)
    {
        using CarCareDbContext context = new CarCareDbContext();
        return await context.Cars
                    .AsNoTracking()
                    .Where(x => x.LicencePlate == licencePlate)
                    .Include(x => x.Maintainences)
                    .FirstOrDefaultAsync();
    }

    public async Task AddMaintainenceAsync(Maintainence maintainence)
    {
        using CarCareDbContext context = new CarCareDbContext();
        await context.Maintainences.AddAsync(maintainence);
        await context.SaveChangesAsync();
    }

    public async Task AddCarAsync(string licencePlate)
    {
        using CarCareDbContext context = new CarCareDbContext();
        await context.Cars.AddAsync(new() { LicencePlate = licencePlate});
        await context.SaveChangesAsync();
    }

    public async Task UpdateMaintainenceAsync(Guid id, Maintainence newMaintainence)
    {
        using CarCareDbContext context = new CarCareDbContext();
        Maintainence maintainence = await context.Maintainences.FindAsync(id);
        maintainence.MaterialType = newMaintainence.MaterialType;
        maintainence.UnitType = newMaintainence.UnitType;
        maintainence.Piece = newMaintainence.Piece;
        maintainence.UnitPrice = newMaintainence.UnitPrice;
        maintainence.KDV = newMaintainence.KDV;
        await context.SaveChangesAsync();
    }

    public async Task DeleteMaintainenceAsync(Maintainence maintainence)
    {
        using CarCareDbContext context = new CarCareDbContext();
        context.Remove(maintainence);
        await context.SaveChangesAsync();
    }

    public async Task<Maintainence> GetMaintainenceById(Guid id)
    {
        using CarCareDbContext context = new CarCareDbContext();
        return await context.Maintainences.FirstOrDefaultAsync(x => x.Id == id);
    }
}
