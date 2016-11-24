using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace ProjectManager.ViewModels
{
	public class BaseViewModel : DotvvmViewModelBase
	{
        public void RedirectToUsers()
        {
            Context.RedirectToRoute("Users");
        }

        public void RedirectToProjects()
        {
            Context.RedirectToRoute("Projects");
        }
	}
}

