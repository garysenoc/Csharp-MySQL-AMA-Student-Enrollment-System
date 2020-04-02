using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amaEnrollment
{
    public partial class biodata : Form
    {
        public biodata()
        {
            InitializeComponent();
        }

        private void biodata_Load(object sender, EventArgs e)
        {
            label62.Text = clsMySQL.studentno;
            label1.Text = clsMySQL.firstname;
            label2.Text = clsMySQL.middlename;
            label29.Text = clsMySQL.lastname;
            label34.Text = clsMySQL.telno;
            label35.Text = clsMySQL.age;
            label36.Text = clsMySQL.sex;
            label37.Text = clsMySQL.status;
            label38.Text = clsMySQL.height;
            label39.Text = clsMySQL.weight;
            label40.Text = clsMySQL.citizen;
            label41.Text = clsMySQL.bday;
            label42.Text = clsMySQL.bplace;
            label43.Text = clsMySQL.fathername;
            label44.Text = clsMySQL.fage;
            label45.Text = clsMySQL.foccupation;
            label46.Text = clsMySQL.mothername;
            label55.Text = clsMySQL.mage;
            label54.Text = clsMySQL.moccupation;
            label47.Text = clsMySQL.province;
            label51.Text = clsMySQL.cityadd;
            label48.Text = clsMySQL.nameguard;
            label52.Text = clsMySQL.addressguard;
            label49.Text = clsMySQL.persontocontact;
            label53.Text = clsMySQL.persontocontactaddress;
            label50.Text = clsMySQL.persontocontactno;
            label56.Text = clsMySQL.lrn;
            label57.Text = clsMySQL.gradelevel;
            label58.Text = clsMySQL.classs;
            label59.Text = clsMySQL.semester;
            label60.Text = clsMySQL.schoolyear;
            label63.Text = clsMySQL.strand;
            pictureBox5.ImageLocation = clsMySQL.pic;
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
