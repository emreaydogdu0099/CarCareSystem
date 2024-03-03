using CarCareSystem.Models.Enums;

namespace CarCareSystem;
public static class Helper
{
    public static UnitType StringToEnum(string selectedUnitType)
    {
        return Enum.TryParse(selectedUnitType, out UnitType unitType) ? unitType : UnitType.Adet;
    }
}
