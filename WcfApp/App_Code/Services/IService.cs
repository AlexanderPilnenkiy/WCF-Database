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
	void DeleteCarService(string CarService);

	[OperationContract]
	List<Car> GetAllCars();

	[OperationContract]
	void InsertCar(Car car);

	[OperationContract]
	void DeleteCar(string Car);

	[OperationContract]
	List<ServiceData> GetServiceData();

	[OperationContract]
	void InsertService(ServiceData serviceData);

	[OperationContract]
	void DeleteService(string Service);
}