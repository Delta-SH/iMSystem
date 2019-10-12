using System;

namespace Site.Models {
    public class Product {
        public int Index { get; set; }

        public string Id { get; set; }

        public int Type { get; set; }

        public string Name { get; set; }

        public string English { get; set; }

        public string Remark { get; set; }

        public decimal Original { get; set; }

        public decimal Price { get; set; }

        public string Comment { get; set; }

        public string Tag { get; set; }

        public string Url { get; set; }

        public string Picture { get; set; }

        public string[] Banners { get; set; }
    }
}