using IMTC.CodeTest.Domain.Enums;

namespace IMTC.CodeTest.Domain.Models
{
    public class Bond
    {
        public string? Name { get; set; }
        public decimal FaceValue { get; set; }
        public decimal CouponRate { get; set; }
        public DateTime MaturityDate { get; set; }
        public CouponType CouponType { get; set; }
        public BondType BondType { get; set; }
    }
}
