using CarCareSystem.Models.Entities.Common;
using CarCareSystem.Models.Enums;

namespace CarCareSystem.Models.Entities;
public class Maintainence : BaseEntity
{
    public Guid CarId { get; set; }
    public string? MaterialType { get; set; }
    public UnitType UnitType { get; set; } = UnitType.Adet;
    public int Piece { get; set; }
    public decimal UnitPrice { get; set; }
    public byte KDV { get; set; }

    public virtual Car? Car { get; set; }
}
