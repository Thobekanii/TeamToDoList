using System;

namespace Domain
{
    public class Task
    {
        public Guid Id { get; set; }
        public string TaskToDo {get;set;}

            public Guid ProjectId { get; set; }
            public Project Project {get;set;}

            public Guid StatusId { get; set; }
            public Status Status {get;set;}

            public Guid AssigneeId { get; set; }
            public Assignee Assignee {get;set;}

            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public DateTime DeadLine{get;set;}

            public string Description { get; set; }
            public string Comment { get; set; }

    }
}