using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

/// <summary>
/// Summary description for LatLong
/// </summary>
[DataContract]
public class LatLong
{
    [DataMember]
    public LatLongDetails LatLongDetails { get; set; }
}

[DataContract]
public class LatLongDetails
{
    [DataMember]
    public string Lat { get; set; }
    [DataMember]
    public string Long { get; set; }
}