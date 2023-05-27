namespace gymVideo
{
    partial class Equipments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipments));
            label12 = new Label();
            label11 = new Label();
            textEquipmentName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBoxDescription = new RichTextBox();
            textMusclesUsed = new TextBox();
            dateTimePickerDD = new DateTimePicker();
            textCost = new TextBox();
            buttonEquipments = new Button();
            buttonSave = new Button();
            buttonReset = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(341, 82);
            label12.Name = "label12";
            label12.Size = new Size(127, 31);
            label12.TabIndex = 77;
            label12.Text = "FITNESS";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(231, 31);
            label11.Name = "label11";
            label11.Size = new Size(240, 65);
            label11.TabIndex = 76;
            label11.Text = "SWEAT";
            // 
            // textEquipmentName
            // 
            textEquipmentName.Location = new Point(349, 151);
            textEquipmentName.Name = "textEquipmentName";
            textEquipmentName.Size = new Size(145, 23);
            textEquipmentName.TabIndex = 78;
            textEquipmentName.TextChanged += textEquipmentName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(231, 152);
            label1.Name = "label1";
            label1.Size = new Size(112, 17);
            label1.TabIndex = 79;
            label1.Text = "Equipment Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(231, 193);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 80;
            label2.Text = "Description:";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(325, 192);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(169, 89);
            richTextBoxDescription.TabIndex = 81;
            richTextBoxDescription.Text = "";
            richTextBoxDescription.TextChanged += richTextBoxDescription_TextChanged;
            // 
            // textMusclesUsed
            // 
            textMusclesUsed.Location = new Point(325, 306);
            textMusclesUsed.Name = "textMusclesUsed";
            textMusclesUsed.Size = new Size(169, 23);
            textMusclesUsed.TabIndex = 82;
            textMusclesUsed.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePickerDD
            // 
            dateTimePickerDD.Format = DateTimePickerFormat.Short;
            dateTimePickerDD.Location = new Point(325, 351);
            dateTimePickerDD.Name = "dateTimePickerDD";
            dateTimePickerDD.Size = new Size(142, 23);
            dateTimePickerDD.TabIndex = 83;
            // 
            // textCost
            // 
            textCost.Location = new Point(325, 394);
            textCost.Name = "textCost";
            textCost.Size = new Size(110, 23);
            textCost.TabIndex = 84;
            // 
            // buttonEquipments
            // 
            buttonEquipments.Location = new Point(314, 506);
            buttonEquipments.Name = "buttonEquipments";
            buttonEquipments.Size = new Size(110, 26);
            buttonEquipments.TabIndex = 86;
            buttonEquipments.Text = "View Equipments";
            buttonEquipments.UseVisualStyleBackColor = true;
            buttonEquipments.Click += buttonEquipments_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(267, 460);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 26);
            buttonSave.TabIndex = 85;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(396, 460);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 26);
            buttonReset.TabIndex = 87;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(227, 307);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 88;
            label3.Text = "Muscles Used:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(231, 351);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 89;
            label4.Text = "Delivery Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(282, 395);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 90;
            label5.Text = "Cost:";
            // 
            // Equipments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(690, 590);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonReset);
            Controls.Add(buttonEquipments);
            Controls.Add(buttonSave);
            Controls.Add(textCost);
            Controls.Add(dateTimePickerDD);
            Controls.Add(textMusclesUsed);
            Controls.Add(richTextBoxDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textEquipmentName);
            Controls.Add(label12);
            Controls.Add(label11);
            Name = "Equipments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label11;
        private TextBox textEquipmentName;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBoxDescription;
        private TextBox textMusclesUsed;
        private DateTimePicker dateTimePickerDD;
        private TextBox textCost;
        private Button buttonEquipments;
        private Button buttonSave;
        private Button buttonReset;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}