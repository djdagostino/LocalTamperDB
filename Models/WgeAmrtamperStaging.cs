﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TestClusterProj.Models;

public partial class WgeAmrtamperStaging
{
    public string MeterName { get; set; }

    public string TamperType { get; set; }

    public DateTime? DiscTime { get; set; }

    public DateTime? EventTime { get; set; }

    public bool? Processed { get; set; }

    public string Category { get; set; }

    public short? ClusterHold { get; set; }
}