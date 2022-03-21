using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyWebApplication_1.Models
{
    public class ForumContext:DbContext
    {
        public DbSet<ForumTheme> ForumThemes { get; set; }
    }
}