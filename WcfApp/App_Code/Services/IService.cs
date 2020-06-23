using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени интерфейса "IService" в коде и файле конфигурации.
[ServiceContract]
public interface IService
{
	[OperationContract]
	List<CarService> GetAllCarServices();

	[OperationContract]
	void InsertCarService(string Name, string Description);

	[OperationContract]
	void InsertServiceToCS(string CarService, string Service);

	[OperationContract]
	List<Car> GetAllCars();

	[OperationContract]
	List<string> AddServicesFromSto(string STO);

	[OperationContract]
	void InsertCarToService(int CarId, string CarService, string Service);

	[OperationContract]
	void InsertCar(string Brand, int Year, DateTime Date);

	[OperationContract]
	List<ServiceData> GetServiceData();

	[OperationContract]
	List<CommonInformation> GetCommonInfo(DateTime First, DateTime Second);

	[OperationContract]
	List<CarsFromSto> GetCarsFromSto(string Sto);

	[OperationContract]
	void InsertService(string Name, string Description, double Price);
}