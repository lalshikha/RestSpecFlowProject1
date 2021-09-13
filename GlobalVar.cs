using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSpecFlowProject1
{
    class GlobalVar
    {
        public Uri uri;
        public string name;
        public int id;
        public RestClient restClient;
        public RestRequest restRequest;
        public RestResponse restResponse;
        public Dictionary<string, string> deserializedOP;
        public string JSONpayload;
        public POSTData postData;
    }
}
