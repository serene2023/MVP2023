using TechTalk.SpecFlow;

namespace demoMars.Feature
{
    [Binding]
    class Login
    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
