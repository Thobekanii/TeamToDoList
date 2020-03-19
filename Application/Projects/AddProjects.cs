using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
namespace Application.Projects {
    public class AddProjects {
        public class Command : IRequest {
            public Guid Id { get; set ;}
            public string ProjectName { get; set; }
        }
        public class Handler : IRequestHandler<Command> {
            private readonly DataContext _context;
            public Handler (DataContext _context) {
                this._context = _context;
            }

            public async Task<Unit> Handle (Command request, CancellationToken cancellation) {
                var project = new Domain.Project {
                    Id = request.Id,
                        ProjectName = request.ProjectName
                };
                _context.projects.Add(project);
                var succes=await _context.SaveChangesAsync()>0;

                if(succes) return Unit.Value;
                Console.Write(Unit.Value);
                throw new Exception("Problem saving changes");
            }
        }
    }
}