using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuizManagementSystem.Teacher_UC
{
    public partial class adminQuestion : UserControl
    {

        String path = @"Data Source = LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog = quizDB; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        private string teacherId;

        public adminQuestion()
        {
         InitializeComponent();
         con = new SqlConnection(path);

        }

        public void SetTeacherId(string id)
        {
            teacherId = id;
           
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            
            try
            {

                string pattern = @"^\d+-[a-zA-Z]+$";
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(settextBox.Text))
                {
                    MessageBox.Show("Invalid set format. Please enter a valid set number followed by a set number and teacher name (e.g., '1-teachername').");
                    return;
                }




                if (!ValidateInputs())
                {
                    // If validation fails, stop further processing
                    return;
                }

                con.Open();

                // Check if the qSet and qNo already exist together
                string checkQuery = "SELECT COUNT(*) FROM questions WHERE qSet = @qSet AND qNo = @qNo";
                cmd = new SqlCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@qSet", settextBox.Text); 
                cmd.Parameters.AddWithValue("@qNo",qNoBox.Text); // Assuming you have a textbox for question number

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This question number already exists in the selected qSet. Please choose a different question number.");
                    return;
                }

                // Insert the new record if qSet does not exist
                string insertQuery = @"
                INSERT INTO questions(qSet, qNo, question, optionA, optionB, optionC, optionD, answer, subject, teacherId)
                VALUES (@qSet, @qNo, @question, @optionA, @optionB, @optionC, @optionD, @answer, @subject, @teacherId)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@qSet", settextBox.Text);
                    cmd.Parameters.AddWithValue("@qNo", qNoBox.Text);
                    cmd.Parameters.AddWithValue("@question", questionBox.Text);
                    cmd.Parameters.AddWithValue("@optionA", opt1Box.Text);
                    cmd.Parameters.AddWithValue("@optionB", opt2Box.Text);
                    cmd.Parameters.AddWithValue("@optionC", opt3Box.Text);
                    cmd.Parameters.AddWithValue("@optionD", opt4Box.Text);
                    cmd.Parameters.AddWithValue("@answer", answerBox.Text);
                    cmd.Parameters.AddWithValue("@subject", subjectcomboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Done!");
                

                int qNo;
                if (int.TryParse(qNoBox.Text, out qNo))
                {
                    qNo += 1;
                    qNoBox.Text = qNo.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid question number. Please enter a valid number.");
                }

                questionBox.Clear();
                opt1Box.Clear();
                opt2Box.Clear();
                opt3Box.Clear();    
                opt4Box.Clear();
                answerBox.Clear();


                con.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void finishBtn_Click(object sender, EventArgs e)
        {
            settextBox.Clear();
            qNoBox.Text = "1";
            questionBox.Clear();
            opt1Box.Clear();
            opt2Box.Clear();
            opt3Box.Clear();
            opt4Box.Clear();
            answerBox.Clear();
            subjectcomboBox.SelectedIndex = -1;
        }


        private bool ValidateInputs()
        {
            // Regex pattern to ensure non-empty strings
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

            if (string.IsNullOrEmpty(subjectcomboBox.Text))
            {
                MessageBox.Show("Please select a value from the Japanese Level.");
                return false;
            }

            return true; // All validations passed
        }

        private void adminQuestion_Load(object sender, EventArgs e)
        {

        }

        private void qNoBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
