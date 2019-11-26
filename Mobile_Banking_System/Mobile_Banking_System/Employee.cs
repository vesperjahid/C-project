using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Banking_System
{
    public partial class Employee : UserControl
    {
        private static Employee _obj;

        public static Employee Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Employee();
                }
                return _obj;
            }
        }
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(employee_list.Instance))
            {
                panel2.Controls.Add(employee_list.Instance);
                employee_list.Instance.Dock = DockStyle.Fill;
                employee_list.Instance.BringToFront();
            }
            else
            {
                employee_list.Instance.BringToFront();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
