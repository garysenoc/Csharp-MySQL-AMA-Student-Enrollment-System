using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace amaEnrollment
{
    public partial class LOGIN : Form
    {
        public string sID;
        public string sql = "";
        public MySqlCommand sql_cmd = new MySqlCommand();
        public string usern, pass, status, fullname;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            clsMySQL.sql_con.Close();
            clsMySQL.sql_con.Open();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textBox1.Text == "Enter Username:")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Silver;
                textBox1.Text = "Enter Username:";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == "Enter Password:")
                textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Silver;
                textBox2.Text = "Enter Password:";
            }   
        }
        private void login(String username, String password)
        {
            sql = "SELECT  * FROM tbadmin WHERE username like '" + username + "' AND password = '" + password + "'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                usern = rd["username"].ToString();
                pass = rd["password"].ToString();
            }
            rd.Close();

            if (username == usern && password == pass)
            {
                MessageBox.Show("Admin have successfully logged in");
                MAINFORM m = new MAINFORM();
                this.Hide();
                m.ShowDialog();


            }
            else if (username == "Enter Username:" || pass == "Enter Password:")
            {
                MessageBox.Show("Please fill up all the requirements", "Fill up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login(textBox1.Text, textBox2.Text);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login(textBox1.Text, textBox2.Text);
            }
        }
    }
}
