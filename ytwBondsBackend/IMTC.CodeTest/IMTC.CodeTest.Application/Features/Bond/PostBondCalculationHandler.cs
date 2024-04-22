using IMTC.CodeTest.Application.Contracts;
using MediatR;

namespace IMTC.CodeTest.Application.Features.Bond
{
    public class PostBondCalculationHandler : IRequestHandler<PostBondCalculationCommand, PostBondCalculationResponse>
    {
        private readonly IBondService _bondService;

        public PostBondCalculationHandler(IBondService bondService)
        {
            _bondService = bondService;
        }
        public async Task<PostBondCalculationResponse> Handle(PostBondCalculationCommand request, CancellationToken cancellationToken)
        {
            var bond = new Domain.Models.Bond()
            { 
                BondType = request.BondType,
                CouponRate = request.CouponRate,
                CouponType = request.CouponType,
                FaceValue = request.FaceValue,
                MaturityDate = request.MaturityDate,
                Name = request.Name
            };
            var resp = new PostBondCalculationResponse();
            resp.CalculatedYtw = await _bondService.PostBondCalculation(bond); ;
            return resp;
        }
    }
}
