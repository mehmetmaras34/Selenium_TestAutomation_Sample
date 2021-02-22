﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Selenium_TestAutomation_Sample.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TrendyolTest")]
    public partial class TrendyolTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TrendyolTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature", "TrendyolTest", "\tMüşteri olarak trendyol sitesine login olunur ve senaryodaki adımlar gerçekleşti" +
                    "rilir.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
#line 5
    testRunner.And("Chrome browser ayağa kaldırılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("AddAndRemoveTheProductToFavorites")]
        public virtual void AddAndRemoveTheProductToFavorites()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AddAndRemoveTheProductToFavorites", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 4
this.FeatureBackground();
#line hidden
#line 7
 testRunner.And("\'https://www.trendyol.com/\' sitesine gidilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 8
 testRunner.And("Popup kapatılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 9
 testRunner.And("Giriş Yap butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 10
 testRunner.And("E-posta adresi \'mehmet_maras@windowslive.com\' olarak girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 11
 testRunner.And("Şifre \'Poyraz349246\' olarak girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 12
 testRunner.And("Giriş yap butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 13
 testRunner.And("Login olduktan sonra çıkan popup kapatılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 14
 testRunner.And("Arama alanına \'samsung\' yazılarak aratılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 15
 testRunner.And("Rastgele bir ürün seçilerek detay sayfası açılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 16
 testRunner.And("Detay sayfasında ürün favorilere eklenir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 17
 testRunner.And("Favoriler sayfasına gidilerek ürünün olup olmadığı kontrol edilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 18
 testRunner.And("Ürün favorilerden çıkarılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 19
 testRunner.And("Ürünün favorilerde olmadığı doğrulanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
