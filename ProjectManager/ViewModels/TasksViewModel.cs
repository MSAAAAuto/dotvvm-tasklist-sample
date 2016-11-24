using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using Newtonsoft.Json;
using ProjectManager.Models;

namespace ProjectManager.ViewModels
{
    public class TasksViewModel : BaseViewModel
    {

        public string AddedNameOfUser { get; set; }

        public string AddedTaskDescription { get; set; }

        public string Id => Context.Parameters["Id"].ToString();

        public ProjectData Project { get; set; }

        public List<TaskData> Tasks { get; set; } = new List<TaskData>();

        public List<string> Users { get; set; }

        public string SelectedUser { get; set; }

        public void AddTask()
        {           
            var dataFileTasks = System.IO.File.ReadAllText(@"C:\Users\chyli\Documents\Visual Studio 2015\Projects\ProjectManager\ProjectManager\json\projects.json");

            var projects = JsonConvert.DeserializeObject<List<ProjectData>>(dataFileTasks);

            var project = projects.FirstOrDefault(s => s.Id == Project.Id);
            Tasks.Add(new TaskData() { NameOfUser = SelectedUser, TaskDescription = AddedTaskDescription });
            project.Tasks.Add(new TaskData() { NameOfUser = SelectedUser, TaskDescription = AddedTaskDescription });
            AddedTaskDescription = "";
            
            string projectDataJson = JsonConvert.SerializeObject(projects, Formatting.Indented);
            System.IO.File.WriteAllText(@"C:\Users\chyli\Documents\Visual Studio 2015\Projects\ProjectManager\ProjectManager\json\projects.json", projectDataJson);
        }

        public override Task PreRender()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                var dataFileTasks = System.IO.File.ReadAllText(@"C:\Users\chyli\Documents\Visual Studio 2015\Projects\ProjectManager\ProjectManager\json\projects.json");

                var projects = JsonConvert.DeserializeObject<List<ProjectData>>(dataFileTasks);
                Project = projects.FirstOrDefault(s => s.Id.ToString() == Id);
                Users = UserDataLogic.GetUserData().Select(s => s.Name).ToList();
            }

            return base.PreRender();
        }

        public void CompleteTask(TaskData task)
        {
            task.IsCompleted = true;
        }
    }
}

