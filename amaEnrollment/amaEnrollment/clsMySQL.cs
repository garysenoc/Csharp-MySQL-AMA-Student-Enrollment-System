using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace amaEnrollment
{
    class clsMySQL
    {
        public static string firstname = "";
        public static string middlename = "";
        public static string lastname = "";
        public static string telno = "";
        public static string age = "";
        public static string sex = "";
        public static string status = "";
        public static string height = "";
        public static string weight = "";
        public static string citizen = "";
        public static string bday = "";
        public static string bplace = "";
        public static string fathername = "";
        public static string fage = "";
        public static string foccupation = "";
        public static string mothername = "";
        public static string mage = "";
        public static string moccupation = "";
        public static string province = "";
        public static string cityadd = "";
        public static string nameguard = "";
        public static string addressguard = "";
        public static string persontocontact = "";
        public static string persontocontactaddress = "";
        public static string persontocontactno = "";
        public static string lrn = "";
        public static string classs = "";
        public static string semester = "";
        public static string schoolyear = "";
        public static string pic = "";
        public static string studentno = "";
        public static string gradelevel = "";
        public static string strand = "";

        public static string server = "127.0.0.1";
        public static string database = "dbenrollment";
        public static string user = "root";
        public static string pass = "";
        public static string constring = "server = " + server + ";" + "database = " + database + ";" + "uid = " + user + ";" + "password = " + pass + ";";
        public static MySqlConnection sql_con = new MySqlConnection(constring);
    }
}
