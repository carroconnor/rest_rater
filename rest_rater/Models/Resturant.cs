using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace rest_rater.Models
{
    public class Resturant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }

    public class RestaurantDBContext : DbContext
    {
        public DbSet<Resturant> Restaurants { get; set; }
    }
}