using Guna.UI2.WinForms.Suite;
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

namespace QuizManagementSystem
{
    public partial class teacherDashboard : Form
    {


        String path = @"Data Source = LAPTOP-DLFH1AQ5\SQLEXPRESS;Initial Catalog = quizDB; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        string teacherId;


        public teacherDashboard(string id)
        {
            InitializeComponent();
            InitializeTimer();
            con = new SqlConnection(path);
            LoadImages();

            teacherId = id;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


 
        private void teacherDashboard_Load(object sender, EventArgs e)
        {
            adminQuestion1.Visible = false;
            updateQuestion1.Visible = false;
            view_Delete2.Visible = false;
            resultdataGridView.Visible = false;





            // Load the XML document
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Lenovo\Pictures\project\xml\quizTeacher.xml");

            // Select the root element
            XmlElement root = doc.DocumentElement;

            // Find the teacher by ID
            XmlNode teacherNode = root.SelectSingleNode($"Teacher[ID='{teacherId}']");



            if (teacherNode != null)
            {
                string teacherName = teacherNode["Name"].InnerText;
                // Display teacher details on the dashboard
                teacherNameLabel.Text =teacherName+" Dashboard";

            }
            else
            {
                MessageBox.Show("Teacher not found!");
            }

        }

        private void newQuestionbtn_Click(object sender, EventArgs e)
        {
            adminQuestion1.Visible=true;
            adminQuestion1.BringToFront();
            adminQuestion1.SetTeacherId(teacherId);
        }

        private void updateQuestionBtn_Click(object sender, EventArgs e)
        {
            updateQuestion1.Visible=true;
            updateQuestion1.BringToFront();
            updateQuestion1.SetTeacherId(teacherId);
        }

        private void deleteQuestionBtn_Click(object sender, EventArgs e)
        {
            view_Delete2.Visible=true;
            view_Delete2.BringToFront();
            view_Delete2.SetTeacherId(teacherId);
        }

        private void view_Delete1_Load(object sender, EventArgs e)
        {
             
        }

        private Timer timer;
        private int imageIndex;
        private string[] images;
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 5000; // 5 seconds
            timer.Tick += new EventHandler(Timer1_Tick);
            timer.Start();
        }

        private void LoadImages()
        {
            
            images = new string[]
            {
                @"C:\Users\Lenovo\Pictures\project\slider\1.png",
                @"C:\Users\Lenovo\Pictures\project\slider\2.png",
                @"C:\Users\Lenovo\Pictures\project\slider\4.png"
            };

            imageIndex = 0;
            if (images.Length > 0)
            {
                slidePictureBox.Image = Image.FromFile(images[imageIndex]);
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            imageIndex++;
            if (imageIndex >= images.Length)
            {
                imageIndex = 0;
            }
            else
            {
                slidePictureBox.Image = Image.FromFile(images[imageIndex]);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void slidePictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            adminQuestion1.Visible = false;
            updateQuestion1.Visible = false;
            view_Delete2.Visible = false;
            resultdataGridView.Visible = true;

            using (SqlConnection conn = new SqlConnection(path))
            {
                string query = @"
                    SELECT studentId, qSet, studentAnswer, correctAnswer,result
                    FROM studentAnswers
                    WHERE teacherId = @teacherId
                    AND numberOfCorrectAnswers IS NOT NULL;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@teacherId", teacherId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                resultdataGridView.DataSource = dt;

            }

        }

        private void resultdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
