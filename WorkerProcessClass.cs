using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中铁流水线管理端
{
  public  class WorkerProcessClass
    {
        /// <summary>
        /// 生产线名称
        /// </summary>
        public string ProductionLineId { get; set; }
        /// <summary>
        /// 工序名称
        /// </summary>
        public string ProcessId { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }
    }
}
