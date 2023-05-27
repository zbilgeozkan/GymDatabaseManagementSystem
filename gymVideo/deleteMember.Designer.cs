namespace gymVideo
{
    partial class deleteMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteMember));
            label12 = new Label();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            buttonDelete = new Button();
            textSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.Fuchsia;
            label12.Location = new Point(347, 95);
            label12.Name = "label12";
            label12.Size = new Size(127, 31);
            label12.TabIndex = 79;
            label12.Text = "FITNESS";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(237, 44);
            label11.Name = "label11";
            label11.Size = new Size(240, 65);
            label11.TabIndex = 78;
            label11.Text = "SWEAT";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 284);
            dataGridView1.TabIndex = 85;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 128, 255);
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(314, 229);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 84;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textSearch.Location = new Point(237, 187);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(334, 25);
            textSearch.TabIndex = 83;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(156, 190);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 82;
            label1.Text = "Enter ID:";
            // 
            // deleteMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(690, 590);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDelete);
            Controls.Add(textSearch);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(label11);
            Name = "deleteMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "deleteMember";
            Load += deleteMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label11;
        private DataGridView dataGridView1;
        private Button buttonDelete;
        private TextBox textSearch;
        private Label label1;
    }
}