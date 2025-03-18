namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] foodCuisine = { "French", "Korean", "Filipino", "American", "Chinese", "Japanese" };
            FoodComboBox.Items.AddRange(foodCuisine);

            FoodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FoodComboBox.SelectedIndex = 0;
        }

        private void Selectbtn_Click(object sender, EventArgs e)
        {
            string[] frenchFood = { "Ratatouille", "Coq au Vin", "Boeuf Bourguignon", "Quiche Lorraine", "Crêpes" };
            string[] koreanFood = { "Samgyeopsal", "Kimchi Jjigae", "Sundubu Jjigae", "Jajangmyeon", "Korean Fried Chicken" };
            string[] filipinoFood = { "Adobo", "Pancit", "Sisig", "Lechon", "Kare-Kare" };
            string[] americanFood = { "Mac and Cheese", "BBQ Ribs", "Buffalo Wings", "New York-Style Pizza", "Pot Roast" };
            string[] chineseFood = { "Peking Duck", "Dim Sum", "Sweet and Sour Pork", "Chop Suey", "Ma Po Tofu" };
            string[] japaneseFood = { "Sushi", "Ramen", "Okonomiyaki", "Tempura", "Takoyaki" };

            FoodCheckedBox.Items.Clear();

            if (FoodComboBox.SelectedItem.ToString().Contains("French"))
            {
                FoodCheckedBox.Items.AddRange(frenchFood);
            }
            else if (FoodComboBox.SelectedItem.ToString().Contains("Korean"))
            {
                FoodCheckedBox.Items.AddRange(koreanFood);
            }
            else if (FoodComboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                FoodCheckedBox.Items.AddRange(filipinoFood);
            }
            else if (FoodComboBox.SelectedItem.ToString().Contains("American"))
            {
                FoodCheckedBox.Items.AddRange(americanFood);
            }
            else if (FoodComboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                FoodCheckedBox.Items.AddRange(chineseFood);
            }
            else if (FoodComboBox.SelectedItem.ToString().Contains("Japanese"))
            {
                FoodCheckedBox.Items.AddRange(japaneseFood);
            }
        }

        private void FoodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (FavFoodList.Items.Count >= 1)
            {
                FavFoodList.Items.Remove(FavFoodList.SelectedItem);
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            FavFoodList.Items.Clear();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            foreach (var item in FoodCheckedBox.Items)
            {
                bool isSelected = FoodCheckedBox.GetItemChecked(FoodCheckedBox.Items.IndexOf(item));
                if (isSelected && !FavFoodList.Items.Contains(item))
                {
                    FavFoodList.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}    