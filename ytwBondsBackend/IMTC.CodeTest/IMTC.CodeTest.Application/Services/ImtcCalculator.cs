using IMTC.CodeTest.Core.Services;
using IMTC.CodeTest.Domain.Models;

namespace IMTC.CodeTest.Application.Services
{
    public class ImtcCalculator : IImtcCalculator
    {
        public async Task<decimal?> CalculateYtw(Bond bond, DateTime settlementDate, decimal index)
        {
            return await Task.FromResult<decimal>(new Random().Next(100));
        }
    }
}
