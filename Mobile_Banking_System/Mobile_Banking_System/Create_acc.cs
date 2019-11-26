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
    public partial class Create_acc : UserControl
    {
        private static Create_acc _obj;

        public static Create_acc Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Create_acc();
                }
                return _obj;
            }
        }
        public Create_acc()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }
    }
}
