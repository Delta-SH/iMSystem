using System;

namespace Site.Models {
    public partial class News {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Comment { get; set; }

        public string Image { get; set; }

        public string Url { get; set; }

        public string Tag { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}