using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LatestNews.Models;
public class NewsResponseModel
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("totalResults")]
    public int TotalResults { get; set; }

    [JsonPropertyName("results")]
    public List<NewsDto> Results { get; set; } = [];

    [JsonPropertyName("nextPage")]
    public string NextPage { get; set; }
}

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class NewsDto
{
    [JsonPropertyName("article_id")]
    public string ArticleId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("keywords")]
    public object Keywords { get; set; }

    [JsonPropertyName("creator")]
    public object Creator { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("pubDate")]
    public string PubDate { get; set; }

    [JsonPropertyName("pubDateTZ")]
    public string PubDateTZ { get; set; }

    [JsonPropertyName("image_url")]
    public string ImageUrl { get; set; }

    [JsonPropertyName("video_url")]
    public object VideoUrl { get; set; }

    [JsonPropertyName("source_id")]
    public string SourceId { get; set; }

    [JsonPropertyName("source_name")]
    public string SourceName { get; set; }

    [JsonPropertyName("source_priority")]
    public int SourcePriority { get; set; }

    [JsonPropertyName("source_url")]
    public string SourceUrl { get; set; }

    [JsonPropertyName("source_icon")]
    public string SourceIcon { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("country")]
    public List<string> Country { get; set; } = [];

    [JsonPropertyName("category")]
    public List<string> Category { get; set; } = [];

    [JsonPropertyName("sentiment")]
    public string Sentiment { get; set; }

    [JsonPropertyName("sentiment_stats")]
    public string SentimentStats { get; set; }

    [JsonPropertyName("ai_tag")]
    public string AiTag { get; set; }

    [JsonPropertyName("ai_region")]
    public string AiRegion { get; set; }

    [JsonPropertyName("ai_org")]
    public object AiOrg { get; set; }

    [JsonPropertyName("duplicate")]
    public bool Duplicate { get; set; }

    public string ImageUrlOrSourceIcon =>
        string.IsNullOrWhiteSpace(ImageUrl) ? SourceIcon : ImageUrl;

    public string Categories => Category?.Count > 0
                                ? string.Join(", ", Category)
                                : "";
    public string Countries => Country?.Count > 0
                                ? string.Join(", ", Country)
                                : "";
            
}

