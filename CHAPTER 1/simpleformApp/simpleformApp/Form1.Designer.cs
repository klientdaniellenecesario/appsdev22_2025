namespace simpleformApp
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
            firstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lastName = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.Location = new Point(136, 120);
            firstName.Name = "firstName";
            firstName.Size = new Size(106, 23);
            firstName.TabIndex = 0;
            firstName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 102);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 229);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // lastName
            // 
            lastName.Location = new Point(136, 247);
            lastName.Name = "lastName";
            lastName.Size = new Size(106, 23);
            lastName.TabIndex = 3;
            lastName.TextChanged += lastName_TextChanged;
            // 
            // submit
            // 
            submit.Location = new Point(161, 286);
            submit.Name = "submit";
            submit.Size = new Size(52, 22);
            submit.TabIndex = 4;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 568);
            Controls.Add(submit);
            Controls.Add(lastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstName;
        private Label label1;
        private Label label2;
        private TextBox lastName;
        private Button submit;
    }
}
