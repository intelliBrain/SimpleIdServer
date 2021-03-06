// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.Scim.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UsersErrorsFeature : Xunit.IClassFixture<UsersErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UsersErrors.feature"
#line hidden
        
        public UsersErrorsFeature(UsersErrorsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UsersErrors", "\tCheck the errors returned by the /Users endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schemas attribute is missing (HTTP POST)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schemas attribute is missing (HTTP POST)")]
        public virtual void ErrorIsReturnedWhenSchemasAttributeIsMissingHTTPPOST()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schemas attribute is missing (HTTP POST)", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 5
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table25, "When ");
#line 8
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.Then("JSON \'response.detail\'=\'schemas attribute is missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schema is not valid (HTTP POST)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schema is not valid (HTTP POST)")]
        public virtual void ErrorIsReturnedWhenSchemaIsNotValidHTTPPOST()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schema is not valid (HTTP POST)", null, ((string[])(null)));
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table26.AddRow(new string[] {
                        "schemas",
                        "[ \"invalidschema\" ]"});
#line 18
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table26, "When ");
#line 22
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("JSON \'response.detail\'=\'the required schemas urn:ietf:params:scim:schemas:core:2." +
                    "0:User,urn:ietf:params:scim:schemas:extension:enterprise:2.0:User are missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when trying to add two resources with the same unique attribute" +
            "")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when trying to add two resources with the same unique attribute" +
            "")]
        public virtual void ErrorIsReturnedWhenTryingToAddTwoResourcesWithTheSameUniqueAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when trying to add two resources with the same unique attribute" +
                    "", null, ((string[])(null)));
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table27.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table27.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table27.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table27.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 32
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table27, "When ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table28.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table28.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table28.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table28.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 40
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table28, "When ");
#line 47
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.Then("HTTP status code equals to \'409\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.Then("JSON \'status\'=\'409\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.Then("JSON \'response.status\'=\'409\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.Then("JSON \'response.scimType\'=\'uniqueness\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.Then("JSON \'response.detail\'=\'attribute userName must be unique\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the user doesn\'t exist (HTTP GET)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the user doesn\'t exist (HTTP GET)")]
        public virtual void ErrorIsReturnedWhenTheUserDoesntExistHTTPGET()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the user doesn\'t exist (HTTP GET)", null, ((string[])(null)));
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 57
 testRunner.When("execute HTTP GET request \'http://localhost/Users/1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.Then("JSON \'status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
 testRunner.Then("JSON \'response.detail\'=\'resource 1 not found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when trying to remove an unknown user (HTTP DELETE)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when trying to remove an unknown user (HTTP DELETE)")]
        public virtual void ErrorIsReturnedWhenTryingToRemoveAnUnknownUserHTTPDELETE()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when trying to remove an unknown user (HTTP DELETE)", null, ((string[])(null)));
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 67
 testRunner.When("execute HTTP DELETE request \'http://localhost/Users/1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.Then("JSON \'status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.Then("JSON \'response.detail\'=\'resource 1 not found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schemas attribute is missing (HTTP PUT)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schemas attribute is missing (HTTP PUT)")]
        public virtual void ErrorIsReturnedWhenSchemasAttributeIsMissingHTTPPUT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schemas attribute is missing (HTTP PUT)", null, ((string[])(null)));
#line 76
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 77
 testRunner.When("execute HTTP PUT JSON request \'http://localhost/Users/id\'", ((string)(null)), table29, "When ");
#line 80
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.Then("JSON \'response.detail\'=\'schemas attribute is missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schema is not valid (HTTP PUT)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schema is not valid (HTTP PUT)")]
        public virtual void ErrorIsReturnedWhenSchemaIsNotValidHTTPPUT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schema is not valid (HTTP PUT)", null, ((string[])(null)));
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table30.AddRow(new string[] {
                        "schemas",
                        "[ \"invalidschema\" ]"});
#line 90
 testRunner.When("execute HTTP PUT JSON request \'http://localhost/Users/id\'", ((string)(null)), table30, "When ");
#line 94
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.Then("JSON \'response.detail\'=\'the schemas invalidschema are unknown\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when trying to update an unknown resource (HTTP PUT)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when trying to update an unknown resource (HTTP PUT)")]
        public virtual void ErrorIsReturnedWhenTryingToUpdateAnUnknownResourceHTTPPUT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when trying to update an unknown resource (HTTP PUT)", null, ((string[])(null)));
#line 103
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table31.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
#line 104
 testRunner.When("execute HTTP PUT JSON request \'http://localhost/Users/id\'", ((string)(null)), table31, "When ");
#line 108
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.Then("JSON \'status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.Then("JSON \'response.status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.Then("JSON \'response.scimType\'=\'unknown\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
 testRunner.Then("JSON \'response.detail\'=\'resource id not found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when update an immutable attribute (HTTP PUT)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when update an immutable attribute (HTTP PUT)")]
        public virtual void ErrorIsReturnedWhenUpdateAnImmutableAttributeHTTPPUT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when update an immutable attribute (HTTP PUT)", null, ((string[])(null)));
#line 117
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table32.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table32.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table32.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
            table32.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 118
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table32, "When ");
#line 125
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And("extract \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table33.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\" ]"});
            table33.AddRow(new string[] {
                        "immutable",
                        "str"});
#line 127
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/Users/$id$\'", ((string)(null)), table33, "And ");
#line 132
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 138
 testRunner.Then("JSON \'response.scimType\'=\'mutability\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schemas attribute is missing (HTTP PATCH)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schemas attribute is missing (HTTP PATCH)")]
        public virtual void ErrorIsReturnedWhenSchemasAttributeIsMissingHTTPPATCH()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schemas attribute is missing (HTTP PATCH)", null, ((string[])(null)));
#line 140
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 141
 testRunner.When("execute HTTP PATCH JSON request \'http://localhost/Users/id\'", ((string)(null)), table34, "When ");
#line 144
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 148
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 149
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.Then("JSON \'response.detail\'=\'schemas attribute is missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schema is not valid (HTTP PATCH)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schema is not valid (HTTP PATCH)")]
        public virtual void ErrorIsReturnedWhenSchemaIsNotValidHTTPPATCH()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schema is not valid (HTTP PATCH)", null, ((string[])(null)));
#line 153
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table35.AddRow(new string[] {
                        "schemas",
                        "[ \"invalidschema\" ]"});
#line 154
 testRunner.When("execute HTTP PATCH JSON request \'http://localhost/Users/id\'", ((string)(null)), table35, "When ");
#line 158
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 161
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 164
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 165
 testRunner.Then("JSON \'response.detail\'=\'some schemas are not recognized by the endpoint\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when trying to patch an unknown resource (HTTP PATCH)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when trying to patch an unknown resource (HTTP PATCH)")]
        public virtual void ErrorIsReturnedWhenTryingToPatchAnUnknownResourceHTTPPATCH()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when trying to patch an unknown resource (HTTP PATCH)", null, ((string[])(null)));
#line 167
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table36.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:api:messages:2.0:PatchOp\" ]"});
            table36.AddRow(new string[] {
                        "Operations",
                        "[ ]"});
#line 168
 testRunner.When("execute HTTP PATCH JSON request \'http://localhost/Users/id\'", ((string)(null)), table36, "When ");
#line 173
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 176
 testRunner.Then("JSON \'status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 177
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 178
 testRunner.Then("JSON \'response.status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 179
 testRunner.Then("JSON \'response.scimType\'=\'unknown\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 180
 testRunner.Then("JSON \'response.detail\'=\'resource id not found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when trying to add a none canonical value (HTTP POST)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when trying to add a none canonical value (HTTP POST)")]
        public virtual void ErrorIsReturnedWhenTryingToAddANoneCanonicalValueHTTPPOST()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when trying to add a none canonical value (HTTP POST)", null, ((string[])(null)));
#line 182
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table37.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\", \"urn:ietf:params:scim:schemas:ext" +
                            "ension:enterprise:2.0:User\" ]"});
            table37.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table37.AddRow(new string[] {
                        "externalId",
                        "externalid"});
            table37.AddRow(new string[] {
                        "type",
                        "unsupported"});
            table37.AddRow(new string[] {
                        "employeeNumber",
                        "number"});
#line 183
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table37, "When ");
#line 191
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 193
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 194
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 195
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 196
 testRunner.Then("JSON \'response.scimType\'=\'schemaViolated\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 197
 testRunner.Then("JSON \'response.detail\'=\'property type is not a valid canonical value\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UsersErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UsersErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
