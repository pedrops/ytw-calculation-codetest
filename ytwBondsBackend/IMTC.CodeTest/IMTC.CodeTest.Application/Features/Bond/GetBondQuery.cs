using MediatR;

namespace IMTC.CodeTest.Application.Features.Bond
{
    public class GetBondQuery: IRequest<GetBondResponse>
    {
        public GetBondQuery(string bondName)
        {
            BondName = bondName;
        }

        public string BondName { get; }

    }
}
