using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using NUnit.Framework;
using Specflow_Xamarin_Team_Proj.SystemTasks;

namespace Specflow_Xamarin_Team_Proj.StepDefinitions
{
    [Binding]
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class AddATaskSteps
    {
        public ITasks tasks;
        Platform platform;

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            tasks = BeforeAfterHooks.tasks;
        }
        
        [When(@"I add a task called ""(.*)""")]
        public void WhenIAddATaskCalled(string taskName)
        {
            //Table Extensions
            tasks
                .AddTask()
                .AddTitle(taskName)
                .AddNote("Get Eggs from shop");
        }
        
        [When(@"I save the task")]
        public void WhenISaveTheTask()
        {
            tasks.SaveTask();
        }
        
        [Then(@"I should see ""(.*)"" on the homepage")]
        public void ThenIShouldSeeOnTheHomepage(string taskName)
        {
            Assert.IsTrue(tasks.HasTask(taskName));
        }
    }
}