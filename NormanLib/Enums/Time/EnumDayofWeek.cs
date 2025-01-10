using System.ComponentModel;

namespace NormanLib.Enums.Time
{
    /// <summary>
    /// 星期
    /// </summary>
    [Flags]
    public enum EnumDayofWeek
    {
        /// <summary>
        /// 測試
        /// </summary>
        //[MemberDescription("測試")]
        Test = -1,

        /// <summary>
        /// 無
        /// </summary>
        [Description("無")]
        None = 0,

        /// <summary>
        /// 星期一
        /// </summary>
        [Description("星期一")]
        Monday = 1,

        /// <summary>
        /// 星期二
        /// </summary>
        [Description("星期二")]
        Tuesday = 2,

        /// <summary>
        /// 星期三
        /// </summary>
        [Description("星期三")]
        Wednesday = 4,

        /// <summary>
        /// 星期四
        /// </summary>
        [Description("星期四")]
        Thursday = 8,

        /// <summary>
        /// 星期五
        /// </summary>
        [Description("星期五")]
        Friday = 16,

        /// <summary>
        /// 星期六
        /// </summary>
        [Description("星期六")]
        Saturday = 32,

        /// <summary>
        /// 星期天
        /// </summary>
        [Description("星期天")]
        Sunday = 64,

        /// <summary>
        /// 平日
        /// </summary>
        [Description("平日")]
        Weekday = Monday | Tuesday | Wednesday | Thursday | Friday,

        /// <summary>
        /// 周末
        /// </summary>
        [Description("周末")]
        Weekend = Saturday | Sunday,

        /// <summary>
        /// 一周
        /// </summary>
        [Description("一周")]
        All = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday,
    }
}