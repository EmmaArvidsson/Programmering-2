using System;
using Newtonsoft.Json;
using RestSharp;

namespace API
{
    class Program
    {
        var client = new RestClient("http://adressen");
        var request = new RestRequest("/", Method.GET);
        IRestResponse response = client.Execute(request);
        String content = response.Content;
        Menu menu = JsonConvert.DeserializeObject<Menu>(content); // Byt ut till er eget huvudobjekt

    }
}
