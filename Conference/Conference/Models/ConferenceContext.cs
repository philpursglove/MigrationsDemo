using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Conference.Models
{
    public class ConferenceContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
    }

    public class Session
    {
        [Key]
        public int SessionId { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string SpeakerName { get; set; }
        public string RepoURL { get; set; }
    }
}