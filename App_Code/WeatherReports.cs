using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

/// <summary>
/// Summary description for Class1
/// </summary>

[DataContract]
public class WeatherReports
{
    [DataMember]
    public current_observations current_observation { get; set; }
}


[DataContract]
public class current_observations
{
    [DataMember]
    public string weather { get; set; }
    [DataMember]
    public string temperature_string { get; set; }
    [DataMember]
    public string temp_f { get; set; }
    [DataMember]
    public string temp_c { get; set; }
    [DataMember]
    public string relative_humidity { get; set; }
    [DataMember]
    public string wind_string { get; set; }
    [DataMember]
    public string wind_dir { get; set; }
    [DataMember]
    public string wind_degrees { get; set; }
    [DataMember]
    public string wind_mph { get; set; }
    [DataMember]
    public string wind_gust_mph { get; set; }
    [DataMember]
    public int UserName { get; set; }

}

public class RESULT
{
    public string name { get; set; }
    public string type { get; set; }
    public string c { get; set; }
    public string zmw { get; set; }
    public string tz { get; set; }
    public string tzs { get; set; }
    public string l { get; set; }
    public string ll { get; set; }
    public string lat { get; set; }
    public string lon { get; set; }
}

public class RootObject
{
    public List<RESULT> RESULTS { get; set; }
}
