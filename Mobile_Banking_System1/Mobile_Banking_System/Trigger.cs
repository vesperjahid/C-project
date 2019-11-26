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
    public partial class Trigger : UserControl
    {
        private static Trigger _obj;

        public static Trigger Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Trigger();
                }
                return _obj;
            }
        }
        public Trigger()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            DataRow row = dt.NewRow();
            row["id"] = "001";
            dt.Rows.Add(row);

            foreach(DataRow Drow in dt.Rows)
            {
                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = Drow["id"].ToString();
            }

        }

        private void Trigger_Load(object sender, EventArgs e)
        {

        }
    }
}
