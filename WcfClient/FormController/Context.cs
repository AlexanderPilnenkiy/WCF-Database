using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfClient.FormController
{
    class Context
    {
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
                            break;
                        case 2:
                            m.MenuItems.Add(new MenuItem("Отправить на СТО", MenuItemNew_Click));
                            break;
                        default:
                            break;
                    }
                }
                m.Show(form1.ItemsList, new Point(e.X, e.Y));
            }
        }

        private void MenuItemNew_Click(Object sender, System.EventArgs e)
        {

        }
    }
}
