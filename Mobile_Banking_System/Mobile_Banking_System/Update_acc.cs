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
    public partial class Update_acc : UserControl
    {
        private static Update_acc _obj;

        public static Update_acc Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Update_acc();
                }
                return _obj;
            }
        }
        public Update_acc()
        {
            InitializeComponent();
        }

        private void Update_acc_Load(object sender, EventArgs e)
        {

        }
    }
}
