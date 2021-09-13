using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RestSharp.Serialization.Json;
using TechTalk.SpecFlow;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;

namespace RestSpecFlowProject1
{
    class Utils
    {

        GlobalVar prop = new GlobalVar();


        public void setGlobalVar(String name, int id)
        {
            prop.name = name;
            prop.id = id;
        }


        public void createRestClient(Uri uri)
        {
            prop.uri = uri;
            prop.restClient = new RestClient(prop.uri);
        }

        public void createGETByIdRestRequest(int id, Method method)
        {
            prop.restRequest = new RestRequest(id.ToString(), method);

        }

        public void createGETRestRequest()
        {
            prop.restRequest = new RestRequest();
        }


        public void createPOSTRestRequest(Method method)
        {
            prop.restRequest = new RestRequest(method);
        }

        public void executeGETRestRequest()
        {
            try
            {
                prop.restResponse = (RestResponse)prop.restClient.Execute(prop.restRequest);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception found ----> "+e);
            }
        }
        public void executePOSTTRestRequest()
        {
            prop.restResponse = (RestResponse)prop.restClient.Execute(prop.restRequest);
        }

        public void deserializeOP()
        {
            var deser = new JsonDeserializer();
            prop.deserializedOP = deser.Deserialize<Dictionary<string, string>>(prop.restResponse);
        }


        public void createJSONObj(string name, int id)
        {
            prop.postData = new POSTData();
            {
                prop.postData.name = name;
                prop.postData.id = id;
            };

            prop.JSONpayload = JsonConvert.SerializeObject(prop.postData);
            Console.WriteLine(prop.JSONpayload);
        }
        public void serializeOP()
        {
            string payloadJSON = JsonConvert.SerializeObject(prop.postData);
            prop.restRequest.AddHeader("Content-Type", "application/json");
            prop.restRequest.AddHeader("Accept", "application/json");
            prop.restRequest.AddHeader("api_key", "special-key");
            prop.restRequest.AddJsonBody(payloadJSON);
            Console.WriteLine("JSON Payload to be passed ----> " + payloadJSON);            
        }



        public void assertAttrib(string key, string val)
        {

            deserializeOP();
            var attribKey = prop.deserializedOP[key];
            Assert.That(attribKey, Is.EqualTo(val), "Invalid key-val pair");
        }


        public void assertAttrib(string key, int val)
        {
            var attribKey = prop.deserializedOP[key];
            Console.WriteLine(key + " as received ----> "+ attribKey);
            Assert.That(attribKey, Is.EqualTo(val.ToString()), "Invalid key-val pair");
        }


        public void assertStatusCode(int statusCode)
        {
            Console.WriteLine("Status Code as received in the response----> "+(int)prop.restResponse.StatusCode);
            Assert.That((int)prop.restResponse.StatusCode, Is.EqualTo(statusCode), "Invalid status code");
        }   
    }
}
