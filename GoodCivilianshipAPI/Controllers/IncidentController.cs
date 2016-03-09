using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoodCivilianshipAPI.Models;

namespace GoodCivilianshipAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api")]
    public class IncidentController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("incidents")]
        public IEnumerable<Incident> GetAllIncidents()
        {
            List<Incident> incidents = new List<Incident>();
            Incident i1 = new Incident();
            i1.Description = "Pot Hole in front of 30th Street";

            Incident i2 = new Incident();
            i2.Description = "Street Light out at JFK and Market St";

            incidents.Add(i1);
            incidents.Add(i2);

            return incidents;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incidentId"></param>
        /// <returns></returns>
        [Route("incidents/{incidentId}")]
        public Incident GetIncident(string incidentId)
        {
            Incident i1 = new Incident();
            i1.Description = "Volunteered at SPCA";

            return i1;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="incident"></param>
        [HttpPost]
        [Route("incidents")]
        public void CreateIncident([FromBody] Incident incident)
        {
            Console.WriteLine("incident - " + incident.Description);
        }
    }
}
