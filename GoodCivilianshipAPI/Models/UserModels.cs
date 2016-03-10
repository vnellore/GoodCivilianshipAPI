using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Models related to User
/// </summary>
namespace GoodCivilianshipAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public enum IncidentStatus
    {
        Reported = 0,
        InProgress = 1,
        Completed = 2,
        Cancelled = 3
    }

    /// <summary>
    /// 
    /// </summary>
    public enum IncidentCategory
    {
        Report = 0,
        Support = 1,
        Learn = 2
    }

    public class Comment
    {
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public string User { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class GPSCoordinates
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }

    /// <summary>
    /// /
    /// </summary>
    public class Incident
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IncidentCategory Category { get; set; }
        public string Description { get; set; }
        public GPSCoordinates GPSLocation { get; set; }
        public string LocationDescription { get; set; }
        public List<User> ReportedUsers { get; set; }
        public IncidentStatus Status { get; set; }
        public List<Comment> Comments { get; set; }
        public List<string> Images { get; set; }
        public DateTime CreateTime { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Interests { get; set; }
        public int RewardPoints { get; set; }
        public List<string> Badges { get; set; }
        public List<Incident> Incidents { get; set; }
    }
    
    public class Recommendation
    {
        public string Description { get; set; }
    }
}