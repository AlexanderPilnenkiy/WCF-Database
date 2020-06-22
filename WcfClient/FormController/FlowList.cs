using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.ServiceReference;

namespace WcfClient.DataOperations
{
    class FlowList
    {
        public void StoList(MainForm form1)
        {
            List<CarService> products = form1.service.GetAllCarServices().ToList();
            form1.ItemsList.DataSource = products;
            form1.ItemsList.Columns["Id"].DisplayIndex = 0;
            form1.ItemsList.Columns["Name"].DisplayIndex = 1;
            form1.ItemsList.Columns["Description"].DisplayIndex = 2;
            form1.CurrentList = 0;
        }

        public void ServicesList(MainForm form1)
        {
            List<ServiceData> services = form1.service.GetServiceData().ToList();
            form1.ItemsList.DataSource = services;
            form1.ItemsList.Columns["Id"].DisplayIndex = 0;
            form1.ItemsList.Columns["Name"].DisplayIndex = 1;
            form1.ItemsList.Columns["Description"].DisplayIndex = 2;
            form1.ItemsList.Columns["Price"].DisplayIndex = 3;
            form1.CurrentList = 1;
        }

        public void CarsList(MainForm form1)
        {
            List<Car> cars = form1.service.GetAllCars().ToList();
            form1.ItemsList.DataSource = cars;
            form1.ItemsList.Columns["Id"].DisplayIndex = 0;
            form1.ItemsList.Columns["Brand"].DisplayIndex = 1;
            form1.ItemsList.Columns["Year"].DisplayIndex = 2;
            form1.ItemsList.Columns["Date"].DisplayIndex = 3;
            form1.CurrentList = 2;
        }
    }
}
