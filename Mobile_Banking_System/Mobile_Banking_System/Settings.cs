using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mobile_Banking_System
{
    public partial class Settings : UserControl
    {
        private static Settings _obj;

        public static Settings Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Settings();
                }
                return _obj;
            }
        }
        public Settings()
        {
            InitializeComponent();
        }
    }
}
