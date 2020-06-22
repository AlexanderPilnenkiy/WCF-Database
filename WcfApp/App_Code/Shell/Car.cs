using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class Car
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Brand { get; set; }
    [DataMember]
    public int Year { get; set; }
    [DataMember]
    public string Date { get; set; }
}