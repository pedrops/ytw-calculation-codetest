using IMTC.CodeTest.Application.Contracts;
using IMTC.CodeTest.Domain.Models;
using IMTC.CodeTest.Domain.Enums;
using IMTC.CodeTest.Calculators;

namespace IMTC.CodeTest.Application.Services
{
    public class BondService : IBondService
    {
        private readonly Dictionary<string, Bond> _bondCache;
        private readonly IYtwCalculator _ytwCalculator;

        public BondService(IYtwCalculator ytwCalculator)
        {
            _bondCache = new Dictionary<string, Bond>();
            _ytwCalculator = ytwCalculator;
            InitializeCache();
        }

        public Task<Bond> GetBondByName(string name)
        {
            if (_bondCache.ContainsKey(name.ToLower()))
            {
                return Task.FromResult(_bondCache[name]);
            }
            else
            {
                return Task.FromResult<Bond>(null);
            }
        }
        private void InitializeCache()
        {
            // Add sample bond data to the cache
            var bonds = new List<Bond>
            {
                new Bond
                {
                    Name = "bond 1",
                    BondType = BondType.Municipal,
                    CouponRate = 0.05m,
                    CouponType = CouponType.Variable,
                    FaceValue = 1000,
                    MaturityDate = DateTime.UtcNow.AddYears(5)
                },
                new Bond
                {
                    Name = "bond 2",
                    BondType = BondType.Corporate,
                    CouponRate = 0.04m,
                    CouponType = CouponType.Fixed,
                    FaceValue = 1500,
                    MaturityDate = DateTime.UtcNow.AddYears(10)
                },
                new Bond
                {
                    Name = "bond 3",
                    BondType = BondType.Government,
                    CouponRate = 0.06m,
                    CouponType = CouponType.Fixed,
                    FaceValue = 1500,
                    MaturityDate = DateTime.UtcNow.AddYears(2)
                },

            };

            // Populate the cache with the sample bond data
            foreach (var bond in bonds)
            {
                _bondCache.Add(bond.Name, bond);
            }
        }


        public async Task<decimal?> PostBondCalculation(Bond bond)
        {
            return await _ytwCalculator.CalculateYtwForBond(bond);
        }

    }
}
