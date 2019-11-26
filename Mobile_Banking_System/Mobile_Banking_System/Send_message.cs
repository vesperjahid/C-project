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
    public partial class Send_message : UserControl
    {
        private static Send_message _obj;

        public static Send_message Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Send_message();
                }
                return _obj;
            }
        }

        private dbconfig con;
        public Send_message()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Send_message_Load(object sender, EventArgs e)
        {
            con = new dbconfig();
            con.query("select * from employee_acc");
            comboBox1.Items.Clear();
            foreach (DataRow dr in con.queryEx().Rows)
            {
                comboBox1.Items.Add(dr[9].ToString());
            }
        }

        
    }
}
