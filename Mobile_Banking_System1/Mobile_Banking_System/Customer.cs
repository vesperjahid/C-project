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
    public partial class Customer : UserControl
    {

        private static Customer _obj;

        public static Customer Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Customer();
                }
                return _obj;
            }
        }
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-G5H300K;Initial Catalog=Bank_Management_System;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select first_name,last_name,father_name,mother_name,mobile_number,email,nid_student_id,gander,dob, address, photo,signature,account_no,acount_type from [create_acc]", con);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
