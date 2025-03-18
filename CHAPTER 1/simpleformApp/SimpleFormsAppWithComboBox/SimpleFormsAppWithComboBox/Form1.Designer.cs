namespace SimpleFormsAppWithComboBox
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
            FoodComboBox = new ComboBox();
            FoodCheckedBox = new CheckedListBox();
            FavFoodList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Selectbtn = new Button();
            Addbtn = new Button();
            removebtn = new Button();
            Clearbtn = new Button();
            SuspendLayout();
            // 
            // FoodComboBox
            // 
            FoodComboBox.BackColor = Color.FromArgb(64, 64, 64);
            FoodComboBox.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FoodComboBox.ForeColor = Color.White;
            FoodComboBox.FormattingEnabled = true;
            FoodComboBox.Location = new Point(55, 179);
            FoodComboBox.Name = "FoodComboBox";
            FoodComboBox.Size = new Size(145, 42);
            FoodComboBox.TabIndex = 0;
            FoodComboBox.SelectedIndexChanged += FoodComboBox_SelectedIndexChanged;
            // 
            // FoodCheckedBox
            // 
            FoodCheckedBox.BackColor = Color.FromArgb(64, 64, 64);
            FoodCheckedBox.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FoodCheckedBox.ForeColor = Color.White;
            FoodCheckedBox.FormattingEnabled = true;
            FoodCheckedBox.Location = new Point(245, 182);
            FoodCheckedBox.Name = "FoodCheckedBox";
            FoodCheckedBox.Size = new Size(211, 238);
            FoodCheckedBox.TabIndex = 1;
            // 
            // FavFoodList
            // 
            FavFoodList.BackColor = Color.FromArgb(64, 64, 64);
            FavFoodList.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FavFoodList.ForeColor = Color.White;
            FavFoodList.FormattingEnabled = true;
            FavFoodList.ItemHeight = 34;
            FavFoodList.Location = new Point(514, 182);
            FavFoodList.Name = "FavFoodList";
            FavFoodList.Size = new Size(170, 242);
            FavFoodList.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Javanese Text", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(225, 27);
            label1.Name = "label1";
            label1.Size = new Size(411, 68);
            label1.TabIndex = 3;
            label1.Text = "Simple Favorite Food Picker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 140);
            label2.Name = "label2";
            label2.Size = new Size(71, 36);
            label2.TabIndex = 4;
            label2.Text = "Cuisine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(312, 140);
            label3.Name = "label3";
            label3.Size = new Size(86, 36);
            label3.TabIndex = 5;
            label3.Text = "Food List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(505, 140);
            label4.Name = "label4";
            label4.Size = new Size(179, 36);
            label4.TabIndex = 6;
            label4.Text = "My Favorite Food List";
            // 
            // Selectbtn
            // 
            Selectbtn.BackColor = Color.FromArgb(64, 64, 64);
            Selectbtn.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Selectbtn.ForeColor = Color.White;
            Selectbtn.Location = new Point(70, 237);
            Selectbtn.Name = "Selectbtn";
            Selectbtn.Size = new Size(117, 37);
            Selectbtn.TabIndex = 7;
            Selectbtn.Text = "Select";
            Selectbtn.UseVisualStyleBackColor = false;
            Selectbtn.Click += Selectbtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.FromArgb(64, 64, 64);
            Addbtn.Font = new Font("Javanese Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(245, 435);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(211, 36);
            Addbtn.TabIndex = 8;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.FromArgb(64, 64, 64);
            removebtn.Font = new Font("Javanese Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removebtn.ForeColor = Color.White;
            removebtn.Location = new Point(704, 182);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(75, 34);
            removebtn.TabIndex = 9;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.BackColor = Color.FromArgb(64, 64, 64);
            Clearbtn.Font = new Font("Javanese Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clearbtn.ForeColor = Color.White;
            Clearbtn.Location = new Point(704, 222);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(75, 33);
            Clearbtn.TabIndex = 10;
            Clearbtn.Text = "Clear All";
            Clearbtn.UseVisualStyleBackColor = false;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(830, 537);
            Controls.Add(Clearbtn);
            Controls.Add(removebtn);
            Controls.Add(Addbtn);
            Controls.Add(Selectbtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FavFoodList);
            Controls.Add(FoodCheckedBox);
            Controls.Add(FoodComboBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FoodComboBox;
        private CheckedListBox FoodCheckedBox;
        private ListBox FavFoodList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Selectbtn;
        private Button Addbtn;
        private Button removebtn;
        private Button Clearbtn;
    }
}
