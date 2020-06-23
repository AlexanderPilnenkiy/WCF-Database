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
    public partial class AddService : Form
    {
        MainForm _mainForm { get; set; }

        public AddService(MainForm main)
        {
            InitializeComponent();
            _mainForm = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClient service = new ServiceClient();
            service.InsertService(Name.Text, Description.Text, Convert.ToDouble(Price.Value));
            FlowList flowList = new FlowList();
            flowList.ServicesList(_mainForm);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
