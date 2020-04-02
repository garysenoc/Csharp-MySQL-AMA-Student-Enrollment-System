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
    public partial class MAINFORM : Form
    {
        public string sID;
        public string sql = "";
        public string pic = "";
        public MySqlCommand sql_cmd = new MySqlCommand();
        public MAINFORM()
        {
            InitializeComponent();
        }

        private void MAINFORM_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            clsMySQL.sql_con.Close();
            clsMySQL.sql_con.Open();
            loadCount1();
            loadCount2();
            loadTotal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SUBJECT s = new SUBJECT();
            this.Hide();
            s.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SUBJECT s = new SUBJECT();
            this.Hide();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADDSTUDENT f = new ADDSTUDENT();
       
            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ADDSTUDENT f = new ADDSTUDENT();
            this.Hide();
           f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MANAGESTUDENT m = new MANAGESTUDENT();
                this.Hide();
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VIEW V = new VIEW();
            this.Hide();
            V.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            this.Hide();
            l.ShowDialog();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            LOGIN l = new LOGIN();
            this.Hide();
            l.ShowDialog();
        }
        private void loadCount1()
        {
            sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '" + comboBox1.Text + "' AND semester ='" + comboBox2.Text + "' AND gradelevel = '11'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                label2.Text = rd["total"].ToString();



            }
            rd.Close();

        }
        private void loadCount2()
        {
            sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '" + comboBox1.Text + "' AND semester ='" + comboBox2.Text + "' AND gradelevel = '12'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                label3.Text = rd["total"].ToString();



            }
            rd.Close();

        }
        private void loadTotal()
        {
            sql = "SELECT count(id)as total FROM tbstudent where schoolyear = '" + comboBox1.Text + "' AND semester ='" + comboBox2.Text + "'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {
                label23.Text = rd["total"].ToString();



            }
            rd.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCount1();
            loadCount2();
            loadTotal();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCount1();
            loadCount2();
            loadTotal();
        }
    }
}
