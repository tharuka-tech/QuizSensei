namespace QuizManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usercomboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showPasswordcheckBox = new System.Windows.Forms.CheckBox();
            this.tLoginBtn = new System.Windows.Forms.Button();
            this.tpasswordBox = new System.Windows.Forms.TextBox();
            this.tnameBox = new System.Windows.Forms.TextBox();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showPasswordcheckBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sPasswordtextBox = new System.Windows.Forms.TextBox();
            this.sLoginBtn = new System.Windows.Forms.Button();
            this.sRegisterBtn = new System.Windows.Forms.Button();
            this.sIdtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showPasswordcheckBox3 = new System.Windows.Forms.CheckBox();
            this.aLoginBtn = new System.Windows.Forms.Button();
            this.aPasswordBox = new System.Windows.Forms.TextBox();
            this.aNameBox = new System.Windows.Forms.TextBox();
            this.wronglabel2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(218)))), ((int)(((byte)(13)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(649, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Sensei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(218)))), ((int)(((byte)(13)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(899, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select User Type";
            // 
            // usercomboBox
            // 
            this.usercomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.usercomboBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercomboBox.FormattingEnabled = true;
            this.usercomboBox.Items.AddRange(new object[] {
            "Admin",
            "Teacher",
            "Student"});
            this.usercomboBox.Location = new System.Drawing.Point(837, 198);
            this.usercomboBox.Name = "usercomboBox";
            this.usercomboBox.Size = new System.Drawing.Size(391, 39);
            this.usercomboBox.TabIndex = 2;
            this.usercomboBox.SelectedIndexChanged += new System.EventHandler(this.usercomboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showPasswordcheckBox);
            this.panel1.Controls.Add(this.tLoginBtn);
            this.panel1.Controls.Add(this.tpasswordBox);
            this.panel1.Controls.Add(this.tnameBox);
            this.panel1.Controls.Add(this.wrongLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(840, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 430);
            this.panel1.TabIndex = 5;
            // 
            // showPasswordcheckBox
            // 
            this.showPasswordcheckBox.AutoSize = true;
            this.showPasswordcheckBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordcheckBox.Location = new System.Drawing.Point(70, 243);
            this.showPasswordcheckBox.Name = "showPasswordcheckBox";
            this.showPasswordcheckBox.Size = new System.Drawing.Size(120, 20);
            this.showPasswordcheckBox.TabIndex = 7;
            this.showPasswordcheckBox.Text = "Show Password";
            this.showPasswordcheckBox.UseVisualStyleBackColor = true;
            this.showPasswordcheckBox.CheckedChanged += new System.EventHandler(this.showPasswordcheckBox_CheckedChanged);
            // 
            // tLoginBtn
            // 
            this.tLoginBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.tLoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.tLoginBtn.FlatAppearance.BorderSize = 0;
            this.tLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.tLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tLoginBtn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLoginBtn.ForeColor = System.Drawing.Color.White;
            this.tLoginBtn.Location = new System.Drawing.Point(67, 294);
            this.tLoginBtn.Name = "tLoginBtn";
            this.tLoginBtn.Size = new System.Drawing.Size(286, 40);
            this.tLoginBtn.TabIndex = 6;
            this.tLoginBtn.Text = "Login";
            this.tLoginBtn.UseVisualStyleBackColor = false;
            this.tLoginBtn.Click += new System.EventHandler(this.tLoginBtn_Click);
            // 
            // tpasswordBox
            // 
            this.tpasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tpasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpasswordBox.Location = new System.Drawing.Point(67, 203);
            this.tpasswordBox.Name = "tpasswordBox";
            this.tpasswordBox.PasswordChar = '*';
            this.tpasswordBox.Size = new System.Drawing.Size(286, 34);
            this.tpasswordBox.TabIndex = 5;
            this.tpasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tnameBox
            // 
            this.tnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnameBox.Location = new System.Drawing.Point(67, 125);
            this.tnameBox.Name = "tnameBox";
            this.tnameBox.Size = new System.Drawing.Size(286, 34);
            this.tnameBox.TabIndex = 4;
            this.tnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongLabel.Location = new System.Drawing.Point(63, 375);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(290, 23);
            this.wrongLabel.TabIndex = 3;
            this.wrongLabel.Text = "Wrong User Name or Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showPasswordcheckBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.sPasswordtextBox);
            this.panel2.Controls.Add(this.sLoginBtn);
            this.panel2.Controls.Add(this.sRegisterBtn);
            this.panel2.Controls.Add(this.sIdtextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(840, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 430);
            this.panel2.TabIndex = 8;
            // 
            // showPasswordcheckBox2
            // 
            this.showPasswordcheckBox2.AutoSize = true;
            this.showPasswordcheckBox2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordcheckBox2.Location = new System.Drawing.Point(70, 258);
            this.showPasswordcheckBox2.Name = "showPasswordcheckBox2";
            this.showPasswordcheckBox2.Size = new System.Drawing.Size(120, 20);
            this.showPasswordcheckBox2.TabIndex = 11;
            this.showPasswordcheckBox2.Text = "Show Password";
            this.showPasswordcheckBox2.UseVisualStyleBackColor = true;
            this.showPasswordcheckBox2.CheckedChanged += new System.EventHandler(this.showPasswordcheckBox2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // sPasswordtextBox
            // 
            this.sPasswordtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sPasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPasswordtextBox.Location = new System.Drawing.Point(67, 217);
            this.sPasswordtextBox.Name = "sPasswordtextBox";
            this.sPasswordtextBox.PasswordChar = '*';
            this.sPasswordtextBox.Size = new System.Drawing.Size(286, 34);
            this.sPasswordtextBox.TabIndex = 9;
            this.sPasswordtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sLoginBtn
            // 
            this.sLoginBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.sLoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.sLoginBtn.FlatAppearance.BorderSize = 0;
            this.sLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.sLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sLoginBtn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLoginBtn.ForeColor = System.Drawing.Color.White;
            this.sLoginBtn.Location = new System.Drawing.Point(67, 304);
            this.sLoginBtn.Name = "sLoginBtn";
            this.sLoginBtn.Size = new System.Drawing.Size(286, 40);
            this.sLoginBtn.TabIndex = 7;
            this.sLoginBtn.Text = "Login";
            this.sLoginBtn.UseVisualStyleBackColor = false;
            this.sLoginBtn.Click += new System.EventHandler(this.sLoginBtn_Click);
            // 
            // sRegisterBtn
            // 
            this.sRegisterBtn.BackColor = System.Drawing.Color.Blue;
            this.sRegisterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sRegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sRegisterBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.sRegisterBtn.FlatAppearance.BorderSize = 0;
            this.sRegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sRegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.sRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sRegisterBtn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.sRegisterBtn.Location = new System.Drawing.Point(67, 360);
            this.sRegisterBtn.Name = "sRegisterBtn";
            this.sRegisterBtn.Size = new System.Drawing.Size(286, 40);
            this.sRegisterBtn.TabIndex = 6;
            this.sRegisterBtn.Text = "Register";
            this.sRegisterBtn.UseVisualStyleBackColor = false;
            this.sRegisterBtn.Click += new System.EventHandler(this.sRegisterBtn_Click);
            // 
            // sIdtextBox
            // 
            this.sIdtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sIdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sIdtextBox.Location = new System.Drawing.Point(67, 138);
            this.sIdtextBox.Name = "sIdtextBox";
            this.sIdtextBox.Size = new System.Drawing.Size(286, 34);
            this.sIdtextBox.TabIndex = 4;
            this.sIdtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
           
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Student ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "Student Login";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(218)))), ((int)(((byte)(13)))));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1310, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 46);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 804);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.showPasswordcheckBox3);
            this.panel3.Controls.Add(this.aLoginBtn);
            this.panel3.Controls.Add(this.aPasswordBox);
            this.panel3.Controls.Add(this.aNameBox);
            this.panel3.Controls.Add(this.wronglabel2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(840, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 430);
            this.panel3.TabIndex = 9;
            // 
            // showPasswordcheckBox3
            // 
            this.showPasswordcheckBox3.AutoSize = true;
            this.showPasswordcheckBox3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordcheckBox3.Location = new System.Drawing.Point(67, 243);
            this.showPasswordcheckBox3.Name = "showPasswordcheckBox3";
            this.showPasswordcheckBox3.Size = new System.Drawing.Size(120, 20);
            this.showPasswordcheckBox3.TabIndex = 7;
            this.showPasswordcheckBox3.Text = "Show Password";
            this.showPasswordcheckBox3.UseVisualStyleBackColor = true;
            this.showPasswordcheckBox3.CheckedChanged += new System.EventHandler(this.showPasswordcheckBox3_CheckedChanged);
            // 
            // aLoginBtn
            // 
            this.aLoginBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.aLoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.aLoginBtn.FlatAppearance.BorderSize = 0;
            this.aLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.aLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.aLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aLoginBtn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLoginBtn.ForeColor = System.Drawing.Color.White;
            this.aLoginBtn.Location = new System.Drawing.Point(67, 294);
            this.aLoginBtn.Name = "aLoginBtn";
            this.aLoginBtn.Size = new System.Drawing.Size(286, 40);
            this.aLoginBtn.TabIndex = 6;
            this.aLoginBtn.Text = "Login";
            this.aLoginBtn.UseVisualStyleBackColor = false;
            this.aLoginBtn.Click += new System.EventHandler(this.aLoginBtn_Click);
            // 
            // aPasswordBox
            // 
            this.aPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPasswordBox.Location = new System.Drawing.Point(67, 203);
            this.aPasswordBox.Name = "aPasswordBox";
            this.aPasswordBox.PasswordChar = '*';
            this.aPasswordBox.Size = new System.Drawing.Size(286, 34);
            this.aPasswordBox.TabIndex = 5;
            this.aPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aNameBox
            // 
            this.aNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aNameBox.Location = new System.Drawing.Point(67, 125);
            this.aNameBox.Name = "aNameBox";
            this.aNameBox.Size = new System.Drawing.Size(286, 34);
            this.aNameBox.TabIndex = 4;
            this.aNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wronglabel2
            // 
            this.wronglabel2.AutoSize = true;
            this.wronglabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wronglabel2.ForeColor = System.Drawing.Color.Red;
            this.wronglabel2.Location = new System.Drawing.Point(63, 375);
            this.wronglabel2.Name = "wronglabel2";
            this.wronglabel2.Size = new System.Drawing.Size(290, 23);
            this.wronglabel2.TabIndex = 3;
            this.wronglabel2.Text = "Wrong User Name or Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 26);
            this.label11.TabIndex = 1;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(116, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 33);
            this.label12.TabIndex = 0;
            this.label12.Text = "Admin Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(218)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.usercomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox usercomboBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tnameBox;
        private System.Windows.Forms.TextBox tpasswordBox;
        private System.Windows.Forms.Button tLoginBtn;
        private System.Windows.Forms.CheckBox showPasswordcheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sRegisterBtn;
        private System.Windows.Forms.TextBox sIdtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sLoginBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sPasswordtextBox;
        private System.Windows.Forms.CheckBox showPasswordcheckBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox showPasswordcheckBox3;
        private System.Windows.Forms.Button aLoginBtn;
        private System.Windows.Forms.TextBox aPasswordBox;
        private System.Windows.Forms.TextBox aNameBox;
        private System.Windows.Forms.Label wronglabel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

