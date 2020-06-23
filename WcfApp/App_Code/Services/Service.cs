using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Npgsql;

public class Service : IService
{
	private NpgsqlConnection Connection;

	public Service()
    {
		string ConnectionString = "Server = 127.0.0.1; User Id = car_user; Database = autoservice; Port = 5432; Password = cuser";
		Connection = new NpgsqlConnection(ConnectionString);
		Connection.Close();
		Connection.Open();
	}

	public List<CarService> GetAllCarServices()
	{
		var Command = new NpgsqlCommand(Views.GetCarServicesList, Connection);

		NpgsqlDataReader Reader = Command.ExecuteReader();
		List<CarService> CServise = new List<CarService>();
		while (Reader.Read())
		{
			CServise.Add(new CarService()
			{
				Id = Reader.GetInt32(0),
				Name = Reader.GetString(1),
				Description = Reader.GetString(2)
			});
		}
		return CServise;
	}

	public void InsertCarService(string Name, string Description)
    {
		using (var command = new NpgsqlCommand(Functions.AddCarService(Name, Description), Connection))
		{
			command.ExecuteNonQuery();
		}
    }

	public void InsertCarToService(int CarId, string CarService, string Service)
    {
		using (var command = new NpgsqlCommand(Functions.AddCarToSto(CarId, CarService, Service), Connection))
		{
			command.ExecuteNonQuery();
		}
	}

	public void InsertServiceToCS(string CarService, string Service)
    {
		using (var command = new NpgsqlCommand(Functions.AddCsService(CarService, Service), Connection))
		{
			command.ExecuteNonQuery();
		}
	}

	public List<Car> GetAllCars()
	{
		var Command = new NpgsqlCommand(Views.GetCarsList, Connection);

		NpgsqlDataReader Reader = Command.ExecuteReader();
		List<Car> car = new List<Car>();
		while (Reader.Read())
		{
			car.Add(new Car()
			{
				Id = Reader.GetInt32(0),
				Brand = Reader.GetString(1),
				Year = Reader.GetInt32(2),
				Date = Reader.GetDateTime(3).ToShortDateString(),
			});
		}
		return car;
	}

	public List<CarsFromSto> GetCarsFromSto(string Sto)
    {
		var Command = new NpgsqlCommand(Functions.GetCarsFromSto(Sto), Connection);

		NpgsqlDataReader Reader = Command.ExecuteReader();
		List<CarsFromSto> cars = new List<CarsFromSto>();
		while (Reader.Read())
		{
			cars.Add(new CarsFromSto()
			{
				Brand = Reader.GetString(0),
				Year = Reader.GetInt32(1),
				Service = Reader.GetString(2),
				Date = Reader.GetDateTime(3).ToShortDateString()
			});
		}
		return cars;
	}


	public void InsertCar(string Brand, int Year, DateTime Date)
	{
		using (var command = new NpgsqlCommand(Functions.AddCar(Brand, Year, Date), Connection))
		{
			command.ExecuteNonQuery();
		}
	}

	public List<ServiceData> GetServiceData()
	{
		var Command = new NpgsqlCommand(Views.GetServicesList, Connection);

		NpgsqlDataReader Reader = Command.ExecuteReader();
		List<ServiceData> services = new List<ServiceData>();
		while (Reader.Read())
		{
			services.Add(new ServiceData()
			{
				Id = Reader.GetInt32(0),
				Name = Reader.GetString(1),
				Description = Reader.GetString(2),
				Price = Reader.GetFloat(3)
			});
		}
		return services;
	}

	public void InsertService(string Name, string Description, double Price)
	{
		using (var command = new NpgsqlCommand(Functions.AddService(Name, Description, Price), Connection))
		{
			command.ExecuteNonQuery();
		}
	}

	public List<string>AddServicesFromSto(string STO)
    {
		var Command = new NpgsqlCommand(Functions.ServicesFromSto(STO), Connection);

		NpgsqlDataReader Reader = Command.ExecuteReader();
		List<string> services = new List<string>();
		while (Reader.Read())
		{
			services.Add(Reader.GetString(0));
		}
		return services;
	}
}
