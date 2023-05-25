using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DVLAQuery
{
    public class Program
    {
        // ***************************************************************************************************
        private static readonly string targetRegistration = "LF63NDX";
        // ***************************************************************************************************

        private static readonly string Url = ConfigurationManager.AppSettings["dvla-base-url"];
        private static readonly string ApiAuthenticationKey = ConfigurationManager.AppSettings["dvla-api-key"];
        

        private static void Main()
        {
            GetRegistration().Wait();
            Console.ReadLine();
        }

        private static async Task GetRegistration()
        {
            var returnedVehicleData = await DvlaApi(targetRegistration);

            Console.WriteLine(JsonConvert.SerializeObject(returnedVehicleData, Formatting.Indented));
            Console.WriteLine(Environment.NewLine + @$"Press Enter to quit.....");
        }

        public static async Task<DVLAReturnedObject?> DvlaApi(string registrationPlate)
        {
            try
            {
                var client = new RestClient(Url);
                var request = new RestRequest(Url, Method.Post);


                request.AddHeader("x-api-key", ApiAuthenticationKey);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", "{\n\t\"registrationNumber\":\"" + registrationPlate + "\"}", ParameterType.RequestBody);
                
                var response = await client.ExecuteAsync(request);

                return JsonConvert.DeserializeObject<DVLAReturnedObject>(response.Content ?? string.Empty);
            }
            catch
            {
                return new DVLAReturnedObject();
            }
        }
    }
}


