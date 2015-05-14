using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareAPIGetVenues
{
    public class FoursTool
    {
        public const string clientID="THJSFTVFPXKTROJ0NZUEOXFYSGGBW2XI3W5BVHQ4ZOSRF4GR";
        public const string clientSecret = "5Z1EIA0SMNSVLDBU5FAIIUGZPNGE1ZXZF3CTSNAY4CI1DSWP";
        public const string coffeeCode = "4bf58dd8d48988d1e0931735";
        public const string apiURL = "https://api.foursquare.com/v2/venues/search?";
        public const int radius = 1000;
        public const string latitude = "40.976993";
        public const string longitude = "28.872423";

        string queryUrl = "";
       public string jsonString = "";


        public FoursTool()
        {
           Tool();
        }

        private async void Tool()
        {
            queryUrl += apiURL;
            queryUrl += "client_id="+clientID;
            queryUrl += "&client_secret=" + clientSecret;
            queryUrl += "&v=" + String.Format("{0:yyyyMMdd}",DateTime.Now);
            queryUrl += String.Format("&ll={0},{1}", latitude, longitude);
            queryUrl += "&radius=" + radius;
            queryUrl += "&categoryId=" + coffeeCode;

            var client = new HttpClient();

            try
            {
                jsonString = await client.GetStringAsync(queryUrl);
            }
            catch (Exception)
            {        
            }
            
        }

        public List<Four.Venue> Firmalar = new List<Four.Venue>();    //venue=mekan class ının adıdır.

        public void verileriBas()
        {
            var returnValue = JsonConvert.DeserializeObject<Four>(jsonString);
        //    Firmalar = returnValue.Respons
        }
    }
}
