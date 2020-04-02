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
    public partial class MANAGESTUDENT : Form
    {
        public string sID;
        public string sql = "";
        public string pic = "";
        public MySqlCommand sql_cmd = new MySqlCommand();
        public MANAGESTUDENT()
        {
            InitializeComponent();
        }

        private void MANAGESTUDENT_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            clsMySQL.sql_con.Close();
            clsMySQL.sql_con.Open();
            loadStudent();
            disable();
            button1.Enabled = false;
        }
        private void loadStudent()
        {
            sql = "SELECT * FROM tbstudent";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            listView2.Items.Clear();
            while (rd.Read())
            {
                listView2.Items.Add(rd["id"].ToString());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(rd["fname"].ToString() + " " + rd["mname"].ToString() + " " + rd["lname"].ToString());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(rd["gradelevel"].ToString());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(rd["lrnno"].ToString());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(rd["strand"].ToString());
            }
            rd.Close();
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
            button3.Enabled = false;
        }
        private void Show_StudData(string srcID)
        {

            sql = "SELECT * FROM tbstudent WHERE id = " + srcID;
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {


                tx1.Text = rd["fname"].ToString();
                tx2.Text = rd["mname"].ToString();
                tx3.Text = rd["lname"].ToString();
                tx4.Text = rd["telno"].ToString();
                tx5.Text = rd["age"].ToString();
                tx6.Text = rd["sex"].ToString();
                tx7.Text = rd["status"].ToString();
                tx8.Text = rd["height"].ToString();
                tx9.Text = rd["weght"].ToString();
                tx10.Text = rd["citizenship"].ToString();
                tx11.Text = rd["birthday"].ToString();
                tx12.Text = rd["birthplace"].ToString();
                tx13.Text = rd["fathername"].ToString();
                tx14.Text = rd["fage"].ToString();
                tx15.Text = rd["foccupation"].ToString();
                tx16.Text = rd["mothername"].ToString();
                tx17.Text = rd["mage"].ToString();
                tx18.Text = rd["moccupation"].ToString();
                tx19.Text = rd["province"].ToString();
                tx20.Text = rd["cityadd"].ToString();
                tx21.Text = rd["nameguardian"].ToString();
                tx22.Text = rd["gaddress"].ToString();
                tx23.Text = rd["persontocontact"].ToString();
                tx24.Text = rd["persontocontactaddress"].ToString();
                tx25.Text = rd["persontocontactadd"].ToString();
                tx26.Text = rd["studentno"].ToString();
                tx27.Text = rd["lrnno"].ToString();
                tx28.Text = rd["studentclass"].ToString();
                tx29.Text = rd["semester"].ToString();
                tx30.Text = rd["schoolyear"].ToString();
                pictureBox5.ImageLocation = rd["pic"].ToString();
                tx31.Text = rd["gradelevel"].ToString();
                tx32.Text = rd["strand"].ToString();



            }
            rd.Close();

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sID = listView2.FocusedItem.Text;
            button1.Enabled = true;
            disable();
            if (sID == "" || sID == null) { return; }
            Show_StudData(sID);
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

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void clearAll()
        {
            tx1.Text = "";
            tx2.Text = "";
            tx3.Text = "";
            tx4.Text = "";
            tx5.Text = "";
            tx6.Text = "";
            tx7.Text = "";
            tx8.Text = "";
            tx9.Text = "";
            tx10.Text = "";
            tx11.Text = "";
            tx12.Text = "";
            tx13.Text = "";
            tx14.Text = "";
            tx15.Text = "";
            tx16.Text = "";
            tx17.Text = "";
            tx18.Text = "";
            tx19.Text = "";
            tx20.Text = "";
            tx21.Text = "";
            tx22.Text = "";
            tx23.Text = "";
            tx24.Text = "";
            tx25.Text = "";
            tx26.Text = "";
            tx27.Text = "";
            tx28.Text = "";
            tx29.Text = "";
            tx30.Text = "";
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

        private void editSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Text = "Update";
            enable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         if(button1.Text == "Update")
         {
             button1.Enabled = false;
             updateRecord(sID);
             button1.Text = "Edit";
         }
            else if(  button1.Text == "Edit")
         {
             enable();
             button1.Text = "Update";
            
            }
        }
        private void updateRecord(string srcID)
        {

            if (pic == "" || pic == null)
            {
                sql = string.Format("UPDATE tbstudent SET fname='{0}', mname='{1}', lname='{2}',telno='{3}', age='{4}', sex='{5}', status='{6}',height='{7}', weght='{8}', citizenship='{9}', birthday='{10}', birthplace='{11}', fathername='{12}',fage='{13}', foccupation='{14}', mothername='{15}', mage='{16}',moccupation='{17}', province='{18}', cityadd='{19}', nameguardian='{20}', gaddress='{21}', persontocontact='{22}',persontocontactaddress='{23}', persontocontactadd='{24}', studentno='{25}', lrnno='{26}',studentclass='{27}', semester='{28}', schoolyear='{29}', gradelevel='{30}', strand='{31}' WHERE id={32}",
         tx1.Text, tx2.Text, tx3.Text, tx4.Text, tx5.Text, tx6.Text, tx7.Text, tx8.Text, tx9.Text, tx10.Text, tx11.Text, tx12.Text, tx13.Text, tx14.Text, tx15.Text, tx16.Text, tx17.Text, tx18.Text, tx19.Text, tx20.Text, tx21.Text, tx22.Text, tx23.Text, tx24.Text, tx25.Text, tx26.Text, tx27.Text, tx28.Text, tx29.Text, tx30.Text,tx31.Text,tx32.Text ,srcID);
                sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
                sql_cmd.ExecuteNonQuery();
                MessageBox.Show("Student Data has been update successfully!", "Update Student");
                clearAll();
                disable();
                loadStudent();
            }
            else
            {
                sql = string.Format("UPDATE tbstudent SET fname='{0}', mname='{1}', lname='{2}',telno='{3}', age='{4}', sex='{5}', status='{6}',height='{7}', weght='{8}', citizenship='{9}', birthday='{10}', birthplace='{11}', fathername='{12}',fage='{13}', foccupation='{14}', mothername='{15}', mage='{16}',moccupation='{17}', province='{18}', cityadd='{19}', nameguardian='{20}', gaddress='{21}', persontocontact='{22}',persontocontactaddress='{23}', persontocontactadd='{24}', studentno='{25}', lrnno='{26}',studentclass='{27}', semester='{28}', schoolyear='{29}', pic='{30}', gradelevel='{31}', strand='{32}' WHERE id={33}",
                         tx1.Text, tx2.Text, tx3.Text, tx4.Text, tx5.Text, tx6.Text, tx7.Text, tx8.Text, tx9.Text, tx10.Text, tx11.Text, tx12.Text, tx13.Text, tx14.Text, tx15.Text, tx16.Text, tx17.Text, tx18.Text, tx19.Text, tx20.Text, tx21.Text, tx22.Text, tx23.Text, tx24.Text, tx25.Text, tx26.Text, tx27.Text, tx28.Text, tx29.Text, tx30.Text, pic, tx31.Text, tx32.Text, srcID);
                sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
                sql_cmd.ExecuteNonQuery();
                MessageBox.Show("Student Data has been update successfully!", "Update Student");
                clearAll();
                disable();
                loadStudent();
                pic = "";
            }



        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            clearAll();
            disable();
            button1.Text = "Edit";
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sID = listView2.FocusedItem.Text;
            if (sID == "" || sID == null) { return; }
            else
            {

            }
            {
                sql = "DELETE FROM tbstudent WHERE id=" + sID;
                sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
                sql_cmd.ExecuteNonQuery();
                loadStudent();
                disable();
                clearAll();

            }
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadStudent();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            MAINFORM m = new MAINFORM();
            this.Hide();
            m.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MAINFORM m = new MAINFORM();
            this.Hide();
            m.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tbstudent WHERE fname LIKE '%" + textBox2.Text + "%' OR mname LIKE '%" + textBox2.Text + "%' OR lname LIKE '%" + textBox2.Text + "%' OR gradelevel LIKE '%" + textBox2.Text + "%' OR lrnno LIKE '%" + textBox2.Text + "%' OR citizenship LIKE '%" + textBox2.Text + "%' OR studentclass LIKE '%" + textBox2.Text + "%'OR semester LIKE '%" + textBox2.Text + "%'OR schoolyear LIKE '%" + textBox2.Text + "%'OR cityadd LIKE '%" + textBox2.Text + "%'OR province LIKE '%" + textBox2.Text + "%'OR mothername LIKE '%" + textBox2.Text + "%'OR fathername LIKE '%" + textBox2.Text + "%' OR gradelevel LIKE '%" + textBox2.Text + "%'OR strand LIKE '%" + textBox2.Text + "%'OR id LIKE '%" + textBox2.Text + "%'";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            listView2.Items.Clear();
            while (rd.Read())
            {

                listView2.Items.Add(rd["id"].ToString());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(rd["fname"].ToString() + " " + rd["mname"].ToString() + " " + rd["lname"].ToString());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(rd["gradelevel"].ToString());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(rd["lrnno"].ToString());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(rd["strand"].ToString());
            }

            rd.Close();
        }
    }
}
