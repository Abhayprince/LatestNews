using LatestNews.ViewModels;
using System.Threading.Tasks;

namespace LatestNews
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _viewModel;
        
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
            FetchNews();
        }
        private async void FetchNews()
        {
            await _viewModel.FetchNewsAsync();
        }
    }

}
