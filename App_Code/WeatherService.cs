using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WeatherService" in code, svc and config file together.
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WeatherService" in code, svc and config file together.
public class WeatherService : IWeatherService
{
    public WeatherReports getWeatherData(string city_name, string state_name, int UserName)
    {
        string key = "4b47e918045b2342";
        string output;
        WeatherReports wp = new WeatherReports();

        using (WebClient client = new WebClient())
        {
            string input = "http://api.wunderground.com/api/" + key + "/conditions/q/" + state_name + "/" + city_name + ".json";
            output = client.DownloadString(input);
            wp = JsonConvert.DeserializeObject<WeatherReports>(output);

            wp.current_observation.weather = "Not Available";
            return wp;
        }
    }
}
