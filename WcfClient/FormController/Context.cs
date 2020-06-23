using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClient.Forms;
using WcfClient.ServiceReference;

namespace WcfClient.FormController
{
    class Context
    {
        int TypeOfMenu, SelectedYear, SelectedId;
        string SelectedService, SelectedAuto, SelectedDate;

        public void OnClick(MainForm form1, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Clear();
                int currentMouseOverRow = form1.ItemsList.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    switch (form1.CurrentList)
                    {
                        case 0:
                            m.MenuItems.Add(new MenuItem("Информация об СТО", MenuItemNew_Click));
                            break;
                        case 1:
                            m.MenuItems.Add(new MenuItem("Привязать к СТО", MenuItemNew_Click));
                            SelectedService = form1.ItemsList[2, form1.ItemsList.CurrentRow.Index].Value.ToString();
                            break;
                        case 2:
                            m.MenuItems.Add(new MenuItem("Отправить на СТО", MenuItemNew_Click));
                            SelectedAuto = form1.ItemsList[0, form1.ItemsList.CurrentRow.Index].Value.ToString();
                            SelectedDate = Convert.ToString(form1.ItemsList[1, form1.ItemsList.CurrentRow.Index].Value);
                            SelectedId = Convert.ToInt32(form1.ItemsList[2, form1.ItemsList.CurrentRow.Index].Value.ToString());
                            SelectedYear = Convert.ToInt32(form1.ItemsList[3, form1.ItemsList.CurrentRow.Index].Value.ToString());
                            break;
                        default:
                            break;
                    }
                }
                TypeOfMenu = form1.CurrentList;
                m.Show(form1.ItemsList, new Point(e.X, e.Y));
            }
        }

        private void MenuItemNew_Click(Object sender, System.EventArgs e)
        {
            switch (TypeOfMenu)
            {
                case 0:
                    break;
                case 1:
                    AddServiceToSTO addServiceToSTO = new AddServiceToSTO(SelectedService);
                    addServiceToSTO.Show();
                    break;
                case 2:
                    AutoToSTO autoToSTO = new AutoToSTO(SelectedAuto, SelectedYear, SelectedDate, SelectedId);
                    autoToSTO.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
