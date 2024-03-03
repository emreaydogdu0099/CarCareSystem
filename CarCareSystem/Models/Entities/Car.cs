using CarCareSystem.Models.Entities.Common;

namespace CarCareSystem.Models.Entities;
public class Car : BaseEntity
{
    public string LicencePlate { get; set; }

    public ICollection<Maintainence> Maintainences { get; set; } 
}
