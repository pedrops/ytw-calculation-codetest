using IMTC.CodeTest.Application.Contracts;
using MediatR;
using Microsoft.Extensions.Logging;

namespace IMTC.CodeTest.Application.Features.Bond
{
    public class GetBondHandler : IRequestHandler<GetBondQuery, GetBondResponse>
    {
        private readonly ILogger<GetBondHandler> _logger;
        private readonly IBondService _bondService;

        public GetBondHandler(IBondService bondService, ILogger<GetBondHandler> logger)
        {
            _bondService = bondService;
            _logger = logger;
        }
        public async Task<GetBondResponse> Handle(GetBondQuery request, CancellationToken cancellationToken)
        {
            var filteredBond = await _bondService.GetBondByName(request.BondName);
            return new GetBondResponse()
            {
                BondType = filteredBond.BondType,
                CouponRate = filteredBond.CouponRate,
                CouponType = filteredBond.CouponType,
                FaceValue = filteredBond.FaceValue,
                MaturityDate = filteredBond.MaturityDate,
                Name = filteredBond.Name
            };
        }
    }
}
