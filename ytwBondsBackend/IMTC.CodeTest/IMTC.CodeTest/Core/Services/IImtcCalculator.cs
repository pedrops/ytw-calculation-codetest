using IMTC.CodeTest.Domain.Models;

namespace IMTC.CodeTest.Core.Services
{
    public interface IImtcCalculator
    {
        public Task<decimal?> CalculateYtw(Bond bond, DateTime settlementDate, decimal index);
    }
}
