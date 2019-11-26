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
    public partial class Delete_acc : UserControl
    {
        private static Delete_acc _obj;

        public static Delete_acc Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Delete_acc();
                }
                return _obj;
            }
        }
        public Delete_acc()
        {
            InitializeComponent();
        }

        private void Delete_acc_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
