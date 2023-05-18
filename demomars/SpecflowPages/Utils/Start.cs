﻿using demoMars.Pages.Helpers;
using TechTalk.SpecFlow;
using static demoMars.Pages.Helpers.CommonMethods;

namespace demoMars.Pages.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignIn class
            SignIn.SigninStep();
        }

        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();

            // end test. (Reports)
            CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();


        }
    }

}

