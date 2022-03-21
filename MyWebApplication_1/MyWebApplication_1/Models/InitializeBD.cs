using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyWebApplication_1.Models
{
    public class InitializeBD: DropCreateDatabaseAlways<ForumContext>
    {
        protected override void Seed(ForumContext bd)
        {
            bd.ForumThemes.Add(new ForumTheme { ThemeName = "Как выучить русский язык", Author = "Ilon Mask", Answers = 200, Views = 1488 });

            base.Seed(bd);
        }
    }
}