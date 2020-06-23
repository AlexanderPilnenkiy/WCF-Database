using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
	[OperationContract]
	List<CarService> GetAllCarServices();

	[OperationContract]
	List<Car> GetAllCars();

	[OperationContract]
	List<string> AddServicesFromSto(string STO);

	[OperationContract]
	List<ServiceData> GetServiceData();

	[OperationContract]
	List<CommonInformation> GetCommonInfo(DateTime First, DateTime Second);

	[OperationContract]
	List<CarsFromSto> GetCarsFromSto(string Sto);

	[OperationContract]
	void InsertCarService(string Name, string Description);

	[OperationContract]
	void InsertServiceToCS(string CarService, string Service);

	[OperationContract]
	void InsertCarToService(int CarId, string CarService, string Service);

	[OperationContract]
	void InsertCar(string Brand, int Year, DateTime Date);

	[OperationContract]
	void InsertService(string Name, string Description, double Price);
}