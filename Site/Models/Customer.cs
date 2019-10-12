using System;

namespace Site.Models {
    public class Customer {
        public string Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 0 电信行业
        /// 1 电力行业
        /// 2 政府行业
        /// 3 其他行业
        /// </summary>
        public int Type { get; set; }

        public string Url { get; set; }

        public string Image { get; set; }

        public string Comment { get; set; }
    }
}