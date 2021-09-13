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
namespace RestSpecFlowProject1.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("SpecFlowPOSTFeature", Description="\tExecute and Assert POST...", SourceFile="Features\\POST Feature.feature", SourceLine=0)]
    public partial class SpecFlowPOSTFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "POST Feature.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "SpecFlowPOSTFeature", "\tExecute and Assert POST...", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void CheckPOSTRequestForAddingANewPetToPetstore(string uri, string method, string name, string id, string attribkey1, string attribkey2, string statusCode, string method2, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("uri", uri);
            argumentsOfScenario.Add("method", method);
            argumentsOfScenario.Add("name", name);
            argumentsOfScenario.Add("id", id);
            argumentsOfScenario.Add("attribkey1", attribkey1);
            argumentsOfScenario.Add("attribkey2", attribkey2);
            argumentsOfScenario.Add("statusCode", statusCode);
            argumentsOfScenario.Add("method2", method2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("check POST request for adding a new pet to petstore", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given(string.Format("URI is {0}", uri), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When(string.Format("Payload is created with  {0}, {1}", name, id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And(string.Format("URI is executed with a {0} method", method), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then(string.Format("{0} should match", statusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And(string.Format("{0} should be {1}", attribkey1, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("{0} should be {1}", attribkey2, id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("check POST request for adding a new pet to petstore, \"https://petstore.swagger.io" +
            "/v2/pet\"", SourceLine=14)]
        public virtual void CheckPOSTRequestForAddingANewPetToPetstore_HttpsPetstore_Swagger_IoV2Pet()
        {
#line 6
 this.CheckPOSTRequestForAddingANewPetToPetstore("\"https://petstore.swagger.io/v2/pet\"", "\"POST\"", "\"slg\"", "847654321", "\"name\"", "\"id\"", "200", "\"GETBYID\"", ((string[])(null)));
#line hidden
        }
        
        public virtual void AssertPreviousPOSTResponseWithGET(string uri, string method, string name, string id, string attribkey1, string attribkey2, string statusCode, string method2, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("uri", uri);
            argumentsOfScenario.Add("method", method);
            argumentsOfScenario.Add("name", name);
            argumentsOfScenario.Add("id", id);
            argumentsOfScenario.Add("attribkey1", attribkey1);
            argumentsOfScenario.Add("attribkey2", attribkey2);
            argumentsOfScenario.Add("statusCode", statusCode);
            argumentsOfScenario.Add("method2", method2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assert previous POST response with GET", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
 testRunner.Given(string.Format("URI is {0}", uri), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
 testRunner.When(string.Format("{0} is passed in the URI", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.And(string.Format("URI is executed with a {0} method", method2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.Then(string.Format("{0} should match", statusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And(string.Format("{0} should be {1}", attribkey1, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And(string.Format("{0} should be {1}", attribkey2, id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Assert previous POST response with GET, \"https://petstore.swagger.io/v2/pet\"", SourceLine=27)]
        public virtual void AssertPreviousPOSTResponseWithGET_HttpsPetstore_Swagger_IoV2Pet()
        {
#line 18
 this.AssertPreviousPOSTResponseWithGET("\"https://petstore.swagger.io/v2/pet\"", "\"POST\"", "\"slg\"", "847654321", "\"name\"", "\"id\"", "200", "\"GETBYID\"", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion