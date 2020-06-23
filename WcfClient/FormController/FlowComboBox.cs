using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.Connection;
using WcfClient.Forms;
using WcfClient.ServiceReference;

namespace WcfClient.FormController
{
    class FlowComboBox
    {
        public void cbCarServices(AddServiceToSTO toSTO)
        {
            int i = 0, j = 0;
            List<CarService> services = ServiceConnection.Service.GetAllCarServices().ToList();
            foreach (CarService cs in services)
            {
                toSTO.cbSTO.Items.Add(services[i].Name);
                i++;
            }
            List<ServiceData> _services = ServiceConnection.Service.GetServiceData().ToList();
            foreach (ServiceData sd in _services)
            {
                toSTO.cbServices.Items.Add(_services[j].Name);
                j++;
            }
        }

        public void cbCarToSto(AutoToSTO toSTO)
        {
            int i = 0;
            List<CarService> services = ServiceConnection.Service.GetAllCarServices().ToList();
            foreach (CarService cs in services)
            {
                toSTO.cbSTO.Items.Add(services[i].Name);
                i++;
            }
            toSTO.cbServices.Enabled = true;
        }

        public void cbServiceFromSto(AutoToSTO toSTO)
        {
            toSTO.cbServices.Items.Clear();
            int j = 0;
            List<string> _services = ServiceConnection.Service.AddServicesFromSto(toSTO.cbSTO.SelectedItem.ToString()).ToList();
            foreach (string sd in _services)
            {
                toSTO.cbServices.Items.Add(_services[j]);
                j++;
            }
        }
    }
}
