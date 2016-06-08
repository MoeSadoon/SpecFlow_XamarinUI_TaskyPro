using Specflow_Xamarin_Team_Proj.SystemTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Specflow_Xamarin_Team_Proj
{
    [Binding]
    public sealed class BeforeAfterHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static ITasks tasks;
        static Platform platform;

        [BeforeTestRun]
        public static void BeforeScenario()
        {
            Console.WriteLine("Running before Task");
            tasks = AppInitializer.StartApp(platform);
        }

    }
}
