using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Assignees {
    public class ListAssignees {
        public class Query : IRequest<List<Assignee>> { }

        public class Handler : IRequestHandler<Query, List<Assignee>> {
            private readonly DataContext _context;
            public Handler (DataContext context) {
                _context = context;
            }
            public async Task<List<Assignee>> Handle (Query request, CancellationToken cancellationToken) {
                var assignee = await _context.assignees.ToListAsync ();

                return assignee;
            }
        }
    }
}