using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
namespace Application.Assignees

{
    public class AddAssignee {
        public class Command : IRequest {
            public Guid Id { get; set; }
            public String AssigneeName { get; set; }
        }
        public class Handler : IRequestHandler<Command> {
            private readonly DataContext _context;
            public Handler (DataContext _context) {
                this._context = _context;
            }

            public async Task<Unit> Handle (Command request, CancellationToken cancellationToken) {
                var assignees = new Domain.Assignee {
                    Id = request.Id,
                    AssigneeName = request.AssigneeName
                };
                _context.assignees.Add (assignees);
                var succes = await _context.SaveChangesAsync () > 0;
                if (succes) return Unit.Value;
                throw new Exception ("Problem saving changes");
            }
        }
    }
}