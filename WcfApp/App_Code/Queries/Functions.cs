using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Functions
{
    public static string AddCarService(string Name, string Description)
    {
        return "select * from add_car_service('" + Name + "', '" + Description + "')";
    }

    public static string AddCsService(string CarService, string Service)
    {
        return "select * from add_cs_service('" + CarService + "', '" + Service + "')";
    }

    public static string AddService(string Service, string Description, double Price)
    {
        return "select * from add_service('" + Service + "', '" + Description + "', '" + Price + "')";
    }
}