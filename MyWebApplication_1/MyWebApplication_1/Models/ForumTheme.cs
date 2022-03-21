using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApplication_1.Models
{
    public class ForumTheme
    {
        public int Id { get; set; }
        public string ThemeName { get; set; }
        public string Author { get; set; }
        public int Answers { get; set; } = 0;
        public int Views { get; set; } = 0;


    }
}