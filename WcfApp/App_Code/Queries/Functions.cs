﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Functions
{
    public static string AddCarService(string Name, string Description)
    {
        return "select * from add_car_service('" + Name + "', '" + Description + "')";
    }
}