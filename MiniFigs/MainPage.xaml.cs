namespace MiniFigs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            charactersCollectionView.ItemsSource = Data.DataRepository.GetAllCharacters();
        }
    }
}
