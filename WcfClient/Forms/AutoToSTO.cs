﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClient.FormController;
using WcfClient.ServiceReference;

namespace WcfClient.Forms
{
    public partial class AutoToSTO : Form
    {
        string Auto { get; set; }
        int _Year { get; set; }
        string _Date { get; set; }
        int CarId { get; set; }

        FlowComboBox comboBox = new FlowComboBox();

        public AutoToSTO(string _auto, int _year, string _date, int _carId)
        {
            InitializeComponent();
            Auto = _auto;
            _Year = _year;
            _Date = _date;
            CarId = _carId;
            comboBox.cbCarToSto(this);
            Name.Text = Auto;
            Year.Value = _Year;
            Date.Value = Convert.ToDateTime(_Date);
        }

        private void cbSTO_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FlowComboBox flowComboBox = new FlowComboBox();
            flowComboBox.cbServiceFromSto(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClient service = new ServiceClient();
            service.InsertCarToService(CarId, cbSTO.SelectedItem.ToString(), cbServices.SelectedItem.ToString());
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}