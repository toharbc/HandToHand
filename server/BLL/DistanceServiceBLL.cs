using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
// using System.Configuration;
// using System.Xml.Linq;

//    namespace BLL
//    {
//        public class DistanceService
//        {
//            public object ConfigurationManager { get; private set; }

//            public int GetDistance(string origin, string dest)
//            {
//                string key = ConfigurationManager.AppSettings["APIKEY"];
//                string uri = $"https://maps.googleapis.com/maps/api/distancematrix/xml?key={key}&origins={origin}&destinations={dest}&mode=driving";
//                var client = new RestClient(uri);
//                client.Timeout = -1;
//                var request = new RestRequest(Method.GET);
//                IRestResponse response = client.Execute(request);
//                XElement element = XElement.Parse(response.Content);
//                return int.Parse(element.Descendants("duration").FirstOrDefault()?.Element("value").Value) / 60;

//            }
//        }

//    }


