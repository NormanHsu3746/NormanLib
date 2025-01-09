namespace NormanLib.Enums
{
    /// <summary>
    /// 星期
    /// </summary>
    [Flags]
    public enum EnumDayofWeek
    {
        /// <summary>
        /// 無
        /// </summary>
        None = 0,

        /// <summary>
        /// 星期一
        /// </summary>
        Monday = 1,

        /// <summary>
        /// 星期二
        /// </summary>
        Tuesday = 2,

        /// <summary>
        /// 星期三
        /// </summary>
        Wednesday = 4,

        /// <summary>
        /// 星期四
        /// </summary>
        Thursday = 8,

        /// <summary>
        /// 星期五
        /// </summary>
        Friday = 16,

        /// <summary>
        /// 星期六
        /// </summary>
        Saturday = 32,

        /// <summary>
        /// 星期天
        /// </summary>
        Sunday = 64,

        /// <summary>
        /// 平日
        /// </summary>
        Weekday = Monday | Tuesday | Wednesday | Thursday | Friday,

        /// <summary>
        /// 周末
        /// </summary>
        Weekend = Saturday | Sunday,

        /// <summary>
        /// 一周
        /// </summary>
        All = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday,
    }
}