using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public static class UserDataLogic
    {

        public static List<UserData> GetUserData()
        {
            return new List<UserData>()
            {
            new UserData() { Name = "John Smith", Age = 35, State = true},
            new UserData() { Name = "George Smith", Age = 25, State = true },
            new UserData() { Name = "Gustav Gergo", Age = 31, State = false },
            new UserData() { Name = "Peter Pettigrew", Age = 45, State = false },
            new UserData() { Name = "George Lucas", Age = 22, State = true }
            };
        }
    }
}