using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Dotnetcore.Domain
{
    public class RandomQuoteQueryHandler : IRequestHandler<RandomQuoteQuery, string>
    {
        public Task<string> Handle(RandomQuoteQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult("This is not yet random");
        }
    }
}