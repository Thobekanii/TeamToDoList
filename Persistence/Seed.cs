using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence {
    public class Seed {
        public static void SeedData (DataContext context) {
            if (!context.projects.Any ()) {
                var project = new List<Project> {
                    new Project {
                    ProjectName = "Staff Salary"
                    },
                    new Project {
                    ProjectName = "Accounting System"
                    },
                    new Project {
                    ProjectName = "Sales Accounting"
                    },
                };
                context.projects.AddRange (project);
            }

            if (!context.assignees.Any ()) {
                var assignees = new List<Assignee> {
                    new Assignee {
                    AssigneeName = "Thobekai"
                    },
                    new Assignee {
                    AssigneeName = "Thabo"
                    },
                };
                context.assignees.AddRange (assignees);
            }

            if (!context.statuses.Any ()) {
                var status = new List<Status> {
                    new Status {
                    StatusName = "Active"
                    },
                    new Status {
                    StatusName = "Closed"
                    },
                    new Status {
                    StatusName = "Completed"
                    },
                };
                context.statuses.AddRange (status);
            }
            context.SaveChanges ();
        }
    }
}