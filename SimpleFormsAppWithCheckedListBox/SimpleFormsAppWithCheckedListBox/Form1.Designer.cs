namespace SimpleFormsAppWithCheckedListBox
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
            movieCheckedList = new CheckedListBox();
            movielistBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            add = new Button();
            delete = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // movieCheckedList
            // 
            movieCheckedList.BackColor = SystemColors.InactiveCaptionText;
            movieCheckedList.ForeColor = SystemColors.Window;
            movieCheckedList.FormattingEnabled = true;
            movieCheckedList.Location = new Point(63, 141);
            movieCheckedList.Name = "movieCheckedList";
            movieCheckedList.Size = new Size(247, 166);
            movieCheckedList.TabIndex = 0;
            movieCheckedList.SelectedIndexChanged += movieCheckedList_SelectedIndexChanged;
            // 
            // movielistBox
            // 
            movielistBox.BackColor = SystemColors.MenuText;
            movielistBox.ForeColor = SystemColors.Menu;
            movielistBox.FormattingEnabled = true;
            movielistBox.ItemHeight = 15;
            movielistBox.Location = new Point(397, 141);
            movielistBox.Name = "movielistBox";
            movielistBox.Size = new Size(328, 169);
            movielistBox.TabIndex = 1;
            movielistBox.SelectedIndexChanged += movielistBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(213, 36);
            label1.Name = "label1";
            label1.Size = new Size(532, 31);
            label1.TabIndex = 2;
            label1.Text = "SIMPLE FAVORITE MOVIE PICKER APP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(96, 116);
            label2.Name = "label2";
            label2.Size = new Size(160, 22);
            label2.TabIndex = 3;
            label2.Text = "Movies/Series List";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(532, 116);
            label3.Name = "label3";
            label3.Size = new Size(66, 22);
            label3.TabIndex = 4;
            label3.Text = "My list";
            label3.Click += label3_Click;
            // 
            // add
            // 
            add.BackColor = SystemColors.ActiveCaptionText;
            add.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.ForeColor = SystemColors.ButtonHighlight;
            add.Location = new Point(63, 324);
            add.Name = "add";
            add.Size = new Size(247, 39);
            add.TabIndex = 5;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.BackColor = SystemColors.ActiveCaptionText;
            delete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.ForeColor = SystemColors.ButtonHighlight;
            delete.Location = new Point(754, 141);
            delete.Name = "delete";
            delete.Size = new Size(121, 40);
            delete.TabIndex = 6;
            delete.Text = "Remove";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.ActiveCaptionText;
            clear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = SystemColors.ButtonHighlight;
            clear.Location = new Point(754, 187);
            clear.Name = "clear";
            clear.Size = new Size(121, 42);
            clear.TabIndex = 7;
            clear.Text = "Clear All";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(935, 450);
            Controls.Add(clear);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(movielistBox);
            Controls.Add(movieCheckedList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox movieCheckedList;
        private ListBox movielistBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button add;
        private Button delete;
        private Button clear;
    }
}
