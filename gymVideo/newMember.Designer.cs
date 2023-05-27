namespace gymVideo
{
    partial class newMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newMember));
            textFirstName = new TextBox();
            textLastName = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePickerDOB = new DateTimePicker();
            textPhone = new TextBox();
            textEmail = new TextBox();
            dateTimePickerJD = new DateTimePicker();
            richTextBoxAddress = new RichTextBox();
            comboBoxMembership = new ComboBox();
            comboBoxGymTime = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            buttonSave = new Button();
            buttonReset = new Button();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(259, 176);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(100, 25);
            textFirstName.TabIndex = 0;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(259, 225);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(100, 25);
            textLastName.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(300, 276);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 21);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Location = new Point(239, 276);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 21);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(257, 320);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(102, 25);
            dateTimePickerDOB.TabIndex = 4;
            dateTimePickerDOB.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(254, 374);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(105, 25);
            textPhone.TabIndex = 5;
            textPhone.TextChanged += textBox3_TextChanged;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(443, 172);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(128, 25);
            textEmail.TabIndex = 6;
            // 
            // dateTimePickerJD
            // 
            dateTimePickerJD.Format = DateTimePickerFormat.Short;
            dateTimePickerJD.Location = new Point(462, 221);
            dateTimePickerJD.Name = "dateTimePickerJD";
            dateTimePickerJD.Size = new Size(109, 25);
            dateTimePickerJD.TabIndex = 7;
            // 
            // richTextBoxAddress
            // 
            richTextBoxAddress.Location = new Point(456, 326);
            richTextBoxAddress.Name = "richTextBoxAddress";
            richTextBoxAddress.Size = new Size(115, 89);
            richTextBoxAddress.TabIndex = 9;
            richTextBoxAddress.Text = "";
            // 
            // comboBoxMembership
            // 
            comboBoxMembership.FormattingEnabled = true;
            comboBoxMembership.Items.AddRange(new object[] { "1 Month", "2 Months", "3 Months", "6 Months", "12 Months" });
            comboBoxMembership.Location = new Point(365, 459);
            comboBoxMembership.Name = "comboBoxMembership";
            comboBoxMembership.Size = new Size(131, 25);
            comboBoxMembership.TabIndex = 10;
            comboBoxMembership.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxGymTime
            // 
            comboBoxGymTime.FormattingEnabled = true;
            comboBoxGymTime.Items.AddRange(new object[] { "08.00 - 10.00", "10.00 - 12.00", "12.00 - 14.00", "14.00 - 16.00", "16.00 - 18.00" });
            comboBoxGymTime.Location = new Point(468, 278);
            comboBoxGymTime.Name = "comboBoxGymTime";
            comboBoxGymTime.Size = new Size(103, 25);
            comboBoxGymTime.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 176);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 12;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(171, 226);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 13;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(172, 278);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 14;
            label3.Text = "Gender:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(167, 326);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 15;
            label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(193, 374);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 16;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(387, 173);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 17;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(387, 225);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 18;
            label7.Text = "Join Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(387, 281);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 19;
            label8.Text = "Gym Time:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(387, 355);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 20;
            label9.Text = "Address:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(242, 462);
            label10.Name = "label10";
            label10.Size = new Size(117, 17);
            label10.TabIndex = 21;
            label10.Text = "Membership Time:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(284, 525);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 26);
            buttonSave.TabIndex = 22;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button1_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(387, 525);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 26);
            buttonReset.TabIndex = 23;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(239, 36);
            label11.Name = "label11";
            label11.Size = new Size(240, 65);
            label11.TabIndex = 24;
            label11.Text = "SWEAT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(350, 88);
            label12.Name = "label12";
            label12.Size = new Size(127, 31);
            label12.TabIndex = 25;
            label12.Text = "FITNESS";
            label12.Click += label12_Click;
            // 
            // newMember
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(690, 590);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(buttonReset);
            Controls.Add(buttonSave);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxGymTime);
            Controls.Add(comboBoxMembership);
            Controls.Add(richTextBoxAddress);
            Controls.Add(dateTimePickerJD);
            Controls.Add(textEmail);
            Controls.Add(textPhone);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textLastName);
            Controls.Add(textFirstName);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "newMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "newMember";
            Load += newMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFirstName;
        private TextBox textLastName;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePickerDOB;
        private TextBox textPhone;
        private TextBox textEmail;
        private DateTimePicker dateTimePickerJD;
        private RichTextBox richTextBoxAddress;
        private ComboBox comboBoxMembership;
        private ComboBox comboBoxGymTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button buttonSave;
        private Button buttonReset;
        private Label label11;
        private Label label12;
    }
}