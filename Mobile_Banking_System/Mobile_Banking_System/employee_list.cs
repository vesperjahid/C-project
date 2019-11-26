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
    public partial class employee_list : UserControl
    {
        private static employee_list _obj;
        private string _user;
        public static employee_list Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new employee_list();
                }
                return _obj;
            }
        }
        public employee_list()
        {
            InitializeComponent();
        }

        private void employee_list_Load(object sender, EventArgs e)
        {

           
        }
    }
}
