﻿using System;

namespace Site.Models {
    public class News {
        public string Id { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// 0-公司新闻 
        /// 1-行业新闻
        /// </summary>
        public int Type { get; set; }

        public string Image { get; set; }

        public string Author { get; set; }

        public string Summary { get; set; }

        public string Content { get; set; }

        public string Tag { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}