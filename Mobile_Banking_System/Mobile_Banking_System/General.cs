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
    public partial class General : UserControl
    {
        private static General _obj;

        public static General Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new General();
                }
                return _obj;
            }
        }
        public General()
        {
            InitializeComponent();
        }

        private void General_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Create_acc.Instance))
            {
                panel2.Controls.Add(Create_acc.Instance);
                Create_acc.Instance.Dock = DockStyle.Fill;
                Create_acc.Instance.BringToFront();
            }
            else
            {
                Create_acc.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Update_acc.Instance))
            {
                panel2.Controls.Add(Update_acc.Instance);
                Update_acc.Instance.Dock = DockStyle.Fill;
                Update_acc.Instance.BringToFront();
            }
            else
            {
                Update_acc.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Delete_acc.Instance))
            {
                panel2.Controls.Add(Delete_acc.Instance);
                Delete_acc.Instance.Dock = DockStyle.Fill;
                Delete_acc.Instance.BringToFront();
            }
            else
            {
                Delete_acc.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Trigger.Instance))
            {
                panel2.Controls.Add(Trigger.Instance);
                Trigger.Instance.Dock = DockStyle.Fill;
                Trigger.Instance.BringToFront();
            }
            else
            {
                Trigger.Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                if (!panel2.Controls.Contains(Send_message.Instance))
            {
                panel2.Controls.Add(Send_message.Instance);
                Send_message.Instance.Dock = DockStyle.Fill;
                Send_message.Instance.BringToFront();
            }
            else
            {
                Send_message.Instance.BringToFront();
            }
        }
    }
}
