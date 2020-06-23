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
    public partial class AboutSTO : Form
    {
        public ServiceClient service = new ServiceClient();
        public string Sto { get; set; }

        public AboutSTO(string sto)
        {
            InitializeComponent();
            Sto = sto;
        }

        private void AboutSTO_Load(object sender, EventArgs e)
        {
            FlowList flowList = new FlowList();
            flowList.StoInfoList(this);
        }
    }
}
