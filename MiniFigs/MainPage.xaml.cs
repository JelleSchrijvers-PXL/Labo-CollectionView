using System.Linq;
using MiniFigs.Models;

namespace MiniFigs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoadDataClicked(object sender, EventArgs e)
        {
            charactersCollectionView.ItemsSource = Data.DataRepository.GetAllCharacters();
        }

        private async void OnChangeSelectionModeClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheetAsync("SelectMode", "Cancel", null, "None", "Single", "Multiple");

            switch (action)
            {
                case "None":
                    charactersCollectionView.SelectionMode = SelectionMode.None;
                    break;
                case "Single":
                    charactersCollectionView.SelectionMode = SelectionMode.Single;
                    break;
                case "Multiple":
                    charactersCollectionView.SelectionMode = SelectionMode.Multiple;
                    break;
            }
        }

        private void SelectionChanged_Event(object sender, SelectionChangedEventArgs e)
        {
            selectionLabel.Text = string.Join(
                ",", e.CurrentSelection.Cast<MiniFig>().Select(miniFig => miniFig.Name));
        }
    }
}
