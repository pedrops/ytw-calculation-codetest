using IMTC.CodeTest.Indices.Services;

namespace IMTC.CodeTest.Application.Services
{
    public class IndexProvider : IIndexProvider
    {
        public async Task<decimal> GetIndex(string indexCode, DateTime date)
        {
            return await Task.FromResult<decimal>(new Random().Next(100));
        }
    }
}
