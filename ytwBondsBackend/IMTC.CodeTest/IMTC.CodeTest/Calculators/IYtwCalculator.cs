using IMTC.CodeTest.Domain.Models;

namespace IMTC.CodeTest.Calculators
{
    public interface IYtwCalculator
    {
        Task<decimal?> CalculateYtwForBond(Bond bond);
        Task<decimal?> CalculateYtwForBond(Bond bond, DateTime settlementDate);
    }
}
