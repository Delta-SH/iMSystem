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
            get { return "4008-118-118"; }
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
        /// Gets or sets the Weibo
        /// </summary>
        public static string Weibo {
            get { return "http://www.weibo.com"; }
        }

        /// <summary>
        /// Gets or sets the Email
        /// </summary>
        public static string Email {
            get { return "service@irep.com.cn"; }
        }

        /// <summary>
        /// Gets or sets the address
        /// </summary>
        public static string Address {
            get { return "福建省漳州市芗城区大学西路翰城一品1幢"; }
        }

        /// <summary>
        /// Gets or sets the code
        /// </summary>
        public static string Code {
            get { return "363000"; }
        }

        /// <summary>
        /// Gets or sets the phone
        /// </summary>
        public static string Phone {
            get { return "0596-2968095"; }
        }

        /// <summary>
        /// Gets or sets the fax
        /// </summary>
        public static string Fax {
            get { return "0596-2968096"; }
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
                        Id = "20190918001",
                        Title = "中国时速600公里高速磁浮列车“动力心脏”对外发布",
                        Type = 0,
                        Image = "http://p3.pstatp.com/large/pgc-image/RcKk1lY6CJudpB",
                        Author = "艾睿普",
                        Tag = "HOT",
                        Summary = "中国时速600公里磁浮列车的动力装备核心——直线电机和电磁铁，9月17日在中车株洲电机有限公司正式对外发布。 刘双双 摄",
                        Content = @"
                        <p>
                        中新网株洲9月17日电 (记者 刘双双)中国时速600公里磁浮列车的动力装备核心--直线电机和电磁铁，17日在中车株洲电机有限公司正式对外发布。
                        </p>
                        <p>
                        现代人工作繁忙，生活压力大，有些上班族常常忙起来就忘记吃饭，或者不会做饭经常叫外卖，还有的更是经常吃泡面麻辣烫等，长此以往，是非常不利于身体健康的。因此，德国莱尔克斯新推出了一款智能烹饪机器人，可以让您每天轻松享用各类美食。
                        </p>
                        <p>
                        该机器人最主要的功能是烹饪功能，其内含目前世界上已知的所有菜系以及各类美食的做法，而且还内含非常丰富的营养、健康等知识。通过机器人头部的电脑屏幕，用户可以自由选择菜名，然后屏幕上会自动显示每道菜所需的食材、用量以及烹饪每道菜所需的时间。并且，在用户选择完毕后，机器人会根据用户的选择提醒用户需要补充哪方面的营养，而哪方面的营养摄入过多，建议用户更改选择，促进用户均衡摄入膳食。并且用户还可以选择自己偏爱的饭菜口味，但是机器人都会权衡用户的选择，然后适当得提出一些建议，例如如果客户选择的口味太咸，机器人就会提醒用户吃得太咸的坏处，促进用户健康饮食。等菜谱选择完毕后，用户只需要提前准备好食材，并且设置好机器人的工作时间，这样到规定的时间，机器人就会自动开始烹饪工作，做好香喷喷的饭菜，等待用户回家品尝。这样用户就可以在自己没有时间做饭或者不会做饭的情况下，依然能够吃到健康营养的饭菜。
                        </p>
                        <p>
                        <div class='img-wrapper'>
                            <img src='http://p3.pstatp.com/large/pgc-image/RcKk1lY6CJudpB' >
                            <div class='img-text'>中车株洲电机开幕仪式</div>
                        </div>
                        </p>
                        <p>
                        该机器人十分智能，对于各类安全知识都非常了解，因此操作安全方面完全不需要担心。并且该机器人具备wifi-app控制功能，用户可以远程控制机器人充电或是更改各种设置等，非常方便实用。
                        </p>
                        <p>
                        德国LIECTROUX莱尔克斯机器人研究院研发的该款智能烹饪机器人给广大用户带来了福音，尤其适用于忙碌的上班族或者是一些不会做菜但是也想吃的健康营养的用户。此外，德国LIECTROUX莱尔克斯机器人也研发了多款智能扫地机器人，其采用的无线室内载波定位技术能够精准地定位室内环境，自动绘制精准的家居地图，并且在清扫过程中记忆清扫过的区域，避免重复清扫，也能很好地避免漏扫。其外形美观，而且其采用2000mAh动力型锂电池，使用寿命长，质量好耐高温，还配备有220ml的大容量水箱，能够实现90分钟持续供水，很好地满足大户型的清洁需求。由于其优良的性能和高效率的清洁能力，一经推出即在市场上获得了极大的反响，深受消费者的喜爱与信赖。
                        </p>",
                        CreatedTime = DateTime.Parse("2019-09-18 15:00:00")
                    },
                    new News {
                        Id = "20190918002",
                        Title = "中国时速600公里高速磁浮列车“动力心脏”对外发布",
                        Type = 0,
                        Image = "http://p3.pstatp.com/large/pgc-image/RcKk1lY6CJudpB",
                        Author = "<a href='http://www.baidu.com' target='_blank'>百度</a>",
                        Tag = "NEW",
                        Summary = "中国时速600公里磁浮列车的动力装备核心——直线电机和电磁铁，9月17日在中车株洲电机有限公司正式对外发布。 刘双双 摄",
                        Content = @"<p>中新网株洲9月17日电 (记者 刘双双)中国时速600公里磁浮列车的动力装备核心--直线电机和电磁铁，17日在中车株洲电机有限公司正式对外发布。</p>",
                        CreatedTime = DateTime.Parse("2019-09-17 15:00:00")
                    },
                    new News {
                        Id = "20190918003",
                        Title = "中国时速600公里高速磁浮列车“动力心脏”对外发布",
                        Type = 0,
                        Image = "http://p3.pstatp.com/large/pgc-image/RcKk1lY6CJudpB",
                        Author = "艾睿普",
                        Tag = "",
                        Summary = "中国时速600公里磁浮列车的动力装备核心——直线电机和电磁铁，9月17日在中车株洲电机有限公司正式对外发布。 刘双双 摄",
                        Content = @"<p>中新网株洲9月17日电 (记者 刘双双)中国时速600公里磁浮列车的动力装备核心--直线电机和电磁铁，17日在中车株洲电机有限公司正式对外发布。</p>",
                        CreatedTime = DateTime.Parse("2019-09-16 15:00:00")
                    },
                    new News {
                        Id = "20190918004",
                        Title = "中国时速600公里高速磁浮列车“动力心脏”对外发布",
                        Type = 1,
                        Image = "http://p3.pstatp.com/large/pgc-image/RcKk1lY6CJudpB",
                        Author = "<a href='https://www.toutiao.com/' target='_blank'>今日头条</a>",
                        Tag = "HOT",
                        Summary = "中国时速600公里磁浮列车的动力装备核心——直线电机和电磁铁，9月17日在中车株洲电机有限公司正式对外发布。 刘双双 摄",
                        Content = @"
                        <p>
                        中新网株洲9月17日电 (记者 刘双双)中国时速600公里磁浮列车的动力装备核心--直线电机和电磁铁，17日在中车株洲电机有限公司正式对外发布。
                        </p>
                        <p>
                        现代人工作繁忙，生活压力大，有些上班族常常忙起来就忘记吃饭，或者不会做饭经常叫外卖，还有的更是经常吃泡面麻辣烫等，长此以往，是非常不利于身体健康的。因此，德国莱尔克斯新推出了一款智能烹饪机器人，可以让您每天轻松享用各类美食。
                        </p>
                        <p>
                        该机器人最主要的功能是烹饪功能，其内含目前世界上已知的所有菜系以及各类美食的做法，而且还内含非常丰富的营养、健康等知识。通过机器人头部的电脑屏幕，用户可以自由选择菜名，然后屏幕上会自动显示每道菜所需的食材、用量以及烹饪每道菜所需的时间。并且，在用户选择完毕后，机器人会根据用户的选择提醒用户需要补充哪方面的营养，而哪方面的营养摄入过多，建议用户更改选择，促进用户均衡摄入膳食。并且用户还可以选择自己偏爱的饭菜口味，但是机器人都会权衡用户的选择，然后适当得提出一些建议，例如如果客户选择的口味太咸，机器人就会提醒用户吃得太咸的坏处，促进用户健康饮食。等菜谱选择完毕后，用户只需要提前准备好食材，并且设置好机器人的工作时间，这样到规定的时间，机器人就会自动开始烹饪工作，做好香喷喷的饭菜，等待用户回家品尝。这样用户就可以在自己没有时间做饭或者不会做饭的情况下，依然能够吃到健康营养的饭菜。
                        </p>
                        <p>
                        <div class='img-wrapper'>
                            <img src='http://p3.pstatp.com/large/pgc-image/RcKk1lY6CJudpB' >
                            <div class='img-text'>中车株洲电机开幕仪式</div>
                        </div>
                        </p>
                        <p>
                        该机器人十分智能，对于各类安全知识都非常了解，因此操作安全方面完全不需要担心。并且该机器人具备wifi-app控制功能，用户可以远程控制机器人充电或是更改各种设置等，非常方便实用。
                        </p>
                        <p>
                        德国LIECTROUX莱尔克斯机器人研究院研发的该款智能烹饪机器人给广大用户带来了福音，尤其适用于忙碌的上班族或者是一些不会做菜但是也想吃的健康营养的用户。此外，德国LIECTROUX莱尔克斯机器人也研发了多款智能扫地机器人，其采用的无线室内载波定位技术能够精准地定位室内环境，自动绘制精准的家居地图，并且在清扫过程中记忆清扫过的区域，避免重复清扫，也能很好地避免漏扫。其外形美观，而且其采用2000mAh动力型锂电池，使用寿命长，质量好耐高温，还配备有220ml的大容量水箱，能够实现90分钟持续供水，很好地满足大户型的清洁需求。由于其优良的性能和高效率的清洁能力，一经推出即在市场上获得了极大的反响，深受消费者的喜爱与信赖。
                        </p>",
                        CreatedTime = DateTime.Parse("2019-09-18 15:00:00")
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the question
        /// </summary>
        public static List<Question> Questions {
            get {
                return new List<Question>() {
                    new Question {
                        Id = "20190918001",
                        Title = "小米商城支持什么方式支付？",
                        Content = @"
<p>小米商城支持小米钱包，支付宝、微信等第三方平台支付，同时支持国内二十多家主流银行机构的储蓄卡、信用卡的网上付款。暂时不支持货到付款的支付方式，您购买的时候一定要注意哦，以免影响您的正常收货。</p>
<p>备注：</p>
<p>小米商城所支持的银行机构可能会有变动，以实际支付页面的信息为准。</p>
<p>小米商城暂时不支持货到付款业务，所以大家买到货到付款的产品有可能是假货，要提高警惕哦。</p>",
                        CreatedTime = DateTime.Parse("2019-09-18 15:00:00")
                    },
                    new Question {
                        Id = "20190918002",
                        Title = "小米商城支持什么方式支付？",
                        Content = @"
<p>小米商城支持小米钱包，支付宝、微信等第三方平台支付，同时支持国内二十多家主流银行机构的储蓄卡、信用卡的网上付款。暂时不支持货到付款的支付方式，您购买的时候一定要注意哦，以免影响您的正常收货。</p>
<p>备注：</p>
<p>小米商城所支持的银行机构可能会有变动，以实际支付页面的信息为准。</p>
<p>小米商城暂时不支持货到付款业务，所以大家买到货到付款的产品有可能是假货，要提高警惕哦。</p>",
                        CreatedTime = DateTime.Parse("2019-09-18 15:00:00")
                    },
                    new Question {
                        Id = "20190918003",
                        Title = "小米商城支持什么方式支付？",
                        Content = @"
<p>小米商城支持小米钱包，支付宝、微信等第三方平台支付，同时支持国内二十多家主流银行机构的储蓄卡、信用卡的网上付款。暂时不支持货到付款的支付方式，您购买的时候一定要注意哦，以免影响您的正常收货。</p>
<p>备注：</p>
<p>小米商城所支持的银行机构可能会有变动，以实际支付页面的信息为准。</p>
<p>小米商城暂时不支持货到付款业务，所以大家买到货到付款的产品有可能是假货，要提高警惕哦。</p>",
                        CreatedTime = DateTime.Parse("2019-09-18 15:00:00")
                    },
                    new Question {
                        Id = "20190918004",
                        Title = "小米商城支持什么方式支付？",
                        Content = @"
<p>小米商城支持小米钱包，支付宝、微信等第三方平台支付，同时支持国内二十多家主流银行机构的储蓄卡、信用卡的网上付款。暂时不支持货到付款的支付方式，您购买的时候一定要注意哦，以免影响您的正常收货。</p>
<p>备注：</p>
<p>小米商城所支持的银行机构可能会有变动，以实际支付页面的信息为准。</p>
<p>小米商城暂时不支持货到付款业务，所以大家买到货到付款的产品有可能是假货，要提高警惕哦。</p>",
                        CreatedTime = DateTime.Parse("2019-09-18 15:00:00")
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the files
        /// </summary>
        public static List<File> Downloads {
            get {
                return new List<File>() {
                    new File {
                        Id = "20190918001",
                        Title = "硬件文档001",
                        Type = 0,
                        Summary = @"海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "20190918002",
                        Title = "硬件文档002",
                        Type = 0,
                        Summary = @"海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "20190918003",
                        Title = "S7-200 可编程控制器系统手册",
                        Type = 1,
                        Summary = @"海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "20190918004",
                        Title = "S7-200 可编程控制器系统手册",
                        Type = 1,
                        Summary = @"海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "20190918005",
                        Title = "升级包003",
                        Type = 2,
                        Summary = @"海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "20190918006",
                        Title = "升级包0034",
                        Type = 2,
                        Summary = @"海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "20190918007",
                        Title = "S7-200 可编程控制器系统手册",
                        Type = 3,
                        Summary = @"海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "20190918007",
                        Title = "S7-200 可编程控制器系统手册",
                        Type = 3,
                        Summary = @"海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。海康威视产品码流的windows播放器，适用于录像文件的播放、鱼眼展开、编辑、串流发布以及RTSP、HLS协议网络流的预览。",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the certificates
        /// </summary>
        public static List<Certificate> Certificates {
            get {
                return new List<Certificate>() {
                    new Certificate {
                        Id = "2862414588961600",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961601",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961602",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961603",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961604",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961605",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961606",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961607",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961608",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961609",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new Certificate {
                        Id = "2862414588961610",
                        Title = "ZKEYS公有云业务管理系统",
                        Url="/content/certificates/2862414588961612.jpg",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public static List<Customer> Customer {
            get {
                return new List<Customer>() {
                    new Customer {
                        Id = "001",
                        Name = "中饮集团1",
                        Type = 0,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "002",
                        Name = "中饮集团2",
                        Type = 0,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "003",
                        Name = "中饮集团3",
                        Type = 0,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "004",
                        Name = "中饮集团4",
                        Type = 0,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "005",
                        Name = "中饮集团5",
                        Type = 0,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "006",
                        Name = "中饮集团6",
                        Type = 1,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "007",
                        Name = "中饮集团7",
                        Type = 1,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "008",
                        Name = "中饮集团8",
                        Type = 1,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "009",
                        Name = "中饮集团9",
                        Type = 2,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "010",
                        Name = "中饮集团10",
                        Type = 2,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "011",
                        Name = "中饮集团11",
                        Type = 2,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "012",
                        Name = "中饮集团12",
                        Type = 3,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "013",
                        Name = "中饮集团13",
                        Type = 3,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    },
                    new Customer {
                        Id = "014",
                        Name = "中饮集团14",
                        Type = 3,
                        Url="http://www.baidu.com",
                        Image = "/content/customers/001.jpg"
                    }
                };
            }
        }
    }
}