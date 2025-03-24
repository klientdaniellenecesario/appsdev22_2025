namespace SimpleFavoriteCartoonFormAppp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox = new PictureBox();
            comboBox = new ComboBox();
            viewbtn = new Button();
            clearbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FromArgb(255, 128, 0);
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Location = new Point(335, 133);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(238, 200);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // comboBox
            // 
            comboBox.BackColor = Color.FromArgb(255, 128, 0);
            comboBox.Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(55, 134);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(147, 23);
            comboBox.TabIndex = 1;
            // 
            // viewbtn
            // 
            viewbtn.BackColor = Color.FromArgb(255, 128, 0);
            viewbtn.Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewbtn.Location = new Point(55, 175);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(147, 35);
            viewbtn.TabIndex = 2;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = false;
            viewbtn.Click += viewbtn_Click;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.FromArgb(255, 128, 0);
            clearbtn.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearbtn.Location = new Point(55, 216);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(147, 35);
            clearbtn.TabIndex = 3;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 115);
            label1.Name = "label1";
            label1.Size = new Size(58, 16);
            label1.TabIndex = 4;
            label1.Text = "Images";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 115);
            label2.Name = "label2";
            label2.Size = new Size(104, 16);
            label2.TabIndex = 5;
            label2.Text = "Select an item:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Ink Free", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 44);
            label3.Name = "label3";
            label3.Size = new Size(406, 30);
            label3.TabIndex = 6;
            label3.Text = "Simple Favorite Cartoon Form App ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(627, 422);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clearbtn);
            Controls.Add(viewbtn);
            Controls.Add(comboBox);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private ComboBox comboBox;
        private Button viewbtn;
        private Button clearbtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
