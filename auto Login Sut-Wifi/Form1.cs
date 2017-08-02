using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_Login_Sut_Wifi
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(Login.Text == "Save")
            {
                if (username.Text != "" && password.Text != "")
                {
                    Properties.Settings.Default.username = username.Text;
                    Properties.Settings.Default.password = password.Text;
                    username.Enabled = false;
                    password.Enabled = false;
                
                    Login.Text = "Edit";
                    Properties.Settings.Default.StatusBtn = "Save";
                    //Login.Enabled = false;

                }
            }
            else
            {
                username.Enabled = true;
                password.Enabled = true;
                Login.Text = "Save";
                Properties.Settings.Default.StatusBtn = "Edit";
            }
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.StatusBtn == "Save")
            {
                    username.Enabled = false;
                    password.Enabled = false;
                    Login.Text = "Edit";
                   //Properties.Settings.Default.StatusBtn = "Edit";
            }
            else
            {
                username.Enabled = true;
                password.Enabled = true;
            }
         
            username.Text = Properties.Settings.Default.username;
            password.Text = Properties.Settings.Default.password;
            if (Properties.Settings.Default.AutoClose == "true")
            {
                timer1.Start();
            }
            if (Properties.Settings.Default.LoginWhenStartThis == "true")
            {
                login();
            }
            
        }
        public  void login()
        {
            int Check = readHtmlPage("https://sutpassport.sut.ac.th/login.html").Length;
            if (Check <= 255)
            {
                signout.Visible = true;
                MessageBox.Show("Already signed in");
               
            }
            else if (Check <= 500)
            {
                MessageBox.Show("Error");
            }
            else
            {
                signout.Visible = true;
                MessageBox.Show("Sign in successfully");
            }
            // MessageBox.Show(.ToString());
        }
        private static String readHtmlPage(string url)
        {

            //setup some variables

            String username = Properties.Settings.Default.username;
            String password = Properties.Settings.Default.password;
            String button = "4";
            String redirect_url = "1.1.1.1";
            //String err_flag = "0";
            //setup some variables end

            String result = "";
            String strPost = "username=" + username + "&password=" + password + "&buttonClicked=" + button + "&redirect_url=" + redirect_url + "&err_flag=0";
            StreamWriter myWriter = null;

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            objRequest.Method = "POST";
            objRequest.ContentLength = strPost.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";

            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(strPost);
            }
            catch(WebException ex )
            {
                return "error";
            }
            finally
            {
                try
                {
                    myWriter.Close();
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("Please Connecting Wifi");
                    Environment.Exit(0);
                }
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr =
               new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();

                // Close and clean up the StreamReader
                sr.Close();
            }
            return result;
        }
        private static String readHtmlPageOut(string url)
        {


            String result = "";
            String strPost = "userStatus=1&err_flag=0&err_msg=";
            StreamWriter myWriter = null;

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            objRequest.Method = "POST";
            objRequest.ContentLength = strPost.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";

            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(strPost);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr =
               new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();

                // Close and clean up the StreamReader
                sr.Close();
            }
            return result;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
         //   Debug.WriteLine(count);
            if (count == 7*5)
            {
                Environment.Exit(1);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("อย่าลืมตรวจสอบการตั้งค่า เชื่อมต่ออัตโนมัติของ Wifi\n สามารถใช้ได้ ทั้ง SUT-Wifi และ SUT-Wifi_AIS");
        }
        private void logout()
        {
            readHtmlPageOut("https://sutpassport.sut.ac.th/logout.html");
            MessageBox.Show("Logout");
            signout.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logout();
        }
    }
}
