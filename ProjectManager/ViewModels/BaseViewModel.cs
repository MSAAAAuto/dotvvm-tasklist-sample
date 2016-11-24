using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace ProjectManager.ViewModels
{
	public class BaseViewModel : DotvvmViewModelBase
	{
        public string path = System.Web.Hosting.HostingEnvironment.MapPath("~/json/projects.json");

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

