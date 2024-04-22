using IMTC.CodeTest.Domain.Models;

namespace IMTC.CodeTest.Application.Contracts
{
    public interface IBondService
    {
        public Task<Bond> GetBondByName(string name);
        public Task<decimal?> PostBondCalculation(Bond bond);
    }
}
