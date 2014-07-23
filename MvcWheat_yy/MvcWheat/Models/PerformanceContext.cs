using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcWheat.Models
{
    public class Performance
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public string City { get; set; }
        public string Place { get; set; }
        public string Type { get; set; }
        public string Information { get; set; }
        public int ClickRate { get; set; }
        public string Poster { get; set; }
        public int AdminID { get; set; }
    }
    public class PerformanceDBContext : DbContext
    {
        public DbSet<Performance> Performances { get; set; }
    }

}