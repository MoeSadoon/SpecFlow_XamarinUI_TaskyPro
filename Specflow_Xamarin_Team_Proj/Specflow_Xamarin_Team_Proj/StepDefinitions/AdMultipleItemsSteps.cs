using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Specflow_Xamarin_Team_Proj.SystemTasks;
using NUnit.Framework;

namespace Specflow_Xamarin_Team_Proj.StepDefinitions
{
    [Binding]
    public class AdMultipleItemsSteps
    {

        List<Task> tasks;
        public ITasks app_tasks;

        [Given(@"a list of tasks")]
        public void GivenAListOfTasks(Table table)
        {
            tasks = table.CreateSet<Task>().ToList();

        }
        
        [When(@"I press add the list of tasks")]
        public void WhenIPressAddTheListOfTasks()
        {
            app_tasks = BeforeAfterHooks.tasks;
            foreach(Task task in tasks)
            {
                app_tasks.AddTask().AddTitle(task.taskName).AddNote(task.taskNote).SaveTask();
            }
        }

        [Then(@"the tasks will appear on home screen")]
        public void ThenTheTasksWillAppearOnHomeScreen()
        {
            foreach(Task task in tasks)
            {
                Assert.IsTrue(app_tasks.HasTask(task.taskName));
            }
        }
    }
}
