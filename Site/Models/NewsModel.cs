using System;
using System.Collections.Generic;

namespace Site.Models {
    public partial class NewsModel {
        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }

        public List<News> PageNews { get; set; }
    }
}