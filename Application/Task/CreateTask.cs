using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Task {
    public class CreateTask {
        public class Command : IRequest {
            public Guid Id { get; set; }
            public string TaskToDo { get; set; }
            public Guid ProjectId { get; set; }
            public Guid StatusId { get; set; }
            public Guid AssigneeId { get; set; }

            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Description { get; set; }
            public string Comment { get; set; }

        }
        public class Handler : IRequestHandler<Command> {
            private readonly DataContext _context;
            public Handler (DataContext context) {
                _context = context;
            }
            public async Task<Unit> Handle (Command request, CancellationToken cancellationToken) {
                var task = new Domain.Task {
                    Id = request.Id,
                    TaskToDo = request.TaskToDo,
                    ProjectId = request.ProjectId,
                    StatusId = request.StatusId,
                    AssigneeId = request.AssigneeId,
                    StartDate = request.StartDate,
                    EndDate = request.EndDate,
                    Description = request.Description,
                    Comment = request.Comment
                };
                _context.tasks.Add (task);
                var succes = await _context.SaveChangesAsync () > 0;

                if (succes) return Unit.Value;
                throw new Exception ("Problem saving changes");
            }
        }
    }
}