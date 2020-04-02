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
    public partial class ADDSTUDENT : Form
    {
        public string sID;
        public string sql = "";
        public string pic;
        public MySqlCommand sql_cmd = new MySqlCommand();
        public ADDSTUDENT()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            MAINFORM m = new MAINFORM();
            this.Hide();
            m.ShowDialog();
        }

        private void ADDSTUDENT_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            clsMySQL.sql_con.Close();
            clsMySQL.sql_con.Open();
            disable();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MAINFORM m = new MAINFORM();
            this.Hide();
            m.ShowDialog();
        }

        private void addStudent()
        {
            sql = string.Format("INSERT INTO tbstudent VALUES (null, '{0}', '{1}', '{2}','{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10}','{11}', '{12}', '{13}', '{14}', '{15}', '{16}','{17}', '{18}','{19}', '{20}', '{21}', '{22}', '{23}', '{24}','{25}', '{26}','{27}', '{28}', '{29}', '{30}', '{31}', '{32}')",
      tx1.Text, tx2.Text, tx3.Text, tx4.Text, tx5.Text, tx6.Text, tx7.Text, tx8.Text, tx9.Text, tx10.Text, tx11.Text, tx12.Text, tx13.Text, tx14.Text, tx15.Text, tx16.Text, tx17.Text, tx18.Text, tx19.Text, tx20.Text, tx21.Text, tx22.Text, tx23.Text, tx24.Text, tx25.Text, tx26.Text, tx27.Text, tx28.Text, tx29.Text, tx30.Text,pic,tx31.Text,tx32.Text);
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            sql_cmd.ExecuteNonQuery();
            MessageBox.Show("New Student has been added successfully!", "Add Subject");
         
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void clearAll()
        {
               tx1.Text="";
            tx2.Text="";
            tx3.Text="";
            tx4.Text="";
            tx5.Text="";
            tx6.Text="";
            tx7.Text="";
            tx8.Text="";
            tx9.Text=""; 
            tx10.Text="";
            tx11.Text=""; 
            tx12.Text="";
            tx13.Text="";
            tx14.Text=""; 
            tx15.Text=""; 
            tx16.Text="";
            tx17.Text="";
            tx18.Text="";
            tx19.Text="";
            tx20.Text=""; 
            tx21.Text="";
            tx22.Text=""; 
            tx23.Text=""; 
            tx24.Text=""; 
            tx25.Text=""; 
            tx26.Text=""; 
            tx27.Text="";
            tx28.Text=""; 
            tx29.Text=""; 
            tx30.Text="";
            tx31.Text = "";
            tx32.Text = "";
            pictureBox5.ImageLocation = "";
     
        }

        private void enable()
        {
            tx1.Enabled = true;
            tx2.Enabled = true;
            tx3.Enabled = true;
            tx4.Enabled = true;
            tx5.Enabled = true;
            tx6.Enabled = true;
            tx7.Enabled = true;
            tx8.Enabled = true;
            tx9.Enabled = true;
            tx10.Enabled = true;
            tx11.Enabled = true;
            tx12.Enabled = true;
            tx13.Enabled = true;
            tx14.Enabled = true;
            tx15.Enabled = true;
            tx16.Enabled = true;
            tx17.Enabled = true;
            tx18.Enabled = true;
            tx19.Enabled = true;
            tx20.Enabled = true;
            tx21.Enabled = true;
            tx22.Enabled = true;
            tx23.Enabled = true;
            tx24.Enabled = true;
            tx25.Enabled = true;
            tx26.Enabled = true;
            tx27.Enabled = true;
            tx28.Enabled = true;
            tx29.Enabled = true;
            tx30.Enabled = true;
            button3.Enabled = true;
            tx31.Enabled = true;
            tx32.Enabled = true;
        }
        private void disable()
        {
            tx1.Enabled = false;
            tx2.Enabled = false;
            tx3.Enabled = false;
            tx4.Enabled = false;
            tx5.Enabled = false;
            tx6.Enabled = false;
            tx7.Enabled = false;
            tx8.Enabled = false;
            tx9.Enabled = false;
            tx10.Enabled = false;
            tx11.Enabled = false;
            tx12.Enabled = false;
            tx13.Enabled = false;
            tx14.Enabled = false;
            tx15.Enabled = false;
            tx16.Enabled = false;
            tx17.Enabled = false;
            tx18.Enabled = false;
            tx19.Enabled = false;
            tx20.Enabled = false;
            tx21.Enabled = false;
            tx22.Enabled = false;
            tx23.Enabled = false;
            tx24.Enabled = false;
            tx25.Enabled = false;
            tx26.Enabled = false;
            tx27.Enabled = false;
            tx28.Enabled = false;
            tx29.Enabled = false;
            tx30.Enabled = false;
            tx31.Enabled = false;
            tx32.Enabled = false;
            button3.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Add Now")
            {
                enable();
                button1.Text = "Add Student";
            }
            else if (button1.Text == "Add Student")
            {
                button1.Text = "Add Now";
                addStudent();
                disable();
                clearAll();
                pictureBox5.Image = null;
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.Text = "Add Now";
            clearAll();
            disable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox5.Image = new Bitmap(open.FileName);
                pic = open.FileName.Replace(@"\", @"\\");
            }
        }

        private void deleteSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tx10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tx7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tx13_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx21_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tx25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void tx24_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tx23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void tx20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void tx19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void tx17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void tx14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tx18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tx16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void tx15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tx12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tx11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tx9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tx8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void tx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void tx26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void tx28_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void tx29_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx30_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void tx27_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
