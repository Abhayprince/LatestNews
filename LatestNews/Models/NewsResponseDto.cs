using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestNews.Models_OLD;
public class NewsDto
{
    public string article_id { get; set; }
    public string title { get; set; }
    public string link { get; set; }
    public object keywords { get; set; }
    public object creator { get; set; }
    public string description { get; set; }
    public string content { get; set; }
    public string pubDate { get; set; }
    public string pubDateTZ { get; set; }
    public string image_url { get; set; }
    public object video_url { get; set; }
    public string source_id { get; set; }
    public string source_name { get; set; }
    public int source_priority { get; set; }
    public string source_url { get; set; }
    public string source_icon { get; set; }
    public string language { get; set; }
    public List<string> country { get; set; }
    public List<string> category { get; set; }
    public string sentiment { get; set; }
    public string sentiment_stats { get; set; }
    public string ai_tag { get; set; }
    public string ai_region { get; set; }
    public object ai_org { get; set; }
    public bool duplicate { get; set; }
}

public class NewsResponseModel
{
    public string status { get; set; }
    public int totalResults { get; set; }
    public List<NewsDto> results { get; set; }
}

//public class SentimentStats
//{
//    public double positive { get; set; }
//    public double neutral { get; set; }
//    public double negative { get; set; }
//}
