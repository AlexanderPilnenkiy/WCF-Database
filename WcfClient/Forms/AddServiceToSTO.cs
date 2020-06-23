using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClient.Connection;
using WcfClient.FormController;
using WcfClient.ServiceReference;

namespace WcfClient.Forms
{
    public partial class AddServiceToSTO : Form
    {
        string CurrentService { get; set; }

        public AddServiceToSTO()
        {
            InitializeComponent();
            FlowComboBox flow = new FlowComboBox();
            flow.cbCarServices(this);
        }

        public AddServiceToSTO(string currentService)
        {
            InitializeComponent();
            FlowComboBox flow = new FlowComboBox();
            flow.cbCarServices(this);
            CurrentService = currentService;
            cbServices.Text = CurrentService;
            cbServices.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceConnection.Service.InsertServiceToCS(cbSTO.Text, cbServices.Text);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
