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
    public partial class CommonInfo : Form
    {
        FlowList flowList = new FlowList();

        public CommonInfo()
        {
            InitializeComponent();
            flowList.CommonInfoList(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowList.CommonInfoList(this);
        }
    }
}
