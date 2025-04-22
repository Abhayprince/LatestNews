using LatestNews.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestNews;
public interface INewsApi
{
    [Get("/api/1/latest")]
    Task<NewsResponseModel> GetLatestNewsAsync(string apiKey = Constants.ApiKey, string language= "en");

    //[Get("/api/1/latest")]
    //Task<ApiResponse<NewsResponseModel>> GetLatestNewsAsync(string apiKey = Constants.ApiKey);
}
