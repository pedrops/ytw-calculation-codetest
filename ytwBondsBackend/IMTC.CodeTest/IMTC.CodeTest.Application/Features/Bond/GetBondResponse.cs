using IMTC.CodeTest.Domain.Enums;

namespace IMTC.CodeTest.Application.Features.Bond
{
    public class GetBondResponse
    {
        public string? Name { get; set; }
        public decimal FaceValue { get; set; }
        public decimal CouponRate { get; set; }
        public DateTime MaturityDate { get; set; }
        public CouponType CouponType { get; set; }
        public BondType BondType { get; set; }
    }
}
