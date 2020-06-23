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
using WcfClient.DataOperations;
using WcfClient.ServiceReference;

namespace WcfClient.Forms
{
    public partial class AddCar : Form
    {
        MainForm _mainForm { get; set; }

        public AddCar(MainForm main)
        {
            InitializeComponent();
            _mainForm = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceConnection.Service.InsertCar(Name.Text, Convert.ToInt32(Year.Value), Date.Value);
            FlowList flowList = new FlowList();
            flowList.CarsList(_mainForm);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
