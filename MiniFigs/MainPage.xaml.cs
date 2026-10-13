namespace MiniFigs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            charactersCollectionView.ItemsSource = Data.DataRepository.GetAllCharacters();
        }
    }
}
