using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClient.DataOperations;
using WcfClient.ServiceReference;

namespace WcfClient.Forms
{
    public partial class AddSTO : Form
    {
        MainForm _mainForm { get; set; }

        public AddSTO(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClient service = new ServiceClient();
            CarService carService = new CarService() { Name = Name.Text, Description = Description.Text };
            service.InsertCarService(carService.Name, carService.Description);
            FlowList flowList = new FlowList();
            flowList.StoList(_mainForm);
            Close();
        }
    }
}
