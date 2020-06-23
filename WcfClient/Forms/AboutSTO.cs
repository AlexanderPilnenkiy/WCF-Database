using System;
using System.Windows.Forms;
using WcfClient.DataOperations;

namespace WcfClient.Forms
{
    public partial class AboutSTO : Form
    {
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
