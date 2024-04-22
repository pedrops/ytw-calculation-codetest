using IMTC.CodeTest.Calculators;
using IMTC.CodeTest.Core.Services;
using IMTC.CodeTest.Domain.Enums;
using IMTC.CodeTest.Domain.Models;
using IMTC.CodeTest.Indices.Services;

namespace IMTC.CodeTest.Application.Services
{
    public class YtwCalculator : IYtwCalculator
    {
        private readonly IImtcCalculator _calculator;
        private readonly IIndexProvider _indexProvider;
        private readonly ITimeService _timeService;

        public YtwCalculator(IImtcCalculator calculator, IIndexProvider indexProvider, ITimeService timeService)
        {
            _calculator = calculator;
            _indexProvider = indexProvider;
            _timeService = timeService;
        }

        public async Task<decimal?> CalculateYtwForBond(Bond bond)
        {
            var settlementDate = _timeService.UtcNow.Date;
            return await CalculateYtwForBond(bond, settlementDate);
        }

        public async Task<decimal?> CalculateYtwForBond(Bond bond, DateTime settlementDate)
        {
            if (bond is null)
            {
                throw new ArgumentNullException(nameof(bond));
            }

            var indexCode = bond switch
            {
                Bond b when b.CouponType == CouponType.Variable => IndexNames.USTR_CMT,
                Bond b when b.BondType == BondType.Municipal => IndexNames.MuniAAA,
                _ => IndexNames.USTR_CMT
            };

            var index = await _indexProvider.GetIndex(indexCode.ToString(), settlementDate);
            var ytw = await _calculator.CalculateYtw(bond, settlementDate, index);
            return ytw;
        }
    }
}
