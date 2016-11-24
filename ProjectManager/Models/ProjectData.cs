using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class ProjectData
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public List<TaskData> Tasks { get; set; } = new List<TaskData>();
    }
}