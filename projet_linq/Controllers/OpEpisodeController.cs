using Microsoft.AspNetCore.Mvc;
using projet_linq.Entity;
using System.Xml;
using projet_linq.Convert;
using projet_linq.Queries;

namespace projet_linq.Controllers;

[ApiController]
[Route("op_episode")]
public class OpEpisodeController : ControllerBase
{

    [HttpGet("getAll")]
    public ActionResult<List<OpEpisode>> Get()
    {
        return Query.Get();
    }
    
    [HttpGet("getByName")]
    public ActionResult<List<OpEpisode>> GetByName([FromQuery] string? name, [FromQuery] bool ascending, [FromQuery] bool descending)
    {
        return Query.GetByName(name, ascending, descending);
    }
    
    [HttpGet("getBySeason")]
    public ActionResult<List<OpEpisode>> GetBySeason([FromQuery] int season, [FromQuery] bool ascending, [FromQuery] bool descending)
    {
        return Query.GetBySeason(season, ascending, descending);
    }
    
    [HttpGet("getByEpisode")]
    public ActionResult<List<OpEpisode>> GetByEpisode([FromQuery] int episode, [FromQuery] bool ascending, [FromQuery] bool descending)
    {
        return Query.GetByEpisode(episode, ascending, descending);
    }
    
    [HttpGet("getByRank")]
    public ActionResult<List<OpEpisode>> GetByRank([FromQuery] string rank, [FromQuery] bool ascending, [FromQuery] bool descending)
    {
        return Query.GetByRank(rank, ascending, descending);
    }
    
    [HttpGet("getByTrend")]
    public ActionResult<List<OpEpisode>> GetByTrend([FromQuery] string trend, [FromQuery] bool ascending, [FromQuery] bool descending)
    {
        return Query.GetByTrend(trend, ascending, descending);
    }
    
    [HttpGet("getByTotalVotes")]
    public ActionResult<List<OpEpisode>> GetByTotalVotes([FromQuery] string totalVotes, [FromQuery] bool ascending, [FromQuery] bool descending)
    {
        return Query.GetByTotalVotes(totalVotes, ascending, descending);
    }

    [HttpGet("getByAverageRatingInOrder")]
    public ActionResult<List<OpEpisode>> GetByAverageRating([FromQuery] double averageRating, [FromQuery] bool ascending, [FromQuery] bool descending)
    {
        return Query.GetByAverageRating(averageRating, ascending, descending);
    }

    [HttpGet("convertXml")]
    public IActionResult GetXml()
    {
        var opEpisode = Query.Get();
        var xmlDocument = ConvertXml.CreateXmlDocument(opEpisode);
        ConvertXml.SaveXmlDocument(xmlDocument);
        return new XmlResult(xmlDocument);
    }
}
