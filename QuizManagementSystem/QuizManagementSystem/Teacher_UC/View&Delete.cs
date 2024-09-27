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

namespace QuizManagementSystem.Teacher_UC
{
    public partial class View_Delete : UserControl
    {
        String path = @"Data Source = LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog = quizDB; Integrated Security = True";
        SqlConnection conn;
        SqlCommand cmd;
        string selectedQSet;
        string steacherId;

        public View_Delete()
        {
            InitializeComponent();
            conn = new SqlConnection(path);
            
        }

        public void SetTeacherId(string id)
        {
            steacherId = id;
            viewQuiz();
        }

        void viewQuiz()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT qSet, qNo, question, optionA, optionB, optionC, optionD, answer FROM questions WHERE teacherId = @teacherId", conn);
            cmd.Parameters.AddWithValue("@teacherId", steacherId);

            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            quizdataGridView.DataSource = dt;
            conn.Close();
        }

        private void quizdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Ensure the clicked row index is valid
            {
               // selectedQSet = quizdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
            if (quizdataGridView.SelectedRows.Count > 0) 
            {
                selectedQSet = quizdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                

                DialogResult result = MessageBox.Show("Are you sure you want to delete this quiz?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(path))
                        {
                            

                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM questions WHERE qSet = @qSet", conn))
                            {
                                cmd.Parameters.AddWithValue("@qSet", selectedQSet);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Quiz deleted successfully.");
                                    viewQuiz(); // Refresh the DataGridView after deletion
                                }
                                else
                                {
                                    MessageBox.Show("No quiz found with the selected qSet.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a quiz to delete.");
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            viewQuiz();
        }
    }
}
