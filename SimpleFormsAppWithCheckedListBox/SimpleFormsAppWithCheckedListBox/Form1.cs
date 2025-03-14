namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "The Flash", "Squid Game", "Black Panther", "Simpsons" };
            movieCheckedList.Items.AddRange(movies);

            movieCheckedList.CheckOnClick = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void movieCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void movielistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach (var movies in movieCheckedList.Items)
            {
                bool inSelected = movieCheckedList.GetItemChecked(movieCheckedList.Items.IndexOf(movies));
                if (inSelected && !movielistBox.Items.Contains(movies))
                {
                    movielistBox.Items.Add(movies);

                }
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(movielistBox.Items.Count >= 1)
            {
                movielistBox.Items.Remove(movielistBox.SelectedItem);
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            movielistBox.Items.Clear();

        }
    }
}
