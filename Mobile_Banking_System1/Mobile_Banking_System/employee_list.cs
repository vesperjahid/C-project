using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mobile_Banking_System
{
    public partial class employee_list : UserControl
    {
        private static employee_list _obj;
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-G5H300K;Initial Catalog=Bank_Management_System;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select first_name,last_name,father_name,mother_name,mobile_number,email,nid,gander,dob, address, photo,signature,account_no,acount_type from [employee_acc]",con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
