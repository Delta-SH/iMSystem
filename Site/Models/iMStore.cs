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
            get { return "V1.0.0 Build191020"; }
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
            get { return "4008-000-000"; }
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
            get { return "tencent://message/?uin=188599700&Site=www.irep.com.cn&Menu=yes"; }
        }

        /// <summary>
        /// Gets or sets the Weibo
        /// </summary>
        public static string Weibo {
            get { return "//www.weibo.com"; }
        }

        /// <summary>
        /// Gets or sets the Email
        /// </summary>
        public static string Email {
            get { return "service@www.irep.com.cn"; }
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
            get { return "0596-2968095"; }
        }

        /// <summary>
        /// Gets or sets the software
        /// </summary>
        public static List<Product> Software {
            get {
                return new List<Product>() {
                    new Product {
                        Index = 1,
                        Id = "p-01-001",
                        Type = 1,
                        Name = "动力环境综合监控系统",
                        English = "Power And Environment Integrated Monitoring System",
                        Remark = "软件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Tag = "hot",
                        Url = "/errors/waitting",
                        Picture = "/content/products/software/p-01-001.jpg",
                        Banners = new string[]{
                            "/content/products/software/p-01-001-01.jpg"
                        },
                        Comment = "动力环境综合监控系统(PEIMS)立足于建设一个全面覆盖数据中心所有核心机房、汇聚层机房、电力室、空调室等设备的动力环境、安防门禁、视频监控、能耗管理于一体的远程监控管理系统，同时配合IMMU嵌入式前置服务器机房现场管理设备，打造出一整套机房本地管理独立运维与远程集成综合运维管理的多元化、多种运维模式的系统。"
                    },
                    new Product {
                        Index = 2,
                        Id = "p-01-002",
                        Type = 1,
                        Name = "蓄电池组在线质量监测系统",
                        English = "Battery Online Monitoring System",
                        Remark = "软件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Url = "/errors/waitting",
                        Picture = "/content/products/software/p-01-002.jpg",
                        Banners = new string[]{
                            "/content/products/software/p-01-002-01.jpg"
                        },
                        Comment = "蓄电池组在线质量监测系统(BOMS)主要功能是监测蓄电池组的蓄电池状态，提早发现并及时告警落后蓄电池，提高直流系统的安全性能。本产品主要应用于电力行业中的直流系统监测，针对蓄电池组的蓄电池状态监控，并提供对单体蓄电池和蓄电池组的报警设定，及对蓄电池内阻监控，从而保证直流系统的安全运行，提高直流系统的可靠性和自动化程度，大大减少试验过程中繁琐的人工测量、手工记录等操作。"
                    },
                    new Product {
                        Index = 3,
                        Id = "p-01-003",
                        Type = 1,
                        Name = "三维组态可视化平台",
                        English = "3D Configuration Visualization Platform",
                        Remark = "软件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Url = "/errors/waitting",
                        Picture = "/content/products/software/p-01-003.jpg",
                        Banners = new string[]{
                            "/content/products/software/p-01-003-01.jpg"
                        },
                        Comment = "暂无"
                    },
                    new Product {
                        Index = 4,
                        Id = "p-01-004",
                        Type = 1,
                        Name = "能耗管理系统",
                        English = "Energy Consumption Management System",
                        Remark = "软件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Tag = "new",
                        Url = "/errors/waitting",
                        Picture = "/content/products/software/p-01-004.jpg",
                        Banners = new string[]{
                            "/content/products/software/p-01-004-01.jpg"
                        },
                        Comment = "暂无"
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
                        Id = "p-02-001",
                        Type = 2,
                        Name = "智能监控管理单元",
                        English = "Intelligent Monitoring Management Unit",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Url = "/errors/waitting",
                        Picture = "/content/products/hardware/p-02-001.jpg",
                        Banners = new string[]{
                            "/content/products/hardware/p-02-001-01.jpg"
                        },
                        Comment = "机房监控设备采用嵌入式计算机控制技术，对机房监控系统的软件和硬件进行一体化设计，内置WebServer服务，软件全部固化，使用标准的浏览器可对机房环境和机房设备实施远程监控，配有开关量采集接口，控制输出接口，RS-232和RS-485数字通讯接口，GPRS短信/电话通讯模块，以及智能化电源管理保证服务器的持续运行。"
                    },
                    new Product {
                        Index = 2,
                        Id = "p-02-002",
                        Type = 2,
                        Name = "配电柜状态采集器",
                        English = "Hardware English Name",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Url = "/errors/waitting",
                        Picture = "/content/products/hardware/p-02-002.jpg",
                        Banners = new string[]{
                            "/content/products/hardware/p-02-002-01.jpg"
                        },
                        Comment = "暂无"
                    },
                    new Product {
                        Index = 3,
                        Id = "p-02-003",
                        Type = 2,
                        Name = "温湿度传感器",
                        English = "Hardware English Name",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Url = "/errors/waitting",
                        Picture = "/content/products/hardware/p-02-003.jpg",
                        Banners = new string[]{
                            "/content/products/hardware/p-02-003-01.jpg"
                        },
                        Comment = "暂无"
                    },
                    new Product {
                        Index = 4,
                        Id = "p-02-004",
                        Type = 2,
                        Name = "烟雾探测器",
                        English = "Hardware English Name",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Url = "/errors/waitting",
                        Picture = "/content/products/hardware/p-02-004.jpg",
                        Banners = new string[]{
                            "/content/products/hardware/p-02-004-01.jpg"
                        },
                        Comment = "暂无"
                    },
                    new Product {
                        Index = 5,
                        Id = "p-02-005",
                        Type = 2,
                        Name = "工业触摸屏一体机",
                        English = "Hardware English Name",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Url = "/errors/waitting",
                        Picture = "/content/products/hardware/p-02-005.jpg",
                        Banners = new string[]{
                            "/content/products/hardware/p-02-005-01.jpg"
                        },
                        Comment = "暂无"
                    },
                    new Product {
                        Index = 6,
                        Id = "p-02-006",
                        Type = 2,
                        Name = "门禁控制器",
                        English = "Hardware English Name",
                        Remark = "硬件产品的简单介绍说明",
                        Original = 10000,
                        Price = 10000,
                        Url = "/errors/waitting",
                        Picture = "/content/products/hardware/p-02-006.jpg",
                        Banners = new string[]{
                            "/content/products/hardware/p-02-006-01.jpg"
                        },
                        Comment = "暂无"
                    },
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
                        Id = "s-00-001",
                        Name = "电信解决方案",
                        English = "Telecom Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 100,
                        Tag = "hot",
                        Url = "/errors/waitting",
                        Comment = "解决方案的简单介绍说明",
                        Image = "/content/solutions/s-00-001.jpg"
                    },
                    new Solution {
                        Index = 2,
                        Id = "s-00-002",
                        Name = "电力解决方案",
                        English = "Electricity Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 100,
                        Tag = "new",
                        Url = "/errors/waitting",
                        Comment = "解决方案的简单介绍说明",
                        Image = "/content/solutions/s-00-002.jpg"
                    },
                    new Solution {
                        Index = 3,
                        Id = "s-00-003",
                        Name = "农业解决方案",
                        English = "Agriculture Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 100,
                        Url = "/errors/waitting",
                        Comment = "解决方案的简单介绍说明",
                        Image = "/content/solutions/s-00-003.jpg"
                    },
                    new Solution {
                        Index = 4,
                        Id = "s-00-004",
                        Name = "政府解决方案",
                        English = "Government Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 100,
                        Url = "/errors/waitting",
                        Comment = "解决方案的简单介绍说明",
                        Image = "/content/solutions/s-00-004.jpg"
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
                        Id = "s-01-001",
                        Name = "企业解决方案",
                        English = "Enterprise Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 100,
                        Url = "/errors/waitting",
                        Comment = "解决方案的简单介绍说明",
                        Image = "/content/solutions/s-01-001.jpg"
                    },
                    new Solution {
                        Index = 2,
                        Id = "s-01-002",
                        Name = "办公楼解决方案",
                        English = "Buliding Solution",
                        Remark = "解决方案的简单介绍说明",
                        Original = 100,
                        Price = 100,
                        Tag = "hot",
                        Url = "/errors/waitting",
                        Comment = "解决方案的简单介绍说明",
                        Image = "/content/solutions/s-01-002.jpg"
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
                        Comment = "智慧赋能未来"
                    },
                    new Figure {
                        Index = 2,
                        Title = "行业领先的软硬件一体化产品",
                        Subtitle = "针对不同的客户需求，定制出更懂你的产品",
                        BgClass = "banner-2",
                        BtnText = "了解详情",
                        Url = "/errors/waitting",
                        Comment = "行业领先的软硬件一体化产品"
                    },
                    new Figure {
                        Index = 3,
                        Title = "专业的智慧型机房解决方案",
                        Subtitle = "致力于让企业机房运维更智能、更安全、更高效",
                        BgClass = "banner-3",
                        BtnText = "了解详情",
                        Url = "/errors/waitting",
                        Comment = "专业的智慧型机房解决方案"
                    }
                };
            }
        }

        /// <summary>
        /// Gets or sets the news 
        /// </summary>
        public static List<News> News {
            get {
                /*
                 * 图片示例
                 <p>
                    <div class='img-wrapper'>
                        <img src='image/001.jpg' >
                        <div class='img-text'>图片说明文字</div>
                    </div>
                 </p>
                 */
                return new List<News>() {
                    new News {
                        Id = "n-20180101-00-001",
                        Title = "漳州市艾睿普软件技术有限公司成立",
                        Type = 0,
                        Image = "/content/images/news.jpg",
                        Author = "艾睿普",
                        Tag = "HOT",
                        Summary = "热烈庆祝漳州市艾睿普软件技术有限公司成立。",
                        Content = @"
                        <p>
                        热烈庆祝漳州市艾睿普软件技术有限公司于2018年1月1日正式成立。
                        </p>
                        ",
                        CreatedTime = DateTime.Parse("2018-01-01 00:00:00")
                    },
                    new News {
                        Id = "n-20180101-01-001",
                        Title = "数据中心机房为什么要使用动力环境监控",
                        Type = 1,
                        Image = "//p3.pstatp.com/large/pgc-image/15348376522893cefa7d68f",
                        Author = "<a href='//www.toutiao.com/a6592077594307330574/' target='_blank'>今日头条</a>",
                        Summary = "如今，机房已成为各大单位的重要组成部分，机房设备必须时时刻刻为计算机系统提供正常的运行环境，一旦机房环境设备出现故障，就会影响到计算机系统的运行，对数据传输、存储及系统运行的可靠性构成威胁，如事故严重又不能及时处理，就可能损坏硬件设备，造成严重后果，其中数据中心机房存在两大必要性，那就是机房监控的必要性以及机房空调防雷的必要性。—来自<智能化弱电工程>",
                        Content = @"
                        <p>如今，机房已成为各大单位的重要组成部分，机房设备必须时时刻刻为计算机系统提供正常的运行环境，一旦机房环境设备出现故障，就会影响到计算机系统的运行，对数据传输、存储及系统运行的可靠性构成威胁，如事故严重又不能及时处理，就可能损坏硬件设备，造成严重后果，其中数据中心机房存在两大必要性，那就是机房监控的必要性以及机房空调防雷的必要性。</p>
                        <p>本文基于机房基本工作原理及其特点，数据中心机房监控的作用和必要性以及雷电对机房空调的侵害进行分析，并提出机房空调系统的雷电防护措施。</p>
                        <p>
                        <div class='img-wrapper'>
                            <img src='//p3.pstatp.com/large/pgc-image/15348376522893cefa7d68f' >
                            <div class='img-text'>图-1</div>
                        </div>
                        </p>
                        <p>数据中心机房监控的必要性</p>
                        <p>数据中心机房为什么要使用动力环境监控</p>
                        <p>因为在信息化建设中，机房运行处于信息交换管理的核心位置。机房内所有设备必须时时刻刻正常运转，否则一旦某台设备出现故障，对数据传输、存储及系统运行构成威胁，就会影响到全局系统的运行，如果不能及时处理，更有可能损坏硬件设备，耽误业务系统运转，造成的经济损失是不可估量的。</p>
                        <p>目前许多机房的管理人员不得不采用 24小时专人值班，定时巡查机房环境设备，这样不仅加重了管理人员的负担，而且更多的时候，不能及时发现和排除故障，对事故发生的时间及责任也无科学的管理, 尤其目前国内普遍缺乏机房环境设备的专业管理人员，在许多地方的机房不得不安排软件人员或者不太懂机房设备管理甚至根本不懂机房设备维护的人员值班，这对机房的安全运行无疑又是一个不利因素。</p>
                        <p>因此对网络机房的电力、环境系统、服务器系统资源、网络资源等进行实时集中的监控极其必要，使用动力环境监控是专为现代计算机、网络通信机房及无人值守变电站而设计的多功能远程监控报警系统，具有多项专利，它可检测多组电压、电流、温度、湿度、漏水、火警、精密空调、UPS、服务器资源、网络资源等详细的参数，和监控现场情况和声音，可通过多种报警方式在第一时间通知相关管理人员，如短信、电话、电子邮件、声光等，确保机房设备能正常的工作状态，管理人员并可通过手机与 WEB远程访问相关的数据，并有独特的预警功能，防患于未然。</p>
                        <p>数据中心机房动力环境监控系统实现的功能</p>
                        <p>监控系统需要实现的主要功能和楼宇自控项目基本相同，概括起来有以下几个主要方面：</p>
                        <p>1、集中实时监视功能</p>
                        <p>传统的机房管理采用的是每天定时巡视的制度，比如早晚各一次检查，并且将设备的一些核心运行参数进行人工笔录后存档。这样取得的数据只限于特定时段，工作单调而且耗费人力。而集中实时监控功能可解决此问题。</p>
                        <p>2、报警和事件功能</p>
                        <p>报警指机房运行中出现异常情况，比如停电事故、漏水事故等。报警的发生意味着机房的运行受到影响，其严重程度可用&quot;优先级&quot;的概念来定义。一般监控系统均可设置几十到上千个优先级以区别报警的严重程度。机房内的报警优先级一般划分为10级即可。</p>
                        <p>3、运行历史数据记录和趋势功能</p>
                        <p>对机房的管理者来说，除了系统的报警功能以外，系统的另一个重要的功能就是历史数据和趋势功能。因为机房只是一个存放计算机和网络设备的场所，随着事件的推移，机房内的设备数量、型号等都会发生变化，按照目前的趋势，一般都是越来越多。因此，从机房管理角度，需要能够拥有机房设备运行的历史资料，这样可以通过分析，找出发展趋势、发现故障隐患。从而大幅度提高机房的管理水平。</p>
                        <p>4、用户管理功能</p>
                        <p>用户管理主要是对监控系统的使用者进行权限管理，避免末授权的人员随意修改参数设置或者查看。而授权需要进行分级控制，不同级别的用户只能进行自己这个级别内所允许的操作。</p>
                        <p>5、确定需要监控的对象</p>
                        <p>UPS电源(包含直流电源)、空调设备、漏水检测、配电系统、发电机、机房实际温湿度、通风系统、防雷系统、消防系统、视频监控、门禁监控、网络设备与应用系统监控、系统通信的监视。</p>
                        <p>6、完善的监控系统的基本要求</p>
                        <p>从实际经验出发，该监控系统应能达到以下几个要求:</p>
                        <p>扩容：系统具备较强的扩容能力。</p>
                        <p>实时：必须达到实时的响应时间。</p>
                        <p>故障报警：必须具备故障分析诊断的能力,能够准确判定故障点,实现声光报警,并弹出提示故障检查内容,提供报警恢复操作。</p>
                        <p>施工：必须能解决动力机房施工方面的各种技术要求。</p>
                        <p>界面统一：必须能将各机房及各种设备统一在单一的中文人机界面。</p>
                        <p>监控设备的完整：必须能将各种传统设备及智能型设备完整纳入监控系统。</p>
                        <p>数据中心机房空调防雷的必要性</p>
                        <p>在弱电系统中机房空调防雷必要性，网络数据中心机房，安全监控系统机房等都配备了机房空调。当雷电来临时，机房空调能否在正常运行的同时又可确保其所处系统的防雷安全，基于机房空调的基本工作原理及其特点，对雷电对机房空调的侵害进行分析，并提出机房空调系统的雷电防护措施。</p>
                        <p>1、机房空调的基本工作原理</p>
                        <p>机房空调的主要工作过程是滤波—整流—逆变，另外还包括像充电器及蓄电池、锁相同步网络、交流旁路供电通道、微处理器、通信接口等一些辅助工作的单元。</p>
                        <p>2、机房空调的类型及其特点</p>
                        <p>从主电路结构和不间断供电的运行机制来看，目前技术成熟并已形成产品的各种机房空调主要有3大类：</p>
                        <p>（1）后备式机房空调;后备式机房空调的特点是转换效率高，当市电供电正常时，逆变器处于停止工作状态，负载上得到的是经过简易稳压处理的市电，只有在市电供电不正常时，逆变器启动，向负载供电。其噪声低、价格比较低廉。</p>
                        <p>（2）在线互动式机房空调;在线互动式产品属机房空调的中间型产品，具有稳压精密、运行稳定、智能化和安全保护等特点。因此它既具有后备式转换率高、可靠性高的优点，又具有在线式供电质量高、转换时间短的优点，且价格适中。</p>
                        <p>（3）在线式机房空调(又可分为：双变换在线式机房空调和双向变换串并联补偿在线式机房空调两种); 在线式机房空调的特点是在正常情况下无论有无市电，它总是由机房空调的逆变器对负载供电，这样就避免了所有由市电电网电压波动及、带来的影响，真正实现了对负载的无、稳压、稳频供电，且在由市电供电转换到蓄电池供电时，无转换时间。因此，其供电输出的电源品质高，保护性能最好，但是结构复杂，成本相对较高。</p>
                        <p>当今的机房空调已在大量引进微处理器监控技术的基础上发展成为一种智能化机房空调.同时，为更好地适应网络环境的要求，机房空调的智能网络功能正向以简单网路管理协议为标准的广域管理结构发展。这样，微电子设备在机房空调上的应用愈来愈广泛。</p>
                        <p>机房空调是强电与弱电相结合的精密电子设备，其构成中除大功率的电力元件外，还包括CPU板、逻辑控制板、整流器控制板、逆变器控制板等微电子控制部件。机房空调微电子控制部件的主要元器件是各种集成电路(IC)，而IC对电磁环境的要求较高，当IC处于幅度为0.3GS(高斯)的电磁脉冲环境下，会使机器发生误动作，电磁脉冲幅度为0.75GS时，IC元件会出现假性损坏，幅度为2.4GS时，IC元件将出现不可逆永久性损坏。对于微电子设备来讲，危害最大的是雷电电磁脉冲，它无孔不入，隐含杀机。</p>
                        <p>机房空调不能阻挡雷电流的侵害的原因</p>
                        <p>1、机房空调安装在重要设备的前端，所以当雷电直击到低压电源线或在电缆上产生感应雷电时，电源导线上的过电流过电压经过配电系统，首先冲击机房空调，而机房空调稳压范围一般单相在160 ~260V，三相在320V ~460V之间。要防止瞬间10~20kV的雷电冲击波的过电压幅值是不可能的，因此当雷击来临时，它最先受到雷电流的冲击。</p>
                        <p>2、内部安装有防雷器件的机房空调分为两种类型：</p>
                        <p>（1）装有不合标准的防雷器件的机房空调.这类是生产厂家为了节省成本，只是象征性地装一组小功率的金属氧化锌压敏电阻MOV，只能对很小的感应雷电有一定的防护作用。</p>
                        <p>（2）部分进口机房空调及国内著名机房空调厂生产的机房空调，是根据国际IEC801-5的标准(抑制吸收电源供电线路输入端的雷电电压及电流的强浪涌，其冲击电流为20kA，冲击电压为6kV，波形为8/20μs)，安装有标准的防雷器件。而这一类机房空调是否能完好的保护机房空调本身，并达到保护其它后续电源及设备免遭雷电侵害的目的，经长期的监测的统计资料表明，直击雷在一般低压架空线路产生的过电压幅值高达100kV，电信线路高达40~60kV.感应雷电过电压幅值在无屏蔽架空线上最高幅值达到20kV，无屏蔽地下电缆可达10kV，由此可知，即使装有标准防雷器件的机房空调，在其电源线路前端(配电室、房、柜及箱)没有加装有效的高能量防雷器件，这类机房空调同样会遭到雷击损坏。</p>
                        <p>3、智能化的机房空调中，信号接口或远程控制用通信线接口，有的没有装浪涌电路，有的仅装有小功率的浪涌抑制电路，均无法防止感应雷击，因此其信号或通信线接口也成为雷电波侵入的主要渠道。</p>
                        <p>综上分析，没有安装防雷器件的机房空调，可以说是没有防雷功能，只能对市电网过电压或很小的杂散电流起到电源净化和保护的作用。当雷击来临时，它本身首先被击坏;内装防雷器件的机房空调，也不能完善地保护其自身，并达到保护其它设备的电源免遭雷电侵害;从架空电源线和信号线上侵入的直击雷过电压和感应雷过电压，是造成智能型机房空调损害的主要原因。因此，加强对机房空调的雷电防护措施是十分必要的，同时也具有重要的现实意义。</p>
                        <p>机房空调的雷电防护</p>
                        <p>直击雷、感应雷和雷电电磁脉冲等都有可能对机房空调造成损害，因此要做好机房空调的防雷就必须严格遵守《建筑物电子信息系统防雷技术规范》综合防雷系统的要求，做好以下几点：</p>
                        <p>1、要将外部防雷措施和内部防雷措施统筹兼顾，全面规划，切实做好接地和等电位连接</p>
                        <p>完善设备所在建筑物外部防雷系统，按照国标《建筑物防雷设计规范》(GB50057-94(2000年版))，安装接闪器，引下线以及防雷接地网等设施。做好机房接地，根据国标《电子计算机房设计规范》(GB50174-1993)，交流工作地、直流工作地、安全保护地、防雷接地宜共用一组接地装置，其接地电阻按其中最小值要求确定;如果必须分设接地，则必须于两地之间加装等电位共地联结器。</p>
                        <p>2、要采取多级防护措施</p>
                        <p>所谓多级防护就是按照电磁兼容的原理，分层次地对雷电流进行削弱，在动力线进户配电柜、楼层配电柜以及机房进户配电盒，安装适配的避雷器。对于有信号或通信接口的机房空调，为防止雷电波从信号或通信线引入，必须在信号或通信线接口处加装相应的信号避雷器。雷电防护的中心内容是泄放和均衡，泄放将雷电流尽可能多的、尽可能远的是泄放于地，而拒之于通信系统之外。均衡是减小雷电流在诸导电物体上产生的电位差，防止雷电流的反击。</p>
                        <p>3、机房空调的安装位置要讲究</p>
                        <p>依据国际电工委员会ICE1312一1((雷电电磁脉冲的防护》的建筑物分区方法，机房空调机房属LPZ1区，在本区内的物体不可能遭受直接雷击，在本区内的电磁场有可能衰减。就是机房空调应安装在LPZ1区内，同时，为防范雷电流产生的强电磁场*，机房空调放置离墙应有一定的距离，与外墙立柱钢筋引下线的距离≥0.83m，即设备处在雷电流磁场的安全区内。并把机器外壳屏蔽接地，机柜门用导线与地加强连接，机柜内成为LPZ2区。</p>
                        <p>避雷器应选用质量可靠，性能优良，并经相关部门备案的产品</p>
                        <p>1、选择SPD，要满足以下三条基本要求：</p>
                        <p>（1）安装SPD之后，在无电涌发生时，SPD不应对电气(电子)系统正常运行产生影响。</p>
                        <p>（2）安装SPD之后，在有电涌发生的情况下，SPD能承受预期通过的雷电流而不损坏，并能箝制电涌电压和分走电涌电流。</p>
                        <p>（3）在电涌电流通过后，SPD应迅速恢复高阻状态，切断工频续流。</p>
                        <p>2、一般，将SPD安装在被保护设备以及机房空调前端，SPD所有连接导线应尽可能短，特别是接地线，其长度不宜大于0.5m.所有连线应规整，平直。</p>",
                        CreatedTime = DateTime.Parse("2018-08-22 06:45:00")
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
                        Id = "q-20191016-001",
                        Title = "常见问题#1",
                        Content = @"<p>暂无答案</p>",
                        CreatedTime = DateTime.Parse("2019-10-16 16:10:00")
                    },
                    new Question {
                        Id = "q-20191016-002",
                        Title = "常见问题#2",
                        Content = @"<p>暂无答案</p>",
                        CreatedTime = DateTime.Parse("2019-10-16 16:10:00")
                    },
                    new Question {
                        Id = "q-20191016-003",
                        Title = "常见问题#3",
                        Content = @"<p>暂无答案</p>",
                        CreatedTime = DateTime.Parse("2019-10-16 16:10:00")
                    },
                    new Question {
                        Id = "q-20191016-004",
                        Title = "常见问题#4",
                        Content = @"<p>暂无答案</p>",
                        CreatedTime = DateTime.Parse("2019-10-16 16:10:00")
                    },
                    new Question {
                        Id = "q-20191016-005",
                        Title = "常见问题#5",
                        Content = @"<p>暂无答案</p>",
                        CreatedTime = DateTime.Parse("2019-10-16 16:10:00")
                    },
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
                        Id = "f-00-001",
                        Title = "EMC检测报告",
                        Type = 0,
                        Summary = @"Intelligent monitoring management unit",
                        Size=428000,
                        Version = "V1.0.0.0",
                        Url="/content/files/EMCReport.pdf",
                        CreatedTime = DateTime.Parse("2019-09-04 00:00:00")
                    },
                    new File {
                        Id = "f-00-002",
                        Title = "LVD检测报告",
                        Type = 0,
                        Summary = @"Intelligent monitoring management unit",
                        Size=650000,
                        Version = "V1.0.0.0",
                        Url="/content/files/LVDReport.pdf",
                        CreatedTime = DateTime.Parse("2019-09-04 00:00:00")
                    },
                    new File {
                        Id = "f-00-003",
                        Title = "RoHS检测报告",
                        Type = 0,
                        Summary = @"Intelligent monitoring management unit",
                        Size=170000,
                        Version = "V1.0.0.0",
                        Url="/content/files/RoHSReport.pdf",
                        CreatedTime = DateTime.Parse("2019-09-04 00:00:00")
                    },
                    new File {
                        Id = "f-01-001",
                        Title = "软件说明书#1",
                        Type = 1,
                        Summary = @"暂无",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "f-01-002",
                        Title = "软件说明书#2",
                        Type = 1,
                        Size=1024000,
                        Summary = @"暂无",
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "f-02-001",
                        Title = "升级包#1",
                        Type = 2,
                        Summary = @"暂无",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "f-02-002",
                        Title = "升级包#2",
                        Type = 2,
                        Summary = @"暂无",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "f-03-001",
                        Title = "其他资料#1",
                        Type = 3,
                        Summary = @"暂无",
                        Size=1024000,
                        Version = "V1.0.0.0",
                        Url="/content/files/introduction.pdf",
                        CreatedTime = DateTime.Parse("2019-09-22 15:00:00")
                    },
                    new File {
                        Id = "f-03-002",
                        Title = "其他资料#2",
                        Type = 3,
                        Summary = @"暂无",
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
                        Id = "z-00-001",
                        Title = "动力环境综合监控系统",
                        Url="/content/certificates/z-00-001.jpg",
                        CreatedTime = DateTime.Parse("2016-09-19 00:00:00")
                    },
                    new Certificate {
                        Id = "z-01-001",
                        Title = "IMMU(CE-EMC)",
                        Url="/content/certificates/z-01-001.jpg",
                        CreatedTime = DateTime.Parse("2019-09-04 00:00:00")
                    },
                    new Certificate {
                        Id = "z-01-002",
                        Title = "IMMU(ROHS)",
                        Url="/content/certificates/z-01-002.jpg",
                        CreatedTime = DateTime.Parse("2019-09-04 00:00:00")
                    },
                    new Certificate {
                        Id = "z-01-003",
                        Title = "IMMU(CE-LVD)",
                        Url="/content/certificates/z-01-003.jpg",
                        CreatedTime = DateTime.Parse("2019-09-04 00:00:00")
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
                        Id = "c-00-001",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 0,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-00-002",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 0,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-00-003",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 0,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-01-001",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 1,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-01-002",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 1,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-01-003",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 1,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-02-001",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 2,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-02-002",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 2,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-02-003",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 2,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-03-001",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 3,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-03-002",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 3,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    },
                    new Customer {
                        Id = "c-03-003",
                        Name = "漳州市艾睿普软件技术有限公司",
                        Type = 3,
                        Url="//www.irep.com.cn",
                        Image = "/content/customers/c-00-001.jpg"
                    }
                };
            }
        }
    }
}