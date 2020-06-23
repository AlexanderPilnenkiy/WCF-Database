using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract]
public class CommonInformation
{
    [DataMember]
    public string STO { get; set; }
    [DataMember]
    public int CountOfServices { get; set; }
    [DataMember]
    public double SummaryPrice { get; set; }
}