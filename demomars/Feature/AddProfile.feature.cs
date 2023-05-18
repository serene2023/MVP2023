﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace demoMars.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AddProfile")]
    public partial class AddProfileFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "AddProfile.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "AddProfile", "As a Seller(user), I want the feature to add user’s Profile Details\r\nSo that the " +
                    "people seeking for some skills can look into user details", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User able to launch the homepage")]
        [NUnit.Framework.CategoryAttribute("demoMars")]
        public void UserAbleToLaunchTheHomepage()
        {
            string[] tagsOfScenario = new string[] {
                    "demoMars"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User able to launch the homepage", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("User able to launch the homepage profile successfully with valid username and pas" +
                        "sword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.And("User able to view the homepage profile launched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.When("User click on Edit Description", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And("User able to edit descriptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.When("User click on Add New “Languages”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.And("User able to enter Add Language, select “Choose language level” and click “Add”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.When("User click on Add New “Skills”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.And("User able to enter Add Skills, select “Choose Skill level” and click “Add”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.When("User click on Add New “Education”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.And("User able to enter “College/University Name”, select “Country of college/universi" +
                        "ty”, select “Title”, enter “Degree”, select “Year of graduation” and click “Add”" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.When("User click on Add New “Certifications”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.And("User able to enter Certificate or Award, enter Certified from, select “Year” and " +
                        "click “Add”", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.When("User click on Edit Availability", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.And("User able to select Availability", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.When("User click on Edit Hours", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.And("User able to select Hours", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.When("User click on Edit Earn Target", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.And("User able to select Earn Target", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.Then("User able to see the updated details on homepage profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
