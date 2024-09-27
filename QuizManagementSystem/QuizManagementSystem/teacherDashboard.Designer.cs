namespace QuizManagementSystem
{
    partial class teacherDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slidePictureBox = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.resultBtn = new System.Windows.Forms.Button();
            this.deleteQuestionBtn = new System.Windows.Forms.Button();
            this.updateQuestionBtn = new System.Windows.Forms.Button();
            this.newQuestionbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultdataGridView = new System.Windows.Forms.DataGridView();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.view_Delete2 = new QuizManagementSystem.Teacher_UC.View_Delete();
            this.updateQuestion1 = new QuizManagementSystem.Teacher_UC.UpdateQuestion();
            this.adminQuestion1 = new QuizManagementSystem.Teacher_UC.adminQuestion();
            this.view_Delete1 = new QuizManagementSystem.Teacher_UC.View_Delete();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.slidePictureBox);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.resultBtn);
            this.panel1.Controls.Add(this.deleteQuestionBtn);
            this.panel1.Controls.Add(this.updateQuestionBtn);
            this.panel1.Controls.Add(this.newQuestionbtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 768);
            this.panel1.TabIndex = 0;
            // 
            // slidePictureBox
            // 
            this.slidePictureBox.Location = new System.Drawing.Point(12, 25);
            this.slidePictureBox.Name = "slidePictureBox";
            this.slidePictureBox.Size = new System.Drawing.Size(256, 231);
            this.slidePictureBox.TabIndex = 10;
            this.slidePictureBox.TabStop = false;
            this.slidePictureBox.Click += new System.EventHandler(this.slidePictureBox_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Tomato;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(32, 650);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(206, 47);
            this.logout.TabIndex = 9;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.resultBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resultBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.resultBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.resultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBtn.ForeColor = System.Drawing.Color.White;
            this.resultBtn.Image = ((System.Drawing.Image)(resources.GetObject("resultBtn.Image")));
            this.resultBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultBtn.Location = new System.Drawing.Point(12, 542);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(260, 47);
            this.resultBtn.TabIndex = 8;
            this.resultBtn.Text = "Student Result";
            this.resultBtn.UseVisualStyleBackColor = false;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // deleteQuestionBtn
            // 
            this.deleteQuestionBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.deleteQuestionBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteQuestionBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.deleteQuestionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.deleteQuestionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteQuestionBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuestionBtn.ForeColor = System.Drawing.Color.White;
            this.deleteQuestionBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteQuestionBtn.Image")));
            this.deleteQuestionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteQuestionBtn.Location = new System.Drawing.Point(12, 458);
            this.deleteQuestionBtn.Name = "deleteQuestionBtn";
            this.deleteQuestionBtn.Size = new System.Drawing.Size(260, 47);
            this.deleteQuestionBtn.TabIndex = 7;
            this.deleteQuestionBtn.Text = "  View and Delete";
            this.deleteQuestionBtn.UseVisualStyleBackColor = false;
            this.deleteQuestionBtn.Click += new System.EventHandler(this.deleteQuestionBtn_Click);
            // 
            // updateQuestionBtn
            // 
            this.updateQuestionBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.updateQuestionBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.updateQuestionBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.updateQuestionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.updateQuestionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateQuestionBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuestionBtn.ForeColor = System.Drawing.Color.White;
            this.updateQuestionBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateQuestionBtn.Image")));
            this.updateQuestionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateQuestionBtn.Location = new System.Drawing.Point(12, 370);
            this.updateQuestionBtn.Name = "updateQuestionBtn";
            this.updateQuestionBtn.Size = new System.Drawing.Size(260, 47);
            this.updateQuestionBtn.TabIndex = 6;
            this.updateQuestionBtn.Text = "   Update Question";
            this.updateQuestionBtn.UseVisualStyleBackColor = false;
            this.updateQuestionBtn.Click += new System.EventHandler(this.updateQuestionBtn_Click);
            // 
            // newQuestionbtn
            // 
            this.newQuestionbtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.newQuestionbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newQuestionbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newQuestionbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.newQuestionbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newQuestionbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.newQuestionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newQuestionbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuestionbtn.ForeColor = System.Drawing.Color.White;
            this.newQuestionbtn.Image = ((System.Drawing.Image)(resources.GetObject("newQuestionbtn.Image")));
            this.newQuestionbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newQuestionbtn.Location = new System.Drawing.Point(12, 285);
            this.newQuestionbtn.Name = "newQuestionbtn";
            this.newQuestionbtn.Size = new System.Drawing.Size(260, 47);
            this.newQuestionbtn.TabIndex = 5;
            this.newQuestionbtn.Text = "      Add New Question";
            this.newQuestionbtn.UseVisualStyleBackColor = false;
            this.newQuestionbtn.Click += new System.EventHandler(this.newQuestionbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(218)))), ((int)(((byte)(13)))));
            this.panel2.Controls.Add(this.resultdataGridView);
            this.panel2.Controls.Add(this.view_Delete2);
            this.panel2.Controls.Add(this.teacherNameLabel);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.updateQuestion1);
            this.panel2.Controls.Add(this.adminQuestion1);
            this.panel2.Location = new System.Drawing.Point(288, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 768);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // resultdataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(218)))), ((int)(((byte)(13)))));
            this.resultdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resultdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultdataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.resultdataGridView.Location = new System.Drawing.Point(174, 117);
            this.resultdataGridView.Name = "resultdataGridView";
            this.resultdataGridView.RowHeadersVisible = false;
            this.resultdataGridView.RowHeadersWidth = 51;
            this.resultdataGridView.RowTemplate.Height = 24;
            this.resultdataGridView.Size = new System.Drawing.Size(791, 352);
            this.resultdataGridView.TabIndex = 17;
            this.resultdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultdataGridView_CellContentClick);
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.ForeColor = System.Drawing.Color.Tomato;
            this.teacherNameLabel.Location = new System.Drawing.Point(295, 3);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(538, 46);
            this.teacherNameLabel.TabIndex = 15;
            this.teacherNameLabel.Text = " Teacher Name   Dashboard";
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(1035, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 38);
            this.exitButton.TabIndex = 12;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 5000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // view_Delete2
            // 
            this.view_Delete2.Location = new System.Drawing.Point(-2, 52);
            this.view_Delete2.Name = "view_Delete2";
            this.view_Delete2.Size = new System.Drawing.Size(1100, 768);
            this.view_Delete2.TabIndex = 16;
            // 
            // updateQuestion1
            // 
            this.updateQuestion1.Location = new System.Drawing.Point(-2, 44);
            this.updateQuestion1.Name = "updateQuestion1";
            this.updateQuestion1.Size = new System.Drawing.Size(1100, 768);
            this.updateQuestion1.TabIndex = 6;
            // 
            // adminQuestion1
            // 
            this.adminQuestion1.Location = new System.Drawing.Point(-2, 44);
            this.adminQuestion1.Name = "adminQuestion1";
            this.adminQuestion1.Size = new System.Drawing.Size(1100, 721);
            this.adminQuestion1.TabIndex = 5;
            // 
            // view_Delete1
            // 
            this.view_Delete1.Location = new System.Drawing.Point(0, 44);
            this.view_Delete1.Name = "view_Delete1";
            this.view_Delete1.Size = new System.Drawing.Size(1100, 768);
            this.view_Delete1.TabIndex = 7;
            this.view_Delete1.Load += new System.EventHandler(this.view_Delete1_Load);
            // 
            // teacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacherDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacherDashboard";
            this.Load += new System.EventHandler(this.teacherDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slidePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newQuestionbtn;
        private System.Windows.Forms.Panel panel2;
        private Teacher_UC.adminQuestion adminQuestion1;
        private System.Windows.Forms.Button deleteQuestionBtn;
        private System.Windows.Forms.Button updateQuestionBtn;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button resultBtn;
        private Teacher_UC.View_Delete view_Delete1;
        private Teacher_UC.UpdateQuestion updateQuestion1;
        private System.Windows.Forms.PictureBox slidePictureBox;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label teacherNameLabel;
        private Teacher_UC.View_Delete view_Delete2;
        private System.Windows.Forms.DataGridView resultdataGridView;
    }
}