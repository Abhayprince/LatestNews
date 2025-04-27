using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LatestNews.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace LatestNews.ViewModels;
public partial class MainPageViewModel : ObservableObject
{
    private readonly INewsApi _newsApi;
    public MainPageViewModel(INewsApi newsApi)
    {
        _newsApi = newsApi;
    }
    public ObservableCollection<NewsDto> News { get; set; } = [];

    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    private bool _isRefreshing;

    [RelayCommand]
    private async Task RefreshNewsAsync()
    {
        await FetchNewsAsync(useIsBusy: false);
        IsRefreshing = false;
    }

    public async Task FetchNewsAsync(bool useIsBusy = true)
    {
        if(useIsBusy)
            IsBusy = true;
        try
        {
            var response = await _newsApi.GetLatestNewsAsync();
            if (response.TotalResults > 0 && response.Results?.Count > 0)
            {
                News.Clear();
                foreach (var item in response.Results)
                {
                    News.Add(item);
                }
            }
        }
        catch (ApiException apiException)
        {
            // Handle Refit Api related EXception with more details
            await Shell.Current.DisplayAlert("Error", apiException.Message, "OK");
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
        finally
        {
            if (useIsBusy)
                IsBusy = false;
        }
    }


    //[RelayCommand]
    //private async Task GoToDetailsPageAsync(string sourceUrl)
    //{
    //    var parameter = new Dictionary<string, object>
    //    {
    //        [nameof(NewsDetailsViewModel.SourceUrl)] = sourceUrl,
    //    };

    //    await Shell.Current.GoToAsync(nameof(NewsDetailPage), parameter);
    //}
    [RelayCommand]
    private async Task GoToDetailsPageAsync(NewsDto news)
    {
        var parameter = new Dictionary<string, object>
        {
            [nameof(NewsDetailsViewModel.News)] = news,
        };

        await Shell.Current.GoToAsync(nameof(NewsDetailPage), parameter);
    }
}


