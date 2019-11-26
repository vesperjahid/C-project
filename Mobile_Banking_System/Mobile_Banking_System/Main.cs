using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Banking_System
{
        public partial class Main : Form
    {
        
        private dbconfig con;
        public Main(string user_id)
        {
            InitializeComponent();
            timer1.Start();
            identity.Text = user_id;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
                         

            panel1.BackColor = Color.FromArgb(130, 11, 19, 43);
            panel3.BackColor = Color.FromArgb(200, 11, 19, 43);
            panel2.BackColor = Color.FromArgb(200, 28, 37, 65);
            panel6.BackColor = Color.FromArgb(255, 39, 40, 56);
            back.BackColor = Color.FromArgb(100, 139, 40, 56);

            // display date & time

            date.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            


            panel2.Controls.Add(Dashboard.Instance);
            Dashboard.Instance.Dock = DockStyle.Fill;
            Dashboard.Instance.BringToFront();

            // passing value from login;
            con = new dbconfig();
            con.query("select * from employee_acc where id ='"+identity.Text+"'");
            DataRow row;
            row = con.queryEx().Rows[0];
            label4.Text = row[1].ToString().Trim() + " " + row[2].ToString().Trim();
            label5.Text = row[15].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Program ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            welcome wl = new welcome();
            wl.move_data(Handle, e);
        }
        
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(255, 112, 26, 2);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(1, 0,0, 0);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(255, 112, 26, 2);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(1, 0, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void round1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 0, 64, 64);
            button2.BackColor = Color.FromArgb(1, 0, 0, 0);
            button3.BackColor = Color.FromArgb(1, 0, 0, 0);
            button4.BackColor = Color.FromArgb(1, 0, 0, 0);
            button5.BackColor = Color.FromArgb(1, 0, 0, 0);
            button6.BackColor = Color.FromArgb(1, 0, 0, 0);

            

            if (!panel2.Controls.Contains(Dashboard.Instance))
            {

                panel2.Controls.Add(Dashboard.Instance);
                Dashboard.Instance.Dock = DockStyle.Fill;
                Dashboard.Instance.BringToFront();
            }
            else
            {
                Dashboard.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 0, 0, 0);
            button2.BackColor = Color.FromArgb(255, 0, 64, 64);
            button3.BackColor = Color.FromArgb(1, 0, 0, 0);
            button4.BackColor = Color.FromArgb(1, 0, 0, 0);
            button5.BackColor = Color.FromArgb(1, 0, 0, 0);
            button6.BackColor = Color.FromArgb(1, 0, 0, 0);

            if (!panel2.Controls.Contains(General.Instance)) {
                panel2.Controls.Add(General.Instance);
                General.Instance.Dock = DockStyle.Fill;
                General.Instance.BringToFront();
            }
            else
            {
                General.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 0, 0, 0);
            button2.BackColor = Color.FromArgb(1, 0, 0, 0);
            button3.BackColor = Color.FromArgb(255, 0, 64, 64);
            button4.BackColor = Color.FromArgb(1, 0, 0, 0);
            button5.BackColor = Color.FromArgb(1, 0, 0, 0);
            button6.BackColor = Color.FromArgb(1, 0, 0, 0);

            if (!panel2.Controls.Contains(Customer.Instance))
            {
                panel2.Controls.Add(Customer.Instance);
                Customer.Instance.Dock = DockStyle.Fill;
                Customer.Instance.BringToFront();
            }
            else
            {
                Customer.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 0, 0, 0);
            button2.BackColor = Color.FromArgb(1, 0, 0, 0);
            button3.BackColor = Color.FromArgb(1, 0, 0, 0);
            button4.BackColor = Color.FromArgb(255, 0, 64, 64);
            button5.BackColor = Color.FromArgb(1, 0, 0, 0);
            button6.BackColor = Color.FromArgb(1, 0, 0, 0);

            if (!panel2.Controls.Contains(Employee.Instance))
            {
                panel2.Controls.Add(Employee.Instance);
                Employee.Instance.Dock = DockStyle.Fill;
                Employee.Instance.BringToFront();
            }
            else
            {
                Employee.Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 0, 0, 0);
            button5.BackColor = Color.FromArgb(255, 0, 64, 64);
            button3.BackColor = Color.FromArgb(1, 0, 0, 0);
            button4.BackColor = Color.FromArgb(1, 0, 0, 0);
            button2.BackColor = Color.FromArgb(1, 0, 0, 0);
            button6.BackColor = Color.FromArgb(1, 0, 0, 0);

            if (!panel2.Controls.Contains(Accounts.Instance))
            {
                panel2.Controls.Add(Accounts.Instance);
                Accounts.Instance.Dock = DockStyle.Fill;
                Accounts.Instance.BringToFront();
            }
            else
            {
                Accounts.Instance.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 0, 0, 0);
            button6.BackColor = Color.FromArgb(255, 0, 64, 64);
            button3.BackColor = Color.FromArgb(1, 0, 0, 0);
            button4.BackColor = Color.FromArgb(1, 0, 0, 0);
            button5.BackColor = Color.FromArgb(1, 0, 0, 0);
            button2.BackColor = Color.FromArgb(1, 0, 0, 0);

            if (!panel2.Controls.Contains(Settings.Instance))
            {
                panel2.Controls.Add(Settings.Instance);
                Settings.Instance.Dock = DockStyle.Fill;
                Settings.Instance.BringToFront();
            }
            else
            {
                Settings.Instance.BringToFront();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;
            this.time.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if(search.Text == "search......")
            {
                search.Text = "";
            }
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "search......";
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
