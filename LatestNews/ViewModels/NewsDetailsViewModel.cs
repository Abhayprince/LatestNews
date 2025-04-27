using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LatestNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestNews.ViewModels;

//[QueryProperty(nameof(SourceUrl), nameof(SourceUrl))]
[QueryProperty(nameof(News), nameof(News))]
public partial class NewsDetailsViewModel : ObservableObject
{
    //[ObservableProperty]
    //private string _sourceUrl;

    [ObservableProperty]
    private bool _isLoading = true;

    [ObservableProperty]
    private NewsDto _news = new();

    [RelayCommand]
    private async Task GoBackAsync() =>
        await Shell.Current.GoToAsync("..");
}
