using projet_linq.Entity;

namespace projet_linq.Queries;
using System.Linq.Expressions;
using Newtonsoft.Json;

public class Query
{
    private static string path = "./Data/OpEpisode.json";
    private static string json = File.ReadAllText(path);
    private static List<OpEpisode> listOpEpisodes = JsonConvert.DeserializeObject<List<OpEpisode>>(json);
    
    public static List<OpEpisode> Get()
    {
        return listOpEpisodes;
    }
    
    public static List<OpEpisode> GetByName(string name, bool ascending, bool descending)
    {
        if (ascending)
        {
            return listOpEpisodes.OrderBy(opEpisode => opEpisode.Name).ToList();
        }
        else if (descending)
        {
            return listOpEpisodes.OrderByDescending(opEpisode => opEpisode.Name).ToList();
        }
        else
        {
            return listOpEpisodes.Where(opEpisode => opEpisode.Name.Contains(name)).ToList();
        }
    }
    
    public static List<OpEpisode> GetBySeason(int season, bool ascending, bool descending)
    {
        if (ascending)
        {
            return listOpEpisodes.OrderBy(opEpisode => opEpisode.Season).ToList();
        }
        else if (descending)
        {
            return listOpEpisodes.OrderByDescending(opEpisode => opEpisode.Season).ToList();
        }
        else
        {
            return listOpEpisodes.Where(opEpisode => opEpisode.Season == season).ToList();
        }
    }
    
    public static List<OpEpisode> GetByEpisode(int episode, bool ascending, bool descending)
    {
        if (ascending)
        {
            return listOpEpisodes.OrderBy(opEpisode => opEpisode.Episode).ToList();
        }
        else if (descending)
        {
            return listOpEpisodes.OrderByDescending(opEpisode => opEpisode.Episode).ToList();
        }
        else
        {
            return listOpEpisodes.Where(opEpisode => opEpisode.Episode == episode).ToList();
        }
    }
    
    public static List<OpEpisode> GetByRank(string rank, bool ascending, bool descending)
    {
        if (ascending)
        {
            return listOpEpisodes.OrderBy(opEpisode => opEpisode.Rank).ToList();
        }
        else if (descending)
        {
            return listOpEpisodes.OrderByDescending(opEpisode => opEpisode.Rank).ToList();
        }
        else
        {
            return listOpEpisodes.Where(opEpisode => opEpisode.Rank == rank).ToList();
        }
    }
    
    public static List<OpEpisode> GetByTrend(string trend, bool ascending, bool descending)
    {
        if (ascending)
        {
            return listOpEpisodes.OrderBy(opEpisode => opEpisode.Trend).ToList();
        }
        else if (descending)
        {
            return listOpEpisodes.OrderByDescending(opEpisode => opEpisode.Trend).ToList();
        }
        else
        {
            return listOpEpisodes.Where(opEpisode => opEpisode.Trend == trend).ToList();
        }
    }
    
    public static List<OpEpisode> GetByTotalVotes(string totalVotes, bool ascending, bool descending)
    {
        if (ascending)
        {
            return listOpEpisodes.OrderBy(opEpisode => opEpisode.Total_votes).ToList();
        }
        else if (descending)
        {
            return listOpEpisodes.OrderByDescending(opEpisode => opEpisode.Total_votes).ToList();
        }
        else
        {
            return listOpEpisodes.Where(opEpisode => opEpisode.Total_votes == totalVotes).ToList();
        }
    }
    
    public static List<OpEpisode> GetByAverageRating(double averageRating, bool ascending, bool descending)
    {
        if (ascending)
        {
            return listOpEpisodes.OrderBy(opEpisode => opEpisode.Average_rating).ToList();
        }
        else if (descending)
        {
            return listOpEpisodes.OrderByDescending(opEpisode => opEpisode.Average_rating).ToList();
        }
        else
        {
            return listOpEpisodes.Where(opEpisode => opEpisode.Average_rating.Equals(averageRating)).ToList();
        }
    }

}
