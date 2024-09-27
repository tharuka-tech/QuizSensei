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

using System.Security.Cryptography;

namespace QuizManagementSystem
{
    public partial class registationForm : Form
    {
        private string connectionString = "data source=LAPTOP-DLFH1AQ5\\SQLEXPRESS;database=quizDB;integrated security=True";
        public registationForm()
        {
            InitializeComponent();
        }

    

        private void registationForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
           this.Close();
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            string sId = sIdTextbox.Text;
            string sName = sNameTextBox.Text;
            string sEmail = sEmailTextBox.Text;
            string sContact = sContactTextBox.Text;
            string password = sPasswordTextBox.Text;


            //Id Valitation
            if (!System.Text.RegularExpressions.Regex.IsMatch(sId, @"^(UGC|UOG)\d{7}$"))
            {
                MessageBox.Show("Please enter a valid Id. It should start with 'UGC' or 'UOG' followed by exactly 7 digits.");
                return;
            }




            //Name Validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(sName, @"^[a-zA-Z\s-]+$"))
            {
                MessageBox.Show("Please enter a valid name. Only alphabetic characters, spaces, and hyphens are allowed.");
                return;
            }


            // Email validation using regular expression
            if (!System.Text.RegularExpressions.Regex.IsMatch(sEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }


            // Phone number validation to ensure it is exactly 10 digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(sContact, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                return;
            }


            // Password validation to ensure it is not empty
            if (string.IsNullOrWhiteSpace(sPasswordTextBox.Text) || !System.Text.RegularExpressions.Regex.IsMatch(sPasswordTextBox.Text, @".+"))
            {
                MessageBox.Show("Password cannot be empty.");
                return;
            }



            // Hash the password before storing it
            string hashedPassword = HashPassword(password);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Students (sId, sName, sEmail, sContact, Password) VALUES (@sId, @sName, @sEmail, @sContact, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@sId", sId);
                        cmd.Parameters.AddWithValue("@sName", sName);
                        cmd.Parameters.AddWithValue("@sEmail", sEmail);
                        cmd.Parameters.AddWithValue("@sContact", sContact);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration Successful");
                        sIdTextbox.Clear();
                        sNameTextBox.Clear();
                        sEmailTextBox.Clear();
                        sContactTextBox.Clear();
                        sPasswordTextBox.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            sIdTextbox.Clear();
            sNameTextBox.Clear();
            sEmailTextBox.Clear();
            sContactTextBox.Clear();
            sPasswordTextBox.Clear();
        }
    }
}
