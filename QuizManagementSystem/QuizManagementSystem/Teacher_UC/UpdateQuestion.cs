using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem.Teacher_UC
{
    public partial class UpdateQuestion : UserControl
    {
        String path = @"Data Source = LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog = quizDB; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        private string steacherId;
        public UpdateQuestion()
        {
            InitializeComponent();
            
        }

        private void UpdateQuestion_Load(object sender, EventArgs e)
        {

        }

        public void SetTeacherId(string id)
        {
            steacherId = id;
            LoadComboBoxData();
        }

     
        private void updateBtn_Click(object sender, EventArgs e)
        {


            if (!ValidateInputs())
            {
                // If validation fails, stop further processing
                return;
            }


            string selectedQSet = setComboBox.SelectedValue.ToString();
            int selectedQNo;

            // Validate if qNo is an integer
            if (!int.TryParse(qNoBox.Text, out selectedQNo))
            {
                MessageBox.Show("Please enter a valid question number.");
                return;
            }

            // Example: Get new values for question, options, and answer
            string newQuestion = questionBox.Text;
            string newOptionA = opt1Box.Text;
            string newOptionB = opt2Box.Text;
            string newOptionC = opt3Box.Text;
            string newOptionD = opt4Box.Text;
            string newAnswer = answerBox.Text;

            string updateQuery = @"
                UPDATE questions
                SET question = @question,
                    optionA = @optionA,
                    optionB = @optionB,
                    optionC = @optionC,
                    optionD = @optionD,
                    answer = @answer
                WHERE qSet = @qSet AND qNo = @qNo";

            using (SqlConnection connection = new SqlConnection(path))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@qSet", selectedQSet);
                        command.Parameters.AddWithValue("@qNo", selectedQNo);
                        command.Parameters.AddWithValue("@question", newQuestion);
                        command.Parameters.AddWithValue("@optionA", newOptionA);
                        command.Parameters.AddWithValue("@optionB", newOptionB);
                        command.Parameters.AddWithValue("@optionC", newOptionC);
                        command.Parameters.AddWithValue("@optionD", newOptionD);
                        command.Parameters.AddWithValue("@answer", newAnswer);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Question updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No matching question found to update.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }



        private void LoadComboBoxData()
        {
            if (string.IsNullOrEmpty(steacherId))
            {
                MessageBox.Show("Teacher ID is not set.");
                return;
            }

            string query = "SELECT DISTINCT qSet FROM questions WHERE teacherId = @teacherId";

            using (SqlConnection connection = new SqlConnection(path))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacherId", steacherId);

                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Bind the DataTable to the ComboBox
                        setComboBox.DataSource = dt;
                        setComboBox.DisplayMember = "qSet";
                        setComboBox.ValueMember = "qSet";

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private bool ValidateInputs()
        {
            // Regex pattern to ensure non-empty strings (you can customize it if needed)
            string nonEmptyPattern = @"\S";

            // Validate each TextBox
            if (!Regex.IsMatch(questionBox.Text, nonEmptyPattern))
            {
                MessageBox.Show("Question field cannot be empty.");
                return false;
            }
            if (!Regex.IsMatch(opt1Box.Text, nonEmptyPattern))
            {
                MessageBox.Show("Option A field cannot be empty.");
                return false;
            }
            if (!Regex.IsMatch(opt2Box.Text, nonEmptyPattern))
            {
                MessageBox.Show("Option B field cannot be empty.");
                return false;
            }
            if (!Regex.IsMatch(opt3Box.Text, nonEmptyPattern))
            {
                MessageBox.Show("Option C field cannot be empty.");
                return false;
            }
            if (!Regex.IsMatch(opt4Box.Text, nonEmptyPattern))
            {
                MessageBox.Show("Option D field cannot be empty.");
                return false;
            }
            if (!Regex.IsMatch(answerBox.Text, nonEmptyPattern))
            {
                MessageBox.Show("Answer field cannot be empty.");
                return false;
            }

            return true; // All validations passed
        }

        private void setComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
