using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mobile_Banking_System
{
    public partial class Login_page : Form
    {
        public static string user_id;
        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private dbconfig con;

        
        public Login_page()
        {
            InitializeComponent();
        }

        private void Login_page_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(70, 205, 83, 52);
            panel5.BackColor = Color.FromArgb(230, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            textBox1.SelectionStart = 0;
            comboBox1.Items.Clear();
            comboBox1.SelectedText = "Select type";
            con = new dbconfig();
            con.query("select * from employee_acc");
            foreach (DataRow dr in con.queryEx().Rows)
            {
                comboBox1.Items.Add(dr[15].ToString());
            }
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(255, 112, 26, 2);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(255, 112, 26, 2);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(255, 0, 0, 64);
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

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(255, 34, 151, 95);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(255, 0, 0, 64);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            move_data(Handle, e);
        }
        public void move_data(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure To Exit Program ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Id")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "User Id";
                textBox1.ForeColor = Color.FromArgb(255, 169, 170, 173);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.FromArgb(255, 169, 170, 173);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="" || textBox1.Text == "User Id" || textBox2.Text == "" || textBox2.Text.ToString() == "Password" || comboBox1.Text == "Select type")
            {

                if (comboBox1.Text == "Select type")
                {
                    label6.Visible = true;
                    label6.Text = "*** Select account type";
                }
                if (textBox2.Text == "" || textBox2.Text.ToString() == "Password")
                {
                    label6.Visible = true;
                    label6.Text = "*** Password empty";
                }
                if (textBox1.Text == "" || textBox1.Text == "User Id")
                {
                    label6.Visible = true;
                    label6.Text = "*** user id empty";
                }
                
            }
            else
            {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5H300K;Initial Catalog=Bank_Management_System;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from employee_acc where id = '"+textBox1.Text+ "' and password = '" + textBox2.Text + "' and acount_type = '" + comboBox1.Text.ToString() + "' ", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {

                    user_id = textBox1.Text;
                    Main m = new Main();
                    this.Hide();
                    m.Show();
                }
            else
            {
                label6.Visible = true;
                label6.Text = "Wrong !!! Enter valid data";
            }
            }
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                label6.Visible = true;
                label6.Text = "*** Only digit accepted";
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
