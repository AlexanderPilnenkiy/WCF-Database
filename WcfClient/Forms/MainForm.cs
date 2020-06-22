﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClient.DataOperations;
using WcfClient.FormController;
using WcfClient.Forms;
using WcfClient.ServiceReference;

namespace WcfClient
{
    public partial class MainForm : Form
    {
        public ServiceClient service = new ServiceClient();
        public int CurrentList;
        FlowList flowList = new FlowList();

        public MainForm()
        {
            InitializeComponent();
            flowList.StoList(this);
        }

        private void списокСТОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowList.StoList(this);
        }

        private void списокУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowList.ServicesList(this);
        }

        private void списокАвтомобилейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowList.CarsList(this);
        }

        private void ItemsList_MouseClick(object sender, MouseEventArgs e)
        {
            Context context = new Context();
            context.OnClick(this, e);
        }

        private void добавитьСТОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSTO addSTO = new AddSTO(this);
            addSTO.Show();
        }

        private void добавитьУслугуКСТОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}