using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

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
        private dbconfig con;
        Image picture;
        Image picture2;
        public Create_acc()
        {
            InitializeComponent();
            identity.Text = Login_page.user_id;
        }

        //email validation

        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        private void Create_acc_Load(object sender, EventArgs e)
        {

            con = new dbconfig();
            con.query("Select count(*) from create_acc");
            DataRow row;
            row = con.queryEx().Rows[0];
            textBox4.Enabled = false;
            int ac = 121122001 + Int32.Parse(row[0].ToString());
            string Ac = Convert.ToString(ac);
            textBox4.Text =Ac;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" || textBox7.Text == "" || textBox6.Text == "" || textBox5.Text == "" || textBox12.Text=="" || textBox11.Text=="" || textBox14.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox10.Text == "")
            {
                label23.Text = "*** All feild filup required";
                label23.ForeColor = Color.Red;
            }       
            else
            {
                if (button1.Text == "Upload" || button2.Text == "Upload")
                {
                    label23.Text = "*** Upload photo & sinature";
                    label23.ForeColor = Color.Red;
                }
                else
                {
                    if (comboBox1.Text == "" || comboBox2.Text == "")
                    {
                        label23.Text = "*** Select gander or acount type";
                        label23.ForeColor = Color.Red;
                    }
                    else
                    {
                        if(dateTimePicker1.Value.ToString() ==" " || dateTimePicker2.Value.ToString()==" ")
                        {
                            label23.Text = "date of birth & select type";
                        }
                        else
                        {
                            con = new dbconfig();
                            con.query("insert into create_acc(first_name, last_name, father_name, mother_name, mobile_number, email, nid_student_id, gander, dob, address, photo, signature, account_no, opening_date, acount_type, password,employee_id) values('" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox12.Text + "','" + textBox11.Text + "','" + textBox14.Text + "','" + comboBox1.Text.ToString() + "','" + dateTimePicker1.Value.ToString() + "','" + textBox3.Text + "',@pic,@pic2,'" + textBox4.Text.ToString() + "','" + dateTimePicker1.Value.ToString() + "','" + comboBox1.Text.ToString() + "','" + textBox10.Text + "','" + identity.Text + "')");
                            con.cmd.Parameters.AddWithValue("@pic", textBox4.Text + ".jpg");
                            con.cmd.Parameters.AddWithValue("@pic2", "s-" + textBox4.Text + ".jpg");
                            con.querynonEx();
                            SaveFileDialog s = new SaveFileDialog();
                            s.Filter = "JPG(*.JPG)|*.jpg|PNG(*.png)|*.png";
                            picture.Save(@"C:\\Users\\vesper\\Desktop\\DBMS project\\Mobile_Banking_System\\Mobile_Banking_System\\Resorces\\UserImage\\" + textBox4.Text + ".jpg", ImageFormat.Jpeg);
                            picture2.Save(@"C:\\Users\\vesper\\Desktop\\DBMS project\\Mobile_Banking_System\\Mobile_Banking_System\\Resorces\\signature\\s-" + textBox4.Text + ".jpg", ImageFormat.Png);
                            MessageBox.Show("Account open seccessfully");
                        }
                    }
                }

                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg|PNG(*.png)|*.png";
            if(f.ShowDialog()== DialogResult.OK)
            {
                string name = f.FileName;
                button1.Text = name;
                button1.BackColor = Color.Gray;
                picture = Image.FromFile(f.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg|PNG(*.png)|*.png";
            if (f.ShowDialog() == DialogResult.OK)
            {
                string name = f.FileName;
                button2.Text = name;
                button2.BackColor = Color.Gray;
                picture2 = Image.FromFile(f.FileName);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if(emailIsValid(textBox11.Text) == false)
            {
                textBox11.BackColor = Color.Red;
            }
            else
            {
                textBox11.BackColor = Color.White;
            }
        }
    }
}
