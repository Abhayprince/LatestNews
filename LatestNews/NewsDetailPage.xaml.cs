using LatestNews.ViewModels;

namespace LatestNews;

public partial class NewsDetailPage : ContentPage
{
    private readonly NewsDetailsViewModel _viewModel;

    public NewsDetailPage(NewsDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
        _viewModel = viewModel;
    }

    private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
    {
        _viewModel.IsLoading = false;
    }
}