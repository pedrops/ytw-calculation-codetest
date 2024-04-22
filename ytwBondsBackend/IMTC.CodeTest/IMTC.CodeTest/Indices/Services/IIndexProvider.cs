namespace IMTC.CodeTest.Indices.Services
{
    public interface IIndexProvider
    {
        Task<decimal> GetIndex(string indexCode, DateTime date);
    }
}
