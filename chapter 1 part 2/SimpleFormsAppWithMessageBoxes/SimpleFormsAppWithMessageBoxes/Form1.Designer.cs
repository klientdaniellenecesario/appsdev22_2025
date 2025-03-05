namespace SimpleFormsAppWithMessageBoxes
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
            firstname = new TextBox();
            lastname = new TextBox();
            middlename = new TextBox();
            suffix = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // firstname
            // 
            firstname.Location = new Point(303, 106);
            firstname.Name = "firstname";
            firstname.Size = new Size(116, 23);
            firstname.TabIndex = 0;
            firstname.TextChanged += firstname_TextChanged;
            // 
            // lastname
            // 
            lastname.Location = new Point(303, 229);
            lastname.Name = "lastname";
            lastname.Size = new Size(116, 23);
            lastname.TabIndex = 1;
            lastname.TextChanged += lastname_TextChanged;
            // 
            // middlename
            // 
            middlename.Location = new Point(303, 164);
            middlename.Name = "middlename";
            middlename.Size = new Size(116, 23);
            middlename.TabIndex = 2;
            middlename.TextChanged += middlename_TextChanged;
            // 
            // suffix
            // 
            suffix.Location = new Point(303, 289);
            suffix.Name = "suffix";
            suffix.Size = new Size(116, 23);
            suffix.TabIndex = 3;
            suffix.TextChanged += suffix_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 88);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 146);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "Middle Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 211);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 271);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Suffix";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(330, 328);
            button1.Name = "button1";
            button1.Size = new Size(66, 29);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 33);
            label5.Name = "label5";
            label5.Size = new Size(138, 15);
            label5.TabIndex = 9;
            label5.Text = "Simple Form Application";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(suffix);
            Controls.Add(middlename);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstname;
        private TextBox lastname;
        private TextBox middlename;
        private TextBox suffix;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}
