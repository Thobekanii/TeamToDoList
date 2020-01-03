using System.Threading;
using System.Collections.Generic;
using MediatR;
using Persistence;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application.Status
{
    public class ListStatus
    {
        public class Query:IRequest<List<Domain.Status>>{}

        public class Handler:IRequestHandler<Query, List<Domain.Status>>
        {
            private readonly DataContext _context;
            public Handler (DataContext context)
            {
                _context=context;
            }

            public async Task<List<Domain.Status>> Handle(Query request, CancellationToken cancellationToken)
            {
                var status=await _context.statuses.ToListAsync();
                return status;
            }
        }
    }
}