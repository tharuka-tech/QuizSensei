using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace QuizManagementSystem
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
            viewTeacher();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void viewTeacher()
        {
            dataGridView.Rows.Clear();

            //load the xml file
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Lenovo\Pictures\project\xml\quizTeacher.xml");

            //select the root elements
            XmlElement root = doc.DocumentElement;

            //read and display the context
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "Teacher")
                {
                    string id = node["ID"].InnerText;
                    string name = node["Name"].InnerText;

                    dataGridView.Rows.Add(id, name);

                }

            }
        }


        private bool ValidateTeacherId(string id)
        {
            Regex idRegex = new Regex(@"^JPN");
            if (!idRegex.IsMatch(id))
            {
                idValidateLabel.Visible = true;
                return false;
            }
            return true;
        }



        // Method to validate if any text box is empty
        private bool ValidateTextBoxes(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"{textBox.Tag} Cannot be Empty! Please Fill the All Textboxes ");
                    return false;
                }
            }
            return true;
        }



        private void viewBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = false;
            viewTeacher();
           

        }

    

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            addPanel.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            idValidateLabel.Visible = false;

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible=true;
            submitBtn.Visible=true;
            updateButton.Visible=false;
            tIdTextbox.Visible = true;
            idlabel.Visible = true;
            deleteButton.Visible = false;

        }



        private void updateBtn_Click(object sender, EventArgs e)
        {
            addPanel.Visible = true;
            updateButton.Visible = true;
            submitBtn.Visible=false;
            tIdTextbox.Visible=false;
            idlabel.Visible=false;
            deleteButton.Visible = false;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            addPanel.Visible=false;
            deleteButton.Visible = true;

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Load the XML document
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Lenovo\Pictures\project\xml\quizTeacher.xml");

            // Select the root element
            XmlElement root = doc.DocumentElement;

            // Create a new teacher element
            XmlElement newTeacher = doc.CreateElement("Teacher");





            // Validate text boxes
            if (!ValidateTextBoxes(tIdTextbox, tNametextBox, tPasswordtextBox))
            {
                return; // Exit the method if any text box is empty
            }




            string newTeacherId = tIdTextbox.Text;
            if (!ValidateTeacherId(newTeacherId))
            {
                return; // Exit the method if validation fails
            }




            XmlNode existingTeacher = root.SelectSingleNode($"Teacher[ID='{newTeacherId}']");

            if (existingTeacher != null)
            {
                MessageBox.Show("A teacher with this ID already exists!");
                return;
            }

            // Hash the password
            string hashedPassword = HashPassword(tPasswordtextBox.Text);


            // Create and append ID element
            XmlElement idElement = doc.CreateElement("ID");
            idElement.InnerText = tIdTextbox.Text;
            newTeacher.AppendChild(idElement);

            // Create and append Name element
            XmlElement nameElement = doc.CreateElement("Name");
            nameElement.InnerText = tNametextBox.Text;
            newTeacher.AppendChild(nameElement);

            // Create and append Password element (hashed)
            XmlElement passwordElement = doc.CreateElement("Password");
            passwordElement.InnerText = hashedPassword;
            newTeacher.AppendChild(passwordElement);

            // Append the new teacher to the root element
            root.AppendChild(newTeacher);

            // Save the document
            doc.Save(@"C:\Users\Lenovo\Pictures\project\xml\quizTeacher.xml");
            MessageBox.Show("Suceefully Added Teacher");
            idValidateLabel.Visible = false;
            viewTeacher();

            tIdTextbox.Clear();
            tNametextBox.Clear();
            tPasswordtextBox.Clear();



        }


        // Method to hash the password using SHA-256
        private string HashPassword(string password)
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


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];

            tIdTextbox.Text = row.Cells["ID"].Value.ToString();
            tNametextBox.Text = row.Cells["Name"].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            

            // Load the XML document
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Lenovo\Pictures\project\xml\quizTeacher.xml");

            // Select the root element
            XmlElement root = doc.DocumentElement;

            // Find the teacher by ID
            string teacherIdToUpdate = tIdTextbox.Text;
            XmlNode teacherNode = root.SelectSingleNode($"Teacher[ID='{teacherIdToUpdate}']");

            if (teacherNode != null)
            {
                // Update the name
                XmlNode nameNode = teacherNode.SelectSingleNode("Name");
                if (nameNode != null)
                {
                    nameNode.InnerText = tNametextBox.Text;
                }


                // Update the password
                XmlNode passwordNode = teacherNode.SelectSingleNode("Password");
                if (passwordNode != null)
                {
                    // Hash the new password before updating
                    string hashedPassword = HashPassword(tPasswordtextBox.Text);
                    passwordNode.InnerText = hashedPassword;
                }

                // Save the document
                doc.Save(@"C:\Users\Lenovo\Pictures\project\xml\quizTeacher.xml");
                MessageBox.Show("Update Sucessfully..");
                tNametextBox.Clear();
                tPasswordtextBox.Clear();
                viewTeacher();

            }
            else
            {
                MessageBox.Show("Teacher not found!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Load the XML document
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Lenovo\Pictures\project\xml\quizTeacher.xml");

            // Select the root element
            XmlElement root = doc.DocumentElement;

            // Find the teacher by ID
            string teacherIdToDelete = tIdTextbox.Text;
            XmlNode teacherNode = root.SelectSingleNode($"Teacher[ID='{teacherIdToDelete}']");

            if (teacherNode != null)
            {
                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the teacher node
                    root.RemoveChild(teacherNode);

                    // Save the document
                    doc.Save(@"C:\Users\Lenovo\Pictures\project\xml\quizTeacher.xml");

                    viewTeacher();
                }
            }
            else
            {
                MessageBox.Show("Teacher not found!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tIdTextbox.Clear();
            tNametextBox.Clear();
            tPasswordtextBox.Clear();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }
    }
}
