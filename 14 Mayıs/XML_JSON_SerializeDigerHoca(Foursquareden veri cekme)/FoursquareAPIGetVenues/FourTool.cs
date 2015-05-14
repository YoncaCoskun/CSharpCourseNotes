using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareAPIGetVenues
{
    public class FourTool
    {
        public const string clientID = "EGOSDS4LL2KJLY20DPWMXRND3KL13DJVMVKVVJ0PLMJPJQPU";
        public const string clientSecret = "N1351BVZ0YBSHWERNU3R04IJY0X5WEHRQRJHRFDOYFQBJ4D1";
        public const string foodCode = "4d4b7105d754a06374d81259";
        public const string apiUrl = "https://api.foursquare.com/v2/venues/search?";
        public const int radius = 1000;
        public const string latitude = "40.976993";
        public const string longitude = "28.872423";

        string queryUrl = "";
        public string jsonString = "";

        public FourTool()
        {
            Tool();
        }

        private async void Tool()
        {
            queryUrl += apiUrl;
            queryUrl += "client_id=" + clientID;
            queryUrl += "&client_secret=" + clientSecret;
            queryUrl += "&v=" + String.Format("{0:yyyyMMdd}", DateTime.Now);
            queryUrl += String.Format("&ll={0},{1}", latitude, longitude);
            queryUrl += "&radius=" + radius;
            queryUrl += "&categoryId=" + foodCode;

            var client = new HttpClient();
            try
            {
                jsonString = await client.GetStringAsync(queryUrl);
            }
            catch
            { }
        }
        public List<Four.Venue> Firmalar = new List<Four.Venue>();

        public void VerilerBas()
        {
            var returnValue = JsonConvert.DeserializeObject<Four>(jsonString);
            Firmalar = returnValue.response.venues.ToList();
        }
    }
}
