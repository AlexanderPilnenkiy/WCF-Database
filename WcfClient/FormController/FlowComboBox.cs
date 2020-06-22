using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.Forms;
using WcfClient.ServiceReference;

namespace WcfClient.FormController
{
    class FlowComboBox
    {
        public void cbCarServices(AddServiceToSTO toSTO)
        {
            int i = 0, j = 0;
            ServiceClient service = new ServiceClient();
            List<CarService> services = service.GetAllCarServices().ToList();
            foreach (CarService cs in services)
            {
                toSTO.cbSTO.Items.Add(services[i].Name);
                i++;
            }
            List<ServiceData> _services = service.GetServiceData().ToList();
            foreach (ServiceData sd in _services)
            {
                toSTO.cbServices.Items.Add(_services[j].Name);
                j++;
            }
        }
    }
}
