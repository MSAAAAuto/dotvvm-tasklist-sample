using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using ProjectManager.Models;

namespace ProjectManager.ViewModels
{
    public class UsersViewModel : BaseViewModel
    {
        public List<UserData> Users { get; set; }

        public override Task PreRender()
        {
            Users = UserDataLogic.GetUserData();
            return base.PreRender();
        }
    }
}

