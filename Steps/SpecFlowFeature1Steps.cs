using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace RestSpecFlowProject1.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {   
        Utils utilsObj = new Utils();

        //Given URI is <uri>
        [Given(@"URI is ""(.*)""")]
        public void GivenURIIs(Uri uri)
        {
            utilsObj.createRestClient(uri);
        }

        //When <id> is passed in the URI 
        [When(@"(.*) is passed in the URI")]
        public void WhenIsPassedInTheURI(int id)
        {
                utilsObj.createGETByIdRestRequest(id, Method.GET);
        }

        //When <id> is passed in the URI for DEL 
        [When(@"(.*) is passed in the URI for DEL")]
        public void WhenIsPassedInTheURIForDEL(int id)
        {
            utilsObj.createGETByIdRestRequest(id, Method.DELETE);
        }

        //When URI is executed with a<method> method
        [When(@"URI is executed with a ""(.*)"" method")]
        public void WhenURIIsExecutedWithAMethod(string p0)
        {
            if (p0=="GETALL")
            {
                utilsObj.createGETRestRequest();
                utilsObj.executeGETRestRequest();
            }
            else if(p0 == "GETBYID" | p0 =="DEL")
            {
                Thread.Sleep(4000);
                utilsObj.executeGETRestRequest();
            }
            else if(p0 == "POST" || p0 == "PUT")
            {
                utilsObj.createPOSTRestRequest(Method.POST);
                utilsObj.serializeOP();
                utilsObj.executePOSTTRestRequest();

            }
        }

        //And <attribkey1> should be <name>
        [Then(@"""(.*)"" should be ""(.*)""")]
        public void ThenShouldBe(string attribKey, string attribVal)
        {
            utilsObj.assertAttrib(attribKey, attribVal);
        }

        //And <attribkey2> should be <id>
        [Then(@"""(.*)"" should be (.*)")]
        public void ThenShouldBe(string attribKey, int attribVal)
        {
            utilsObj.assertAttrib(attribKey, attribVal);
        }

        //Then <statusCode> should match
        [Then(@"(.*) should match")]
        public void ThenShouldMatch(int statusCode)
        {
            utilsObj.assertStatusCode(statusCode);
        }

        //When Payload is created with  <name>, <id>
        [When(@"Payload is created with  ""(.*)"", (.*)")]
        public void WhenPayloadIsCreatedWith(string name, int id)
        {
            utilsObj.createJSONObj(name, id);
            //utilsObj.serializeOP();
        }


    }
}
