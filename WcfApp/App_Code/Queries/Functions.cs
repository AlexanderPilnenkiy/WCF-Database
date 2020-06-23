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

    public static string AddCar(string Brand, int Year, DateTime Date)
    {
        return "select * from add_car('" + Brand + "', '" + Year + "', '" + Date + "')";
    }

    public static string ServicesFromSto(string CarService)
    {
        return "select * from get_services_from_sto('" + CarService + "')";
    }

    public static string AddCarToSto(int CarId, string CarService, string Service)
    {
        return "select * from add_car_to_sto('" + CarId + "', '" + CarService + "', '" + Service + "')";
    }

    public static string GetCarsFromSto(string Sto)
    {
        return "select * from get_cars_from_sto('" + Sto + "')";
    }
}