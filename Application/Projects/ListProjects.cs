using System.Threading;
using System.Collections.Generic;
using Domain;
using MediatR;
using Persistence;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application.Projects
{
    public class ListProjects
    {
        public class Query: IRequest<List<Project>>{}

        public class Handler:IRequestHandler<Query,List<Project>>
        {
           private readonly DataContext _context;
           public Handler (DataContext context) 
           {
               _context=context;
           }
           public async Task<List<Project>> Handle(Query request, CancellationToken cancellationToken)
           {
               var project =await _context.projects.ToListAsync();
               return project;
           }
        }
    }
}