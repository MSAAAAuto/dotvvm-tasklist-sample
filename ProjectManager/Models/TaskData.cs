using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class TaskData
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NameOfUser { get; set; }
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}