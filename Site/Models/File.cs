using System;

namespace Site.Models {
    public class File {
        public string Id { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// 0 硬件文档
        /// 1 软件文档
        /// 2 升级包
        /// 3 其他资料
        /// </summary>
        public int Type { get; set; }

        public string Summary { get; set; }

        public long Size { get; set; }

        public string Version { get; set; }

        public string Url { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}