namespace QuizManagementSystem
{
    partial class studentQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentQuiz));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leveldataGridView = new System.Windows.Forms.DataGridView();
            this.n1Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.resultBtn = new System.Windows.Forms.Button();
            this.n5Btn = new System.Windows.Forms.Button();
            this.n4Btn = new System.Windows.Forms.Button();
            this.n3Btn = new System.Windows.Forms.Button();
            this.n2Btn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.optionARadioButton = new System.Windows.Forms.RadioButton();
            this.optionBRadioButton = new System.Windows.Forms.RadioButton();
            this.optionCRadioButton = new System.Windows.Forms.RadioButton();
            this.optionDRadioButton = new System.Windows.Forms.RadioButton();
            this.nextBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.pdfButton = new System.Windows.Forms.Button();
            this.congratepictureBox = new System.Windows.Forms.PictureBox();
            this.congratelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leveldataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congratepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(1325, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 38);
            this.exitButton.TabIndex = 13;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(698, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quiz Sensei";
            // 
            // leveldataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.leveldataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.leveldataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leveldataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.leveldataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(218)))), ((int)(((byte)(13)))));
            this.leveldataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leveldataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leveldataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.leveldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leveldataGridView.EnableHeadersVisualStyles = false;
            this.leveldataGridView.Location = new System.Drawing.Point(280, 63);
            this.leveldataGridView.Name = "leveldataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.leveldataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.leveldataGridView.RowHeadersVisible = false;
            this.leveldataGridView.RowHeadersWidth = 51;
            this.leveldataGridView.RowTemplate.Height = 24;
            this.leveldataGridView.Size = new System.Drawing.Size(1074, 444);
            this.leveldataGridView.TabIndex = 15;
            this.leveldataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leveldataGridView_CellContentClick);
            // 
            // n1Btn
            // 
            this.n1Btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.n1Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n1Btn.FlatAppearance.BorderSize = 0;
            this.n1Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.n1Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.n1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n1Btn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n1Btn.Image = ((System.Drawing.Image)(resources.GetObject("n1Btn.Image")));
            this.n1Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.n1Btn.Location = new System.Drawing.Point(31, 137);
            this.n1Btn.Name = "n1Btn";
            this.n1Btn.Size = new System.Drawing.Size(213, 58);
            this.n1Btn.TabIndex = 16;
            this.n1Btn.Text = "N1";
            this.n1Btn.UseVisualStyleBackColor = false;
            this.n1Btn.Click += new System.EventHandler(this.n1Btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.resultBtn);
            this.panel1.Controls.Add(this.n5Btn);
            this.panel1.Controls.Add(this.n4Btn);
            this.panel1.Controls.Add(this.n3Btn);
            this.panel1.Controls.Add(this.n2Btn);
            this.panel1.Controls.Add(this.n1Btn);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 770);
            this.panel1.TabIndex = 21;
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
            this.logout.Location = new System.Drawing.Point(31, 710);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(206, 47);
            this.logout.TabIndex = 32;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.BackColor = System.Drawing.Color.Lime;
            this.resultBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.resultBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultBtn.Image = ((System.Drawing.Image)(resources.GetObject("resultBtn.Image")));
            this.resultBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultBtn.Location = new System.Drawing.Point(12, 619);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(250, 58);
            this.resultBtn.TabIndex = 21;
            this.resultBtn.Text = "Result";
            this.resultBtn.UseVisualStyleBackColor = false;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // n5Btn
            // 
            this.n5Btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.n5Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n5Btn.FlatAppearance.BorderSize = 0;
            this.n5Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.n5Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.n5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n5Btn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n5Btn.Image = ((System.Drawing.Image)(resources.GetObject("n5Btn.Image")));
            this.n5Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.n5Btn.Location = new System.Drawing.Point(31, 450);
            this.n5Btn.Name = "n5Btn";
            this.n5Btn.Size = new System.Drawing.Size(213, 58);
            this.n5Btn.TabIndex = 20;
            this.n5Btn.Text = "N5";
            this.n5Btn.UseVisualStyleBackColor = false;
            this.n5Btn.Click += new System.EventHandler(this.n5Btn_Click);
            // 
            // n4Btn
            // 
            this.n4Btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.n4Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n4Btn.FlatAppearance.BorderSize = 0;
            this.n4Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.n4Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.n4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n4Btn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n4Btn.Image = ((System.Drawing.Image)(resources.GetObject("n4Btn.Image")));
            this.n4Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.n4Btn.Location = new System.Drawing.Point(31, 370);
            this.n4Btn.Name = "n4Btn";
            this.n4Btn.Size = new System.Drawing.Size(213, 58);
            this.n4Btn.TabIndex = 19;
            this.n4Btn.Text = "N4";
            this.n4Btn.UseVisualStyleBackColor = false;
            this.n4Btn.Click += new System.EventHandler(this.n4Btn_Click);
            // 
            // n3Btn
            // 
            this.n3Btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.n3Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n3Btn.FlatAppearance.BorderSize = 0;
            this.n3Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.n3Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.n3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n3Btn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n3Btn.Image = ((System.Drawing.Image)(resources.GetObject("n3Btn.Image")));
            this.n3Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.n3Btn.Location = new System.Drawing.Point(31, 290);
            this.n3Btn.Name = "n3Btn";
            this.n3Btn.Size = new System.Drawing.Size(213, 58);
            this.n3Btn.TabIndex = 18;
            this.n3Btn.Text = "N3";
            this.n3Btn.UseVisualStyleBackColor = false;
            this.n3Btn.Click += new System.EventHandler(this.n3Btn_Click);
            // 
            // n2Btn
            // 
            this.n2Btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.n2Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n2Btn.FlatAppearance.BorderSize = 0;
            this.n2Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.n2Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.n2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n2Btn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n2Btn.Image = ((System.Drawing.Image)(resources.GetObject("n2Btn.Image")));
            this.n2Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.n2Btn.Location = new System.Drawing.Point(31, 212);
            this.n2Btn.Name = "n2Btn";
            this.n2Btn.Size = new System.Drawing.Size(213, 58);
            this.n2Btn.TabIndex = 17;
            this.n2Btn.Text = "N2";
            this.n2Btn.UseVisualStyleBackColor = false;
            this.n2Btn.Click += new System.EventHandler(this.n2Btn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.Blue;
            this.selectBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectBtn.Location = new System.Drawing.Point(1076, 579);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(142, 41);
            this.selectBtn.TabIndex = 23;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(453, 194);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(79, 27);
            this.questionLabel.TabIndex = 24;
            this.questionLabel.Text = "label2";
            // 
            // optionARadioButton
            // 
            this.optionARadioButton.AutoSize = true;
            this.optionARadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionARadioButton.Location = new System.Drawing.Point(526, 265);
            this.optionARadioButton.Name = "optionARadioButton";
            this.optionARadioButton.Size = new System.Drawing.Size(131, 28);
            this.optionARadioButton.TabIndex = 25;
            this.optionARadioButton.TabStop = true;
            this.optionARadioButton.Text = "radioButton1";
            this.optionARadioButton.UseVisualStyleBackColor = true;
            // 
            // optionBRadioButton
            // 
            this.optionBRadioButton.AutoSize = true;
            this.optionBRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionBRadioButton.Location = new System.Drawing.Point(526, 302);
            this.optionBRadioButton.Name = "optionBRadioButton";
            this.optionBRadioButton.Size = new System.Drawing.Size(131, 28);
            this.optionBRadioButton.TabIndex = 26;
            this.optionBRadioButton.TabStop = true;
            this.optionBRadioButton.Text = "radioButton2";
            this.optionBRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionCRadioButton
            // 
            this.optionCRadioButton.AutoSize = true;
            this.optionCRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCRadioButton.Location = new System.Drawing.Point(526, 337);
            this.optionCRadioButton.Name = "optionCRadioButton";
            this.optionCRadioButton.Size = new System.Drawing.Size(131, 28);
            this.optionCRadioButton.TabIndex = 27;
            this.optionCRadioButton.TabStop = true;
            this.optionCRadioButton.Text = "radioButton3";
            this.optionCRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionDRadioButton
            // 
            this.optionDRadioButton.AutoSize = true;
            this.optionDRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionDRadioButton.Location = new System.Drawing.Point(526, 369);
            this.optionDRadioButton.Name = "optionDRadioButton";
            this.optionDRadioButton.Size = new System.Drawing.Size(131, 28);
            this.optionDRadioButton.TabIndex = 28;
            this.optionDRadioButton.TabStop = true;
            this.optionDRadioButton.Text = "radioButton4";
            this.optionDRadioButton.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Lime;
            this.nextBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(1076, 579);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(142, 41);
            this.nextBtn.TabIndex = 29;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.BackColor = System.Drawing.Color.Red;
            this.finishBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishBtn.ForeColor = System.Drawing.Color.White;
            this.finishBtn.Location = new System.Drawing.Point(1076, 579);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(142, 41);
            this.finishBtn.TabIndex = 30;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = false;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // questionTimer
            // 
            this.questionTimer.Interval = 1000;
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(1145, 136);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(106, 24);
            this.timerLabel.TabIndex = 31;
            this.timerLabel.Text = "Time Left:";
            // 
            // pdfButton
            // 
            this.pdfButton.BackColor = System.Drawing.Color.Lime;
            this.pdfButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfButton.ForeColor = System.Drawing.Color.White;
            this.pdfButton.Location = new System.Drawing.Point(1050, 623);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(215, 41);
            this.pdfButton.TabIndex = 32;
            this.pdfButton.Text = "Genarate PDF";
            this.pdfButton.UseVisualStyleBackColor = false;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // congratepictureBox
            // 
            this.congratepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("congratepictureBox.Image")));
            this.congratepictureBox.Location = new System.Drawing.Point(337, 63);
            this.congratepictureBox.Name = "congratepictureBox";
            this.congratepictureBox.Size = new System.Drawing.Size(824, 497);
            this.congratepictureBox.TabIndex = 33;
            this.congratepictureBox.TabStop = false;
            // 
            // congratelabel
            // 
            this.congratelabel.AutoSize = true;
            this.congratelabel.Font = new System.Drawing.Font("Arial Narrow", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratelabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.congratelabel.Location = new System.Drawing.Point(682, 265);
            this.congratelabel.Name = "congratelabel";
            this.congratelabel.Size = new System.Drawing.Size(505, 94);
            this.congratelabel.TabIndex = 34;
            this.congratelabel.Text = "Congratulation";
            // 
            // studentQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(218)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.optionDRadioButton);
            this.Controls.Add(this.optionCRadioButton);
            this.Controls.Add(this.optionBRadioButton);
            this.Controls.Add(this.optionARadioButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.leveldataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.congratelabel);
            this.Controls.Add(this.congratepictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.studentQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leveldataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.congratepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView leveldataGridView;
        private System.Windows.Forms.Button n1Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button n5Btn;
        private System.Windows.Forms.Button n4Btn;
        private System.Windows.Forms.Button n3Btn;
        private System.Windows.Forms.Button n2Btn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton optionARadioButton;
        private System.Windows.Forms.RadioButton optionBRadioButton;
        private System.Windows.Forms.RadioButton optionCRadioButton;
        private System.Windows.Forms.RadioButton optionDRadioButton;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Timer questionTimer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button pdfButton;
        private System.Windows.Forms.PictureBox congratepictureBox;
        private System.Windows.Forms.Label congratelabel;
    }
}