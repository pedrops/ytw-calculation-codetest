using IMTC.CodeTest.Core.Services;

namespace IMTC.CodeTest.Application.Services
{
    public class TimeService : ITimeService
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
