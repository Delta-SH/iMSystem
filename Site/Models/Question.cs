using System;

namespace Site.Models {
    public class Question {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}