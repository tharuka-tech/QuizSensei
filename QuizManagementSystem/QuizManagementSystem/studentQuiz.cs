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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace QuizManagementSystem
{
    public partial class studentQuiz : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
       
        string studentId;
        string selectedQSet;
        private int currentQuestionNumber = 1;
        private int correctAnswerCount = 0;
        private string currentQSet;
        private string correctAnswer;
        private string teacherId;
        private int timeLeft = 30;
        public studentQuiz(string id)
        {
            InitializeComponent();
            conn= new SqlConnection(@"Data Source=LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog=quizDB;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
            
            //meka thama id eka log weccha studentge
            studentId = id; 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentQuiz_Load(object sender, EventArgs e)
        {
            questionLabel.Visible = false;
            optionARadioButton.Visible = false;
            optionBRadioButton.Visible = false;
            optionCRadioButton.Visible = false;
            optionDRadioButton.Visible = false;
            nextBtn.Visible = false;
            finishBtn.Visible = false;
            timerLabel.Visible = false;
            pdfButton.Visible = false;
            congratelabel.Visible = false;
            congratepictureBox.Visible = false;
        }

        private void displaydata(string query, DataGridView dataGridView)
        {
            try
            {
                conn.Open();
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void n1Btn_Click(object sender, EventArgs e)
        {
            leveldataGridView.DataSource = null;
            displaydata("select DISTINCT qSet from questions where subject = 'N1';", leveldataGridView);
            selectBtn.Visible = true;
            pdfButton.Visible= false;
        }

        private void n2Btn_Click(object sender, EventArgs e)
        {
            leveldataGridView.DataSource = null;
            displaydata("select DISTINCT qSet from questions where subject = 'N2';", leveldataGridView);
            selectBtn.Visible = true;
            pdfButton.Visible = false;
        }

        private void n3Btn_Click(object sender, EventArgs e)
        {
            leveldataGridView.DataSource = null;
            displaydata("select DISTINCT qSet from questions where subject = 'N3';", leveldataGridView);
            selectBtn.Visible = true;
            pdfButton.Visible = false;
        }

        private void n4Btn_Click(object sender, EventArgs e)
        {
            leveldataGridView.DataSource = null;
            displaydata("select DISTINCT qSet from questions where subject = 'N4';", leveldataGridView);
            selectBtn.Visible = true;
            pdfButton.Visible = false;
        }

        private void n5Btn_Click(object sender, EventArgs e)
        {
            leveldataGridView.DataSource = null;
            displaydata("select DISTINCT qSet from questions where subject = 'N5';", leveldataGridView);
            selectBtn.Visible = true;
            pdfButton.Visible = false;

        }

        private void leveldataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && leveldataGridView.Rows[e.RowIndex].Cells["qSet"].Value != null)
            {
                selectedQSet = leveldataGridView.Rows[e.RowIndex].Cells["qSet"].Value.ToString();   
            }

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(selectedQSet))
            {
                // Hide the DataGridView and the Select button
                panel1.Visible = false;
                leveldataGridView.Visible = false;
                selectBtn.Visible = false;
                nextBtn.Visible = false;
                // Show question-related elements
                questionLabel.Visible = true;
                optionARadioButton.Visible = true;
                optionBRadioButton.Visible = true;
                optionCRadioButton.Visible = true;
                optionDRadioButton.Visible = true;
                nextBtn.Visible = true; // Show the Next button
                timerLabel.Visible = true;

                currentQSet = selectedQSet;
                currentQuestionNumber = 1; // Start with the first question

                LoadQuestions(currentQSet, currentQuestionNumber);
            }
            else
            {
                MessageBox.Show("Please select a question set first.");
            }

        }


        private void LoadQuestions(string qSet, int questionNumber)
        {
            timeLeft = 30; // Reset the timer to 30 seconds for each question
            questionTimer.Start(); // Start the timer when a new question is loaded

            string query = "SELECT qNo,teacherId, question, optionA, optionB, optionC, optionD, answer FROM questions WHERE qSet = @qSet AND qNo = @qNo;";

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog=quizDB;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@qSet", qSet);
                cmd.Parameters.AddWithValue("@qNo", questionNumber);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Example of displaying the first question and its options
                    questionLabel.Text = $"Q{reader["qNo"]}: {reader["question"].ToString()}";
                    optionARadioButton.Text = reader["optionA"].ToString();
                    optionBRadioButton.Text = reader["optionB"].ToString();
                    optionCRadioButton.Text = reader["optionC"].ToString();
                    optionDRadioButton.Text = reader["optionD"].ToString();
                    // Store the correct answer, etc.

                    // Store the correct answer and teacher ID
                    correctAnswer = reader["answer"].ToString();
                    teacherId = reader["teacherId"].ToString();

                }
                else
                {
                    // No more questions in this set
                    questionTimer.Stop();
                    finishBtn.Visible = true;

                    // Hide question and option elements
                    questionLabel.Visible = false;
                    optionARadioButton.Visible = false;
                    optionBRadioButton.Visible = false;
                    optionCRadioButton.Visible = false;
                    optionDRadioButton.Visible = false;
                    timerLabel.Visible = false;
                    nextBtn.Visible = false;

                    // Optionally, show a message indicating no more questions
                    MessageBox.Show("Congrlation You Complete the Quiz.");
                    congratepictureBox.Visible = true;
                    congratelabel.Visible = true;
                }
            }
        }




        private int GetCorrectAnswerCount(string studentId, string qSet)
        {
            int count = 0;
            string query = "SELECT SUM(numberOfCorrectAnswers) FROM studentAnswers WHERE studentId = @studentId AND qSet = @qSet;";

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog=quizDB;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@qSet", qSet);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    count = Convert.ToInt32(result);
                }
            }
            return count;
        }






        private void SaveResultsToDatabase(string studentAnswer, string currentQuestion)
        {
            string previousQSet = null;
            int correctAnswerCount = 0;

            // Check if starting a new quiz
            if (currentQSet != previousQSet)
            {
                // Retrieve the correct answer count for the new quiz
                correctAnswerCount = GetCorrectAnswerCount(studentId, currentQSet);
                previousQSet = currentQSet;
            }

            // Determine result for the current question
            string result = studentAnswer == correctAnswer ? "Correct" : "Incorrect";

            // Increment correct answer count if the answer is correct
            if (result == "Correct")
            {
                correctAnswerCount++;
            }

            // Insert results into the database
            string query = "INSERT INTO studentAnswers (studentId, qSet, teacherId, question, studentAnswer, correctAnswer, result, numberOfCorrectAnswers) " +
                           "VALUES (@studentId, @qSet, @teacherId, @question, @studentAnswer, @correctAnswer, @result, @numberOfCorrectAnswers);";

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog=quizDB;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@qSet", currentQSet);
                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                cmd.Parameters.AddWithValue("@question", currentQuestion);
                cmd.Parameters.AddWithValue("@studentAnswer", studentAnswer);
                cmd.Parameters.AddWithValue("@correctAnswer", correctAnswer);
                cmd.Parameters.AddWithValue("@result", result);
                cmd.Parameters.AddWithValue("@numberOfCorrectAnswers", correctAnswerCount);

                cmd.ExecuteNonQuery();
            }
        }






        private void nextBtn_Click(object sender, EventArgs e)
        {
            string selectedAnswer = "not answered";


            questionTimer.Stop(); // Stop the timer when the student moves to the next question

            // Check which RadioButton is selected and get the text value
            if (optionARadioButton.Checked)
            {
                selectedAnswer = optionARadioButton.Text;
            }
            else if (optionBRadioButton.Checked)
            {
                selectedAnswer = optionBRadioButton.Text;
            }
            else if (optionCRadioButton.Checked)
            {
                selectedAnswer = optionCRadioButton.Text;
            }
            else if (optionDRadioButton.Checked)
            {
                selectedAnswer = optionDRadioButton.Text;
            }

            if (selectedAnswer == correctAnswer)
            {
                correctAnswerCount++;
            }

            // Save the current question, student's answer, and result
            SaveResultsToDatabase(selectedAnswer, questionLabel.Text);

            // Increment the question number for the next question
            currentQuestionNumber++;

            // Load the next question (if any)
            LoadQuestions(currentQSet, currentQuestionNumber);

            // If there are no more questions, hide the Next button and show the Finish button
            if (nextBtn.Visible == false)
            {
                finishBtn.Visible = true;
            }

            // Clear selection for the next question
            optionARadioButton.Checked = false;
            optionBRadioButton.Checked = false;
            optionCRadioButton.Checked = false;
            optionDRadioButton.Checked = false;

            questionTimer.Start(); // Restart the timer for the next question
        }




        private void displayResults()
        {
            string query = "SELECT studentId, qSet, question, correctAnswer, result FROM studentAnswers WHERE studentId = @studentId;";

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog=quizDB;Integrated Security=True"))
            {
                questionLabel.Visible = false;
                optionARadioButton.Visible = false;
                optionBRadioButton.Visible = false;
                optionCRadioButton.Visible = false;
                optionDRadioButton.Visible = false;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                leveldataGridView.DataSource = dt;
                leveldataGridView.Visible = true;
            }
        }


        private void displayCurrentResult()
        {
            string query = "SELECT studentId, qSet, question, studentAnswer, correctAnswer, result FROM studentAnswers WHERE studentId = @studentId AND qSet = @selectedQSet;";

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog=quizDB;Integrated Security=True"))
            {
                questionLabel.Visible = false;
                optionARadioButton.Visible = false;
                optionBRadioButton.Visible = false;
                optionCRadioButton.Visible = false;
                optionDRadioButton.Visible = false;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@selectedQSet", selectedQSet); // Adding selectedQSet parameter

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                leveldataGridView.DataSource = dt;
                leveldataGridView.Visible = true;
            }
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {   
            questionTimer.Stop();
            questionLabel.Visible = false;
            finishBtn.Visible = false;  
            timerLabel.Visible = false;
            leveldataGridView.DataSource = null;
            congratelabel.Visible = false;  
            congratepictureBox.Visible = false;
            panel1.Visible = true;
            displayCurrentResult();
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timerLabel.Text = "Time Left: " + timeLeft.ToString();

                
            }
            else
            {
                // Time's up - skip to the next question
                questionTimer.Stop();
                SaveResultsToDatabase("not answered", questionLabel.Text); // Save "not answered" in the database

                // Load the next question
                currentQuestionNumber++;
                LoadQuestions(currentQSet, currentQuestionNumber);

                // If there are no more questions, hide the Next button and show the Finish button
                if (nextBtn.Visible == false)
                {
                    finishBtn.Visible = true;
                }
            }
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            questionLabel.Visible = false;
            optionARadioButton.Visible = false;
            optionBRadioButton.Visible = false;
            optionCRadioButton.Visible = false;
            optionDRadioButton.Visible = false;
            nextBtn.Visible = false;
            selectBtn.Visible = false;  
            finishBtn.Visible = false;

            timerLabel.Visible = false;
            leveldataGridView.DataSource = null;
            displayResults();
            pdfButton.Visible = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }


        private void GeneratePDF()
        {
            // Create a directory to save the PDFs if it doesn't exist
            string directoryPath = @"C:\Users\Lenovo\Pictures\project\GeneratedPDFs";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Generate a unique filename with a timestamp
            string fileName = $"StudentResults_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
            string filePath = Path.Combine(directoryPath, fileName);

            // Create a new PDF document
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Create a new font for the PDF
                    BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12);

                    // Add a title to the PDF
                    pdfDoc.Add(new Paragraph("Student Results", font));
                    pdfDoc.Add(new Paragraph(" ")); // Add an empty line

                    // Create a table with the same number of columns as your DataGridView
                    PdfPTable pdfTable = new PdfPTable(leveldataGridView.Columns.Count);

                    // Add the headers from the DataGridView to the PDF table
                    foreach (DataGridViewColumn column in leveldataGridView.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                        pdfTable.AddCell(cell);
                    }

                    // Add the data rows from the DataGridView to the PDF table
                    foreach (DataGridViewRow row in leveldataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(new Phrase(cell.Value?.ToString(), font));
                        }
                    }

                    // Add the table to the document
                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
    

            MessageBox.Show($"PDF Generated Successfully at {filePath}!");
        }







        private void pdfButton_Click(object sender, EventArgs e)
        {
            GeneratePDF();


        }
       
        
    }
}
