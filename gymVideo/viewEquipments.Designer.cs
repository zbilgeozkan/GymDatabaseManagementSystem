namespace gymVideo
{
    partial class viewEquipments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewEquipments));
            label12 = new Label();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(327, 85);
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
            label11.Location = new Point(217, 34);
            label11.Name = "label11";
            label11.Size = new Size(240, 65);
            label11.TabIndex = 78;
            label11.Text = "SWEAT";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(586, 392);
            dataGridView1.TabIndex = 80;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // viewEquipments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(690, 590);
            Controls.Add(dataGridView1);
            Controls.Add(label12);
            Controls.Add(label11);
            Name = "viewEquipments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewEquipments";
            Load += viewEquipments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label11;
        private DataGridView dataGridView1;
    }
}