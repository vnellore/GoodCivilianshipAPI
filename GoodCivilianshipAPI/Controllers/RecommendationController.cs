using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoodCivilianshipAPI.Models;

namespace GoodCivilianshipAPI.Controllers
{
    [RoutePrefix("api")]
    public class RecommendationController : ApiController
    {
        [Route("recommendations")]
        public IEnumerable<Recommendation> GetAllRecommendations()
        {
            List<Recommendation> recommendations = new List<Recommendation>();
            Recommendation r1 = new Recommendation();
            r1.Description = "Pot Hole in front of 30th Street";

            Recommendation r2 = new Recommendation();
            r2.Description = "Street Light out at JFK and Market St";

            recommendations.Add(r1);
            recommendations.Add(r2);

            return recommendations;
        }
    }
}
