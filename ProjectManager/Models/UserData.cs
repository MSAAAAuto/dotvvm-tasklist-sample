using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class UserData
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public bool State { get; set; }
        public bool IsCompleted { get; set; }
    }
}