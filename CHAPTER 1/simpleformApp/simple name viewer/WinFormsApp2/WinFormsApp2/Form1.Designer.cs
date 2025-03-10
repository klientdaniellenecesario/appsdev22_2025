namespace WinFormsApp2
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
            lstbox = new ListBox();
            txtbox = new TextBox();
            addbtn = new Button();
            removebtn = new Button();
            clearbtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstbox
            // 
            lstbox.BackColor = SystemColors.ButtonShadow;
            lstbox.FormattingEnabled = true;
            lstbox.ItemHeight = 15;
            lstbox.Location = new Point(12, 121);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(134, 304);
            lstbox.TabIndex = 1;
            lstbox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // txtbox
            // 
            txtbox.BackColor = SystemColors.ButtonShadow;
            txtbox.Location = new Point(152, 121);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(95, 23);
            txtbox.TabIndex = 2;
            txtbox.TextChanged += txtbox_TextChanged;
            // 
            // addbtn
            // 
            addbtn.BackColor = SystemColors.ButtonShadow;
            addbtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbtn.ForeColor = Color.DarkBlue;
            addbtn.Location = new Point(164, 195);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(83, 29);
            addbtn.TabIndex = 3;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackColor = SystemColors.ButtonShadow;
            removebtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removebtn.ForeColor = Color.DarkBlue;
            removebtn.Location = new Point(164, 230);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(83, 29);
            removebtn.TabIndex = 4;
            removebtn.Text = "DELETE";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = SystemColors.ButtonShadow;
            clearbtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearbtn.ForeColor = Color.DarkBlue;
            clearbtn.Location = new Point(164, 265);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(83, 29);
            clearbtn.TabIndex = 5;
            clearbtn.Text = "CLEAR";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(259, 33);
            label1.TabIndex = 6;
            label1.Text = "Simple Name Viewer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(282, 450);
            Controls.Add(label1);
            Controls.Add(clearbtn);
            Controls.Add(removebtn);
            Controls.Add(addbtn);
            Controls.Add(txtbox);
            Controls.Add(lstbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstbox;
        private TextBox txtbox;
        private Button addbtn;
        private Button removebtn;
        private Button clearbtn;
        private Label label1;
    }
}
