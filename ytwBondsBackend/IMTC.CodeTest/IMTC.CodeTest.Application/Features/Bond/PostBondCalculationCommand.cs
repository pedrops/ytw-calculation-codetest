using IMTC.CodeTest.Domain.Enums;
using MediatR;

namespace IMTC.CodeTest.Application.Features.Bond
{
    public class PostBondCalculationCommand : IRequest<PostBondCalculationResponse>
    {
        public PostBondCalculationCommand(string? name, decimal faceValue, decimal couponRate, DateTime maturityDate, CouponType couponType, BondType bondType)
        {
            Name = name;
            FaceValue = faceValue;
            CouponRate = couponRate;
            MaturityDate = maturityDate;
            CouponType = couponType;
            BondType = bondType;
        }

        public string? Name { get; set; }
        public decimal FaceValue { get; set; }
        public decimal CouponRate { get; set; }
        public DateTime MaturityDate { get; set; }
        public CouponType CouponType { get; set; }
        public BondType BondType { get; set; }
    }
}
