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
    public partial class Accounts : UserControl
    {
        private static Accounts _obj;

        public static Accounts Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Accounts();
                }
                return _obj;
            }
        }
        public Accounts()
        {
            InitializeComponent();
        }

        private void Branches_Load(object sender, EventArgs e)
        {

        }
    }
}
