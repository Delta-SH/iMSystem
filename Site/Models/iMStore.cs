using System;
using System.Collections.Generic;

namespace Site.Models {
    [Serializable]
    public partial class iMStore {
        /// <summary>
        /// Gets or sets the application identifier
        /// </summary>
        public static Guid Id {
            get { return new Guid("55980595-4B9F-435D-B729-96EDC08301A8"); }
        }

        /// <summary>
        /// Gets or sets the application name
        /// </summary>
        public static string Name {
            get { return "漳州市艾睿普软件技术有限公司 - 智慧型机房解决方案服务商"; }
        }

        /// <summary>
        /// Gets or sets the application version
        /// </summary>
        public static string Version {
            get { return "V1.0.0 Build190905"; }
        }

        /// <summary>
        /// Gets or sets the company
        /// </summary>
        public static string Company {
            get { return "漳州市艾睿普软件技术有限公司"; }
        }

        /// <summary>
        /// Gets or sets the contact
        /// </summary>
        public static string Contact {
            get { return "4008 118 118"; }
        }

        /// <summary>
        /// Gets or sets the beian
        /// </summary>
        public static string Beian {
            get { return "闽ICP备17027880号-1"; }
        }

        /// <summary>
        /// Gets or sets the QQ
        /// </summary>
        public static string QQ {
            get { return "tencent://message/?uin=543600918&Site=www.irep.com.cn&Menu=yes"; }
        }

        /// <summary>
        /// Gets or sets the software
        /// </summary>
        public static List<Product> Software {
            get {
                return new List<Product>() {
                    new Product {
                        Index = 1,
                        Id = "P000101",
                        Type = 1,
                        Name = "DCIM存储系统",
                        English = "DCIM Storage System",
                        Remark = "软件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Tag = "new",
                        Url = "/product/dcim",
                        Picture = "/Content/images/software-bg-01.png",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    },
                    new Product {
                        Index = 2,
                        Id = "P000102",
                        Type = 1,
                        Name = "动环监控系统",
                        English = "DCIM Storage System",
                        Remark = "软件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Url = "/product/dcim",
                        Picture = "/Content/images/forums-bg-01.jpg",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    },
                    new Product {
                        Index = 3,
                        Id = "P000103",
                        Type = 1,
                        Name = "三维可视化平台",
                        English = "DCIM Storage System",
                        Remark = "软件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Url = "/product/dcim",
                        Picture = "/Content/images/forums-bg-02.jpg",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    },
                    new Product {
                        Index = 4,
                        Id = "P000104",
                        Type = 1,
                        Name = "能耗管理系统",
                        English = "DCIM Storage System",
                        Remark = "软件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Tag = "hot",
                        Url = "/product/dcim",
                        Picture = "/Content/images/forums-bg-03.jpg",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the hardware
        /// </summary>
        public static List<Product> Hardware {
            get {
                return new List<Product>() {
                    new Product {
                        Index = 1,
                        Id = "P000201",
                        Type = 2,
                        Name = "水浸传感器",
                        English = "DCIM Storage System",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Url = "/product/dcim",
                        Picture = "/Content/images/forums-bg-01.jpg",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    },
                    new Product {
                        Index = 2,
                        Id = "P000202",
                        Type = 2,
                        Name = "温湿度传感器",
                        English = "DCIM Storage System",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Tag = "hot",
                        Url = "/product/dcim",
                        Picture = "/Content/images/forums-bg-02.jpg",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    },
                    new Product {
                        Index = 3,
                        Id = "P000203",
                        Type = 2,
                        Name = "红外传感器",
                        English = "DCIM Storage System",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Tag = "new",
                        Url = "/product/dcim",
                        Picture = "/Content/images/forums-bg-03.jpg",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    },
                    new Product {
                        Index = 4,
                        Id = "P000204",
                        Type = 2,
                        Name = "光电烟雾传感器",
                        English = "DCIM Storage System",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Url = "/product/dcim",
                        Picture = "/Content/images/forums-bg-01.jpg",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    },
                    new Product {
                        Index = 5,
                        Id = "P000205",
                        Type = 2,
                        Name = "光电烟雾传感器",
                        English = "DCIM Storage System",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Url = "/product/dcim",
                        Picture = "/Content/images/forums-bg-01.jpg",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    },
                    new Product {
                        Index = 6,
                        Id = "P000206",
                        Type = 2,
                        Name = "光电烟雾传感器",
                        English = "DCIM Storage System",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Url = "/product/dcim",
                        Picture = "/Content/images/forums-bg-01.jpg",
                        Banners = new string[]{
                            "/Content/images/forums-bg-01.jpg",
                            "/Content/images/forums-bg-02.jpg",
                            "/Content/images/forums-bg-03.jpg"
                        },
                        Comment = "提供稳定、安全、高效、高可扩展的云存储服务，支持最大5TB多媒体、文本、二进制等任意类型数据的存储。"
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the solutions
        /// </summary>
        public static List<Solution> Hsolution {
            get {
                return new List<Solution>() {
                    new Solution {
                        Index = 1,
                        Id = "S000101",
                        Name = "电信解决方案",
                        English = "Telecom Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Url = "/solution/telecom",
                        Comment = "结合大数据能力帮助电商企业快速搭建平台、应对业务高并发，剖析秒杀、视频直播等场景。"
                    },
                    new Solution {
                        Index = 2,
                        Id = "S000102",
                        Name = "农业解决方案",
                        English = "Agriculture Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Tag = "hot",
                        Url = "/solution/telecom",
                        Comment = "结合大数据能力帮助电商企业快速搭建平台、应对业务高并发，剖析秒杀、视频直播等场景。"
                    },
                    new Solution {
                        Index = 3,
                        Id = "S000103",
                        Name = "工业解决方案",
                        English = "Industry Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Tag = "new",
                        Url = "/solution/telecom",
                        Comment = "结合大数据能力帮助电商企业快速搭建平台、应对业务高并发，剖析秒杀、视频直播等场景。"
                    },
                    new Solution {
                        Index = 4,
                        Id = "S000104",
                        Name = "政府解决方案",
                        English = "Government Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Url = "/solution/telecom",
                        Comment = "结合大数据能力帮助电商企业快速搭建平台、应对业务高并发，剖析秒杀、视频直播等场景。"
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the solutions
        /// </summary>
        public static List<Solution> Tsolution {
            get {
                return new List<Solution>() {
                    new Solution {
                        Index = 1,
                        Id = "S000201",
                        Name = "企业解决方案",
                        English = "Enterprise Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Url = "/solution/telecom",
                        Comment = "结合大数据能力帮助电商企业快速搭建平台、应对业务高并发，剖析秒杀、视频直播等场景。"
                    },
                    new Solution {
                        Index = 2,
                        Id = "S000202",
                        Name = "办公楼解决方案",
                        English = "Buliding Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 79.9M,
                        Tag = "hot",
                        Url = "/solution/telecom",
                        Comment = "结合大数据能力帮助电商企业快速搭建平台、应对业务高并发，剖析秒杀、视频直播等场景。"
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the carousel 
        /// </summary>
        public static List<Figure> Carousel {
            get {
                return new List<Figure>() {
                    new Figure {
                        Index = 1,
                        BgClass = "banner-1",
                        Comment = "促销信息1"
                    },
                    new Figure {
                        Index = 2,
                        Title = "行业领先的软硬件一体化产品",
                        Subtitle = "针对不同的客户需求，定制出更懂你的产品",
                        BgClass = "banner-2",
                        BtnText = "了解详情",
                        Url = "/product/dcim",
                        Comment = "促销信息2"
                    },
                    new Figure {
                        Index = 3,
                        Title = "专业的智慧型机房解决方案",
                        Subtitle = "致力于让企业机房运维更智能、更安全、更高效",
                        BgClass = "banner-3",
                        BtnText = "了解详情",
                        Url = "/product/dcim",
                        Comment = "促销信息3"
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the news 
        /// </summary>
        public static List<News> News {
            get {
                return new List<News>() {
                    new News {
                        Id = "2017022808582801",
                        Title = "华为农网解决方案蝴蝶站在孟加拉完成首商用",
                        Comment = "日前，华为农网解决方案蝴蝶站在孟加拉完成首商用部署。华为农网解决方案致力于帮助运营商更经济地进行农网建设，为广大农村未联接人口提供联接。本次部署的蝴蝶站作为农网解决方案的一部分，相比传统三扇区降低农网成本30%，扩大运营商可盈利覆盖区域。",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0214/1487040525901.jpg",
                        Url = "/cn/news/2017/2",
                        Tag = "p1",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582802",
                        Title = "无限极中草药多糖技术斩获科技大奖",
                        Comment = "2月7日，无限极（中国）有限公司作为第一完成单位合作完成的项目“中草药活性多糖快速筛选、制备关键技术及产业化应用”荣获广东省科学技术一等奖！",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0210/thumb_252_154_1486689902410.jpg",
                        Url = "/cn/news/2017/3",
                        Tag = "p2",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582801",
                        Title = "华为农网解决方案蝴蝶站在孟加拉完成首商用",
                        Comment = "日前，华为农网解决方案蝴蝶站在孟加拉完成首商用部署。华为农网解决方案致力于帮助运营商更经济地进行农网建设，为广大农村未联接人口提供联接。本次部署的蝴蝶站作为农网解决方案的一部分，相比传统三扇区降低农网成本30%，扩大运营商可盈利覆盖区域。",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0214/1487040525901.jpg",
                        Url = "/cn/news/2017/2",
                        Tag = "p1",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582802",
                        Title = "无限极中草药多糖技术斩获科技大奖",
                        Comment = "2月7日，无限极（中国）有限公司作为第一完成单位合作完成的项目“中草药活性多糖快速筛选、制备关键技术及产业化应用”荣获广东省科学技术一等奖！",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0210/thumb_252_154_1486689902410.jpg",
                        Url = "/cn/news/2017/3",
                        Tag = "p2",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582801",
                        Title = "华为农网解决方案蝴蝶站在孟加拉完成首商用",
                        Comment = "日前，华为农网解决方案蝴蝶站在孟加拉完成首商用部署。华为农网解决方案致力于帮助运营商更经济地进行农网建设，为广大农村未联接人口提供联接。本次部署的蝴蝶站作为农网解决方案的一部分，相比传统三扇区降低农网成本30%，扩大运营商可盈利覆盖区域。",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0214/1487040525901.jpg",
                        Url = "/cn/news/2017/2",
                        Tag = "p1",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582802",
                        Title = "无限极中草药多糖技术斩获科技大奖",
                        Comment = "2月7日，无限极（中国）有限公司作为第一完成单位合作完成的项目“中草药活性多糖快速筛选、制备关键技术及产业化应用”荣获广东省科学技术一等奖！",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0210/thumb_252_154_1486689902410.jpg",
                        Url = "/cn/news/2017/3",
                        Tag = "p2",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582801",
                        Title = "华为农网解决方案蝴蝶站在孟加拉完成首商用",
                        Comment = "日前，华为农网解决方案蝴蝶站在孟加拉完成首商用部署。华为农网解决方案致力于帮助运营商更经济地进行农网建设，为广大农村未联接人口提供联接。本次部署的蝴蝶站作为农网解决方案的一部分，相比传统三扇区降低农网成本30%，扩大运营商可盈利覆盖区域。",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0214/1487040525901.jpg",
                        Url = "/cn/news/2017/2",
                        Tag = "p1",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582802",
                        Title = "无限极中草药多糖技术斩获科技大奖",
                        Comment = "2月7日，无限极（中国）有限公司作为第一完成单位合作完成的项目“中草药活性多糖快速筛选、制备关键技术及产业化应用”荣获广东省科学技术一等奖！",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0210/thumb_252_154_1486689902410.jpg",
                        Url = "/cn/news/2017/3",
                        Tag = "p2",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582801",
                        Title = "华为农网解决方案蝴蝶站在孟加拉完成首商用",
                        Comment = "日前，华为农网解决方案蝴蝶站在孟加拉完成首商用部署。华为农网解决方案致力于帮助运营商更经济地进行农网建设，为广大农村未联接人口提供联接。本次部署的蝴蝶站作为农网解决方案的一部分，相比传统三扇区降低农网成本30%，扩大运营商可盈利覆盖区域。",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0214/1487040525901.jpg",
                        Url = "/cn/news/2017/2",
                        Tag = "p1",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582802",
                        Title = "无限极中草药多糖技术斩获科技大奖",
                        Comment = "2月7日，无限极（中国）有限公司作为第一完成单位合作完成的项目“中草药活性多糖快速筛选、制备关键技术及产业化应用”荣获广东省科学技术一等奖！",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0210/thumb_252_154_1486689902410.jpg",
                        Url = "/cn/news/2017/3",
                        Tag = "p2",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582801",
                        Title = "华为农网解决方案蝴蝶站在孟加拉完成首商用",
                        Comment = "日前，华为农网解决方案蝴蝶站在孟加拉完成首商用部署。华为农网解决方案致力于帮助运营商更经济地进行农网建设，为广大农村未联接人口提供联接。本次部署的蝴蝶站作为农网解决方案的一部分，相比传统三扇区降低农网成本30%，扩大运营商可盈利覆盖区域。",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0214/1487040525901.jpg",
                        Url = "/cn/news/2017/2",
                        Tag = "p1",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582802",
                        Title = "无限极中草药多糖技术斩获科技大奖",
                        Comment = "2月7日，无限极（中国）有限公司作为第一完成单位合作完成的项目“中草药活性多糖快速筛选、制备关键技术及产业化应用”荣获广东省科学技术一等奖！",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0210/thumb_252_154_1486689902410.jpg",
                        Url = "/cn/news/2017/3",
                        Tag = "p2",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582801",
                        Title = "华为农网解决方案蝴蝶站在孟加拉完成首商用",
                        Comment = "日前，华为农网解决方案蝴蝶站在孟加拉完成首商用部署。华为农网解决方案致力于帮助运营商更经济地进行农网建设，为广大农村未联接人口提供联接。本次部署的蝴蝶站作为农网解决方案的一部分，相比传统三扇区降低农网成本30%，扩大运营商可盈利覆盖区域。",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0214/1487040525901.jpg",
                        Url = "/cn/news/2017/2",
                        Tag = "p1",
                        CreatedTime = DateTime.Now
                    },
                    new News {
                        Id = "2017022808582802",
                        Title = "无限极中草药多糖技术斩获科技大奖",
                        Comment = "2月7日，无限极（中国）有限公司作为第一完成单位合作完成的项目“中草药活性多糖快速筛选、制备关键技术及产业化应用”荣获广东省科学技术一等奖！",
                        Image = "http://wwwimg.infinitus.com.cn/up/2017/0210/thumb_252_154_1486689902410.jpg",
                        Url = "/cn/news/2017/3",
                        Tag = "p2",
                        CreatedTime = DateTime.Now
                    }
                };
            }
        }
    }
}