using System;

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
            get { return "动力环境监控系统"; }
        }

        /// <summary>
        /// Gets or sets the application version
        /// </summary>
        public static string Version {
            get { return "V1.0.0 Build170101"; }
        }

        /// <summary>
        /// Gets or sets the company
        /// </summary>
        public static string Company {
            get { return "中达电通股份有限公司"; }
        }
    }
}