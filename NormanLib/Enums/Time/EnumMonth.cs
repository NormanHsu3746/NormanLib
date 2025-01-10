using System.ComponentModel;

namespace NormanLib.Enums.Time
{
    /// <summary>
    /// 月份
    /// </summary>
    [Flags]
    public enum EnumMonth
    {
        /// <summary>
        /// 無
        /// </summary>
        [Description("無")]
        None = 0,

        /// <summary>
        /// 一月
        /// </summary>
        [Description("一月")]
        January = 1,

        /// <summary>
        /// 二月
        /// </summary>
        [Description("二月")]
        February = 2,

        /// <summary>
        /// 三月
        /// </summary>
        [Description("三月")]
        March = 4,

        /// <summary>
        /// 四月
        /// </summary>
        [Description("四月")]
        April = 8,

        /// <summary>
        /// 五月
        /// </summary>
        [Description("五月")]
        May = 16,

        /// <summary>
        /// 六月
        /// </summary>
        [Description("六月")]
        June = 32,

        /// <summary>
        /// 七月
        /// </summary>
        [Description("七月")]
        July = 64,

        /// <summary>
        /// 八月
        /// </summary>
        [Description("八月")]
        August = 128,

        /// <summary>
        /// 九月
        /// </summary>
        [Description("九月")]
        September = 256,

        /// <summary>
        /// 十月
        /// </summary>
        [Description("十月")]
        Octobor = 512,

        /// <summary>
        /// 十一月
        /// </summary>
        [Description("十一月")]
        November = 1024,

        /// <summary>
        /// 十二月
        /// </summary>
        [Description("十二月")]
        December = 2048,

        /// <summary>
        /// 全年
        /// </summary>
        [Description("全年")]
        All = January | February | March | April | May | June | July | August | September | Octobor | November | December,
    }
}