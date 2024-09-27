using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using System.Security.Cryptography;
using System.IO;

namespace QuizManagementSystem
{
    public partial class Form1 : Form
    {
        private string connectionString = "data source=LAPTOP-DLFH1AQ5\\SQLEXPRESS;database=quizDB;integrated security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            wrongLabel.Visible = false;
            wronglabel2.Visible = false;
        }

        private void usercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( usercomboBox.SelectedIndex == 0)
            {
                panel1.Visible = false;
                panel2.Visible=false;
                panel3.Visible=true;
               

            }else if(usercomboBox.SelectedIndex == 1) {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible=false;
                

            }
            else if (usercomboBox.SelectedIndex == 2)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible=false;

            }
        }

        

        private void showPasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordcheckBox.Checked == true)
            {
                tpasswordBox.PasswordChar = '\0';
                showPasswordcheckBox.Text = "Hide Password";
            }
            else
            {
                tpasswordBox.PasswordChar = '*';
                showPasswordcheckBox.Text = "Show Password";
            }
        }

        private void tLoginBtn_Click(object sender, EventArgs e)
        {
           
            // Load the XML document
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Lenovo\Pictures\project\xml\quizTeacher.xml");

            // Select the root element
            XmlElement root = doc.DocumentElement;

            // Get the entered username and password
            string enteredUsername = tnameBox.Text;
            string enteredPassword = tpasswordBox.Text;

            // Hash the entered password
            string hashedPassword = HashPassword2(enteredPassword);

            // Find the teacher by username and hashed password
            XmlNode teacherNode = root.SelectSingleNode($"Teacher[Name='{enteredUsername}' and Password='{hashedPassword}']");



            if (teacherNode != null)
            {
                string teacherId = teacherNode["ID"].InnerText;
                
              
                wrongLabel.Visible=false;

                teacherDashboard t1 = new teacherDashboard(teacherId);
                t1.Show();
                this.Hide();
            }
            else
            {
                wrongLabel.Visible = true;
                tnameBox.Clear();
                tpasswordBox.Clear();
            }
             
        }


        // Method to hash the password using SHA-256
        private string HashPassword2(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private void sLoginBtn_Click(object sender, EventArgs e)
        {
            string sId = sIdtextBox.Text;
            string password = sPasswordtextBox.Text;

            // Hash the entered password
            string hashedPassword = HashPassword(password);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM Students WHERE sId=@sId AND Password=@Password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@sId", sId);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword); // Use hashed password

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Login Successful");

                            studentQuiz sQuiz = new studentQuiz(sId);
                            sQuiz.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed. Incorrect ID or Password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }




        private void sRegisterBtn_Click(object sender, EventArgs e)
        {
            registationForm registationForm = new registationForm();
            registationForm.Show();
        }

        private void showPasswordcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordcheckBox2.Checked == true)
            {
                sPasswordtextBox.PasswordChar = '\0';
                showPasswordcheckBox2.Text = "Hide Password";
            }
            else
            {
                sPasswordtextBox.PasswordChar = '*';
                showPasswordcheckBox2.Text = "Show Password";
            }
        }


        private void aLoginBtn_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Lenovo\Pictures\project\file hadling\admin.txt";
            bool loginSuccess = false;

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] credentials = line.Split(',');
                    string storedName = credentials[0].Trim();
                    string storedPassword = credentials[1].Trim();

                    if (aNameBox.Text == storedName && aPasswordBox.Text == storedPassword)
                    {
                        loginSuccess = true;
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                wrongLabel.Visible = false;

                adminDashboard admin = new adminDashboard();
                admin.Show();
                this.Hide();
            }
            else
            {
                wronglabel2.Visible = true;
                aNameBox.Clear();
                aPasswordBox.Clear();
            }

        }

        private void showPasswordcheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordcheckBox3.Checked == true)
            {
                aPasswordBox.PasswordChar = '\0';
                showPasswordcheckBox3.Text = "Hide Password";
            }
            else
            {
                aPasswordBox.PasswordChar = '*';
                showPasswordcheckBox3.Text = "Show Password";
            }
        }
    }
}
