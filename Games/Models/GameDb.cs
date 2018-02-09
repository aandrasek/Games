using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Games.Models
{
    public class GameDb:DbContext
    {
        public DbSet<NumberGameEntity> Number { get; set; }
        public DbSet<SpaceshipGameEntity> Spaceship { get; set; }
    }
}