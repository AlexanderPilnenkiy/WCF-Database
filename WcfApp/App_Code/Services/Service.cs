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

	public void DeleteCarService(string ServiceName)
	{

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

	public void InsertCar(Car carData)
	{

	}

	public void DeleteCar(string Car)
	{

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

	public void InsertService(ServiceData serviceData)
	{

	}

	public void DeleteService(string Service)
	{

	}
}
