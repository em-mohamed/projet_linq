using System.Text.Json.Serialization;

namespace projet_linq.Entity;

public class OpEpisode
{
    public OpEpisode(
        int key,
        string rank,
        string trend,
        int season,
        int episode,
        string name,
        string total_votes,
        double average_rating
    )
    {
        Key = key;
        Rank = rank;
        Trend = trend;
        Season = season;
        Episode = episode;
        Name = name;
        Total_votes = total_votes;
        Average_rating = average_rating;
    }
    
    [JsonPropertyName("key")]
    public int Key { get; set; }
    
    [JsonPropertyName("rank")]
    public string Rank { get; set; }
    
    [JsonPropertyName("trend")]
    public string Trend { get; set; }
    
    [JsonPropertyName("season")]
    public int Season { get; set; }
    
    [JsonPropertyName("episode")]
    public int Episode { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("total_votes")]
    public string Total_votes { get; set; }
    
    [JsonPropertyName("average_rating")]
    public double Average_rating { get; set; }
    
    public override string ToString()
    {
        return $"Key: {Key}, Rank: {Rank}, Trend: {Trend}, Season: {Season}, Episode: {Episode}, Name: {Name}, Total_votes: {Total_votes}, Average_rating: {Average_rating}";
    }
}