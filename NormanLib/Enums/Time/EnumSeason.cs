using System.ComponentModel;

namespace NormanLib.Enums.Time
{
    /// <summary>
    /// 季節
    /// </summary>
    [Flags]
    public enum EnumSeason
    {
        /// <summary>
        /// 無
        /// </summary>
        [Description("無")]
        None = 0,

        /// <summary>
        /// 春天
        /// </summary>
        [Description("春天")]
        Spring = EnumMonth.March | EnumMonth.April | EnumMonth.May,

        /// <summary>
        /// 夏天
        /// </summary>
        [Description("夏天")]
        Summer = EnumMonth.June | EnumMonth.July | EnumMonth.August,

        /// <summary>
        /// 秋天
        /// </summary>
        [Description("秋天")]
        Autumn = EnumMonth.September | EnumMonth.Octobor | EnumMonth.November,

        /// <summary>
        /// 冬天
        /// </summary>
        [Description("冬天")]
        Winter = EnumMonth.December | EnumMonth.January | EnumMonth.February,

        /// <summary>
        /// 四季
        /// </summary>
        [Description("四季")]
        All = Spring | Summer | Autumn | Winter,
    }
}