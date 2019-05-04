using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTISModels
{
    public class Appointment
    {
        /// <summary>
        /// 放疗号
        /// </summary>
        public string TreatmentId { get; set; }

        /// <summary>
        /// 日程类型
        /// </summary>
        public int Type { get; set; }


        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 主题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public int Label { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 全天
        /// </summary>
        public bool AllDay { get; set; }

        

        /// <summary>
        /// 循环信息
        /// </summary>
        public string RecurrenceInfo { get; set; }

        /// <summary>
        /// 提醒信息
        /// </summary>
        public string ReminderInfo { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public byte[] Icon1 { get; set; }

        /// <summary>
        /// 是否刷卡
        /// </summary>
        public bool IsSwipingCard { get; set; }

        /// <summary>
        /// 刷卡时间
        /// </summary>
        public DateTime SwipingCardDateTime { get; set; }

    }
}
